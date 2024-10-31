using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_educationgrade : _Common
    {
         private static IResourceProvider resourceProvider_gen_educationgrade = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_educationgrade.xml"));//DbResourceProvider(); //  
         
         
        public static string educationgradeList
        {
            get
            {
                return resourceProvider_gen_educationgrade.GetResource("educationgradeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string educationgradeCreate
        {
            get
            {
                return resourceProvider_gen_educationgrade.GetResource("educationgradeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string educationgradeUpdate
        {
            get
            {
                return resourceProvider_gen_educationgrade.GetResource("educationgradeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string educationgradeDetails
        {
            get
            {
                return resourceProvider_gen_educationgrade.GetResource("educationgradeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string edugradename
        {
            get
            {
                return resourceProvider_gen_educationgrade.GetResource("edugradename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string edugradenameRequired
        {
            get
            {
                return resourceProvider_gen_educationgrade.GetResource("edugradenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string marksfrom
        {
            get
            {
                return resourceProvider_gen_educationgrade.GetResource("marksfrom", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string marksto
        {
            get
            {
                return resourceProvider_gen_educationgrade.GetResource("marksto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_educationgrade.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_educationgrade.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_educationgrade.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_educationgrade.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_educationgrade.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
