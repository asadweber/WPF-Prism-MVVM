using AppConfig.HelperClasses;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.SecurityModels;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;

namespace Web.Core.Frame.Helpers
{
    public class dataTableButtonPanel : IDisposable
    {
        #region IDisposable Members

        private bool isDisposed = false;

        ~dataTableButtonPanel()
        {
            Dispose(false);
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Code to dispose the managed resources of the class
            }
            // Code to dispose the un-managed resources of the class

            isDisposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public dataTableButtonPanel()
        {
        }
        #endregion
        public clsPrivateKeys clsPrivate = new clsPrivateKeys();
        /// <summary>
        /// Basic button panel code: edit delete and view
        /// </summary>
        /// <param name="primaryKey"></param>
        /// <param name="primaryKeyName"></param>
        /// <param name="claimsIdentity"></param>
        /// <returns></returns>
        public string genDTBtnPanel<T>(string controllerName, T primaryKey, string primaryKeyName, ClaimsIdentity claimsIdentity,
             List<dataTableButtonModel> btnActionList, IHttpContextAccessor httpContextAccessor)
        {
            clsPrivateKeys objClsPrivate = new clsPrivateKeys();
            CancellationToken cancellationToken = new CancellationToken();
            owin_formactionEntity owin_formaction = new owin_formactionEntity();
            IList<Owin_ProcessGetFormActionistEntity> listProcessGetFormAction = new List<Owin_ProcessGetFormActionistEntity>();
            string strJson = string.Empty;
            try
            {
                if (claimsIdentity != null)
                {
                    List<Claim> listClaims = (List<Claim>)claimsIdentity.Claims;
                    if (listClaims != null && listClaims.Count > 0)
                    {
                        string masteruserid = listClaims.Find(c => c.Type == "masteruserid").Value;
                        owin_formaction.masteruserid = Convert.ToInt64(masteruserid);
                        owin_formaction.actionname = controllerName + "/";
                        listProcessGetFormAction = BFC.Core.FacadeCreatorObjects.Security.owin_formactionFCC.GetFacadeCreate(httpContextAccessor)
                       .GetFormActionListByMasterUserId(owin_formaction, cancellationToken).GetAwaiter().GetResult();
                    }

                    //string json = System.Text.Encoding.UTF8.GetString(httpContextAccessor.HttpContext.Session.Get("PermissionList"));
                    //listProcessGetFormAction = JsonConvert.DeserializeObject<List<Owin_ProcessGetFormActionistEntity>>(json);




                    strJson += "<div class='btn-toolbar pull-right' role='toolbar'>";
                    string btnclass = string.Empty;
                    //List<Owin_ProcessGetFormActionistEntity_Ext> itemList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Owin_ProcessGetFormActionistEntity_Ext>>(HttpContext.Current.Session["jsonList"].ToString());
                    foreach (dataTableButtonModel objsingButton in btnActionList)
                    {
                        var action = objsingButton.btnmethodname.Replace("{controllername}", controllerName).ToString();
                        if (listProcessGetFormAction.Any(x => x.ActionName.Contains(action)))
                        {
                            strJson += "<button type='button' class=\"" + objsingButton.btnclass + "\" ";
                            strJson += " onclick =\"location.href='/" + objsingButton.btnmethodname.Replace("{controllername}", controllerName) + clsPrivate.EncodeParams(primaryKeyName, primaryKey.ToString()) + "'\">";
                            strJson += "" + objsingButton.btnicon + "  " + objsingButton.btnname + "</button>  ";
                            //strJson += "<button class='"+ objsingButton.btnclass+ "' onclick ='" + editMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&quot;)'> <i class='fa fa-edit'> </i> " + KAF.MsgContainer._Common._btnUpdate + "</button> ";
                        }
                    }
                    strJson += "</div>";
                }
                else
                    throw new Exception("Login required");
            }
            catch (Exception ex)
            {
                strJson = ex.Message;
            }
            return strJson;
        }
        //   public string genDTBtnPanel<T>(string controllerName, T primaryKey, string primaryKeyName, ClaimsIdentity claimsIdentity,
        //       List<dataTableButtonModel> btnActionList)
        //   {
        //       clsPrivateKeys objClsPrivate = new clsPrivateKeys();
        //       string strJson = string.Empty;
        //       try
        //       {
        //           if (claimsIdentity != null)
        //           {
        //               strJson += "<div class='btn-toolbar pull-right' role='toolbar'>";
        //               string btnclass = string.Empty;

