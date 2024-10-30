using BDO.Core.DataAccessObjects.CommonEntities;
using Microsoft.Extensions.Options;
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
    public class EmailSender : IEmailSender
    {
        private readonly IOptions<EmailSettings> _optionsEmailSettings;
        internal EmailSender(
            IOptions<EmailSettings> optionsEmailSettings)
        {
            _optionsEmailSettings = optionsEmailSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Task SendEmailAsync(string email, string subject, string message)
        {

            Execute(email, subject, message).Wait();
            return Task.FromResult(0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task Execute(string email, string subject, string message)
        {
            try
            {
                MailMessage mail = new MailMessage()
                {
                    From = new MailAddress(_optionsEmailSettings.Value.UsernameEmail, _optionsEmailSettings.Value.FromEmail)
                };
                mail.To.Add(new MailAddress(email));

                if (_optionsEmailSettings.Value.CcEmail != "ccEmail")
                    mail.CC.Add(new MailAddress(_optionsEmailSettings.Value.CcEmail));

                mail.Subject = subject;
                mail.Body = message;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;

                using (SmtpClient smtp = new SmtpClient(_optionsEmailSettings.Value.SecondayDomain, _optionsEmailSettings.Value.SecondaryPort))
                {
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(_optionsEmailSettings.Value.UsernameEmail, _optionsEmailSettings.Value.UsernamePassword);
                    smtp.EnableSsl = _optionsEmailSettings.Value.IsSSL;
                    await smtp.SendMailAsync(mail);
                }
            }
            catch (Exception ex)
            {
                string st = ex.Message;
            }
        }
    }
}
