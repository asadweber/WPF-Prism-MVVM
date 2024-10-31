using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_maritalstatus : _Common
    {
         private static IResourceProvider resourceProvider_gen_maritalstatus = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_maritalstatus.xml"));//DbResourceProvider(); //  
         
         
        public static string maritalstatusList
        {
            get
            {
                return resourceProvider_gen_maritalstatus.GetResource("maritalstatusList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string maritalstatusCreate
        {
            get
            {
                return resourceProvider_gen_maritalstatus.GetResource("maritalstatusCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string maritalstatusUpdate
        {
            get
            {
                return resourceProvider_gen_maritalstatus.GetResource("maritalstatusUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string maritalstatusDetails
        {
            get
            {
                return resourceProvider_gen_maritalstatus.GetResource("maritalstatusDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string maritalstatus
        {
            get
            {
                return resourceProvider_gen_maritalstatus.GetResource("maritalstatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string maritalstatusRequired
        {
            get
            {
                return resourceProvider_gen_maritalstatus.GetResource("maritalstatusRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ismarried
        {
            get
            {
                return resourceProvider_gen_maritalstatus.GetResource("ismarried", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_maritalstatus.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_maritalstatus.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_maritalstatus.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_maritalstatus.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_maritalstatus.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
