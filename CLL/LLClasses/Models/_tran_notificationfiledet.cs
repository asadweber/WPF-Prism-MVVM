using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_notificationfiledet : _Common
    {
         private static IResourceProvider resourceProvider_tran_notificationfiledet = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_notificationfiledet.xml"));//DbResourceProvider(); //  
         
         
        public static string notificationfiledetList
        {
            get
            {
                return resourceProvider_tran_notificationfiledet.GetResource("notificationfiledetList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationfiledetCreate
        {
            get
            {
                return resourceProvider_tran_notificationfiledet.GetResource("notificationfiledetCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationfiledetUpdate
        {
            get
            {
                return resourceProvider_tran_notificationfiledet.GetResource("notificationfiledetUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationfiledetDetails
        {
            get
            {
                return resourceProvider_tran_notificationfiledet.GetResource("notificationfiledetDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string filerequestdetid
        {
            get
            {
                return resourceProvider_tran_notificationfiledet.GetResource("filerequestdetid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string filerequestdetidRequired
        {
            get
            {
                return resourceProvider_tran_notificationfiledet.GetResource("filerequestdetidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filerequestid
        {
            get
            {
                return resourceProvider_tran_notificationfiledet.GetResource("filerequestid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string filerequestidRequired
        {
            get
            {
                return resourceProvider_tran_notificationfiledet.GetResource("filerequestidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string recipientcivilid
        {
            get
            {
                return resourceProvider_tran_notificationfiledet.GetResource("recipientcivilid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string recipientmobile
        {
            get
            {
                return resourceProvider_tran_notificationfiledet.GetResource("recipientmobile", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string recipientemail
        {
            get
            {
                return resourceProvider_tran_notificationfiledet.GetResource("recipientemail", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_notificationfiledet.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_notificationfiledet.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
