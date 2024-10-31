using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_generallook : _Common
    {
         private static IResourceProvider resourceProvider_gen_generallook = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_generallook.xml"));//DbResourceProvider(); //  
         
         
        public static string generallookList
        {
            get
            {
                return resourceProvider_gen_generallook.GetResource("generallookList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string generallookCreate
        {
            get
            {
                return resourceProvider_gen_generallook.GetResource("generallookCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string generallookUpdate
        {
            get
            {
                return resourceProvider_gen_generallook.GetResource("generallookUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string generallookDetails
        {
            get
            {
                return resourceProvider_gen_generallook.GetResource("generallookDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string generallook
        {
            get
            {
                return resourceProvider_gen_generallook.GetResource("generallook", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string generallookRequired
        {
            get
            {
                return resourceProvider_gen_generallook.GetResource("generallookRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_generallook.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_generallook.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_generallook.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_generallook.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_generallook.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
