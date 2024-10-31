using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_medexamnotification : _Common
    {
         private static IResourceProvider resourceProvider_tran_medexamnotification = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_medexamnotification.xml"));//DbResourceProvider(); //  
         
         
        public static string medexamnotificationList
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("medexamnotificationList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string medexamnotificationCreate
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("medexamnotificationCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string medexamnotificationUpdate
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("medexamnotificationUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string medexamnotificationDetails
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("medexamnotificationDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string batchid
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("batchid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchidRequired
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("batchidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string registrationid
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("registrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationidRequired
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("registrationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string applicantphaseid
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("applicantphaseid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicantphaseidRequired
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("applicantphaseidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string notificationtype
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("notificationtype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationtypeRequired
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("notificationtypeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string messagesubject
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("messagesubject", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string messagesubjectRequired
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("messagesubjectRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string messagebody
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("messagebody", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string messagebodyRequired
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("messagebodyRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string smsnotification
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("smsnotification", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string smsnotificationRequired
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("smsnotificationRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string pacinotification
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("pacinotification", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string pacinotificationRequired
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("pacinotificationRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string emailnotification
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("emailnotification", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emailnotificationRequired
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("emailnotificationRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string senddate
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("senddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string senddateRequired
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("senddateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string notificationstatus
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("notificationstatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationstatusRequired
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("notificationstatusRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fileid
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("fileid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileidRequired
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("fileidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fileuploadresult
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("fileuploadresult", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileuploadresultRequired
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("fileuploadresultRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_medexamnotification.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
