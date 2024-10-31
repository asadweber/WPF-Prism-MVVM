using CLL.Localization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.Interfaces.Services;
using Web.Core.Frame.Interfaces.UseCases;
using Web.Core.Frame.Dto;
using AppConfig.HelperClasses;
using Web.Core.Frame.Helpers;
using System.Security.Claims;
using static AppConfig.HelperClasses.applicationEnamNConstants;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Text;

namespace Web.Core.Frame.UseCases
{
    public sealed partial class Owin_FormActionUseCase
    {
        //public Task<bool> GetFormActionByRole(Owin_FormActionRequest message, IOwin_FormActionHandler<Owin_FormActionRequest> outputPort)
        //{
        //    throw new NotImplementedException();
        //}


        public async Task<bool> GetFormActionByRole(Owin_FormActionRequest message, IOwin_FormActionHandler<Owin_FormActionResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            string lang = System.Threading.Thread.CurrentThread.CurrentUICulture.Name.ToLowerInvariant().ToLower();


            List<string> excludedfiles = new List<string>();
            excludedfiles.Add("Task Pending");
            excludedfiles.Add("Base");
            excludedfiles.Add("Common");
            excludedfiles.Add("UnAuthorize Access");
            excludedfiles.Add("Home");

            try
            {
                IList<Owin_ProcessGetFormActionistEntity> listProcessGetFormAction = await BFC.Core.FacadeCreatorObjects.Security.owin_formactionFCC.GetFacadeCreate(_contextAccessor)
                .GetFormActionByRole(message.Objowin_formaction, cancellationToken);

                if (listProcessGetFormAction != null && listProcessGetFormAction.Count > 0)
                {
                    var listRootMenus = listProcessGetFormAction.Where(x => !excludedfiles.Contains(x.FormName) && x.ParentID == 1).Distinct();

                    var listform = listProcessGetFormAction.GroupBy(test => test.AppFormID)
                       .Select(grp => grp.First())
                       .ToList();
                    var listformaction = listProcessGetFormAction.GroupBy(test => test.FormActionID)
                        .Select(grp => grp.First())
                        .ToList();
                    List<MenuWiseForm> kList = (from m in listRootMenus
                                                select new MenuWiseForm
                                                {
                                                    appformid = m.AppFormID,
                                                    formname = (lang == "ar-kw" ? m.FormNameAr : m.FormName),
                                                    formList = (from f in listform
                                                                where m.AppFormID == f.ParentID
                                                                select new FormWiseAction
                                                                {
                                                                    // menuid = f.MenuID,
                                                                    appformid = f.AppFormID,
                                                                    formname = (lang == "ar-kw" ? f.FormNameAr : f.FormName),
                                                                    formActionList = (from a in listformaction
                                                                                      where f.AppFormID == a.ParentID && a.EventName != "Internal Method"
                                                                                      select new FormAction
                                                                                      {
                                                                                          actionname = a.ActionName,
                                                                                          formactionid = a.FormActionID,
                                                                                          isview = Convert.ToBoolean(Convert.ToInt32(a.Status)),
                                                                                          //action = lang == "ar-kw" ? a.Ex_Nvarchar1 : string.Join(" ", (a.Ex_Nvarchar3 + " " + a.Ex_Nvarchar2).Split(' ').Distinct())
                                                                                          action = lang == "ar-kw" ? a.DisplayNameAr + " [" + a.EventName + "]" : a.DisplayName + " [" + a.EventName + "]"
                                                                                      }).ToList()

                                                                }).ToList()
                                                }).ToList();



                    var rootMenu = listProcessGetFormAction.Where(test => test.ParentID == 1).ToList();
                    var subMenu = listProcessGetFormAction.Where(t => t.AppFormID != 0 && t.ParentID != 1).ToList();
                    var listAction = listProcessGetFormAction.Where(t => t.AppFormID == 0).ToList();

                    List<MenuWiseForm> cList = (from s in subMenu
                                                join c in subMenu on s.AppFormID equals c.ParentID
                                                select new MenuWiseForm
                                                {
                                                    appformid = c.AppFormID,
                                                    formname = lang == "ar-kw" ? c.FormName : c.FormNameAr,
                                                    formList = (from a in subMenu
                                                                where c.AppFormID == a.AppFormID
                                                                select new FormWiseAction
                                                                {
                                                                    appformid = a.AppFormID,
                                                                    formname = lang == "ar-kw" ? a.FormNameAr : a.FormName,
                                                                    formActionList = (from b in listAction
                                                                                      where a.AppFormID == b.ParentID && b.EventName != "Internal Method"
                                                                                      select new FormAction
                                                                                      {
                                                                                          actionname = b.ActionName,
                                                                                          formactionid = b.FormActionID,
                                                                                          isview = Convert.ToBoolean(Convert.ToInt32(b.Status)),
                                                                                          //action = lang == "ar-kw" ? b.Ex_Nvarchar1 : string.Join(" ", (b.Ex_Nvarchar3 + " " + b.Ex_Nvarchar2).Split(' ').Distinct())
                                                                                          action = lang == "ar-kw" ? b.DisplayNameAr + " [" + a.EventName + "]" : b.DisplayName + " [" + b.EventName + "]"
                                                                                      }).ToList()
                                                                }).ToList()
                                                }).ToList();
                    var uList = kList.Concat(cList);

                    //string permissionhtml = GeneratePermissionlayout(uList.ToList());
                    //var obj = new owin_formactionEntity();
                    //obj.ActionName = permissionhtml;
                    var result = new Owin_FormActionResponse(uList, true);

                    outputPort.GetFormActionByRole(result);
                }
                else
                {
                    Owin_FormActionResponse objResponse = new Owin_FormActionResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                     "404",
                     _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetFormActionByRole(objResponse);
                }
                return true;
            }
            catch (Exception ex)
            {
                Owin_FormActionResponse objResponse = new Owin_FormActionResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetFormActionByRole(objResponse);
                return true;
            }
        }

