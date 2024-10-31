using BDO.Core.DataAccessObjects.ExtendedEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Frame.Interfaces.Services;
using Web.Core.Frame.UseCases;

namespace Web.Api.Infrastructure.Services
{
    public class FileUploadClient : IFileUploadClient
    {
        private readonly IHttpContextAccessor _contextAccessor;

        private readonly ILogger<FileUploadClient> _logger;
        private readonly FtpServerSetting ftpServerSetting;
        internal FileUploadClient(
            IHttpContextAccessor contextAccessor,ILoggerFactory loggerFactory, IOptions<FtpServerSetting> ftpServerSetting
            )
        {
            _logger = loggerFactory.CreateLogger<FileUploadClient>();
            this.ftpServerSetting = ftpServerSetting.Value;
            _contextAccessor = contextAccessor;
        }

        public bool FolderCheckFTP(string fileUploadDir)
        {
            try
            {
                FtpWebRequest requestDir = (FtpWebRequest)WebRequest.Create(ftpServerSetting.UploadFtpUrl + fileUploadDir);
                requestDir.Method = WebRequestMethods.Ftp.MakeDirectory;

                if (ftpServerSetting.IsSSL)
                {
                    requestDir.EnableSsl = true;
                }

                requestDir.Credentials = new NetworkCredential(ftpServerSetting.FtpUser, ftpServerSetting.FtpUserPassword);
                requestDir.UsePassive = true;
                requestDir.UseBinary = true;
                requestDir.KeepAlive = false;
                FtpWebResponse response = (FtpWebResponse)requestDir.GetResponse();
                Stream ftpStream = response.GetResponseStream();

                ftpStream.Close();
                response.Close();

                return true;

            }
            catch (WebException ex)
            {
                FtpWebResponse response = (FtpWebResponse)ex.Response;
                if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                {
                    response.Close();
                    return true;
                }
                else
                {
                    response.Close();
                    return false;
                }
            }
            return false;
        }

        public string UploadFileFTP(byte[] Myfile, string fileUploadDir, string FileNamePrefix, string fileExtension)
        {
            string strMsg = string.Empty;
            try
            {

                FolderCheckFTP(fileUploadDir);
                if (!fileUploadDir.Substring(fileUploadDir.Length - 1).Contains("/"))
                    fileUploadDir = fileUploadDir + "/";



                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpServerSetting.UploadFtpUrl + fileUploadDir + FileNamePrefix + fileExtension);
                request.Method = WebRequestMethods.Ftp.UploadFile;

                if (ftpServerSetting.IsSSL)
                {
                    request.EnableSsl = true;
                }


                request.Credentials = new NetworkCredential(ftpServerSetting.FtpUser, ftpServerSetting.FtpUserPassword);
                Stream ftpstream = request.GetRequestStream();
                ftpstream.Write(Myfile, 0, Myfile.Length);
                ftpstream.Close();

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                strMsg = request.RequestUri.AbsoluteUri.Replace(ftpServerSetting.UploadFtpUrl, "");

                response.Close();

            }
            catch (Exception ex)
            {
                strMsg = "";

            }
            return strMsg;
        }

        public string DeleteFileFTP(string fileUploadDir, string FileNamePrefix, string fileExtension)
        {
            string strMsg = string.Empty;
            

            try
            {
                if (!fileUploadDir.Substring(fileUploadDir.Length - 1).Contains("/"))
                    fileUploadDir = fileUploadDir + "/";

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpServerSetting.UploadFtpUrl + fileUploadDir + FileNamePrefix + fileExtension);
                request.Method = WebRequestMethods.Ftp.DeleteFile;


                if (ftpServerSetting.IsSSL)
                {
                    request.EnableSsl = true;
                }

                request.Credentials = new NetworkCredential(ftpServerSetting.FtpUser, ftpServerSetting.FtpUserPassword);
                request.Proxy = null;
                request.UseBinary = false;
                request.UsePassive = true;
                request.KeepAlive = false;
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader sr = new StreamReader(responseStream);
                sr.ReadToEnd();
                string StatusCode = response.StatusDescription;
                sr.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                strMsg = "";

            }
            return strMsg;
        }

        public string DeleteFileFTP(string fileUrl)
        {
            string strMsg = string.Empty;


            try
            {
               

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(fileUrl);
                request.Method = WebRequestMethods.Ftp.DeleteFile;


                if (ftpServerSetting.IsSSL)
                {
                    request.EnableSsl = true;
                }

                request.Credentials = new NetworkCredential(ftpServerSetting.FtpUser, ftpServerSetting.FtpUserPassword);
                request.Proxy = null;
                request.UseBinary = false;
                request.UsePassive = true;
                request.KeepAlive = false;
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader sr = new StreamReader(responseStream);
                sr.ReadToEnd();
                string StatusCode = response.StatusDescription;
                sr.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                strMsg = "";

            }
            return strMsg;
        }
    }
}
