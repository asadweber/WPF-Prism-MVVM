using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _reg_hobbies : _Common
    {
         private static IResourceProvider resourceProvider_reg_hobbies = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_reg_hobbies.xml"));//DbResourceProvider(); //  
         
         
        public static string hobbiesList
        {
            get
            {
                return resourceProvider_reg_hobbies.GetResource("hobbiesList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hobbiesCreate
        {
            get
            {
                return resourceProvider_reg_hobbies.GetResource("hobbiesCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hobbiesUpdate
        {
            get
            {
                return resourceProvider_reg_hobbies.GetResource("hobbiesUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hobbiesDetails
        {
            get
            {
                return resourceProvider_reg_hobbies.GetResource("hobbiesDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_reg_hobbies.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_reg_hobbies.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hobbies
        {
            get
            {
                return resourceProvider_reg_hobbies.GetResource("hobbies", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hobbiesRequired
        {
            get
            {
                return resourceProvider_reg_hobbies.GetResource("hobbiesRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string details
        {
            get
            {
                return resourceProvider_reg_hobbies.GetResource("details", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_reg_hobbies.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_reg_hobbies.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_reg_hobbies.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_reg_hobbies.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