        public async Task<bool> AssignRolePermission(Owin_RolePermissionRequest message, ICRUDRequestHandler<Owin_RolePermissionResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            long? i = null;
            try
            {
                i = await BFC.Core.FacadeCreatorObjects.Security.owin_formactionFCC.GetFacadeCreate(_contextAccessor)
                    .AssignPermission(message.Objowin_rolepermission, cancellationToken);

                outputPort.Update(new Owin_RolePermissionResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                        ), true, null));
                return true;
            }
            catch (Exception ex)
            {
                Owin_RolePermissionResponse objResponse = new Owin_RolePermissionResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                       "500",
                       ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.Update(objResponse);
                return true;
            }
        }

        private string GeneratePermissionlayout(List<MenuWiseForm> dataList)
        {
            StringBuilder htmlbuilder = new StringBuilder();
            htmlbuilder.Append("");
            long root = 0;
            foreach (MenuWiseForm mRoot in dataList)
            {
                htmlbuilder.Append("<div id='accordion" + ++root + "' class=''>");
                htmlbuilder.Append("<div class='card'>");
                htmlbuilder.Append("<div class='card-header' id='mheading" + root + "'>");
                htmlbuilder.Append("<h5 class='mb-0'>");
                htmlbuilder.Append("<button class='btn btn-link' data-toggle='collapse' data-target='#mcollapse" + root + "' aria-expanded='true' aria-controls='mcollapse" + root + "'>" + mRoot.formname + "</button>");
                //htmlbuilder.Append("</button>");
                htmlbuilder.Append("</h5>");
                htmlbuilder.Append("</div>");
                htmlbuilder.Append("<div id='mcollapse" + root + "' class='collapse show' aria-labelledby='mheading" + root + "' data-parent='#mheading" + root + "'>");
                htmlbuilder.Append("<div class='card-body'>");
                foreach (FormWiseAction sRoot in mRoot.formList)
                {
                    htmlbuilder.Append("<div class='card'>");

                    htmlbuilder.Append("<div class='card-header' id='heading" + sRoot.appformid + "'>");
                    htmlbuilder.Append("<h5 class='mb-0'>");
                    htmlbuilder.Append("<button class='btn btn-link' data-toggle='collapse' data-target='#collapse" + sRoot.appformid + "' aria-expanded='true' aria-controls='collapse" + sRoot.appformid + "'>" + sRoot.formname + "</button>");
                    //htmlbuilder.Append("</button>");
                    htmlbuilder.Append("</h5>");
                    htmlbuilder.Append("</div>");

                    htmlbuilder.Append("<div id='collapse" + sRoot.appformid + "' class='collapse show' aria-labelledby='heading" + sRoot.appformid + "' data-parent='#accordion" + root + "'>");
                    htmlbuilder.Append(" <div class='card-body'>");
                    htmlbuilder.Append("<div class='row'>");
                    foreach (FormAction action in sRoot.formActionList)
                    {
                        htmlbuilder.Append("<div class='col-md-4'>");
                        htmlbuilder.Append("<label>");
                        htmlbuilder.Append("<input type='checkbox' class='actionid' value='" + action.formactionid + "' " + action.isview + ">" + action.actionname);
                        htmlbuilder.Append("</label>");
                        htmlbuilder.Append("</div>");
                    }
                    htmlbuilder.Append("</div>");
                    htmlbuilder.Append("</div>");
                    htmlbuilder.Append("</div>");
                    htmlbuilder.Append("</div>");
                }
                htmlbuilder.Append("</div>");
                htmlbuilder.Append("</div>");
                htmlbuilder.Append("</div>");
                htmlbuilder.Append("</div>");
            }
            return htmlbuilder.ToString();
        }
        private string dummy()
        {
            //Create a new StringBuilder object
            StringBuilder sb = new StringBuilder();

            sb.Append(" <div class=\"card\">\n");
            sb.Append("                                            <div class=\"card-header\" id=\"mheadingOne\">\n");
            sb.Append("                                                <h5 class=\"mb-0\">\n");
            sb.Append("                                                    <button class=\"btn btn-link\" data-toggle=\"collapse\" data-target=\"#mcollapseOne\" aria-expanded=\"true\" aria-controls=\"mcollapseOne\">\n");
            sb.Append("                                                        Collapsible Parent Group Item #1\n");
            sb.Append("                                                    </button>\n");
            sb.Append("                                                </h5>\n");
            sb.Append("                                            </div>\n");
            sb.Append("                                            <div id=\"mcollapseOne\" class=\"collapse show\" aria-labelledby=\"mheadingOne\" data-parent=\"#mheadingOne\">\n");
            sb.Append("                                                <div class=\"card-body\">\n");
            sb.Append("\n");
            sb.Append("                                                    <div class=\"card\">\n");
            sb.Append("                                                        <div class=\"card-header\" id=\"headingOne\">\n");
            sb.Append("                                                            <h5 class=\"mb-0\">\n");
            sb.Append("                                                                <button class=\"btn btn-link\" data-toggle=\"collapse\" data-target=\"#collapseOne\" aria-expanded=\"true\" aria-controls=\"collapseOne\">\n");
            sb.Append("                                                                    Collapsible Group Item #1\n");
            sb.Append("                                                                </button>\n");
            sb.Append("                                                            </h5>\n");
            sb.Append("                                                        </div>\n");
            sb.Append("                                                        <div id=\"collapseOne\" class=\"collapse show\" aria-labelledby=\"headingOne\" data-parent=\"#accordion\">\n");
            sb.Append("                                                            <div class=\"card-body\">\n");
            sb.Append("                                                                <div class=\"row\">\n");
            sb.Append("                                                                    <div class=\"col-md-4\">\n");
            sb.Append("                                                                        <label>\n");
            sb.Append("                                                                            <input type=\"checkbox\" class=\"actionid\" value=\"43914\">Edu Qualification [List View]\n");
            sb.Append("                                                                        </label>\n");
            sb.Append("                                                                    </div>\n");
            sb.Append("                                                                    <div class=\"col-md-4\">\n");
            sb.Append("                                                                        <label>\n");
            sb.Append("                                                                            <input type=\"checkbox\" class=\"actionid\" value=\"43915\">Edu Qualification Table Data [List View Operation]\n");
            sb.Append("                                                                        </label>\n");
            sb.Append("                                                                    </div>\n");
            sb.Append("                                                                    <div class=\"col-md-4\">\n");
            sb.Append("                                                                        <label>\n");
            sb.Append("                                                                            <input type=\"checkbox\" class=\"actionid\" value=\"43916\">Edu Qualification New [Create View]\n");
            sb.Append("                                                                        </label>\n");
            sb.Append("                                                                    </div>\n");
            sb.Append("                                                                    <div class=\"col-md-4\">\n");
            sb.Append("                                                                        <label>\n");
            sb.Append("                                                                            <input type=\"checkbox\" class=\"actionid\" value=\"43917\">Edu Qualification Insert [Create Operation]\n");
            sb.Append("                                                                        </label>\n");
            sb.Append("                                                                    </div>\n");
            sb.Append("                                                                    <div class=\"col-md-4\">\n");
            sb.Append("                                                                        <label>\n");
            sb.Append("                                                                            <input type=\"checkbox\" class=\"actionid\" value=\"43918\">Edu Qualification Edit [Update View]\n");
            sb.Append("                                                                        </label>\n");
            sb.Append("                                                                    </div>\n");
            sb.Append("                                                                    <div class=\"col-md-4\">\n");
            sb.Append("                                                                        <label>\n");
            sb.Append("                                                                            <input type=\"checkbox\" class=\"actionid\" value=\"43919\">Edu Qualification Update [Update Operation]\n");
            sb.Append("                                                                        </label>\n");
            sb.Append("                                                                    </div>\n");
            sb.Append("                                                                    <div class=\"col-md-4\">\n");
            sb.Append("                                                                        <label>\n");
            sb.Append("                                                                            <input type=\"checkbox\" class=\"actionid\" value=\"43920\">Edu Qualification Delete [Delete Operation]\n");
            sb.Append("                                                                        </label>\n");
            sb.Append("                                                                    </div>\n");
            sb.Append("                                                                    <div class=\"col-md-4\">\n");
            sb.Append("                                                                        <label>\n");
            sb.Append("                                                                            <input type=\"checkbox\" class=\"actionid\" value=\"43921\">Edu Qualification Detail [Detail View]\n");
            sb.Append("                                                                        </label>\n");
            sb.Append("                                                                    </div>\n");
            sb.Append("                                                                </div>\n");
            sb.Append("                                                            </div>\n");
            sb.Append("                                                        </div>\n");
            sb.Append("                                                    </div>\n");
            sb.Append("                                                    <div class=\"card\">\n");
            sb.Append("                                                        <div class=\"card-header\" id=\"headingTwo\">\n");
            sb.Append("                                                            <h5 class=\"mb-0\">\n");
            sb.Append("                                                                <button class=\"btn btn-link collapsed\" data-toggle=\"collapse\" data-target=\"#collapseTwo\" aria-expanded=\"false\" aria-controls=\"collapseTwo\">\n");
            sb.Append("                                                                    Collapsible Group Item #2\n");
            sb.Append("                                                                </button>\n");
            sb.Append("                                                            </h5>\n");
            sb.Append("                                                        </div>\n");
            sb.Append("                                                        <div id=\"collapseTwo\" class=\"collapse\" aria-labelledby=\"headingTwo\" data-parent=\"#accordion\">\n");
            sb.Append("                                                            <div class=\"card-body\">\n");
            sb.Append("                                                            </div>\n");
            sb.Append("                                                        </div>\n");
            sb.Append("                                                    </div>\n");
            sb.Append("                                                    <div class=\"card\">\n");
            sb.Append("                                                        <div class=\"card-header\" id=\"headingThree\">\n");
            sb.Append("                                                            <h5 class=\"mb-0\">\n");
            sb.Append("                                                                <button class=\"btn btn-link collapsed\" data-toggle=\"collapse\" data-target=\"#collapseThree\" aria-expanded=\"false\" aria-controls=\"collapseThree\">\n");
            sb.Append("                                                                    Collapsible Group Item #3\n");
            sb.Append("                                                                </button>\n");
            sb.Append("                                                            </h5>\n");
            sb.Append("                                                        </div>\n");
            sb.Append("                                                        <div id=\"collapseThree\" class=\"collapse\" aria-labelledby=\"headingThree\" data-parent=\"#accordion\">\n");
            sb.Append("                                                            <div class=\"card-body\">\n");
            sb.Append("                                                            </div>\n");
            sb.Append("                                                        </div>\n");
            sb.Append("                                                    </div>\n");
            sb.Append("                                                </div>\n");
            sb.Append("                                            </div>\n");
            sb.Append("                                        </div>\n");

            return sb.ToString();
        }

        public async Task<bool> GetFormActionListByMasterUserId(Owin_FormActionRequest message, IOwin_FormActionHandler<Owin_FormActionResponse> outputPort)
        {
            CancellationToken cancellationToken = new CancellationToken();
            try
            {
                IList<Owin_ProcessGetFormActionistEntity> listProcessGetFormAction = await BFC.Core.FacadeCreatorObjects.Security.owin_formactionFCC.GetFacadeCreate(_contextAccessor)
                .GetFormActionByRole(message.Objowin_formaction, cancellationToken);
                if (listProcessGetFormAction != null && listProcessGetFormAction.Count > 0)
                {
                    var result = new Owin_FormActionResponse(listProcessGetFormAction, true);

                    outputPort.GetFormActionByRole(result);
                }
                else
                {
                    Owin_FormActionResponse objResponse = new Owin_FormActionResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                         "404",
                         _sharedLocalizer["NO_DATA_FOUND"]));
                    _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                    outputPort.GetFormActionByRole(objResponse);
                }
                return true;
            }
            catch (Exception ex)
            {
                Owin_FormActionResponse objResponse = new Owin_FormActionResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                    "500",
                    ex.Message));
                _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
                outputPort.GetFormActionByRole(objResponse);
                return true;
            }
        }
    }
}
