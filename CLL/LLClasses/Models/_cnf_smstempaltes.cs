using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _cnf_smstempaltes : _Common
    {
         private static IResourceProvider resourceProvider_cnf_smstempaltes = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_cnf_smstempaltes.xml"));//DbResourceProvider(); //  
         
         
        public static string smstempaltesList
        {
            get
            {
                return resourceProvider_cnf_smstempaltes.GetResource("smstempaltesList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string smstempaltesCreate
        {
            get
            {
                return resourceProvider_cnf_smstempaltes.GetResource("smstempaltesCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string smstempaltesUpdate
        {
            get
            {
                return resourceProvider_cnf_smstempaltes.GetResource("smstempaltesUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string smstempaltesDetails
        {
            get
            {
                return resourceProvider_cnf_smstempaltes.GetResource("smstempaltesDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string smstemplateshortname
        {
            get
            {
                return resourceProvider_cnf_smstempaltes.GetResource("smstemplateshortname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string smstemplateshortnameRequired
        {
            get
            {
                return resourceProvider_cnf_smstempaltes.GetResource("smstemplateshortnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string smstemplatemsg
        {
            get
            {
                return resourceProvider_cnf_smstempaltes.GetResource("smstemplatemsg", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string smstemplatemsgRequired
        {
            get
            {
                return resourceProvider_cnf_smstempaltes.GetResource("smstemplatemsgRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_cnf_smstempaltes.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_cnf_smstempaltes.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_cnf_smstempaltes.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_cnf_smstempaltes.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
