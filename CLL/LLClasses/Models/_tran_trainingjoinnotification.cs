using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _tran_trainingjoinnotification : _Common
    {
        private static IResourceProvider resourceProvider_tran_trainingjoinnotification = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_trainingjoinnotification.xml"));//DbResourceProvider(); //  


        public static string trainingjoinnotificationList
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("trainingjoinnotificationList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string trainingjoinnotificationCreate
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("trainingjoinnotificationCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string trainingjoinnotificationUpdate
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("trainingjoinnotificationUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string trainingjoinnotificationDetails
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("trainingjoinnotificationDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string batchid
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("batchid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchidRequired
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("batchidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoid
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationid
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("registrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationidRequired
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("registrationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicantphaseid
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("applicantphaseid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicantphaseidRequired
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("applicantphaseidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationtype
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("notificationtype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationtypeRequired
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("notificationtypeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string messagesubject
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("messagesubject", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string messagesubjectRequired
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("messagesubjectRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string messagebody
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("messagebody", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string messagebodyRequired
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("messagebodyRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string smsnotification
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("smsnotification", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string smsnotificationRequired
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("smsnotificationRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string pacinotification
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("pacinotification", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string pacinotificationRequired
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("pacinotificationRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emailnotification
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("emailnotification", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emailnotificationRequired
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("emailnotificationRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string senddate
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("senddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string senddateRequired
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("senddateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationstatus
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("notificationstatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationstatusRequired
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("notificationstatusRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileid
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("fileid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileidRequired
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("fileidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileuploadresult
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("fileuploadresult", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileuploadresultRequired
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("fileuploadresultRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string comment
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string remarks
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_trainingjoinnotification.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


    }
}
