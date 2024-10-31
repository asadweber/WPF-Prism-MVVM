using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_status : _Common
    {
         private static IResourceProvider resourceProvider_gen_status = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_status.xml"));//DbResourceProvider(); //  
         
         
        public static string statusList
        {
            get
            {
                return resourceProvider_gen_status.GetResource("statusList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusCreate
        {
            get
            {
                return resourceProvider_gen_status.GetResource("statusCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusUpdate
        {
            get
            {
                return resourceProvider_gen_status.GetResource("statusUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusDetails
        {
            get
            {
                return resourceProvider_gen_status.GetResource("statusDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string statusname
        {
            get
            {
                return resourceProvider_gen_status.GetResource("statusname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusnameRequired
        {
            get
            {
                return resourceProvider_gen_status.GetResource("statusnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string status
        {
            get
            {
                return resourceProvider_gen_status.GetResource("status", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusRequired
        {
            get
            {
                return resourceProvider_gen_status.GetResource("statusRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_status.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_status.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_status.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_status.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_status.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
