using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_educationshift : _Common
    {
         private static IResourceProvider resourceProvider_gen_educationshift = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_educationshift.xml"));//DbResourceProvider(); //  
         
         
        public static string educationshiftList
        {
            get
            {
                return resourceProvider_gen_educationshift.GetResource("educationshiftList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string educationshiftCreate
        {
            get
            {
                return resourceProvider_gen_educationshift.GetResource("educationshiftCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string educationshiftUpdate
        {
            get
            {
                return resourceProvider_gen_educationshift.GetResource("educationshiftUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string educationshiftDetails
        {
            get
            {
                return resourceProvider_gen_educationshift.GetResource("educationshiftDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string educationshiftname
        {
            get
            {
                return resourceProvider_gen_educationshift.GetResource("educationshiftname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string educationshiftnameRequired
        {
            get
            {
                return resourceProvider_gen_educationshift.GetResource("educationshiftnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_educationshift.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_educationshift.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_educationshift.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_educationshift.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_educationshift.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
