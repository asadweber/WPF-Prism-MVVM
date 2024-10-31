using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_generalhealth : _Common
    {
         private static IResourceProvider resourceProvider_gen_generalhealth = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_generalhealth.xml"));//DbResourceProvider(); //  
         
         
        public static string generalhealthList
        {
            get
            {
                return resourceProvider_gen_generalhealth.GetResource("generalhealthList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string generalhealthCreate
        {
            get
            {
                return resourceProvider_gen_generalhealth.GetResource("generalhealthCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string generalhealthUpdate
        {
            get
            {
                return resourceProvider_gen_generalhealth.GetResource("generalhealthUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string generalhealthDetails
        {
            get
            {
                return resourceProvider_gen_generalhealth.GetResource("generalhealthDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string generalhealth
        {
            get
            {
                return resourceProvider_gen_generalhealth.GetResource("generalhealth", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string generalhealthRequired
        {
            get
            {
                return resourceProvider_gen_generalhealth.GetResource("generalhealthRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_generalhealth.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_generalhealth.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_generalhealth.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_generalhealth.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_generalhealth.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
