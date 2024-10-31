using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_companytype : _Common
    {
         private static IResourceProvider resourceProvider_gen_companytype = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_companytype.xml"));//DbResourceProvider(); //  
         
         
        public static string companytypeList
        {
            get
            {
                return resourceProvider_gen_companytype.GetResource("companytypeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companytypeCreate
        {
            get
            {
                return resourceProvider_gen_companytype.GetResource("companytypeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companytypeUpdate
        {
            get
            {
                return resourceProvider_gen_companytype.GetResource("companytypeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companytypeDetails
        {
            get
            {
                return resourceProvider_gen_companytype.GetResource("companytypeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string companytypename
        {
            get
            {
                return resourceProvider_gen_companytype.GetResource("companytypename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companytypenameRequired
        {
            get
            {
                return resourceProvider_gen_companytype.GetResource("companytypenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_companytype.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_companytype.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_companytype.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_companytype.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_companytype.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
