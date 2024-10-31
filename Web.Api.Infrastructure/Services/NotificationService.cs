using AppConfig.HelperClasses;
using BDO.Core.DataAccessObjects.CommonEntities;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.DataAccessObjects.ExtendedEntities;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Security.Claims;
using System.Threading.Tasks;
using Web.Core.Frame.Interfaces.Services;
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

        internal NotificationService(IConfiguration config,
            IOptions<EmailSettings> optionsEmailSettings
            , IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
            _config = config;
            _optionsEmailSettings = optionsEmailSettings;
            _kAFPaciServiceSettings = _config.GetSection(nameof(KAFPaciServiceSettings)).Get<KAFPaciServiceSettings>();
        }

		public NotificationService()
		{
		}

		///// <summary>
		///// SendDigitalIDNotifcationAsync
		///// </summary>
		///// <param name="civilid"></param>
		///// <param name="subject"></param>
		///// <param name="message"></param>
		///// <param name="subjectAR"></param>
		///// <param name="messageAR"></param>
		///// <returns></returns>
		//public Task SendDigitalIDNotifcationAsync(string civilid, string subject, string message, string subjectAR, string messageAR)
		//{

		//	Execute(civilid, subject, message, subjectAR, messageAR).Wait();
		//	return Task.FromResult(0);
		//}

		/// <summary>
		/// SendBulkDigitalIDNotifcationAsync
		/// </summary>
		/// <param name="civilid"></param>
		/// <param name="subject"></param>
		/// <param name="message"></param>
		/// <param name="subjectAR"></param>
		/// <param name="messageAR"></param>
		/// <returns></returns>
		public async Task<string> SendBulkDigitalIDNotifcationAsync(byte[] fileByteContent, string file_guid)
		{
			//readExcel(filePath);
			var token = GetToken().Result;
			var bearerToken = token;
			var applicationId = "C4077E81-CD92-42E9-8811-B93A6578A4C7";
			var sendsms = true;
			var senddigitalidnotification = true;
			var sendemail = true;

			HttpResponseMessage response = null;
			//Guid file_guid = Guid.NewGuid();
			var fileGuid = file_guid;
			var msg = "";

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

                        MemoryStream ms = new MemoryStream(fileByteContent);
                        multipartContent.Add(new StreamContent(ms), "file", $"{fileGuid}.xlsx");

                        request.Content = multipartContent;
						response = await httpClient.SendAsync(request);
						if (response.IsSuccessStatusCode)
						{
							var contents = await response.Content.ReadAsStringAsync();
							dynamic _responsebody = Newtonsoft.Json.Linq.JObject.Parse(contents);
							msg = _responsebody._ajaxresponse.responsetext.ToString();

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
			return msg;
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

						request.Content = new StringContent("{\n  \"userName\": \"mroyon@gmail.com\",\n  \"password\": \"paci@dmin321\",\n  \"remoteIpAddress\": \"string\"\n}");
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
