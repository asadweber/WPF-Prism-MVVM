using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_servicestatus : _Common
    {
         private static IResourceProvider resourceProvider_gen_servicestatus = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_servicestatus.xml"));//DbResourceProvider(); //  
         
         
        public static string servicestatusList
        {
            get
            {
                return resourceProvider_gen_servicestatus.GetResource("servicestatusList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicestatusCreate
        {
            get
            {
                return resourceProvider_gen_servicestatus.GetResource("servicestatusCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicestatusUpdate
        {
            get
            {
                return resourceProvider_gen_servicestatus.GetResource("servicestatusUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicestatusDetails
        {
            get
            {
                return resourceProvider_gen_servicestatus.GetResource("servicestatusDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string servicestatusar
        {
            get
            {
                return resourceProvider_gen_servicestatus.GetResource("servicestatusar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicestatusarRequired
        {
            get
            {
                return resourceProvider_gen_servicestatus.GetResource("servicestatusarRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string servicestatusen
        {
            get
            {
                return resourceProvider_gen_servicestatus.GetResource("servicestatusen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicestatusenRequired
        {
            get
            {
                return resourceProvider_gen_servicestatus.GetResource("servicestatusenRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string descriptionar
        {
            get
            {
                return resourceProvider_gen_servicestatus.GetResource("descriptionar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string descriptionen
        {
            get
            {
                return resourceProvider_gen_servicestatus.GetResource("descriptionen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_gen_servicestatus.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
