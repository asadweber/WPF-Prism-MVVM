using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_syexamnotification : _Common
    {
         private static IResourceProvider resourceProvider_tran_syexamnotification = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_syexamnotification.xml"));//DbResourceProvider(); //  
         
         
        public static string syexamnotificationList
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("syexamnotificationList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string syexamnotificationCreate
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("syexamnotificationCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string syexamnotificationUpdate
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("syexamnotificationUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string syexamnotificationDetails
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("syexamnotificationDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string batchid
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("batchid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchidRequired
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("batchidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string registrationid
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("registrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationidRequired
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("registrationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string applicantphaseid
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("applicantphaseid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicantphaseidRequired
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("applicantphaseidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string messagesubject
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("messagesubject", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string messagesubjectRequired
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("messagesubjectRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string messagebody
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("messagebody", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string messagebodyRequired
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("messagebodyRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string smsnotification
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("smsnotification", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string smsnotificationRequired
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("smsnotificationRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string pacinotification
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("pacinotification", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string pacinotificationRequired
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("pacinotificationRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string emailnotification
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("emailnotification", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emailnotificationRequired
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("emailnotificationRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string senddate
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("senddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string senddateRequired
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("senddateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string notificationstatus
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("notificationstatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationstatusRequired
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("notificationstatusRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fileid
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("fileid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileidRequired
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("fileidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fileuploadresult
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("fileuploadresult", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileuploadresultRequired
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("fileuploadresultRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_syexamnotification.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
