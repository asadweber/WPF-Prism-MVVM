using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_gender : _Common
    {
         private static IResourceProvider resourceProvider_gen_gender = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_gender.xml"));//DbResourceProvider(); //  
         
         
        public static string genderList
        {
            get
            {
                return resourceProvider_gen_gender.GetResource("genderList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string genderCreate
        {
            get
            {
                return resourceProvider_gen_gender.GetResource("genderCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string genderUpdate
        {
            get
            {
                return resourceProvider_gen_gender.GetResource("genderUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string genderDetails
        {
            get
            {
                return resourceProvider_gen_gender.GetResource("genderDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string gender
        {
            get
            {
                return resourceProvider_gen_gender.GetResource("gender", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string genderRequired
        {
            get
            {
                return resourceProvider_gen_gender.GetResource("genderRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string gendereng
        {
            get
            {
                return resourceProvider_gen_gender.GetResource("gendereng", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string priority
        {
            get
            {
                return resourceProvider_gen_gender.GetResource("priority", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_gender.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_gender.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_gender.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
