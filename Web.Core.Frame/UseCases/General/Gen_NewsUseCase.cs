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
using DocumentFormat.OpenXml.Office.CoverPageProps;
using System.Transactions;
using DocumentFormat.OpenXml.EMMA;
using System.IO;
using Microsoft.Extensions.Options;
using System.Text;
using NLog.LayoutRenderers.Wrappers;

namespace Web.Core.Frame.UseCases
{
   public sealed partial class Gen_NewsUseCase : IGen_NewsUseCase
   {
      private readonly IHttpContextAccessor _contextAccessor;
      private readonly IJwtFactory _jwtFactory;
      private readonly IStringLocalizer _sharedLocalizer;
      private readonly ILogger<Gen_NewsUseCase> _logger;
      private dataTableButtonPanel objDTBtnPanel = new dataTableButtonPanel();
      public Error _errors { get; set; }
      private IFileUploadClient fileuploadclient;

      private readonly FtpServerSetting ftpServerSetting;
      public Gen_NewsUseCase(
          IHttpContextAccessor contextAccessor,
          IJwtFactory jwtFactory,
          IStringLocalizerFactory factory,
          ILoggerFactory loggerFactory,
          IFileUploadClient fileuploadclient,
         IOptions<FtpServerSetting> ftpServerSetting)
      {
         _contextAccessor = contextAccessor;
         _jwtFactory = jwtFactory;
         _logger = loggerFactory.CreateLogger<Gen_NewsUseCase>();

         var type = typeof(SharedResource);
         var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
         _sharedLocalizer = factory.Create("SharedResource", assemblyName.Name);
         this.ftpServerSetting = ftpServerSetting.Value;
         this.fileuploadclient = fileuploadclient;
      }

      public Task<bool> Handle(Gen_NewsRequest message, IOutputPort<Gen_NewsResponse> outputPort)
      {
         throw new Exception("Not Implemented");
      }

