using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _reg_language : _Common
    {
         private static IResourceProvider resourceProvider_reg_language = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_reg_language.xml"));//DbResourceProvider(); //  
         
         
        public static string languageList
        {
            get
            {
                return resourceProvider_reg_language.GetResource("languageList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string languageCreate
        {
            get
            {
                return resourceProvider_reg_language.GetResource("languageCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string languageUpdate
        {
            get
            {
                return resourceProvider_reg_language.GetResource("languageUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string languageDetails
        {
            get
            {
                return resourceProvider_reg_language.GetResource("languageDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_reg_language.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_reg_language.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string languageid
        {
            get
            {
                return resourceProvider_reg_language.GetResource("languageid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string languageidRequired
        {
            get
            {
                return resourceProvider_reg_language.GetResource("languageidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string speakingskillproficiencyid
        {
            get
            {
                return resourceProvider_reg_language.GetResource("speakingskillproficiencyid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string speakingskillproficiencyidRequired
        {
            get
            {
                return resourceProvider_reg_language.GetResource("speakingskillproficiencyidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string readingskillproficiencyid
        {
            get
            {
                return resourceProvider_reg_language.GetResource("readingskillproficiencyid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string readingskillproficiencyidRequired
        {
            get
            {
                return resourceProvider_reg_language.GetResource("readingskillproficiencyidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string writingskillproficiencyid
        {
            get
            {
                return resourceProvider_reg_language.GetResource("writingskillproficiencyid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string writingskillproficiencyidRequired
        {
            get
            {
                return resourceProvider_reg_language.GetResource("writingskillproficiencyidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_reg_language.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_reg_language.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_reg_language.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_reg_language.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
