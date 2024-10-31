using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_educationmajor : _Common
    {
         private static IResourceProvider resourceProvider_gen_educationmajor = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_educationmajor.xml"));//DbResourceProvider(); //  
         
         
        public static string educationmajorList
        {
            get
            {
                return resourceProvider_gen_educationmajor.GetResource("educationmajorList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string educationmajorCreate
        {
            get
            {
                return resourceProvider_gen_educationmajor.GetResource("educationmajorCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string educationmajorUpdate
        {
            get
            {
                return resourceProvider_gen_educationmajor.GetResource("educationmajorUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string educationmajorDetails
        {
            get
            {
                return resourceProvider_gen_educationmajor.GetResource("educationmajorDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string educationmajorname
        {
            get
            {
                return resourceProvider_gen_educationmajor.GetResource("educationmajorname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string educationmajornameRequired
        {
            get
            {
                return resourceProvider_gen_educationmajor.GetResource("educationmajornameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_educationmajor.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_educationmajor.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_educationmajor.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_educationmajor.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_educationmajor.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
