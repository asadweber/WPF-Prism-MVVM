using AppConfig.HelperClasses;
using BDO.Core.DataAccessObjects.CommonEntities;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.DataAccessObjects.ExtendedEntities;
using CLL.LLClasses;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Web.Core.Frame.Interfaces.Services;
using Web.Core.Frame.Interfaces.UseCases;
using Web.Core.Frame.Presenters;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Path = System.IO.Path;

namespace Web.Api.Infrastructure.Services
{
	/// <summary>
	/// 
	/// </summary>
	public class NotificationService : INotificationService
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IConfiguration _config;
        private readonly IOptions<EmailSettings> _optionsEmailSettings;
        private readonly KAFPaciServiceSettings _kAFPaciServiceSettings;
		private readonly IGen_PhasesUseCase _gen_PhasesUseCase;
		private readonly Gen_PhasesPresenter _gen_PhasesPresenter;

		internal NotificationService(IConfiguration config,
            IOptions<EmailSettings> optionsEmailSettings
			, IGen_PhasesUseCase gen_PhasesUseCase
			, Gen_PhasesPresenter gen_PhasesPresenter
			, IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
            _config = config;
            _optionsEmailSettings = optionsEmailSettings;
            _kAFPaciServiceSettings = _config.GetSection(nameof(KAFPaciServiceSettings)).Get<KAFPaciServiceSettings>();

			_gen_PhasesUseCase = gen_PhasesUseCase;
			_gen_PhasesPresenter = gen_PhasesPresenter;
		}

		public NotificationService()
		{
		}

		/// <summary>
		/// SendDigitalIDNotifcationAsync
		/// </summary>
		/// <param name="civilid"></param>
		/// <param name="subject"></param>
		/// <param name="message"></param>
		/// <param name="subjectAR"></param>
		/// <param name="messageAR"></param>
		/// <returns></returns>
		public async Task<bool> SendDigitalIDNotifcationAsync(string civilid, string subject, string message, string subjectAR, string messageAR)
		{
			bool isOK=true;
			var returnValue = Execute(civilid, subject, message, subjectAR, messageAR);
			//if(returnValue.)
			return  isOK; 
		}

		public async Task<bool> SendDigitalIDNotifcationStatusChangeAsync(kns_tran_registrationprofileEntity profile)
		{
			var StatusUpdateKey = long.Parse(_config.GetSection("Notification").GetSection("StatusUpdateKey").Value);
			await _gen_PhasesUseCase.GetSingle(new Gen_PhasesRequest(new gen_phasesEntity() { phasesid = StatusUpdateKey }), _gen_PhasesPresenter);
			var phaseInfo = (gen_phasesEntity)_gen_PhasesPresenter.Result;
			bool isOK = true;
			var returnValue = Execute(profile.civilid, phaseInfo.paciNotificationSubjectTemplateAR, ReplaceStingforProfile(profile,phaseInfo.pacinotificationtemplateAR), phaseInfo.paciNotificationSubjectTemplateAR, ReplaceStingforProfile(profile, phaseInfo.pacinotificationtemplateAR));
			return isOK;
		}
		public static string StripHTML(string input)
		{
			return Regex.Replace(input, "<[a-zA-Z/].*?>", String.Empty);
		}
		private string ReplaceStingforProfile( kns_tran_registrationprofileEntity profile, string NotficationMsg)
		{
			string FormatNotficationMsg = string.Empty;
			if (string.IsNullOrEmpty(profile.Age))
				profile.Age = "0";
			if (!string.IsNullOrEmpty(NotficationMsg))
			{
				FormatNotficationMsg = NotficationMsg.Replace("{name}", profile.fullname).Replace("{Name}", profile.fullname).Replace("{NAME}", profile.fullname);
				FormatNotficationMsg = FormatNotficationMsg.Replace("{age}", profile.Age.ToString()).Replace("{Age}", profile.Age.ToString()).Replace("{AGE}", profile.Age.ToString());
				FormatNotficationMsg = FormatNotficationMsg.Replace("{civilid}", profile.civilid).Replace("{CivilID}", profile.civilid).Replace("{CIVILID}", profile.civilid);
				FormatNotficationMsg = StripHTML(FormatNotficationMsg);
			}
			else
			{
				FormatNotficationMsg = "";
			}
			return FormatNotficationMsg;
		}
		
