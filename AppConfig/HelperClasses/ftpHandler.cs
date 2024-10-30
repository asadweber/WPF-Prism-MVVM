using BDO.Core.DataAccessObjects.CommonEntities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace AppConfig.HelperClasses
{
    public class ftpHandler
    {
        #region IDisposable Members

        private bool isDisposed = false;

        ~ftpHandler()
        {
            Dispose(false);
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Code to dispose the managed resources of the class
            }
            // Code to dispose the un-managed resources of the class

            isDisposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public ftpHandler()
        {
        }
        #endregion

        /// <summary>
        /// CreateFTPDir
        /// </summary>
        /// <param name="pathToCreate"></param>
        /// <param name="ftpSettings"></param>
        /// <returns></returns>
        public bool CreateFTPDir(string pathToCreate, FtpSettingsOptions ftpSettings)
        {
            FtpWebRequest reqFTP = null;
            Stream ftpStream = null;

            string _Password = ftpSettings.pass;
            string _UserName = ftpSettings.user;
            string _ftpURL = ftpSettings.ftpAddress;
            string currentDir = "";
            try
            {
                currentDir = _ftpURL + pathToCreate;
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(currentDir);
                reqFTP.Method = WebRequestMethods.Ftp.MakeDirectory;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(_UserName, _Password);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                ftpStream = response.GetResponseStream();
                ftpStream.Close();
                response.Close();
                return true;
            }
            catch (WebException e)
            {
                String status = ((FtpWebResponse)e.Response).StatusDescription;
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;

        }


        /// <summary>
        /// DeleteFileFTP
        /// </summary>
        /// <param name="fileUploadDir"></param>
        /// <param name="FileNamePrefix"></param>
        /// <param name="fileExtension"></param>
        /// <param name="ftpSettings"></param>
        /// <returns></returns>
        public string DeleteFileFTP(string fileUploadDir, string FileNamePrefix, string fileExtension, FtpSettingsOptions ftpSettings)
        {
            string strMsg = string.Empty;
            string strmsg = string.Empty;

            string _Password = ftpSettings.pass;
            string _UserName = ftpSettings.user;
            string _ftpURL = ftpSettings.ftpAddress;

            try
            {
                if (!string.IsNullOrEmpty(_Password) && !string.IsNullOrEmpty(_UserName) && !string.IsNullOrEmpty(_ftpURL))
                {
                    if (!fileUploadDir.Contains("/"))
                        fileUploadDir = fileUploadDir + "/";
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_ftpURL + fileUploadDir + FileNamePrefix + fileExtension);
                    request.Method = WebRequestMethods.Ftp.DeleteFile;
                    request.Credentials = new NetworkCredential(_UserName, _Password);
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
            }
            catch (Exception ex)
            {
                strmsg = ex.Message;

            }
            return strMsg;
        }

        /// <summary>
        /// UploadFileFTP
        /// </summary>
        /// <param name="Myfile"></param>
        /// <param name="fileUploadDir"></param>
        /// <param name="FileNamePrefix"></param>
        /// <param name="fileExtension"></param>
        /// <param name="ftpSettings"></param>
        /// <returns></returns>
        public string UploadFileFTP(byte[] Myfile, string fileUploadDir, string FileNamePrefix, string fileExtension, FtpSettingsOptions ftpSettings)
        {
            string strMsg = string.Empty;
            string strmsg = string.Empty;


            string _Password = ftpSettings.pass;
            string _UserName = ftpSettings.user;
            string _ftpURL = ftpSettings.ftpAddress;

            try
            {
                if (!string.IsNullOrEmpty(_Password) && !string.IsNullOrEmpty(_UserName) && !string.IsNullOrEmpty(_ftpURL))
                {
                    FolderCheckFTP(fileUploadDir, ftpSettings);
                    if (!fileUploadDir.Contains("/"))
                        fileUploadDir = fileUploadDir + "/";

                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_ftpURL + fileUploadDir + (FileNamePrefix.Contains('.') == true ? FileNamePrefix : FileNamePrefix + fileExtension));
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    request.Credentials = new NetworkCredential(_UserName, _Password);
                    Stream ftpstream = request.GetRequestStream();
                    ftpstream.Write(Myfile, 0, Myfile.Length);
                    ftpstream.Close();

                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                    strmsg = response.StatusDescription;

                    response.Close();
                }
            }
            catch (Exception ex)
            {
                strmsg = ex.Message;

            }
            return strMsg;
        }


        /// <summary>
        /// FolderCheckFTP
        /// </summary>
        /// <param name="fileUploadDir"></param>
        /// <param name="ftpSettings"></param>
        public void FolderCheckFTP(string fileUploadDir, FtpSettingsOptions ftpSettings)
        {
            string strMsg = string.Empty;
            string strmsg = string.Empty;


            string _Password = ftpSettings.pass;
            string _UserName = ftpSettings.user;
            string _ftpURL = ftpSettings.ftpAddress;


            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_ftpURL + fileUploadDir);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.Credentials = new NetworkCredential(_UserName, _Password);
                using (FtpWebResponse res = (FtpWebResponse)request.GetResponse())
                {
                    // Okay. 
                }

            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    FtpWebResponse response = (FtpWebResponse)ex.Response;
                    if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                    {
                        AppConfig.HelperClasses.ftpHandler objFTP = new ftpHandler();
                        string mainfolder = fileUploadDir.Substring(0, 36);
                        string userfolderpath = mainfolder + "/";
                        objFTP.CreateFTPDir(userfolderpath, ftpSettings);
                    }
                }
            }
        }
    }
}
