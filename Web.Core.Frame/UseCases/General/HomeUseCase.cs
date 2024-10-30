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
using Microsoft.Extensions.Configuration;
using System.Text;
using System.Globalization;

namespace Web.Core.Frame.UseCases
{
	public sealed class HomeUseCase : IHomeUseCase
	{
		private readonly IHttpContextAccessor _contextAccessor;
		private readonly IJwtFactory _jwtFactory;
		private readonly IStringLocalizer _sharedLocalizer;
		private readonly ILogger<HomeUseCase> _logger;
		private dataTableButtonPanel objDTBtnPanel = new dataTableButtonPanel();
		public Error _errors { get; set; }
		private readonly HostingDomainSettings _hostingDomainSettings;

		private readonly IConfiguration _configuration;
		private CultureInfo cultureInfo = Thread.CurrentThread.CurrentUICulture;

		public HomeUseCase(
			IHttpContextAccessor contextAccessor,
			IJwtFactory jwtFactory,
			IStringLocalizerFactory factory,
			ILoggerFactory loggerFactory,
			IConfiguration configuration)
		{
			_contextAccessor = contextAccessor;
			_jwtFactory = jwtFactory;
			_logger = loggerFactory.CreateLogger<HomeUseCase>();

			_configuration = configuration;
			_hostingDomainSettings = _configuration.GetSection(nameof(HostingDomainSettings)).Get<HostingDomainSettings>();
			var type = typeof(SharedResource);
			var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
			_sharedLocalizer = factory.Create("SharedResource", assemblyName.Name);
		}