		public async Task<bool> SendBulkDigitalIDNotifcationAsync(byte[] fileByteContent, string file_guid, bool? sendsms, bool? senddigitalidnotification, bool? sendemail, bool? SendSahelNotification, bool? SendWhatsAppNotification)
        {
            var token = GetToken().Result;
            var bearerToken = token;
            var applicationId = "C4077E81-CD92-42E9-8811-B93A6578A4C7";
           
			HttpResponseMessage response = null;
            var fileGuid = file_guid;
            var msg = "";
			bool isOK = false;
           
			var AllowSendNotification = bool.Parse(_config.GetSection("Notification").GetSection("AllowSendNotification").Value);

			if (AllowSendNotification)
			{
				try
				{
					using (var httpClient = new HttpClient())
					{
						using (var request = new HttpRequestMessage(new HttpMethod("POST"), _kAFPaciServiceSettings.WebApiAddress + "NotificationFileRequestInfo/NotificationFileUpload"))
						{
							request.Headers.TryAddWithoutValidation("accept", "*/*");
							request.Headers.TryAddWithoutValidation("Authorization", $"bearer {bearerToken}");

							var multipartContent = new MultipartFormDataContent();
							multipartContent.Add(new StringContent(file_guid.ToString()), "fileguid");
							multipartContent.Add(new StringContent(applicationId), "applicationid");
							multipartContent.Add(new StringContent(sendsms.ToString()), "sendsms");
							multipartContent.Add(new StringContent(senddigitalidnotification.ToString()), "senddigitalidnotification");
							multipartContent.Add(new StringContent(sendemail.ToString()), "sendemail");
							
							multipartContent.Add(new StringContent(SendSahelNotification.ToString()), "sendsahelnotification");
							multipartContent.Add(new StringContent(SendWhatsAppNotification.ToString()), "sendwhatsappnotification");


							MemoryStream ms = new MemoryStream(fileByteContent);
							multipartContent.Add(new StreamContent(ms), "file", $"{fileGuid}.xlsx");

							request.Content = multipartContent;
							response = await httpClient.SendAsync(request);
							if (response.IsSuccessStatusCode)
							{
								var contents = await response.Content.ReadAsStringAsync();
								dynamic _responsebody = Newtonsoft.Json.Linq.JObject.Parse(contents);
								msg = _responsebody._ajaxresponse.responsetext.ToString();
								isOK = true;

							}
							else
							{
								msg = "Failed";
							}
						}
					}
				}
				catch (Exception ex)
				{
					throw ex;
				}
				finally
				{
					response = null;
					//httpClient.Dispose();
				}
			}
			else
			{
                isOK = true;
            }
			
			return isOK;
        }

