using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_religion : _Common
    {
         private static IResourceProvider resourceProvider_gen_religion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_religion.xml"));//DbResourceProvider(); //  
         
         
        public static string religionList
        {
            get
            {
                return resourceProvider_gen_religion.GetResource("religionList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string religionCreate
        {
            get
            {
                return resourceProvider_gen_religion.GetResource("religionCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string religionUpdate
        {
            get
            {
                return resourceProvider_gen_religion.GetResource("religionUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string religionDetails
        {
            get
            {
                return resourceProvider_gen_religion.GetResource("religionDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string religionname
        {
            get
            {
                return resourceProvider_gen_religion.GetResource("religionname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string religionnameRequired
        {
            get
            {
                return resourceProvider_gen_religion.GetResource("religionnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_religion.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_religion.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_religion.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_religion.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_religion.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
