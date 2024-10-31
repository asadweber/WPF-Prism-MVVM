using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_companies : _Common
    {
         private static IResourceProvider resourceProvider_gen_companies = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_companies.xml"));//DbResourceProvider(); //  
         
         
        public static string companiesList
        {
            get
            {
                return resourceProvider_gen_companies.GetResource("companiesList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companiesCreate
        {
            get
            {
                return resourceProvider_gen_companies.GetResource("companiesCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companiesUpdate
        {
            get
            {
                return resourceProvider_gen_companies.GetResource("companiesUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companiesDetails
        {
            get
            {
                return resourceProvider_gen_companies.GetResource("companiesDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string companyname
        {
            get
            {
                return resourceProvider_gen_companies.GetResource("companyname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companynameRequired
        {
            get
            {
                return resourceProvider_gen_companies.GetResource("companynameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string companytypeid
        {
            get
            {
                return resourceProvider_gen_companies.GetResource("companytypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string companytypeidRequired
        {
            get
            {
                return resourceProvider_gen_companies.GetResource("companytypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string militaryidrequired
        {
            get
            {
                return resourceProvider_gen_companies.GetResource("militaryidrequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_companies.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_companies.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_companies.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_companies.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_companies.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
