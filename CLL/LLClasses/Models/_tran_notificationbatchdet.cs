using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_notificationbatchdet : _Common
    {
         private static IResourceProvider resourceProvider_tran_notificationbatchdet = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_notificationbatchdet.xml"));//DbResourceProvider(); //  
         
         
        public static string notificationbatchdetList
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("notificationbatchdetList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationbatchdetCreate
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("notificationbatchdetCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationbatchdetUpdate
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("notificationbatchdetUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationbatchdetDetails
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("notificationbatchdetDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string notificationbatchid
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("notificationbatchid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationbatchidRequired
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("notificationbatchidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string parentnotificationbatchdetid
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("parentnotificationbatchdetid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string userid
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("userid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string useridRequired
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("useridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string masteruserid
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("masteruserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string masteruseridRequired
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("masteruseridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string registrationid
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("registrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationidRequired
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("registrationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string applicantphaseid
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("applicantphaseid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicantphaseidRequired
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("applicantphaseidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string notificationtypeid
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("notificationtypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationtypeidRequired
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("notificationtypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string notificationtemplateid
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("notificationtemplateid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationtemplateidRequired
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("notificationtemplateidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string sentto
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("sentto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string sentmsg
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("sentmsg", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string senddate
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("senddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string sendresponse
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("sendresponse", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string sendstatus
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("sendstatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isabsent
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("isabsent", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_notificationbatchdet.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
