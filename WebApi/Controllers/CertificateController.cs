using AppConfig.EncryptionHandler;
using AppConfig.HelperClasses;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.DataAccessObjects.ExtendedEntities;
using BDO.DataAccessObjects.Report;
using CLL.Localization;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Microsoft.Reporting.NETCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using Web.Core.Frame.Dto.UseCaseRequests;
using Web.Core.Frame.Interfaces.UseCases;
using Web.Core.Frame.Presenters;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.UseCases;
using WebApi.Extensions;
using WebShared;

namespace Web.Api.Controllers
{
    /// <summary>
    /// CertificateController
    /// </summary>
    [Authorize(Policy = "ApiPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public partial class CertificateController : ControllerBase

    {
        private readonly IKns_Tran_RegistrationProfileUseCase _kns_TranRegistrationProfileUseCase;
        private readonly Kns_Tran_RegistrationProfilePresenter _kns_TranRegistrationProfilePresenter;

        private readonly ILoginUseCase _loginUseCase;
        private readonly LoginPresenter _loginPresenter;


        private readonly ILogger<CertificateController> _logger;
        private readonly IStringLocalizer _sharedLocalizer;

        private readonly KAFPaciServiceSettings _kAFPaciServiceSettings;
        public IConfiguration _configuration { get; }
        private IWebHostEnvironment _webhost;
        private readonly HostingDomainSettings _hostingDomainSettings;
        private readonly IKns_Tran_RegEducationInfoUseCase _Kns_Tran_RegEducationInfoUseCase;
        private readonly Kns_Tran_RegEducationInfoPresenter _Kns_Tran_RegEducationInfoPresenter;


        private readonly IKns_BatchDetailUseCase _Kns_BatchDetailUseCase;
        private readonly Kns_BatchDetailPresenter _Kns_BatchDetailPresenter;


        /// <summary>
        /// CertificateController
        /// </summary>
        /// <param name="kns_TranRegistrationProfileUseCase"></param>
        /// <param name="kns_TranRegistrationProfilePresenter"></param>
        /// <param name="loggerFactory"></param>
        /// <param name="factory"></param>
        /// <param name="schemeProvider"></param>
        /// <param name="webhost"></param>
        /// <param name="configuration"></param>
        /// <param name="kns_Tran_RegEducationInfoUseCase"></param>
        /// <param name="kns_Tran_RegEducationInfoPresenter"></param>
        /// <param name="kns_BatchDetailUseCase"></param>
        /// <param name="kns_BatchDetailPresenter"></param>
        /// <param name="loginUseCase"></param>
        /// <param name="loginPresenter"></param>
        public CertificateController(
            IKns_Tran_RegistrationProfileUseCase kns_TranRegistrationProfileUseCase,
            Kns_Tran_RegistrationProfilePresenter kns_TranRegistrationProfilePresenter,
            ILoggerFactory loggerFactory,
            IStringLocalizerFactory factory,
            IAuthenticationSchemeProvider schemeProvider,
            IWebHostEnvironment webhost,
            IConfiguration configuration
,
            IKns_Tran_RegEducationInfoUseCase kns_Tran_RegEducationInfoUseCase,
            Kns_Tran_RegEducationInfoPresenter kns_Tran_RegEducationInfoPresenter,
            IKns_BatchDetailUseCase kns_BatchDetailUseCase,
            Kns_BatchDetailPresenter kns_BatchDetailPresenter,

            ILoginUseCase loginUseCase, 
            LoginPresenter loginPresenter)
        {
            _kns_TranRegistrationProfileUseCase = kns_TranRegistrationProfileUseCase;
            _kns_TranRegistrationProfilePresenter = kns_TranRegistrationProfilePresenter;
            _logger = loggerFactory.CreateLogger<CertificateController>();

            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _sharedLocalizer = factory.Create("SharedResource", assemblyName.Name);
            _webhost = webhost;
            _configuration = configuration;
            _kAFPaciServiceSettings = _configuration.GetSection(nameof(KAFPaciServiceSettings)).Get<KAFPaciServiceSettings>();
            _hostingDomainSettings = _configuration.GetSection(nameof(HostingDomainSettings)).Get<HostingDomainSettings>();
            _Kns_Tran_RegEducationInfoUseCase = kns_Tran_RegEducationInfoUseCase;
            _Kns_Tran_RegEducationInfoPresenter = kns_Tran_RegEducationInfoPresenter;
            _Kns_BatchDetailUseCase = kns_BatchDetailUseCase;
            _Kns_BatchDetailPresenter = kns_BatchDetailPresenter;

            _loginUseCase = loginUseCase;
            _loginPresenter = loginPresenter;
        }



        /// <summary>
        /// ProfileCertificate
        /// </summary>
        /// <param name="civilId"></param>
        /// <returns></returns>
        [HttpGet("ProfileCertificate")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<IActionResult> ProfileCertificate(string civilId)
        {
            try
            {
                var FileByte = await GetReportByCivilId(civilId, "rdlc_Get_rpt_ApplicantProfileReportQR");
                return Ok(FileByte);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }


        /// <summary>
        /// ProfessionalCertificate
        /// </summary>
        /// <param name="civilId"></param>
        /// <returns></returns>
		[HttpGet("ProfessionalCertificate")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<IActionResult> ProfessionalCertificate(string civilId)
        {
            try
            {
                var FileByte = await GetReportByCivilId(civilId, "Rdlc_ApplicantProfessionCertificateQR");
                return Ok(FileByte);
            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);
            }

        }


        /// <summary>
        /// EmployementCertificate
        /// </summary>
        /// <param name="civilId"></param>
        /// <returns></returns>
		[HttpGet("EmployementCertificate")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<IActionResult> EmployementCertificate(string civilId)
        {
            try
            {
                var FileByte = await GetReportByCivilId(civilId, "Rdlc_ApplicantEmploymentCertificateQR");
                return Ok(FileByte);
            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);
            }

        }


        /// <summary>
        /// GeneralCertificate
        /// </summary>
        /// <param name="civilId"></param>
        /// <returns></returns>
		[HttpGet("GeneralCertificate")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<IActionResult> GeneralCertificate(string civilId)
        {
            try
            {
                var FileByte = await GetReportByCivilId(civilId, "rdlc_Get_rpt_ApplicantProfileReport_Ext");
                return Ok(FileByte);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }


        /// <summary>
        /// RecruitSituationCertificate
        /// </summary>
        /// <param name="civilId"></param>
        /// <returns></returns>
        [HttpGet("RecruitSituationCertificate")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<IActionResult> RecruitSituationCertificate(string civilId)
        {
            try
            {
                string ReportName = "Rdlc_RecruitSituation";

                var result = await _kns_TranRegistrationProfileUseCase.Get_RecruitSituation_Report(new Kns_Tran_RegistrationProfileRequest(new kns_tran_registrationprofileEntity() { civilid = civilId, strMasterID = ReportName }), _kns_TranRegistrationProfilePresenter);

                if (result)
                {
                    var objEntty = new List<RecruitSituationReportEntity>();
                    objEntty = (List<RecruitSituationReportEntity>)_kns_TranRegistrationProfilePresenter.Result;

                    await _Kns_BatchDetailUseCase.GetAll(new Kns_BatchDetailRequest(new kns_batchdetailEntity() { basicinfoid = objEntty.FirstOrDefault().basicinfoid }), _Kns_BatchDetailPresenter);
                    var kns_batchdetailList = _Kns_BatchDetailPresenter.Result as List<kns_batchdetailEntity>;
                    if (kns_batchdetailList != null && kns_batchdetailList.Count > 0)
                    {
                        var CurrentBatchDetail = kns_batchdetailList.OrderByDescending(p => p.planorderdetailid).FirstOrDefault();
                        if (CurrentBatchDetail.KnsNo.HasValue)
                        {
                            StringValues languages = "en-US";
                            if (!Request.Headers.TryGetValue("Accept-Language", out languages))
                            {
                                // Default to English if Accept-Language header is not present
                                languages = "ar-KW";
                            }

                            var Message = languages == "ar-KW" ? "يرجى مراجعة الخدمة الوطنية لاصدار الشهادة للمجندين" : "During training you are not able to download report";
                        }
                    }

                    ReportParameter[] parameters = new ReportParameter[0];


                    clsPrivateKeys objClsPrivate = new clsPrivateKeys();
                    foreach (RecruitSituationReportEntity item in objEntty)
                    {
                        EncryptionHelper objEnc = new EncryptionHelper();

                        QRCode obj = new QRCode();


                        string StrEnc = objClsPrivate.EncodeParams("profile", item.CivilID + "," + DateTime.Now.ToString("yyyy/MM/dd"), "ReportSerial", objEntty.FirstOrDefault().code);

                        string encValue = _hostingDomainSettings.KnsFrontAddress + "/Registered/ValidateProfile" + StrEnc;
                        item.QRCode = QRCoder(encValue);

                    }


                    SharedReport sharedReport = new SharedReport();
                    var bytearrReport = sharedReport.GenerateReport(objEntty, ReportName, parameters);
                    var base64String = Convert.ToBase64String(bytearrReport);
                    return Ok(base64String);
                }
                else
                {
                    throw new Exception("Provided CivilId Is not Register");
                }
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }


        /// <summary>
        /// DrivingLicCertificate
        /// </summary>
        /// <param name="civilid"></param>
        /// <returns></returns>

        [AllowAnonymous]
        [HttpGet("DrivingLicCertificate/civilid/{civilid}")]
        [ServiceFilter(typeof(ApiSecurityFillerAttribute))]
        public async Task<IActionResult> DrivingLicCertificate(string civilid)
        {
            string username = string.Empty;
            string password = string.Empty;
            try
            {
                
                if (Request.Headers.TryGetValue("username", out var headerusername))
                {
                    username = headerusername.ToString();
                }
                if (Request.Headers.TryGetValue("password", out var headerpassword))
                {
                    password = headerpassword.ToString();
                }

                if (username == string.Empty || password == string.Empty)
                {
                    return BadRequest();
                }
                else
                {
                    LoginRequest Loginrequest = new LoginRequest(username, password, "127.0.0.1");
                    await _loginUseCase.Handle(Loginrequest, _loginPresenter);
                    var token = _loginPresenter.ContentResult.Content.ToString();

                    if (token != string.Empty)
                    {
                        token = token.Trim();
                        if (token.StartsWith("[") && token.EndsWith("]"))
                        {
                            token = token.Substring(1, token.Length - 2);
                        }


                        JObject jsonObject = JObject.Parse(token);
                        if (jsonObject["accessToken"] != null)
                        {
                            JToken successToken = jsonObject["success"];
                            if (successToken != null && successToken.Type == JTokenType.Boolean)
                            {
                                bool success = successToken.Value<bool>();
                                var Result = await _kns_TranRegistrationProfileUseCase.CheckRecruitDrivingLicence(new Kns_Tran_RegistrationProfileRequest(new kns_tran_registrationprofileEntity() { civilid = civilid }), _kns_TranRegistrationProfilePresenter);
                                if (Result)
                                {
                                    var data = _kns_TranRegistrationProfilePresenter.Result as List<kns_tran_registrationprofileEntity>;

                                    var Reply = new clsJsonReply();
                                    Reply.status = "success";
                                    Reply.responsetext = data.FirstOrDefault().IsAccepted;
                                    return Ok(Reply);
                                }
                                else
                                {
                                    var Reply = new clsJsonReply();
                                    Reply.status = "Civil ID not found in the database";
                                    Reply.responsetext = "no";
                                    return Ok(Reply);
                                }
                            }
                            else
                            {
                                return Unauthorized();
                            }
                        }
                        else
                        {
                            return Unauthorized();
                        }
                    }
                    else
                        return Unauthorized();
                }
            }
            catch (Exception)
            {
                var Reply = new clsJsonReply();
                Reply.status = "Civil ID not found in the database";
                Reply.responsetext = "no";
                return NotFound(Reply);
            }
        }



        private async Task<string> GetReportByCivilId(string civilId, string RDLCReportName)
        {
            string ReportName = GetReportName(RDLCReportName);
            await _kns_TranRegistrationProfileUseCase.Get_rpt_StudentProfile_Ext(new Kns_Tran_RegistrationProfileRequest(new kns_tran_registrationprofileEntity() { civilid = civilId, strMasterID = RDLCReportName }), _kns_TranRegistrationProfilePresenter);
            var objEntty = new List<kns_tran_registrationprofileEntity>();
            objEntty = (List<kns_tran_registrationprofileEntity>)_kns_TranRegistrationProfilePresenter.Result;

            if (objEntty.Count == 0)
            {
                throw new Exception("Provided CivilId Is not Register");
            }


            await _Kns_BatchDetailUseCase.GetAll(new Kns_BatchDetailRequest(new kns_batchdetailEntity() { basicinfoid = objEntty.FirstOrDefault().basicinfoid }), _Kns_BatchDetailPresenter);
            var kns_batchdetailList = _Kns_BatchDetailPresenter.Result as List<kns_batchdetailEntity>;
            if (kns_batchdetailList != null && kns_batchdetailList.Count > 0)
            {
                var CurrentBatchDetail = kns_batchdetailList.OrderByDescending(p => p.planorderdetailid).FirstOrDefault();
                objEntty.FirstOrDefault().KnsNo = CurrentBatchDetail.KnsNo;
            }

            if (objEntty.FirstOrDefault().KnsNo.HasValue)
            {
                StringValues languages = "en-US";
                if (!Request.Headers.TryGetValue("Accept-Language", out languages))
                {
                    // Default to English if Accept-Language header is not present
                    languages = "ar-KW";
                }


                var Message = languages == "ar-KW" ? "تم الرفض حيث أن المجند في التدريب حاليا" : "During traning you are not able to download report";

                throw new Exception(Message);
            }

            await _Kns_Tran_RegEducationInfoUseCase.GetAll(new Kns_Tran_RegEducationInfoRequest(new kns_tran_regeducationinfoEntity() { basicinfoid = objEntty.FirstOrDefault().basicinfoid }), _Kns_Tran_RegEducationInfoPresenter);
            var Kns_Tran_RegEducationInfo = _Kns_Tran_RegEducationInfoPresenter.Result as List<kns_tran_regeducationinfoEntity>;
            if (Kns_Tran_RegEducationInfo == null)
            {
                StringValues languages = "en-US";
                if (!Request.Headers.TryGetValue("Accept-Language", out languages))
                {
                    // Default to English if Accept-Language header is not present
                    languages = "ar-KW";
                }


                //var isRtl = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.IsRightToLeft;
                var Message = languages == "ar-KW" ? "يجب استكمال بيانات الشهادة الدراسية لتحميل الشهادة" : "You have not provided any education/certificate info";
                //var Message = "يجب استكمال بيانات الشهادة الدراسية لتحميل الشهادة";

                throw new Exception(Message);
            }

            clsPrivateKeys objClsPrivate = new clsPrivateKeys();
            ReportParameter[] parameters;
            if (RDLCReportName == "rdlc_Get_rpt_ApplicantProfileReport_Ext")
            {
                parameters = new ReportParameter[2];
                parameters[0] = new ReportParameter("LoggedInUserName", objEntty.FirstOrDefault().civilid);
                parameters[1] = new ReportParameter("CivilId", objEntty.FirstOrDefault().civilid);
            }
            else
            {
                parameters = new ReportParameter[0];
            }

            foreach (kns_tran_registrationprofileEntity item in objEntty)
            {
                EncryptionHelper objEnc = new EncryptionHelper();

                QRCode obj = new QRCode();


                string StrEnc = objClsPrivate.EncodeParams("profile", item.civilid + "," + DateTime.Now.ToString("yyyy/MM/dd"), "ReportSerial", objEntty.FirstOrDefault().code);

                string encValue = _hostingDomainSettings.KnsFrontAddress + "/Registered/ValidateProfile" + StrEnc;
                item.QRCode = QRCoder(encValue);

            }
            SharedReport sharedReport = new SharedReport();
            var bytearrReport = sharedReport.GenerateReport(objEntty, ReportName, parameters);
            var base64String = Convert.ToBase64String(bytearrReport);
            return base64String;
        }
        private byte[] QRCoder(string SignEncGUID)
        {
            QRCodeGenerator.ECCLevel eccLevel = QRCodeGenerator.ECCLevel.M;
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(SignEncGUID, eccLevel))
                {
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {
                        Bitmap bm = qrCode.GetGraphic(20, System.Drawing.Color.Black, System.Drawing.Color.White, null, 0);
                        return (byte[])TypeDescriptor.GetConverter(bm).ConvertTo(bm, typeof(byte[]));
                        // _signBase64 = Convert.ToBase64String(bytes);
                    }
                }
            }
        }
        private string GetReportName(string strreportname)
        {
            string reportName = string.Empty;
            if (strreportname.Contains("rdlc_Get_rpt_ApplicantProfileReportQR"))
            {
                reportName = "rdlc_Get_rpt_ApplicantProfileReportQR";
            }
            else if (strreportname.Contains("Rdlc_ApplicantEmploymentCertificateQR"))
            {
                reportName = "Rdlc_ApplicantEmploymentCertificateQR";
            }
            else if (strreportname.Contains("Rdlc_ApplicantProfessionCertificateQR"))
            {
                reportName = "Rdlc_ApplicantProfessionCertificateQR";
            }
            else if (strreportname.Contains("rdlc_Get_rpt_ApplicantProfileReport_Ext"))
            {
                reportName = "rdlc_Get_rpt_ApplicantProfileReport_Ext";
            }
            return reportName;
        }
    }

    /// <summary>
    /// clsJsonReply
    /// </summary>
    [Serializable]
    [DataContract(Name = "clsJsonReply", Namespace = "http://www.KAF.com/types")]
    public class clsJsonReply
    {
        [DataMember]
        public string status { get; set; }

        [DataMember]
        public string responsetext { get; set; }

        public clsJsonReply() : base()
        { }
    }
}
