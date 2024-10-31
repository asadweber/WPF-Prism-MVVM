using BDO.Core.DataAccessObjects.CommonEntities;
using BDO.DataAccessObjects.ExtendedEntities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Web.Core.Frame.Interfaces.Services;

namespace Web.Api.Infrastructure.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class DigitalNotificationSender : IDigitalNotificationSender
    {
        private readonly IConfiguration _config;
        private readonly IHttpClientHR _httpClientHR;

        internal DigitalNotificationSender(IConfiguration config,
            IHttpClientHR httpClientHR)
        {
            _config = config;
            _httpClientHR = httpClientHR;
        }
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task<string> SendDigitalNotificationAsync(EmailEntity emailobject)
        {
            string response = string.Empty;
            try
            {
                response = await _httpClientHR.SendPACINotification(emailobject);
            }
            catch (Exception ex)
            {
                string st = ex.Message;
            }
            return response;
        }

      
      
    }
}
