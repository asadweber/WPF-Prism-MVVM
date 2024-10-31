using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_country : _Common
    {
         private static IResourceProvider resourceProvider_gen_country = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_country.xml"));//DbResourceProvider(); //  
         
         
        public static string countryList
        {
            get
            {
                return resourceProvider_gen_country.GetResource("countryList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string countryCreate
        {
            get
            {
                return resourceProvider_gen_country.GetResource("countryCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string countryUpdate
        {
            get
            {
                return resourceProvider_gen_country.GetResource("countryUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string countryDetails
        {
            get
            {
                return resourceProvider_gen_country.GetResource("countryDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string countryname
        {
            get
            {
                return resourceProvider_gen_country.GetResource("countryname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string countrynameRequired
        {
            get
            {
                return resourceProvider_gen_country.GetResource("countrynameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string gmt
        {
            get
            {
                return resourceProvider_gen_country.GetResource("gmt", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_country.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_country.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_country.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_country.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_country.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
