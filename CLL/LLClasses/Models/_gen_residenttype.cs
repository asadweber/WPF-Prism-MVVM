using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_residenttype : _Common
    {
         private static IResourceProvider resourceProvider_gen_residenttype = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_residenttype.xml"));//DbResourceProvider(); //  
         
         
        public static string residenttypeList
        {
            get
            {
                return resourceProvider_gen_residenttype.GetResource("residenttypeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string residenttypeCreate
        {
            get
            {
                return resourceProvider_gen_residenttype.GetResource("residenttypeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string residenttypeUpdate
        {
            get
            {
                return resourceProvider_gen_residenttype.GetResource("residenttypeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string residenttypeDetails
        {
            get
            {
                return resourceProvider_gen_residenttype.GetResource("residenttypeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string residenttype
        {
            get
            {
                return resourceProvider_gen_residenttype.GetResource("residenttype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string residenttypeRequired
        {
            get
            {
                return resourceProvider_gen_residenttype.GetResource("residenttypeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_residenttype.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_residenttype.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_residenttype.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_residenttype.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_residenttype.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
