using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_instituteinfo : _Common
    {
         private static IResourceProvider resourceProvider_gen_instituteinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_instituteinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string instituteinfoList
        {
            get
            {
                return resourceProvider_gen_instituteinfo.GetResource("instituteinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string instituteinfoCreate
        {
            get
            {
                return resourceProvider_gen_instituteinfo.GetResource("instituteinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string instituteinfoUpdate
        {
            get
            {
                return resourceProvider_gen_instituteinfo.GetResource("instituteinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string instituteinfoDetails
        {
            get
            {
                return resourceProvider_gen_instituteinfo.GetResource("instituteinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string ispublic
        {
            get
            {
                return resourceProvider_gen_instituteinfo.GetResource("ispublic", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string institutename
        {
            get
            {
                return resourceProvider_gen_instituteinfo.GetResource("institutename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string institutenameRequired
        {
            get
            {
                return resourceProvider_gen_instituteinfo.GetResource("institutenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string countryid
        {
            get
            {
                return resourceProvider_gen_instituteinfo.GetResource("countryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string countryidRequired
        {
            get
            {
                return resourceProvider_gen_instituteinfo.GetResource("countryidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_instituteinfo.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_instituteinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_instituteinfo.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_instituteinfo.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_instituteinfo.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
