using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _cnf_filerequired : _Common
    {
         private static IResourceProvider resourceProvider_cnf_filerequired = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_cnf_filerequired.xml"));//DbResourceProvider(); //  
         
         
        public static string filerequiredList
        {
            get
            {
                return resourceProvider_cnf_filerequired.GetResource("filerequiredList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string filerequiredCreate
        {
            get
            {
                return resourceProvider_cnf_filerequired.GetResource("filerequiredCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string filerequiredUpdate
        {
            get
            {
                return resourceProvider_cnf_filerequired.GetResource("filerequiredUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string filerequiredDetails
        {
            get
            {
                return resourceProvider_cnf_filerequired.GetResource("filerequiredDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string batchid
        {
            get
            {
                return resourceProvider_cnf_filerequired.GetResource("batchid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchidRequired
        {
            get
            {
                return resourceProvider_cnf_filerequired.GetResource("batchidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileconfigname
        {
            get
            {
                return resourceProvider_cnf_filerequired.GetResource("fileconfigname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileconfignameRequired
        {
            get
            {
                return resourceProvider_cnf_filerequired.GetResource("fileconfignameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string certificateid
        {
            get
            {
                return resourceProvider_cnf_filerequired.GetResource("certificateid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isrequired
        {
            get
            {
                return resourceProvider_cnf_filerequired.GetResource("isrequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isprintrequired
        {
            get
            {
                return resourceProvider_cnf_filerequired.GetResource("isprintrequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_cnf_filerequired.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_cnf_filerequired.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_cnf_filerequired.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
