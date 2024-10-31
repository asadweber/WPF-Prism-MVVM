using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _cnf_fileconfigname : _Common
    {
         private static IResourceProvider resourceProvider_cnf_fileconfigname = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_cnf_fileconfigname.xml"));//DbResourceProvider(); //  
         
         
        public static string fileconfignameList
        {
            get
            {
                return resourceProvider_cnf_fileconfigname.GetResource("fileconfignameList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileconfignameCreate
        {
            get
            {
                return resourceProvider_cnf_fileconfigname.GetResource("fileconfignameCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileconfignameUpdate
        {
            get
            {
                return resourceProvider_cnf_fileconfigname.GetResource("fileconfignameUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileconfignameDetails
        {
            get
            {
                return resourceProvider_cnf_fileconfigname.GetResource("fileconfignameDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string fileconfigname
        {
            get
            {
                return resourceProvider_cnf_fileconfigname.GetResource("fileconfigname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileconfignameRequired
        {
            get
            {
                return resourceProvider_cnf_fileconfigname.GetResource("fileconfignameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_cnf_fileconfigname.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_cnf_fileconfigname.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_cnf_fileconfigname.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
