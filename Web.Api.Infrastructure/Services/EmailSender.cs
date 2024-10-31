using BDO.Core.DataAccessObjects.CommonEntities;
using BDO.DataAccessObjects.ExtendedEntities;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading.Tasks;
using Web.Core.Frame.Interfaces.Services;

namespace Web.Api.Infrastructure.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration _config;
        private readonly EmailSettings _mailsettings;

        internal EmailSender(IConfiguration config)
        {
            _config = config;
            _mailsettings = config.GetSection(nameof(EmailSettings)).Get<EmailSettings>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Task SendEmailAsync(EmailEntity emailobject)
        {

            Execute(emailobject).Wait();
            return Task.FromResult(0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task Execute(EmailEntity emailobject)
        {
            bool isMailSent = false;
            try
            {
                MailMessage mail = new MailMessage()
                {
                    From = new MailAddress(_mailsettings.FromEmail, _mailsettings.FromEmail)
                };

                mail.To.Add(new MailAddress(emailobject.toEmail));

                if (emailobject.attachments != null)
                {
                    foreach (EmailAttachmentsEntity singleFile in emailobject.attachments)
                    {
                        var bytes = Convert.FromBase64String(singleFile.filesBase64);
                        MemoryStream strm = new MemoryStream(bytes);
                        Attachment data = new Attachment(strm, singleFile.filename);
                        ContentDisposition disposition = data.ContentDisposition;
                        data.ContentId = singleFile.filename;
                        data.ContentDisposition.Inline = true;
                        mail.Attachments.Add(data);
                    }
                }

                mail.Subject = emailobject.subject;
                mail.Body = emailobject.message;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;
                using (SmtpClient smtp = new SmtpClient(_mailsettings.PrimaryDomain, _mailsettings.PrimaryPort))
                {
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(_mailsettings.UsernameEmail, _mailsettings.UsernamePassword);
                    smtp.EnableSsl = _mailsettings.IsSSL;
                    await smtp.SendMailAsync(mail);
                    isMailSent = true;
                }
                mail.Dispose();


                //keep a copy
                MailMessage mailcopy = new MailMessage()
                {
                    From = new MailAddress(_mailsettings.FromEmail, _mailsettings.FromEmail)
                };


                if (emailobject.subject == "تظلمات الصفوف الامامية")
                {
                    mailcopy.To.Add(new MailAddress("flg@kuwaitarmy.gov.kw"));
                    mailcopy.CC.Add(new MailAddress(_mailsettings.FromEmail));

                    // mailcopy.To.Add(new MailAddress("mahmud@kuwaitarmy.gov.kw"));
                }
                else
                {
                    mailcopy.To.Add(new MailAddress(_mailsettings.FromEmail));
                    //mailcopy.To.Add(new MailAddress("mahmud@kuwaitarmy.gov.kw"));
                }

                if (emailobject.attachments != null)
                {
                    foreach (EmailAttachmentsEntity objSingleFile in emailobject.attachments)
                    {
                        var bytes = Convert.FromBase64String(objSingleFile.filesBase64);
                        MemoryStream strm = new MemoryStream(bytes);
                        Attachment data = new Attachment(strm, objSingleFile.filename);
                        ContentDisposition disposition = data.ContentDisposition;
                        data.ContentId = objSingleFile.filename;
                        data.ContentDisposition.Inline = true;
                        mailcopy.Attachments.Add(data);
                    }
                }
                mailcopy.Subject = "البريد من: " + emailobject.toEmail + " -- " + emailobject.subject;
                mailcopy.Body = emailobject.message;
                mailcopy.IsBodyHtml = true;
                mailcopy.Priority = MailPriority.High;
                using (SmtpClient smtp = new SmtpClient(_mailsettings.PrimaryDomain, _mailsettings.PrimaryPort))
                {
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(_mailsettings.UsernameEmail, _mailsettings.UsernamePassword);
                    smtp.EnableSsl = _mailsettings.IsSSL;
                    await smtp.SendMailAsync(mailcopy);
                    isMailSent = true;
                }

                mailcopy.Dispose();

            }
            catch (Exception ex)
            {
                string st = ex.Message;
            }
        }
    }
}
