using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _cnf_smsactivationtransection : _Common
    {
         private static IResourceProvider resourceProvider_cnf_smsactivationtransection = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_cnf_smsactivationtransection.xml"));//DbResourceProvider(); //  
         
         
        public static string smsactivationtransectionList
        {
            get
            {
                return resourceProvider_cnf_smsactivationtransection.GetResource("smsactivationtransectionList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string smsactivationtransectionCreate
        {
            get
            {
                return resourceProvider_cnf_smsactivationtransection.GetResource("smsactivationtransectionCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string smsactivationtransectionUpdate
        {
            get
            {
                return resourceProvider_cnf_smsactivationtransection.GetResource("smsactivationtransectionUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string smsactivationtransectionDetails
        {
            get
            {
                return resourceProvider_cnf_smsactivationtransection.GetResource("smsactivationtransectionDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string smscodeid
        {
            get
            {
                return resourceProvider_cnf_smsactivationtransection.GetResource("smscodeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string smscodeidRequired
        {
            get
            {
                return resourceProvider_cnf_smsactivationtransection.GetResource("smscodeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string providedcode
        {
            get
            {
                return resourceProvider_cnf_smsactivationtransection.GetResource("providedcode", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string providedcodeRequired
        {
            get
            {
                return resourceProvider_cnf_smsactivationtransection.GetResource("providedcodeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string issuccess
        {
            get
            {
                return resourceProvider_cnf_smsactivationtransection.GetResource("issuccess", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_cnf_smsactivationtransection.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_cnf_smsactivationtransection.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_cnf_smsactivationtransection.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_cnf_smsactivationtransection.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
