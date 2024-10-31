using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _cnf_studentmenuskipdetail : _Common
    {
         private static IResourceProvider resourceProvider_cnf_studentmenuskipdetail = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_cnf_studentmenuskipdetail.xml"));//DbResourceProvider(); //  
         
         
        public static string studentmenuskipdetailList
        {
            get
            {
                return resourceProvider_cnf_studentmenuskipdetail.GetResource("studentmenuskipdetailList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string studentmenuskipdetailCreate
        {
            get
            {
                return resourceProvider_cnf_studentmenuskipdetail.GetResource("studentmenuskipdetailCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string studentmenuskipdetailUpdate
        {
            get
            {
                return resourceProvider_cnf_studentmenuskipdetail.GetResource("studentmenuskipdetailUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string studentmenuskipdetailDetails
        {
            get
            {
                return resourceProvider_cnf_studentmenuskipdetail.GetResource("studentmenuskipdetailDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string studentskippedserialid
        {
            get
            {
                return resourceProvider_cnf_studentmenuskipdetail.GetResource("studentskippedserialid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string studentskippedserialidRequired
        {
            get
            {
                return resourceProvider_cnf_studentmenuskipdetail.GetResource("studentskippedserialidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_cnf_studentmenuskipdetail.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_cnf_studentmenuskipdetail.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string appformid
        {
            get
            {
                return resourceProvider_cnf_studentmenuskipdetail.GetResource("appformid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string appformidRequired
        {
            get
            {
                return resourceProvider_cnf_studentmenuskipdetail.GetResource("appformidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string formactionid
        {
            get
            {
                return resourceProvider_cnf_studentmenuskipdetail.GetResource("formactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string formactionidRequired
        {
            get
            {
                return resourceProvider_cnf_studentmenuskipdetail.GetResource("formactionidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string formname
        {
            get
            {
                return resourceProvider_cnf_studentmenuskipdetail.GetResource("formname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string formnameRequired
        {
            get
            {
                return resourceProvider_cnf_studentmenuskipdetail.GetResource("formnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string noinfoavailable
        {
            get
            {
                return resourceProvider_cnf_studentmenuskipdetail.GetResource("noinfoavailable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string haschecked
        {
            get
            {
                return resourceProvider_cnf_studentmenuskipdetail.GetResource("haschecked", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string optional
        {
            get
            {
                return resourceProvider_cnf_studentmenuskipdetail.GetResource("optional", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_cnf_studentmenuskipdetail.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_cnf_studentmenuskipdetail.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_cnf_studentmenuskipdetail.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_cnf_studentmenuskipdetail.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
