using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_professiongroup : _Common
    {
         private static IResourceProvider resourceProvider_gen_professiongroup = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_professiongroup.xml"));//DbResourceProvider(); //  
         
         
        public static string professiongroupList
        {
            get
            {
                return resourceProvider_gen_professiongroup.GetResource("professiongroupList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string professiongroupCreate
        {
            get
            {
                return resourceProvider_gen_professiongroup.GetResource("professiongroupCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string professiongroupUpdate
        {
            get
            {
                return resourceProvider_gen_professiongroup.GetResource("professiongroupUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string professiongroupDetails
        {
            get
            {
                return resourceProvider_gen_professiongroup.GetResource("professiongroupDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string professiongroupname
        {
            get
            {
                return resourceProvider_gen_professiongroup.GetResource("professiongroupname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string professiongroupnameRequired
        {
            get
            {
                return resourceProvider_gen_professiongroup.GetResource("professiongroupnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_professiongroup.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_professiongroup.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_professiongroup.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_professiongroup.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_professiongroup.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
