using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_countryclass : _Common
    {
         private static IResourceProvider resourceProvider_gen_countryclass = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_countryclass.xml"));//DbResourceProvider(); //  
         
         
        public static string countryclassList
        {
            get
            {
                return resourceProvider_gen_countryclass.GetResource("countryclassList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string countryclassCreate
        {
            get
            {
                return resourceProvider_gen_countryclass.GetResource("countryclassCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string countryclassUpdate
        {
            get
            {
                return resourceProvider_gen_countryclass.GetResource("countryclassUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string countryclassDetails
        {
            get
            {
                return resourceProvider_gen_countryclass.GetResource("countryclassDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string countryid
        {
            get
            {
                return resourceProvider_gen_countryclass.GetResource("countryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string countryidRequired
        {
            get
            {
                return resourceProvider_gen_countryclass.GetResource("countryidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string classname
        {
            get
            {
                return resourceProvider_gen_countryclass.GetResource("classname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string classnameRequired
        {
            get
            {
                return resourceProvider_gen_countryclass.GetResource("classnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string classhierarchy
        {
            get
            {
                return resourceProvider_gen_countryclass.GetResource("classhierarchy", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string classhierarchyRequired
        {
            get
            {
                return resourceProvider_gen_countryclass.GetResource("classhierarchyRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_countryclass.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_countryclass.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_countryclass.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_countryclass.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_countryclass.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
