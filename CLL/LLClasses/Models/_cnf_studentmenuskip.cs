using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _cnf_studentmenuskip : _Common
    {
         private static IResourceProvider resourceProvider_cnf_studentmenuskip = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_cnf_studentmenuskip.xml"));//DbResourceProvider(); //  
         
         
        public static string studentmenuskipList
        {
            get
            {
                return resourceProvider_cnf_studentmenuskip.GetResource("studentmenuskipList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string studentmenuskipCreate
        {
            get
            {
                return resourceProvider_cnf_studentmenuskip.GetResource("studentmenuskipCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string studentmenuskipUpdate
        {
            get
            {
                return resourceProvider_cnf_studentmenuskip.GetResource("studentmenuskipUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string studentmenuskipDetails
        {
            get
            {
                return resourceProvider_cnf_studentmenuskip.GetResource("studentmenuskipDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string usercateogryid
        {
            get
            {
                return resourceProvider_cnf_studentmenuskip.GetResource("usercateogryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string usercateogryidRequired
        {
            get
            {
                return resourceProvider_cnf_studentmenuskip.GetResource("usercateogryidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string appformid
        {
            get
            {
                return resourceProvider_cnf_studentmenuskip.GetResource("appformid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string appformidRequired
        {
            get
            {
                return resourceProvider_cnf_studentmenuskip.GetResource("appformidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string formactionid
        {
            get
            {
                return resourceProvider_cnf_studentmenuskip.GetResource("formactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string formactionidRequired
        {
            get
            {
                return resourceProvider_cnf_studentmenuskip.GetResource("formactionidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string formname
        {
            get
            {
                return resourceProvider_cnf_studentmenuskip.GetResource("formname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string formnameRequired
        {
            get
            {
                return resourceProvider_cnf_studentmenuskip.GetResource("formnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hasskipped
        {
            get
            {
                return resourceProvider_cnf_studentmenuskip.GetResource("hasskipped", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string skippedprompt
        {
            get
            {
                return resourceProvider_cnf_studentmenuskip.GetResource("skippedprompt", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_cnf_studentmenuskip.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_cnf_studentmenuskip.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_cnf_studentmenuskip.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_cnf_studentmenuskip.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