        ////List<Owin_ProcessGetFormActionistEntity_Ext> itemList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Owin_ProcessGetFormActionistEntity_Ext>>(HttpContext.Current.Session["jsonList"].ToString());
        //foreach (dataTableButtonModel objsingButton in btnActionList)
        //               {
        //                   strJson += "<button type='button' class=\"" + objsingButton.btnclass + "\" ";
        //                   strJson += " onclick =\"location.href='/" + objsingButton.btnmethodname.Replace("{controllername}", controllerName) + clsPrivate.EncodeParams(primaryKeyName, primaryKey.ToString()) + "'\">";
        //                   strJson += "" +objsingButton.btnicon + "  " +  objsingButton.btnname + "</button>  ";
        //                   //strJson += "<button class='"+ objsingButton.btnclass+ "' onclick ='" + editMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&quot;)'> <i class='fa fa-edit'> </i> " + KAF.MsgContainer._Common._btnUpdate + "</button> ";
        //               }
        //               strJson += "</div>";
        //           }
        //           else
        //               throw new Exception("Login required");
        //       }
        //       catch (Exception ex)
        //       {
        //           strJson = ex.Message;
        //       }
        //       return strJson;
        //   }

        public string genDTBtnPanelProcerss<T>(string controllerName, T primaryKey, string primaryKeyName, ClaimsIdentity claimsIdentity,
           List<dataTableButtonModel> btnActionList, bool ShowButton = false)
        {
            clsPrivateKeys objClsPrivate = new clsPrivateKeys();
            string strJson = string.Empty;
            try
            {
                if (ShowButton)
                {
                    if (claimsIdentity != null)
                    {
                        strJson += "<div class='btn-toolbar pull-right' role='toolbar'>";
                        string btnclass = string.Empty;
                        //List<Owin_ProcessGetFormActionistEntity_Ext> itemList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Owin_ProcessGetFormActionistEntity_Ext>>(HttpContext.Current.Session["jsonList"].ToString());
                        foreach (dataTableButtonModel objsingButton in btnActionList)
                        {
                            strJson += "<button type='button' class=\"" + objsingButton.btnclass + "\" ";
                            strJson += " onclick =\"location.href='/" + objsingButton.btnmethodname.Replace("{controllername}", controllerName) + clsPrivate.EncodeParams(primaryKeyName, primaryKey.ToString()) + "'\">";
                            strJson += "" + objsingButton.btnicon + "  " + objsingButton.btnname + "</button>  ";
                            //strJson += "<button class='"+ objsingButton.btnclass+ "' onclick ='" + editMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&quot;)'> <i class='fa fa-edit'> </i> " + KAF.MsgContainer._Common._btnUpdate + "</button> ";
                        }
                        strJson += "</div>";
                    }
                    else
                        throw new Exception("Login required");
                }
            }
            catch (Exception ex)
            {
                strJson = ex.Message;
            }
            return strJson;
        }

        public bool checkButtonPermission(string actionname, ClaimsIdentity claimsIdentity, IHttpContextAccessor httpContextAccessor)
        {
            bool permitted = false;
            clsPrivateKeys objClsPrivate = new clsPrivateKeys();
            CancellationToken cancellationToken = new CancellationToken();
            owin_formactionEntity owin_formaction = new owin_formactionEntity();
            IList<Owin_ProcessGetFormActionistEntity> listProcessGetFormAction = new List<Owin_ProcessGetFormActionistEntity>();

            try
            {
                List<Claim> listClaims = (List<Claim>)claimsIdentity.Claims;
                if (listClaims != null && listClaims.Count > 0)
                {
                    string masteruserid = listClaims.Find(c => c.Type == "masteruserid").Value;
                    owin_formaction.masteruserid = Convert.ToInt64(masteruserid);
                    owin_formaction.actionname = actionname;
                    listProcessGetFormAction = BFC.Core.FacadeCreatorObjects.Security.owin_formactionFCC.GetFacadeCreate(httpContextAccessor)
                   .GetFormActionListByMasterUserId(owin_formaction, cancellationToken).GetAwaiter().GetResult();
                }

                if (listProcessGetFormAction.Any(x => x.ActionName.Contains(actionname)))
                {
                    permitted = true;
                }
            }
            catch (Exception)
            {
                permitted = false;
            }
            return permitted;
        }


    }
}
