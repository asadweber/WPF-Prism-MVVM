using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_servicestype : _Common
    {
         private static IResourceProvider resourceProvider_gen_servicestype = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_servicestype.xml"));//DbResourceProvider(); //  
         
         
        public static string servicestypeList
        {
            get
            {
                return resourceProvider_gen_servicestype.GetResource("servicestypeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicestypeCreate
        {
            get
            {
                return resourceProvider_gen_servicestype.GetResource("servicestypeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicestypeUpdate
        {
            get
            {
                return resourceProvider_gen_servicestype.GetResource("servicestypeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicestypeDetails
        {
            get
            {
                return resourceProvider_gen_servicestype.GetResource("servicestypeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string servicetypear
        {
            get
            {
                return resourceProvider_gen_servicestype.GetResource("servicetypear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicetypearRequired
        {
            get
            {
                return resourceProvider_gen_servicestype.GetResource("servicetypearRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string descriptionar
        {
            get
            {
                return resourceProvider_gen_servicestype.GetResource("descriptionar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string servicetype
        {
            get
            {
                return resourceProvider_gen_servicestype.GetResource("servicetype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string description
        {
            get
            {
                return resourceProvider_gen_servicestype.GetResource("description", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
