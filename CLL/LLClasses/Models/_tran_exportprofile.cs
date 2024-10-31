using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_exportprofile : _Common
    {
         private static IResourceProvider resourceProvider_tran_exportprofile = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_exportprofile.xml"));//DbResourceProvider(); //  
         
         
        public static string exportprofileList
        {
            get
            {
                return resourceProvider_tran_exportprofile.GetResource("exportprofileList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string exportprofileCreate
        {
            get
            {
                return resourceProvider_tran_exportprofile.GetResource("exportprofileCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string exportprofileUpdate
        {
            get
            {
                return resourceProvider_tran_exportprofile.GetResource("exportprofileUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string exportprofileDetails
        {
            get
            {
                return resourceProvider_tran_exportprofile.GetResource("exportprofileDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string registrationid
        {
            get
            {
                return resourceProvider_tran_exportprofile.GetResource("registrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationidRequired
        {
            get
            {
                return resourceProvider_tran_exportprofile.GetResource("registrationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_tran_exportprofile.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_tran_exportprofile.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string batchid
        {
            get
            {
                return resourceProvider_tran_exportprofile.GetResource("batchid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchidRequired
        {
            get
            {
                return resourceProvider_tran_exportprofile.GetResource("batchidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string exporteddate
        {
            get
            {
                return resourceProvider_tran_exportprofile.GetResource("exporteddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string exporteddateRequired
        {
            get
            {
                return resourceProvider_tran_exportprofile.GetResource("exporteddateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_tran_exportprofile.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_exportprofile.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_exportprofile.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
