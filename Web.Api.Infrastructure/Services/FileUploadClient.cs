using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Net;
using Web.Core.Frame.Interfaces.Services;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

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
                FtpWebRequest requestDir = (FtpWebRequest)WebRequest.Create(ftpServerSetting.uploadftpurl + fileUploadDir);
                requestDir.Method = WebRequestMethods.Ftp.MakeDirectory;
                if (ftpServerSetting.IsSSL)
                {
                    requestDir.EnableSsl = true;
                }


                requestDir.Credentials = new NetworkCredential(ftpServerSetting.ftpuser, ftpServerSetting.ftpuserpassword);
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
        }

        public string UploadFileFTP(byte[] Myfile, string fileUploadDir, string FileNamePrefix, string fileExtension)
        {
            string strMsg = string.Empty;
            try
            {

                FolderCheckFTP(fileUploadDir);
                if (!fileUploadDir.Substring(fileUploadDir.Length - 1).Contains("/"))
                    fileUploadDir = fileUploadDir + "/";



                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpServerSetting.uploadftpurl + fileUploadDir + FileNamePrefix + fileExtension);
                request.Method = WebRequestMethods.Ftp.UploadFile;
            
                if (ftpServerSetting.IsSSL)
                {
                    request.EnableSsl = true;
                }

                request.Credentials = new NetworkCredential(ftpServerSetting.ftpuser, ftpServerSetting.ftpuserpassword);
                Stream ftpstream = request.GetRequestStream();
                ftpstream.Write(Myfile, 0, Myfile.Length);
                ftpstream.Close();

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                strMsg = request.RequestUri.AbsoluteUri.Replace(ftpServerSetting.uploadftpurl, "");

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

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpServerSetting.uploadftpurl + fileUploadDir + FileNamePrefix + fileExtension);
                request.Method = WebRequestMethods.Ftp.DeleteFile;
                if (ftpServerSetting.IsSSL)
                {
                    request.EnableSsl = true;
                }
                request.Credentials = new NetworkCredential(ftpServerSetting.ftpuser, ftpServerSetting.ftpuserpassword);
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
        public string ReadFileFTP(string fileUploadDir, string FileNamePrefix, string fileExtension)
        {
            string fileContentBase64 = string.Empty;
			try
            {
                if (!fileUploadDir.Substring(fileUploadDir.Length - 1).Contains("/"))
                    fileUploadDir = fileUploadDir + "/";

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpServerSetting.uploadftpurl + fileUploadDir + FileNamePrefix + fileExtension);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                
                if (ftpServerSetting.IsSSL)
                {
                    request.EnableSsl = true;
                }

                request.Credentials = new NetworkCredential(ftpServerSetting.ftpuser, ftpServerSetting.ftpuserpassword);
                request.Proxy = null;
                request.UseBinary = false;
                request.UsePassive = true;
                request.KeepAlive = false;
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
				using (Stream responseStream = response.GetResponseStream())
				{
					// Read the file content and convert it to Base64
					using (MemoryStream ms = new MemoryStream())
					{
						byte[] buffer = new byte[1024];
						int bytesRead;

						while ((bytesRead = responseStream.Read(buffer, 0, buffer.Length)) > 0)
						{
							ms.Write(buffer, 0, bytesRead);
						}

						// Convert the file content to Base64 string
						fileContentBase64 = Convert.ToBase64String(ms.ToArray());
					}
				}

			}
            catch (Exception ex)
            {
				fileContentBase64 = "";

            }
			return fileContentBase64;

		}
        public string ReadFileFTPPath(string filepath)
        {
			string Retfilepath= $"{ftpServerSetting.readfileurl}{filepath}";
			return Retfilepath;

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
                request.Credentials = new NetworkCredential(ftpServerSetting.ftpuser, ftpServerSetting.ftpuserpassword);
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