        public async Task<string> SentNotification(PaciNotification NotificationBody, bool allowSendNotification)
        {
            string? response=string.Empty;
            try
            {
				if (allowSendNotification)
				{
					var token = GetToken().Result;
					var bearerToken = token;

					using (var notificationClient = new RestClient($"{_kAFPaciServiceSettings.WebApiAddress}NotificationRequestRecipientList/SendNotificationToSingleUser"))
					{
						var Shahilrequest = new RestRequest() { Method = Method.Post };
						Shahilrequest.AddHeader("Content-Type", "application/json");
						Shahilrequest.AddHeader("Authorization", $"Bearer {bearerToken}");


						Shahilrequest.AddJsonBody(NotificationBody);
						var NotificationApiresponse = notificationClient.Execute(Shahilrequest);
						response = NotificationApiresponse.Content;

					}
				}

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
            return response;
        }



        private void readExcel(string filePath)
		{
			List<_notificationrequestrecipientlistEntity> notificationrequestrecipientlist = new List<_notificationrequestrecipientlistEntity>();
			try
			{

				using var workbook = new XLWorkbook(filePath);
				var memoryStream = new MemoryStream();
				workbook.SaveAs(memoryStream);
				memoryStream.Position = 0;

				using (var workBook = new XLWorkbook(memoryStream))
				{
					var worksheet = workBook.Worksheet(1);
					//string firstSerial = worksheet.Cell(1, 1).GetValue<string>();
					//string firstCivilID = worksheet.Cell(1, 2).GetValue<string>();
					//string firstMessageSubject = worksheet.Cell(1, 3).GetValue<string>();
					//string firstMessageBody = worksheet.Cell(1, 4).GetValue<string>();
					//string firstMessageSubjectAR = worksheet.Cell(1, 5).GetValue<string>();
					//string firstMessageBodyAR = worksheet.Cell(1, 6).GetValue<string>();
					//string firstMobileNumber = worksheet.Cell(1, 7).GetValue<string>();
					//string firstEmailContent = worksheet.Cell(1, 8).GetValue<string>();
					//string firstEmailContentAR = worksheet.Cell(1, 9).GetValue<string>();
					//string firstEmail = worksheet.Cell(1, 10).GetValue<string>();
					int row = 2;
					while (true)
					{
						string Serial = worksheet.Cell(row, 1).GetValue<string>();
						string CivilID = worksheet.Cell(row, 2).GetValue<string>();
						string MessageSubject = worksheet.Cell(row, 3).GetValue<string>();
						string MessageBody = worksheet.Cell(row, 4).GetValue<string>();
						string MessageSubjectAR = worksheet.Cell(row, 5).GetValue<string>();
						string MessageBodyAR = worksheet.Cell(row, 6).GetValue<string>();
						string MobileNumber = worksheet.Cell(row, 7).GetValue<string>();
						string EmailContent = worksheet.Cell(row, 8).GetValue<string>();
						string EmailContentAR = worksheet.Cell(row, 9).GetValue<string>();
						string Email = worksheet.Cell(row, 10).GetValue<string>();

						if (string.IsNullOrEmpty(CivilID) && string.IsNullOrEmpty(Serial))
							break;
						notificationrequestrecipientlist.Add(new _notificationrequestrecipientlistEntity()
						{
							recipientcivilid = CivilID,
							msgsubject = MessageSubject,
							msg = MessageBody,
							msgsubjectar = MessageSubjectAR,
							msgar = MessageBodyAR,
							recipientmobile = MobileNumber,
							messagebodyemail = EmailContent,
							messagebodyemailar = EmailContentAR,
							recipientemail = Email,
						});
						row++;
					}
				}
				
			}
			catch { }

			System.Diagnostics.Debug.WriteLine(notificationrequestrecipientlist);

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="email"></param>
		/// <param name="subject"></param>
		/// <param name="message"></param>
		/// <returns></returns>
		/// 
		public async Task Execute(string civilid, string subject, string message, string subjectAR, string messageAR)
		{
			try
			{
				string responseFinal = string.Empty;
				DigitalNoticationREsponseEntity responseObject = new DigitalNoticationREsponseEntity();
				var token = GetToken().Result;
				if (!string.IsNullOrEmpty(token))
				{
					using (var httpClient = new HttpClient())
					{
						using (var request = new HttpRequestMessage(new HttpMethod("GET"),
							_kAFPaciServiceSettings.WebApiAddress+"Tran_PaciSignInRequestInfo/SendMessageToDigitalIDUserGet?PersonCivilNo=" + civilid + "&NotificationSubjectEn=" + subject + "&NotificationSubjectAr=" + subjectAR + "&NotificationMessageEn=" + message + "&NotificationMessageAr=" + messageAR + "&MobileNumber="))
						{
							request.Headers.TryAddWithoutValidation("accept", "text/plain");
							request.Headers.TryAddWithoutValidation("Authorization", "bearer " + token);

							var response = await httpClient.SendAsync(request);
							var JsonStrm = response.Content.ReadAsStringAsync();
							if (JsonStrm != null)
								if (!string.IsNullOrEmpty(JsonStrm.Result))
								{
									responseFinal = JsonStrm.Result;
								}
						}
					}

					responseObject = JsonConvert.DeserializeObject<DigitalNoticationREsponseEntity>(responseFinal);

				}

			}
			catch (Exception ex)
			{
				string st = ex.Message;
			}
		}


		private async Task<string> GetToken()
		{
			string responseFinal = string.Empty;
			string token = string.Empty;
			try
			{
				using (var httpClient = new HttpClient())
				{
					using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://kafpaci.kuwaitarmy.gov.kw/api/Auth/login"))
					{
						request.Headers.TryAddWithoutValidation("accept", "text/plain");

						request.Content = new StringContent("{\n  \"userName\": \"mroyon@gmail.com\",\n  \"password\": \"121212\",\n  \"remoteIpAddress\": \"string\"\n}");
						request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

						var response = await httpClient.SendAsync(request);
						var JsonStrm = response.Content.ReadAsStringAsync();
						if (JsonStrm != null)
							if (!string.IsNullOrEmpty(JsonStrm.Result))
							{
								responseFinal = JsonStrm.Result;
							}
					}
				}
				dynamic dynamicApi = JsonConvert.DeserializeObject(responseFinal);
				token = dynamicApi.accessToken.token.ToString();
				return token;
			}
			catch (Exception ex)
			{
				string st = ex.Message;
				return st;
			}

		}
	}
}
