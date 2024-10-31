using CLL.Abstract;
using CLL.LLClasses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace CLL.LLClasses.Models
{
    public class _tran_finalexamnotification : _Common
    {
        private static IResourceProvider resourceProvider_tran_finalexamnotification = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_finalexamnotification.xml"));//DbResourceProvider(); //  


        public static string finalexamnotificationList
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("finalexamnotificationList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string finalexamnotificationCreate
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("finalexamnotificationCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string finalexamnotificationUpdate
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("finalexamnotificationUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string finalexamnotificationDetails
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("finalexamnotificationDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string batchid
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("batchid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchidRequired
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("batchidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoid
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationid
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("registrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationidRequired
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("registrationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicantphaseid
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("applicantphaseid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicantphaseidRequired
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("applicantphaseidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationtype
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("notificationtype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationtypeRequired
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("notificationtypeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string messagesubject
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("messagesubject", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string messagesubjectRequired
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("messagesubjectRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string messagebody
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("messagebody", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string messagebodyRequired
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("messagebodyRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string smsnotification
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("smsnotification", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string smsnotificationRequired
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("smsnotificationRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string pacinotification
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("pacinotification", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string pacinotificationRequired
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("pacinotificationRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emailnotification
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("emailnotification", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emailnotificationRequired
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("emailnotificationRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string senddate
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("senddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string senddateRequired
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("senddateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationstatus
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("notificationstatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationstatusRequired
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("notificationstatusRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileid
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("fileid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileidRequired
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("fileidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileuploadresult
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("fileuploadresult", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileuploadresultRequired
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("fileuploadresultRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string comment
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string remarks
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_finalexamnotification.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


    }
}

