using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_languages : _Common
    {
         private static IResourceProvider resourceProvider_gen_languages = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_languages.xml"));//DbResourceProvider(); //  
         
         
        public static string languagesList
        {
            get
            {
                return resourceProvider_gen_languages.GetResource("languagesList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string languagesCreate
        {
            get
            {
                return resourceProvider_gen_languages.GetResource("languagesCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string languagesUpdate
        {
            get
            {
                return resourceProvider_gen_languages.GetResource("languagesUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string languagesDetails
        {
            get
            {
                return resourceProvider_gen_languages.GetResource("languagesDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string languagename
        {
            get
            {
                return resourceProvider_gen_languages.GetResource("languagename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string languagenameRequired
        {
            get
            {
                return resourceProvider_gen_languages.GetResource("languagenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_languages.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_languages.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_languages.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_languages.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_languages.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
