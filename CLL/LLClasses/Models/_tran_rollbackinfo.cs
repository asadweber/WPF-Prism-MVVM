using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_rollbackinfo : _Common
    {
         private static IResourceProvider resourceProvider_tran_rollbackinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_rollbackinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string rollbackinfoList
        {
            get
            {
                return resourceProvider_tran_rollbackinfo.GetResource("rollbackinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string rollbackinfoCreate
        {
            get
            {
                return resourceProvider_tran_rollbackinfo.GetResource("rollbackinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string rollbackinfoUpdate
        {
            get
            {
                return resourceProvider_tran_rollbackinfo.GetResource("rollbackinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string rollbackinfoDetails
        {
            get
            {
                return resourceProvider_tran_rollbackinfo.GetResource("rollbackinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_tran_rollbackinfo.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_tran_rollbackinfo.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string registrationid
        {
            get
            {
                return resourceProvider_tran_rollbackinfo.GetResource("registrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationidRequired
        {
            get
            {
                return resourceProvider_tran_rollbackinfo.GetResource("registrationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string type
        {
            get
            {
                return resourceProvider_tran_rollbackinfo.GetResource("type", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string typeRequired
        {
            get
            {
                return resourceProvider_tran_rollbackinfo.GetResource("typeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string trandate
        {
            get
            {
                return resourceProvider_tran_rollbackinfo.GetResource("trandate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string trandateRequired
        {
            get
            {
                return resourceProvider_tran_rollbackinfo.GetResource("trandateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_tran_rollbackinfo.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_tran_rollbackinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_rollbackinfo.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_rollbackinfo.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
