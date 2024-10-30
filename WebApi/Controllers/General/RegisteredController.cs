using AppConfig.EncryptionHandler;
using AppConfig.HelperClasses;
using BDO;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.DataAccessObjects.Report;
using CLL.LLClasses.Models;
using CLL.Localization;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Spreadsheet;
using Jil;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Reporting.NETCore;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using Newtonsoft.Json;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Web.Core.Frame.Interfaces.UseCases;
using Web.Core.Frame.Presenters;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.UseCases;
using WebApi.Extensions;
using WebShared;

namespace WebFront.Controllers
{
    /// <summary>
    /// RegisteredController
    /// </summary>
    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]

    public class RegisteredController : ControllerBase
    {

        private readonly ILogger<RegisteredController> _logger;

        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IAuth_UseCase _auth_UseCase;
        private readonly Auth_Presenter _auth_UsePresenter;


        private readonly IStringLocalizerFactory factory;
        private readonly IRegisterUserUseCase _RegisterUseruseCase;
        private readonly RegisterUserPresenter _registerUserPresenter;

        private readonly IStringLocalizer _sharedLocalizer;


        private readonly IAuthenticationSchemeProvider _schemeProvider;
        
        private readonly IKns_Gen_CertificateUseCase _kns_GenCertificateUseCase;
        private readonly Kns_Gen_CertificatePresenter _kns_GenCertificatePresenter;


        private readonly IKns_Gen_CertificateSubjectsUseCase _kns_GenCertificateSubjectsUseCase;
        private readonly Kns_Gen_CertificateSubjectsPresenter _kns_GenCertificateSubjectsPresenter;


        private readonly IKns_ImportFromPaciExcelUseCase _kns_ImportFromPaciExcelUseCase;
        private readonly Kns_ImportFromPaciExcelPresenter _Kns_ImportFromPaciExcelPresenter;


        private readonly IKns_Tran_RegistrationProfileUseCase _kns_TranRegistrationProfileUseCase;
        private readonly Kns_Tran_RegistrationProfilePresenter _kns_TranRegistrationProfilePresenter;

        private IWebHostEnvironment _webhost;


        
        public RegisteredController(
                    IKns_Tran_RegistrationProfileUseCase kns_TranRegistrationProfileUseCase,
                    Kns_Tran_RegistrationProfilePresenter kns_TranRegistrationProfilePresenter,
            IHttpContextAccessor contextAccessor,

                    ILoggerFactory loggerFactory,
                    IAuth_UseCase auth_UseCase,
                    Auth_Presenter auth_UsePresenter,
                    IStringLocalizerFactory factory,
                    IRegisterUserUseCase iRegisterUseruseCase,
                    RegisterUserPresenter registerUserPresenter,
                    IKns_Gen_CertificateUseCase kns_GenCertificateUseCase,
                    Kns_Gen_CertificatePresenter kns_GenCertificatePresenter,
                    IKns_Gen_CertificateSubjectsUseCase kns_GenCertificateSubjectsUseCase,
                    Kns_Gen_CertificateSubjectsPresenter kns_GenCertificateSubjectsPresenter,
                    IKns_ImportFromPaciExcelUseCase kns_ImportFromPaciExcelUseCase,
                    Kns_ImportFromPaciExcelPresenter kns_ImportFromPaciExcelPresenter,
                     IWebHostEnvironment webhost)
        {


            _logger = loggerFactory.CreateLogger<RegisteredController>();
            this.factory = factory;
            _contextAccessor = contextAccessor;


            _auth_UseCase = auth_UseCase;
            _auth_UsePresenter = auth_UsePresenter;

            this._RegisterUseruseCase = iRegisterUseruseCase;
            this._registerUserPresenter = registerUserPresenter;
            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _sharedLocalizer = factory.Create("SharedResource", assemblyName.Name);

            _kns_GenCertificateUseCase = kns_GenCertificateUseCase;
            _kns_GenCertificatePresenter = kns_GenCertificatePresenter;

            _kns_GenCertificateSubjectsUseCase = kns_GenCertificateSubjectsUseCase;
            _kns_GenCertificateSubjectsPresenter = kns_GenCertificateSubjectsPresenter;
            _kns_ImportFromPaciExcelUseCase = kns_ImportFromPaciExcelUseCase;
            _Kns_ImportFromPaciExcelPresenter = kns_ImportFromPaciExcelPresenter;
            _webhost = webhost;


            _kns_TranRegistrationProfileUseCase = kns_TranRegistrationProfileUseCase;
            _kns_TranRegistrationProfilePresenter = kns_TranRegistrationProfilePresenter;
        }


        /// <summary>
        /// CheckIfKAFListed
        /// </summary>
        /// <returns></returns>
        /// 
       // [ApiExplorerSettings(IgnoreApi = true)]
        [AllowAnonymous]
        [HttpGet("CheckIfKAFListed/civilid/{civilid}")]
        public async Task<ActionResult> CheckIfKAFListed(string civilid)
        {
            if (string.IsNullOrEmpty(civilid))
                return BadRequest();

            kns_importfrompaciexcelEntity objEntity = new kns_importfrompaciexcelEntity();
            objEntity.civilid = civilid;
            await _kns_ImportFromPaciExcelUseCase.ValiidatePaciCivilIDFromCD(new Kns_ImportFromPaciExcelRequest(objEntity), _Kns_ImportFromPaciExcelPresenter);
            return _Kns_ImportFromPaciExcelPresenter.ContentResult;
        }


        /// <summary>
        /// GetAllGenCertificate
        /// </summary>
        /// <returns></returns>
        [ApiExplorerSettings(IgnoreApi = true)]
        [AllowAnonymous]
        [HttpGet("GetAllGenCertificate")]
        public async Task<ActionResult> GetAllGenCertificate()
        {
            await _kns_GenCertificateUseCase.GetAll(new Kns_Gen_CertificateRequest(new kns_gen_certificateEntity()), _kns_GenCertificatePresenter);
            return _kns_GenCertificatePresenter.ContentResult;
        }

        /// <summary>
        /// GetAllGenCertificateSubjectsByCertificate
        /// </summary>
        /// <returns></returns>
        [ApiExplorerSettings(IgnoreApi = true)]
        [AllowAnonymous]
        [HttpGet("GetAllGenCertificateSubjectsByCertificate/certificateid/{certificateid}")]
        public async Task<ActionResult> GetAllGenCertificateSubjectsByCertificate(string certificateid)
        {
            await _kns_GenCertificateSubjectsUseCase.GetAll(new Kns_Gen_CertificateSubjectsRequest(new kns_gen_certificatesubjectsEntity()
            {
                certificateid = string.IsNullOrEmpty(certificateid) == true? -99 : long.Parse(certificateid)
            }), _kns_GenCertificateSubjectsPresenter);
            return _kns_GenCertificateSubjectsPresenter.ContentResult;
        }


        /// <summary>
        /// RegisterProfile
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("RegisterProfile")]
        public async Task<ActionResult> RegisterProfile([FromBody] KnsUserRegistrationEntity request)
        {
            _logger.LogInformation("Post Data For Registration", request);
            await _kns_TranRegistrationProfileUseCase.Registration(new Kns_Tran_RegistrationProfileRequest(DataPrepearForRegister(request)), _kns_TranRegistrationProfilePresenter);
            return _kns_TranRegistrationProfilePresenter.ContentResult;
        }


        private kns_tran_registrationprofileEntity DataPrepearForRegister(KnsUserRegistrationEntity request)
        {

            request.ConfirmPassword = request.Password = "KnS#007"; //RandomString(6);

            kns_tran_registrationprofileEntity kns_Tran_RegistrationprofileEntity = new kns_tran_registrationprofileEntity();

            kns_Tran_RegistrationprofileEntity.civilid = request.cividId;
            kns_Tran_RegistrationprofileEntity.name1 = request.PaciData.araB_NAME_1;
            kns_Tran_RegistrationprofileEntity.name2 = request.PaciData.araB_NAME_2;
            kns_Tran_RegistrationprofileEntity.name3 = request.PaciData.araB_NAME_3;
            kns_Tran_RegistrationprofileEntity.name5 = request.PaciData.araB_NAME_4;
            kns_Tran_RegistrationprofileEntity.fullname = request.PaciData.araB_FULL_NAME;
            kns_Tran_RegistrationprofileEntity.dob = DateTime.Parse(request.PaciData.birtH_DATE.Value.ToString("yyyy-MM-dd"));

            kns_Tran_RegistrationprofileEntity.mob1 = request.PaciData.teL_1;
            kns_Tran_RegistrationprofileEntity.mob2 = request.PaciData.teL_2;
            kns_Tran_RegistrationprofileEntity.email = request.Email;



            kns_Tran_RegistrationprofileEntity.paciauthdata = request.PaciJsonData;
            kns_Tran_RegistrationprofileEntity.paciservicedata = request.PaciPersonalDataJson;

            kns_Tran_RegistrationprofileEntity.password = request.Password;

            kns_Tran_RegistrationprofileEntity.BackOfficeAdminUser = request.BackOfficeAdminUser;
            kns_Tran_RegistrationprofileEntity.BackOfficeAdminUserPass = request.BackOfficeAdminUserPass;

            //Set HardCode Value
            kns_Tran_RegistrationprofileEntity.registrationstatus = (int)RegistrationStatusEnm.Account_OP;
            kns_Tran_RegistrationprofileEntity.countrynationalityid = 1;// Kuwaiti



            kns_Tran_RegistrationprofileEntity.kns_tran_regimergencycontactinfo = request.kns_tran_regimergencycontactinfo;

            kns_Tran_RegistrationprofileEntity.gender = 1;//MALE
            kns_Tran_RegistrationprofileEntity.peraddcountryid = 1;// Kuwaiti
            kns_Tran_RegistrationprofileEntity.maritalstatus = 4;// UnMarride


            CancellationToken cancellationToken = new CancellationToken();
            kns_Tran_RegistrationprofileEntity.bloodgroupid = BFC.Core.FacadeCreatorObjects.General.gen_bloodgroupFCC.GetFacadeCreate(_contextAccessor).GetAll(new gen_bloodgroupEntity() { bloodgroup = request.PaciData.blooD_TYPE }, cancellationToken)
                .Result.FirstOrDefault()?.bloodgroupid;

            kns_Tran_RegistrationprofileEntity.peraddgovernid = BFC.Core.FacadeCreatorObjects.General.gen_govcityFCC.GetFacadeCreate(_contextAccessor).GetAll(new gen_govcityEntity() { gov_code_paci = request.PaciData.governoratE_NAME }, cancellationToken).Result.FirstOrDefault()?.cityid;

            if (kns_Tran_RegistrationprofileEntity.peraddgovernid.HasValue)
            {
                kns_Tran_RegistrationprofileEntity.peraddcityid = BFC.Core.FacadeCreatorObjects.General.gen_govcityFCC.GetFacadeCreate(_contextAccessor).GetAll(new gen_govcityEntity()
                {
                    cityname = request.PaciPersonalData.Address.Area,
                    parentid = kns_Tran_RegistrationprofileEntity.peraddgovernid
                }, cancellationToken).Result.FirstOrDefault()?.cityid;
            }

            kns_Tran_RegistrationprofileEntity.peraddblock = request.PaciPersonalData.Address.BlockNumber;
            kns_Tran_RegistrationprofileEntity.peraddstreet = request.PaciPersonalData.Address.StreetName;
            kns_Tran_RegistrationprofileEntity.perpaci = request.PaciPersonalData.Address.PaciBuildingNumber;
            kns_Tran_RegistrationprofileEntity.peraddhousingno = request.PaciPersonalData.Address.BuildingNumber;
            kns_Tran_RegistrationprofileEntity.peraddhousingflatno = request.PaciPersonalData.Address.FloorNumber;


            kns_Tran_RegistrationprofileEntity.kns_tran_regeducationinfoEntity = request.kns_tran_regeducationinfoEntity;

            return kns_Tran_RegistrationprofileEntity;
        }

    }
}