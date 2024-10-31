using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_services : _Common
    {
         private static IResourceProvider resourceProvider_gen_services = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_services.xml"));//DbResourceProvider(); //  
         
         
        public static string servicesList
        {
            get
            {
                return resourceProvider_gen_services.GetResource("servicesList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicesCreate
        {
            get
            {
                return resourceProvider_gen_services.GetResource("servicesCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicesUpdate
        {
            get
            {
                return resourceProvider_gen_services.GetResource("servicesUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicesDetails
        {
            get
            {
                return resourceProvider_gen_services.GetResource("servicesDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string servicetypeid
        {
            get
            {
                return resourceProvider_gen_services.GetResource("servicetypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicetypeidRequired
        {
            get
            {
                return resourceProvider_gen_services.GetResource("servicetypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string servicename
        {
            get
            {
                return resourceProvider_gen_services.GetResource("servicename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicenameRequired
        {
            get
            {
                return resourceProvider_gen_services.GetResource("servicenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string servicenamear
        {
            get
            {
                return resourceProvider_gen_services.GetResource("servicenamear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicenamearRequired
        {
            get
            {
                return resourceProvider_gen_services.GetResource("servicenamearRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string servicedescription
        {
            get
            {
                return resourceProvider_gen_services.GetResource("servicedescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string servicedescriptionar
        {
            get
            {
                return resourceProvider_gen_services.GetResource("servicedescriptionar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string servicelogopath
        {
            get
            {
                return resourceProvider_gen_services.GetResource("servicelogopath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicelogopathRequired
        {
            get
            {
                return resourceProvider_gen_services.GetResource("servicelogopathRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string serviceurl
        {
            get
            {
                return resourceProvider_gen_services.GetResource("serviceurl", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