		public async Task<bool> LoadMenuByUserID(HomeRequest message, ICRUDRequestHandler<HomeResponse> outputPort)
		{
			CancellationToken cancellationToken = new CancellationToken();
			try
			{
				cultureInfo= Thread.CurrentThread.CurrentCulture;
				//IList<MenuEntity> oblist = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor).GetLoadMenuByUserID(message.Objowin_userentity, cancellationToken);

				IList<Owin_ProcessGetFormActionistEntity_Ext> oblist = await BFC.Core.FacadeCreatorObjects.Security.ExtendedPartial.FCCKAFUserSecurity.GetFacadeCreate(_contextAccessor).GetMenuWiseFormActionList(message.Objowin_userentity, cancellationToken);
				if (oblist != null && oblist.Count > 0)
				{
					//string menuitems = GenerateMenu(oblist.Where(p => p.ParentID == null).FirstOrDefault(), oblist.Where(p => p.ParentID != null).ToList());
					var menuitems = GetMenuWritten(oblist, "/");
					outputPort.GetAll(new HomeResponse(new AjaxResponse("200", menuitems, "Success", "Success", ""), true, null));
				}
				else
				{
					HomeResponse objResponse = new HomeResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
					 "404",
					 _sharedLocalizer["NO_DATA_FOUND"]));
					_logger.LogInformation(JsonConvert.SerializeObject(objResponse));
					outputPort.GetAll(objResponse);
				}
				return true;
			}
			catch (Exception ex)
			{
				HomeResponse objResponse = new HomeResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
					"500",
					ex.Message));
				_logger.LogInformation(JsonConvert.SerializeObject(objResponse));
				outputPort.GetAll(objResponse);
				return true;
			}
		}

		#region Menu Generate

		public string GetMenuWritten(IList<Owin_ProcessGetFormActionistEntity_Ext> itemList, string DomURLPrefix)
		{
			StringBuilder menubuilder = new StringBuilder();

			//menubuilder.Append("<li class='header'>MAIN NAVIGATION</li>");
			try
			{
				List<Owin_ProcessGetFormActionistEntity_Ext> menuItems = itemList.Where(p => p.FormActionID == 0 && p.IsView == true).ToList();
				List<Owin_ProcessGetFormActionistEntity_Ext> formItems = itemList.Where(p => p.FormActionID != 0 && p.IsView == true).ToList();

				if (menuItems != null && menuItems.Count > 0)
				{
					List<Owin_ProcessGetFormActionistEntity_Ext> parentMenus = itemList.Where(p => p.ParentID == 1 && p.IsView == true).ToList();

					foreach (Owin_ProcessGetFormActionistEntity_Ext parentMenu in parentMenus.OrderBy(p => p.Sequence).ToList())
					{
						menubuilder.Append("<li class='nav-item'>");
						menubuilder.Append("<a href='#' class='nav-link'>");
						string ClassIcon = string.IsNullOrEmpty(parentMenu.ClassIcon) ? "fas fa-users-cog" : parentMenu.ClassIcon;

                        if (cultureInfo.Name.ToLower() == "ar-kw")
						{
							menubuilder.Append($"<i class='{ClassIcon} nav-icon'></i> <span>" + parentMenu.FormNameAR + "</span>");
						}
						else
						{
							menubuilder.Append($"<i class='{ClassIcon} nav-icon'></i> <span>" + parentMenu.FormName + "</span>");
						}
						//menubuilder.Append("<i class='nav-icon fas fa-users-cog'></i> <span>" + parentMenu.FormName + "</span>");
						menubuilder.Append("<span class='pull-right-container'>");
						menubuilder.Append("<i class='right fas fa-angle-left'></i>");
						menubuilder.Append("</span>");
						menubuilder.Append("</a>");

						menubuilder.Append("<ul class='nav nav-treeview'>");

						if (formItems.Where(p => p.ParentID == parentMenu.AppFormID).FirstOrDefault() != null)
						{
							foreach (Owin_ProcessGetFormActionistEntity_Ext form in formItems.Where(p => p.ParentID == parentMenu.AppFormID && p.IsView == true))
							{
                                string formClassIcon = string.IsNullOrEmpty(form.ClassIcon) ? "fas fa-user-plus" : form.ClassIcon;

                                if (cultureInfo.Name.ToLower() == "ar-kw")
								{
									menubuilder.Append($"<li class='nav-item'><a href='" + DomURLPrefix + form.URL + form.ActionName + $"' class='nav-link'><i class='{formClassIcon} nav-icon'></i><p> " + form.DisplayNameAr + "</p></a></li>");
								}
								else
								{
									menubuilder.Append("<li class='nav-item'><a href='" + DomURLPrefix + form.URL + form.ActionName + $"' class='nav-link'><i class='{formClassIcon} nav-icon'></i><p> " + form.DisplayName + "</p></a></li>");
								}

							}
						}

						// seleced parent has morechild so call recursive
						if (menuItems.Where(p => p.ParentID == parentMenu.AppFormID).FirstOrDefault() != null)
						{
							menubuilder.Append(GetMenuParentChild(menuItems, formItems, parentMenu.AppFormID, DomURLPrefix));
						}

						menubuilder.Append("</ul>");
						menubuilder.Append("</li>");
					}

					return menubuilder.ToString();
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return menubuilder.ToString();
		}

		private string GetMenuParentChild(
		  List<Owin_ProcessGetFormActionistEntity_Ext> menuItems,
		  List<Owin_ProcessGetFormActionistEntity_Ext> formItems,
		  long? ParentmenuID,
		  string DomURLPrefix)
		{
			StringBuilder menubuilder = new StringBuilder();
			try
			{

				foreach (Owin_ProcessGetFormActionistEntity_Ext objparent in menuItems.Where(p => p.ParentID == ParentmenuID && p.IsView == true).ToList())
				{
					// menubuilder.Append("<li>");
					if (objparent.IsVisibleInMenu == true)
					{
						menubuilder.Append("<li class='nav-item'>");
                        string ClassIcon = string.IsNullOrEmpty(objparent.ClassIcon) ? "fas fa-users-cog" : objparent.ClassIcon;

                        if (cultureInfo.Name.ToLower() == "ar-kw")
						{
							menubuilder.Append($"<a href='#' class='nav-link'><i class='{ClassIcon} nav-icon'></i> <p>" + objparent.FormNameAR + "<i class='right fas fa-angle-left'></i></p>");
						}
						else
						{
							menubuilder.Append($"<a href='#' class='nav-link'><i class='{ClassIcon} nav-icon'></i> <p>" + objparent.FormName + "<i class='right fas fa-angle-left'></i></p>");
						}
						
						//menubuilder.Append("<span class='pull-right-container'>");
						//menubuilder.Append("<i class='right fas fa-angle-left'></i>");
						//menubuilder.Append("</span>");
						menubuilder.Append("</a>");


						menubuilder.Append("<ul class='nav nav-treeview'>");
						if (formItems.Where(p => p.ParentID == objparent.AppFormID).FirstOrDefault() != null)
						{
							foreach (Owin_ProcessGetFormActionistEntity_Ext form in formItems.Where(p => p.ParentID == objparent.AppFormID && p.IsView == true))
							{
                                string formClassIcon = string.IsNullOrEmpty(form.ClassIcon) ? "fas fa-user-plus" : form.ClassIcon;

                                if (cultureInfo.Name.ToLower() == "ar-kw")
								{
									menubuilder.Append("<li class='nav-item'><a href='" + DomURLPrefix + form.URL + form.ActionName + $"' class='nav-link'><i class='{formClassIcon} nav-icon'></i><p> " + form.DisplayNameAr + "</p></a></li>");
								}
								else
								{
									menubuilder.Append("<li class='nav-item'><a href='" + DomURLPrefix + form.URL + form.ActionName + $"' class='nav-link'><i class='{formClassIcon} nav-icon'></i><p> " + form.DisplayName + "</p></a></li>");
								}
								//menubuilder.Append("<li class='nav-item'><a href='" + DomURLPrefix + form.URL + form.ActionName + "' class='nav-link'><i class='fas fa-user-plus nav-icon'></i><p> " + form.DisplayName + "</p></a></li>");

							}
						}

						//If contain child
						if (menuItems.Where(p => p.ParentID == objparent.AppFormID).FirstOrDefault() != null)
						{
							menubuilder.Append(GetMenuParentChild(menuItems, formItems, objparent.AppFormID, DomURLPrefix));
						}

						menubuilder.Append("</ul>");
						menubuilder.Append("</li>");
					}
					else
					{

						if (formItems.Where(p => p.ParentID == objparent.AppFormID).FirstOrDefault() != null)
						{
							foreach (Owin_ProcessGetFormActionistEntity_Ext form in formItems.Where(p => p.ParentID == objparent.AppFormID && p.IsView == true))
							{
                                string formClassIcon = string.IsNullOrEmpty(form.ClassIcon) ? "fas fa-user-plus" : form.ClassIcon;

                                if (cultureInfo.Name.ToLower() == "ar-kw")
								{
									menubuilder.Append("<li class='nav-item'><a href='" + DomURLPrefix + form.URL + form.ActionName + $"' class='nav-link'><i class='{formClassIcon} nav-icon'></i><p>" + form.DisplayNameAr + "</p></a></li>");
								}
								else
								{
									menubuilder.Append("<li class='nav-item'><a href='" + DomURLPrefix + form.URL + form.ActionName + $"' class='nav-link'><i class='{formClassIcon} nav-icon'></i><p>" + form.DisplayName + "</p></a></li>");
								}
								//menubuilder.Append("<li class='nav-item'><a href='" + DomURLPrefix + form.URL + form.ActionName + "' class='nav-link'><i class='fas fa-user-plus nav-icon'></i><p>" + form.DisplayName + "</p></a></li>");
							}
						}

						//If contain child
						if (menuItems.Where(p => p.ParentID == objparent.AppFormID).FirstOrDefault() != null)
						{
							menubuilder.Append(GetMenuParentChild(menuItems, formItems, objparent.AppFormID, DomURLPrefix));
						}

					}

				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return menubuilder.ToString();
		}



		#endregion


		private string GenerateMenu(MenuEntity parentEntity, IList<MenuEntity> oblist)
		{
			string menu = string.Empty;
			foreach (MenuEntity single in oblist.Where(p => p.ParentID == parentEntity.FormActionID).ToList())
			{
				if (childExists(single, oblist))
				{
					menu += "<li class=\"nav-item\">";
					menu += "<a href=\"#\" class=\"nav-link\">";
					menu += "<i class=\"nav-icon fas fa-users-cog\"></i>";
					menu += "<p>";
					menu += single.DisplayName;
					menu += "<i class=\"right fas fa-angle-left\"></i>";
					menu += "</p>";
					menu += "</a>";
					menu += "<ul class=\"nav nav-treeview\">";
					menu += GenerateMenu(single, oblist);
					menu += "</ul>";
					menu += "</li>";
				}
				else
				{
					menu += getChildNode(single);
				}
			}
			return menu;
		}

		private string getChildNode(MenuEntity single)
		{
			string childNode = string.Empty;

			childNode += "<li class=\"nav-item\">";
			childNode += "<a href=\"" + _hostingDomainSettings.CompleteDomainURL + single.ActionName + "\" class=\"nav-link\">";
			childNode += "<i class=\"fas fa-user-plus nav-icon\"></i>";
			childNode += "<p>" + single.DisplayName + "</p>";
			childNode += "</a>";
			childNode += "</li>";

			return childNode;
		}


		private bool childExists(MenuEntity single, IList<MenuEntity> oblist)
		{
			MenuEntity objSingleChildExists = oblist.Where(p => p.ParentID != null && p.ParentID == single.FormActionID).FirstOrDefault();
			if (objSingleChildExists == null)
				return false;
			else
				return true;
		}

		public Task<bool> Handle(HomeRequest message, IOutputPort<HomeResponse> outputPort)
		{
			throw new NotImplementedException();
		}
	}
}