      public async Task<bool> GetAll(Gen_NewsRequest message, ICRUDRequestHandler<Gen_NewsResponse> outputPort)
      {
         CancellationToken cancellationToken = new CancellationToken();
         try
         {
            IList<gen_newsEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_newsFCC.GetFacadeCreate(_contextAccessor)
            .GetAll(message.Objgen_news, cancellationToken);


            if (oblist != null && oblist.Count > 0)
            {
               outputPort.GetAll(new Gen_NewsResponse(oblist.ToList(), true));
               return true;
            }
            else
            {
               Gen_NewsResponse objResponse = new Gen_NewsResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                "404",
                _sharedLocalizer["NO_DATA_FOUND"]));
               _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
               outputPort.GetAll(objResponse);
               return false;
            }
         }
         catch (Exception ex)
         {
            Gen_NewsResponse objResponse = new Gen_NewsResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
            _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
            outputPort.GetAll(objResponse);
            return true;
         }
      }

      public async Task<bool> GetAllPaged(Gen_NewsRequest message, ICRUDRequestHandler<Gen_NewsResponse> outputPort)
      {
         CancellationToken cancellationToken = new CancellationToken();
         try
         {
            IList<gen_newsEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_newsFCC.GetFacadeCreate(_contextAccessor)
            .GetAllByPages(message.Objgen_news, cancellationToken);

            if (oblist != null && oblist.Count > 0)
            {
               outputPort.GetAllPaged(new Gen_NewsResponse(oblist.ToList(), true));
               return true;
            }
            else
            {
               Gen_NewsResponse objResponse = new Gen_NewsResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                "404",
                _sharedLocalizer["NO_DATA_FOUND"]));
               _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
               outputPort.GetAllPaged(objResponse);
               return false;
            }
         }
         catch (Exception ex)
         {
            Gen_NewsResponse objResponse = new Gen_NewsResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
            _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
            outputPort.GetAllPaged(objResponse);
            return true;
         }
      }

      public async Task<bool> GetListView(Gen_NewsRequest message, ICRUDRequestHandler<Gen_NewsResponse> outputPort)
      {
         CancellationToken cancellationToken = new CancellationToken();
         try
         {

            IList<gen_newsEntity> oblist = await BFC.Core.FacadeCreatorObjects.General.gen_newsFCC.GetFacadeCreate(_contextAccessor)
            .GAPgListView(message.Objgen_news, cancellationToken);

            clsPrivateKeys objClsPrivate = new clsPrivateKeys();

            List<dataTableButtonModel> btnActionList = new List<dataTableButtonModel>();
            //btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.New_GET));
            btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.Edit_GET));
            btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.Delete_GET));
            btnActionList.Add(new dataTableButtonModel(basicCRUDButtons.GetSingle_GET));

            var data = (from t in oblist
                        select new
                        {
                           t.newsid,
                           t.newscategoryid,
                           t.newsheadlinear,
                           t.newsheadline,
                           t.newsdetailar,
                           t.newsdetail,
                           t.showinticker,
                           t.showinscroller,
                           t.showasmodal,

                           newsimagepath = !string.IsNullOrEmpty(t.newsimagepath) ? $"{this.ftpServerSetting.ReadFileUrl}{t.newsimagepath}" : $"{this.ftpServerSetting.ReadFileUrl}News/noNewsImage.png",


                           newsheadlinearshort = t.newsheadlinear.Length > 40 ? t.newsheadlinear.Substring(0, 40) + " ... " : t.newsheadlinear,
                           newsdetailarshort = t.newsdetailar.Length > 200 ? t.newsdetailar.Substring(0, 200) + " ... " : t.newsdetailar,
                           publisheddate = t.publisheddate.HasValue ? t.publisheddate.Value.ToString("yyyy-MM-dd") : "-",
                           ViewDetailNews = "/News/NewsDetails" + objClsPrivate.EncodeParams("NewsID", t.newsid.ToString()),
                           datatablebuttonscode = objDTBtnPanel.genDTBtnPanel(message.Objgen_news.ControllerName, t.newsid, "newsid", _contextAccessor.HttpContext.User.Identity as ClaimsIdentity, btnActionList, _contextAccessor),
                           Read_More = _sharedLocalizer["More"].Value

                        }).ToList();

            outputPort.GetListView(new Gen_NewsResponse(new AjaxResponse(oblist[0].RETURN_KEY, data), true, null));
            return true;

         }
         catch (Exception ex)
         {
            Gen_NewsResponse objResponse = new Gen_NewsResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
            _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
            outputPort.GetListView(objResponse);
            return true;
         }
      }

      public async Task<bool> GetSingle(Gen_NewsRequest message, ICRUDRequestHandler<Gen_NewsResponse> outputPort)
      {
         CancellationToken cancellationToken = new CancellationToken();
         try
         {
            gen_newsEntity objSingle = await BFC.Core.FacadeCreatorObjects.General.gen_newsFCC.GetFacadeCreate(_contextAccessor)
            .GetSingle(message.Objgen_news, cancellationToken);

            gen_newsgalleryEntity _objgallery = new gen_newsgalleryEntity();
            if (objSingle != null)
            {
               _objgallery.newsid = objSingle.newsid;
            }

            IList<gen_newsgalleryEntity> objgallerylist = await BFC.Core.FacadeCreatorObjects.General.gen_newsgalleryFCC.GetFacadeCreate(_contextAccessor)
            .GetAll(_objgallery, cancellationToken);

            if (objSingle != null)
            {
                    if (objgallerylist != null && objgallerylist.Count > 0)
                    {
                        objgallerylist = objgallerylist.Select(c => { c.imagepath = (!string.IsNullOrEmpty(objSingle.newsimagepath) ? $"{this.ftpServerSetting.ReadFileUrl}{c.imagepath}" : ""); return c; }).ToList();
                        objSingle.gen_newsgalleryList = objgallerylist.ToList();

                        objSingle.imagefiles = new List<KAF.BusinessDataObjects.cor_foldercontentsEntity>();

                        foreach (var item in objgallerylist)
                        {
                            objSingle.imagefiles.Add(new KAF.BusinessDataObjects.cor_foldercontentsEntity()
                            {
                                fileid = item.newsgalleryid,
                                filepath = item.imagepath,
                                extension=item.imageextension,
                                filetype = item.imagetype,
                                actualfilename = item.imagename,
                                CurrentState = BDO.Core.Base.BaseEntity.EntityState.Unchanged,
                                currentstate = BDO.Core.Base.BaseEntity.EntityState.Unchanged.ToString(),

                            });
                        }
                    }
                    //objSingle.newsimagepath = !string.IsNullOrEmpty(objSingle.newsimagepath) ? $"{this.ftpServerSetting.ReadFileUrl}{objSingle.newsimagepath}" : "";





                    outputPort.GetSingle(new Gen_NewsResponse(objSingle, true));
               return true;
            }
            else
            {
               Gen_NewsResponse objResponse = new Gen_NewsResponse(false, _sharedLocalizer["NO_DATA_FOUND"], new Error(
                "404",
                _sharedLocalizer["NO_DATA_FOUND"]));
               _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
               outputPort.GetSingle(objResponse);
               return false;
            }
         }
         catch (Exception ex)
         {
            Gen_NewsResponse objResponse = new Gen_NewsResponse(false, _sharedLocalizer["DATA_FETCH_ERROR"], new Error(
                "500",
                ex.Message));
            _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
            outputPort.GetSingle(objResponse);
            return true;
         }
      }

      public async Task<bool> Save(Gen_NewsRequest message, ICRUDRequestHandler<Gen_NewsResponse> outputPort)
      {
         _logger.LogInformation(JsonConvert.SerializeObject(message));
         CancellationToken cancellationToken = new CancellationToken();
         long? i = null;
         try
         {
            string News_Image_Folder = "News";
                try
                {
                    if (message.Objgen_news.imagefiles != null && message.Objgen_news.imagefiles.Count > 0)
                    {
                        gen_newsgalleryEntity _objgallery = new gen_newsgalleryEntity();
                        foreach (var imagefile in message.Objgen_news.imagefiles)
                        {

                            string uniquefileName = imagefile.filename.Replace(imagefile.extension, "") + Guid.NewGuid();

                            _objgallery.imageextension = imagefile.extension;
                            _objgallery.imagename = uniquefileName;
                            _objgallery.imagetype = imagefile.GetType().Name;
                            message.Objgen_news.newsimagepath = fileuploadclient.UploadFileFTP(Convert.FromBase64String(imagefile.filepath), News_Image_Folder, uniquefileName, imagefile.extension);
                            _objgallery.imagepath = message.Objgen_news.newsimagepath;

                            message.Objgen_news.gen_newsgalleryList.Add(_objgallery);
                        }
                    }
                }
                catch (Exception)
                {

                }

            i = await BFC.Core.FacadeCreatorObjects.General.gen_newsFCC.GetFacadeCreate(_contextAccessor)
                    .Add(message.Objgen_news, cancellationToken);

            outputPort.Save(new Gen_NewsResponse(new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
            ), true, null));
            return true;
         }
         catch (Exception ex)
         {
            Gen_NewsResponse objResponse = new Gen_NewsResponse(false, _sharedLocalizer["DATA_SAVE_ERROR"], new Error(
                "500",
                ex.Message));
            _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
            outputPort.Save(objResponse);
            return true;
         }
      }

      public async Task<bool> Update(Gen_NewsRequest message, ICRUDRequestHandler<Gen_NewsResponse> outputPort)
      {
         CancellationToken cancellationToken = new CancellationToken();
         long? i = null;
         try
         {

            string News_Image_Folder = "News";

            var single = await BFC.Core.FacadeCreatorObjects.General.gen_newsFCC.GetFacadeCreate(_contextAccessor)
                            .GetSingle(message.Objgen_news, cancellationToken);
            //if (message.Objgen_news.imagefile != null)
            //{

            //   fileuploadclient.DeleteFileFTP(message.Objgen_news.newsimagepath);

            //   FileInfo fileInfo = new FileInfo(message.Objgen_news.imagefile.FileName);
            //   string uniquefileName = message.Objgen_news.imagefile.FileName.Replace(fileInfo.Extension, "") + Guid.NewGuid();

            //   using (var ms = new MemoryStream())
            //   {
            //      message.Objgen_news.imagefile.CopyTo(ms);
            //      var fileBytes = ms.ToArray();
            //      message.Objgen_news.newsimagepath = fileuploadclient.UploadFileFTP(fileBytes, News_Image_Folder, uniquefileName, fileInfo.Extension);
            //   }

            //}
            //else
            //{

            //   message.Objgen_news.newsimagepath = single.newsimagepath;

            //}

            i = await BFC.Core.FacadeCreatorObjects.General.gen_newsFCC.GetFacadeCreate(_contextAccessor)
            .Update(message.Objgen_news, cancellationToken);

            outputPort.Update(new Gen_NewsResponse(new AjaxResponse("200", _sharedLocalizer["DATA_UPDATE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                    ), true, null));
            return true;
         }
         catch (Exception ex)
         {
            Gen_NewsResponse objResponse = new Gen_NewsResponse(false, _sharedLocalizer["DATA_UPDATE_ERROR"], new Error(
                   "500",
                   ex.Message));
            _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
            outputPort.Update(objResponse);
            return true;
         }
      }

      public async Task<bool> Delete(Gen_NewsRequest message, ICRUDRequestHandler<Gen_NewsResponse> outputPort)
      {
         CancellationToken cancellationToken = new CancellationToken();
         long? i = null;
         try
         {
            var single = await BFC.Core.FacadeCreatorObjects.General.gen_newsFCC.GetFacadeCreate(_contextAccessor)
                    .GetSingle(message.Objgen_news, cancellationToken);

            var newsgalary = await BFC.Core.FacadeCreatorObjects.General.gen_newsgalleryFCC.GetFacadeCreate(_contextAccessor)
                    .GetAll(new gen_newsgalleryEntity() { newsid = message.Objgen_news.newsid }, cancellationToken);
            try
            {
               foreach (var item in newsgalary)
               {
                  if (item.imagepath != null)
                  {

                     fileuploadclient.DeleteFileFTP(item.imagepath);
                  }
               }
            }
            catch (Exception)
            {

            }


            i = await BFC.Core.FacadeCreatorObjects.General.gen_newsFCC.GetFacadeCreate(_contextAccessor)
                .Delete(message.Objgen_news, cancellationToken);
            outputPort.Delete(new Gen_NewsResponse(new AjaxResponse("200", _sharedLocalizer["DATA_DELETE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
                   ), true, null));
            return true;
         }
         catch (Exception ex)
         {
            Gen_NewsResponse objResponse = new Gen_NewsResponse(false, _sharedLocalizer["DATA_DELETE_ERROR"], new Error(
                     "500",
                     ex.Message));
            _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
            outputPort.Delete(objResponse);
            return true;
         }
      }

      public async Task<bool> SaveMasterDetgen_newsgallery(Gen_NewsRequest message, ICRUDRequestHandler<Gen_NewsResponse> outputPort)
      {
         _logger.LogInformation(JsonConvert.SerializeObject(message));
         CancellationToken cancellationToken = new CancellationToken();
         List<gen_newsgalleryEntity> _objgalleryList = new List<gen_newsgalleryEntity>();

         long? i = null;
         try
         {
            string News_Image_Folder = "News";
                try
                {
                    if (message.Objgen_news.imagefiles != null && message.Objgen_news.imagefiles.Count > 0)
                    {


                        foreach (var imagefile in message.Objgen_news.imagefiles)
                        {
                            string uniquefileName = imagefile.actualfilename + Guid.NewGuid();
                            message.Objgen_news.newsimagepath = fileuploadclient.UploadFileFTP(Convert.FromBase64String(imagefile.filepath), News_Image_Folder, uniquefileName, imagefile.extension);

                            gen_newsgalleryEntity _objgallery = new gen_newsgalleryEntity();
                            _objgallery.imagepath = message.Objgen_news.newsimagepath;
                            _objgallery.imagetype = imagefile.filetype;
                            _objgallery.imageextension = imagefile.extension;
                            _objgallery.imagename = imagefile.actualfilename;
                            _objgallery.CurrentState = BDO.Core.Base.BaseEntity.EntityState.Added;
                            _objgalleryList.Add(_objgallery);
                        }

                    }
                }
                catch (Exception)
                {

                }
            if (message.Objgen_news.ispublished == true)
               message.Objgen_news.publisheddate = DateTime.Now;

            i = await BFC.Core.FacadeCreatorObjects.General.gen_newsFCC.GetFacadeCreate(_contextAccessor)
                        .SaveMasterDetgen_newsgallery(message.Objgen_news, _objgalleryList, cancellationToken);

            outputPort.Save(new Gen_NewsResponse(new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
            ), true, null));
            return true;
         }
         catch (Exception ex)
         {
            Gen_NewsResponse objResponse = new Gen_NewsResponse(false, _sharedLocalizer["DATA_SAVE_ERROR"], new Error(
                "500",
                ex.Message));
            _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
            outputPort.Save(objResponse);
            return true;
         }
      }

      public async Task<bool> UpdateMasterDetgen_newsgallery(Gen_NewsRequest message, ICRUDRequestHandler<Gen_NewsResponse> outputPort)
      {
         _logger.LogInformation(JsonConvert.SerializeObject(message));
         CancellationToken cancellationToken = new CancellationToken();
         List<gen_newsgalleryEntity> _objgalleryList = new List<gen_newsgalleryEntity>();

         IList<gen_newsgalleryEntity> _objGalleryListExisting = new List<gen_newsgalleryEntity>();
         long? i = null;
         try
         {
            string News_Image_Folder = "News";

            _objGalleryListExisting = await BFC.Core.FacadeCreatorObjects.General.gen_newsgalleryFCC.GetFacadeCreate(_contextAccessor)
                                            .GetAll(new gen_newsgalleryEntity { newsid = message.Objgen_news.newsid }, cancellationToken);

                if (message.Objgen_news.imagefiles != null && message.Objgen_news.imagefiles.Count > 0)
                {
                    foreach (var img in _objGalleryListExisting)
                    {
                        fileuploadclient.DeleteFileFTP(img.imagepath);
                        img.CurrentState = BDO.Core.Base.BaseEntity.EntityState.Deleted;
                    }

                    foreach (var imagefile in message.Objgen_news.imagefiles.Where(q => q.CurrentState != BDO.Core.Base.BaseEntity.EntityState.Deleted))
                    {
                        string uniquefileName = imagefile.actualfilename + Guid.NewGuid();
                        message.Objgen_news.newsimagepath = fileuploadclient.UploadFileFTP(Convert.FromBase64String(imagefile.filepath), News_Image_Folder, uniquefileName, imagefile.extension);

                        gen_newsgalleryEntity _objgallery = new gen_newsgalleryEntity();
                        _objgallery.imagepath = message.Objgen_news.newsimagepath;
                        _objgallery.imagetype = imagefile.filetype;
                        _objgallery.imageextension = imagefile.extension;
                        _objgallery.imagename = imagefile.actualfilename;
                        _objgallery.CurrentState = BDO.Core.Base.BaseEntity.EntityState.Added;

                        _objgalleryList.Add(_objgallery);
                    }

                    foreach (var imagefile in message.Objgen_news.imagefiles.Where(q => q.CurrentState == BDO.Core.Base.BaseEntity.EntityState.Deleted))
                    {

                        gen_newsgalleryEntity _objgallery = new gen_newsgalleryEntity();
                        _objgallery.newsgalleryid = imagefile.fileid;
                        _objgallery.imagepath = message.Objgen_news.newsimagepath;
                        _objgallery.imagetype = imagefile.filetype;
                        _objgallery.imageextension = imagefile.extension;
                        _objgallery.imagename = imagefile.actualfilename;
                        _objgallery.CurrentState = BDO.Core.Base.BaseEntity.EntityState.Deleted;
                        _objgalleryList.Add(_objgallery);
                    }
                }
                //else
                //{
                //    foreach (var img in _objGalleryListExisting)
                //    {
                //        img.CurrentState = BDO.Core.Base.BaseEntity.EntityState.Unchanged;
                //    }
                //    if (_objGalleryListExisting.Count > 0)
                //        message.Objgen_news.newsimagepath = _objGalleryListExisting[0].imagepath;
                //}

            if (message.Objgen_news.ispublished == true)
               message.Objgen_news.publisheddate = DateTime.Now;

            message.Objgen_news.CurrentState = BDO.Core.Base.BaseEntity.EntityState.Changed;
            //_objgalleryList.AddRange(_objGalleryListExisting);

            i = await BFC.Core.FacadeCreatorObjects.General.gen_newsFCC.GetFacadeCreate(_contextAccessor)
                    .SaveMasterDetgen_newsgallery(message.Objgen_news, _objgalleryList, cancellationToken);

            outputPort.Save(new Gen_NewsResponse(new AjaxResponse("200", _sharedLocalizer["DATA_SAVE_CONFIRMATION"].Value, CLL.LLClasses._Status._statusSuccess, CLL.LLClasses._Status._titleInformation, "/"
            ), true, null));
            return true;
         }
         catch (Exception ex)
         {
            Gen_NewsResponse objResponse = new Gen_NewsResponse(false, _sharedLocalizer["DATA_SAVE_ERROR"], new Error(
                "500",
                ex.Message));
            _logger.LogInformation(JsonConvert.SerializeObject(objResponse));
            outputPort.Save(objResponse);
            return true;
         }
      }


   }
}