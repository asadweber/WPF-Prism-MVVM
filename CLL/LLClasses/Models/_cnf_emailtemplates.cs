using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _cnf_emailtemplates : _Common
    {
         private static IResourceProvider resourceProvider_cnf_emailtemplates = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_cnf_emailtemplates.xml"));//DbResourceProvider(); //  
         
         
        public static string emailtemplatesList
        {
            get
            {
                return resourceProvider_cnf_emailtemplates.GetResource("emailtemplatesList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emailtemplatesCreate
        {
            get
            {
                return resourceProvider_cnf_emailtemplates.GetResource("emailtemplatesCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emailtemplatesUpdate
        {
            get
            {
                return resourceProvider_cnf_emailtemplates.GetResource("emailtemplatesUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emailtemplatesDetails
        {
            get
            {
                return resourceProvider_cnf_emailtemplates.GetResource("emailtemplatesDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string emailtemplateshortname
        {
            get
            {
                return resourceProvider_cnf_emailtemplates.GetResource("emailtemplateshortname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emailtemplateshortnameRequired
        {
            get
            {
                return resourceProvider_cnf_emailtemplates.GetResource("emailtemplateshortnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string emailtemplatemsg
        {
            get
            {
                return resourceProvider_cnf_emailtemplates.GetResource("emailtemplatemsg", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emailtemplatemsgRequired
        {
            get
            {
                return resourceProvider_cnf_emailtemplates.GetResource("emailtemplatemsgRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string emailtempaltesubject
        {
            get
            {
                return resourceProvider_cnf_emailtemplates.GetResource("emailtempaltesubject", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emailtempaltesubjectRequired
        {
            get
            {
                return resourceProvider_cnf_emailtemplates.GetResource("emailtempaltesubjectRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_cnf_emailtemplates.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_cnf_emailtemplates.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_cnf_emailtemplates.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_cnf_emailtemplates.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
