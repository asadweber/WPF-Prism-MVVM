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
    public class PaciCivilIDInformationSender : IPaciCivilIDInformationSender
    {
        private readonly IConfiguration _config;
        private readonly IHttpClientHR _httpClientHR;

        internal PaciCivilIDInformationSender(IConfiguration config,
            IHttpClientHR httpClientHR)
        {
            _config = config;
            _httpClientHR = httpClientHR;
        }

        /// <summary>
        /// GetPACICivilIDInformationAsync
        /// </summary>
        /// <param name="email"></param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task<Payload> GetPACICivilIDInformationAsync(EmailEntity emailobject)
        {
            Payload response = new Payload();
            try
            {
                response = await _httpClientHR.GetPACICivilIDInformation(emailobject);
            }
            catch (Exception ex)
            {
                string st = ex.Message;
            }
            return response;
        }

      
      
    }
}
