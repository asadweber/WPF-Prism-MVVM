using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_serviceinfo : _Common
    {
         private static IResourceProvider resourceProvider_gen_serviceinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_serviceinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string serviceinfoList
        {
            get
            {
                return resourceProvider_gen_serviceinfo.GetResource("serviceinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string serviceinfoCreate
        {
            get
            {
                return resourceProvider_gen_serviceinfo.GetResource("serviceinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string serviceinfoUpdate
        {
            get
            {
                return resourceProvider_gen_serviceinfo.GetResource("serviceinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string serviceinfoDetails
        {
            get
            {
                return resourceProvider_gen_serviceinfo.GetResource("serviceinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string servicear
        {
            get
            {
                return resourceProvider_gen_serviceinfo.GetResource("servicear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicearRequired
        {
            get
            {
                return resourceProvider_gen_serviceinfo.GetResource("servicearRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string serviceen
        {
            get
            {
                return resourceProvider_gen_serviceinfo.GetResource("serviceen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string serviceenRequired
        {
            get
            {
                return resourceProvider_gen_serviceinfo.GetResource("serviceenRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string descriptionar
        {
            get
            {
                return resourceProvider_gen_serviceinfo.GetResource("descriptionar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string descriptionen
        {
            get
            {
                return resourceProvider_gen_serviceinfo.GetResource("descriptionen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_gen_serviceinfo.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
