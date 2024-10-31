using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_countrycity : _Common
    {
         private static IResourceProvider resourceProvider_gen_countrycity = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_countrycity.xml"));//DbResourceProvider(); //  
         
         
        public static string countrycityList
        {
            get
            {
                return resourceProvider_gen_countrycity.GetResource("countrycityList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string countrycityCreate
        {
            get
            {
                return resourceProvider_gen_countrycity.GetResource("countrycityCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string countrycityUpdate
        {
            get
            {
                return resourceProvider_gen_countrycity.GetResource("countrycityUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string countrycityDetails
        {
            get
            {
                return resourceProvider_gen_countrycity.GetResource("countrycityDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string parentid
        {
            get
            {
                return resourceProvider_gen_countrycity.GetResource("parentid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string countryid
        {
            get
            {
                return resourceProvider_gen_countrycity.GetResource("countryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string countryidRequired
        {
            get
            {
                return resourceProvider_gen_countrycity.GetResource("countryidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string cityname
        {
            get
            {
                return resourceProvider_gen_countrycity.GetResource("cityname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string citynameRequired
        {
            get
            {
                return resourceProvider_gen_countrycity.GetResource("citynameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isgovernate
        {
            get
            {
                return resourceProvider_gen_countrycity.GetResource("isgovernate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_countrycity.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_countrycity.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_countrycity.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_countrycity.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_countrycity.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oraclegovid
        {
            get
            {
                return resourceProvider_gen_countrycity.GetResource("oraclegovid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
