using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_usefullink : _Common
    {
         private static IResourceProvider resourceProvider_gen_usefullink = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_usefullink.xml"));//DbResourceProvider(); //  
         
         
        public static string usefullinkList
        {
            get
            {
                return resourceProvider_gen_usefullink.GetResource("usefullinkList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string usefullinkCreate
        {
            get
            {
                return resourceProvider_gen_usefullink.GetResource("usefullinkCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string usefullinkUpdate
        {
            get
            {
                return resourceProvider_gen_usefullink.GetResource("usefullinkUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string usefullinkDetails
        {
            get
            {
                return resourceProvider_gen_usefullink.GetResource("usefullinkDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string usefullinkcategoryid
        {
            get
            {
                return resourceProvider_gen_usefullink.GetResource("usefullinkcategoryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string usefullinkcategoryidRequired
        {
            get
            {
                return resourceProvider_gen_usefullink.GetResource("usefullinkcategoryidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string usefullink
        {
            get
            {
                return resourceProvider_gen_usefullink.GetResource("usefullink", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string usefullinkRequired
        {
            get
            {
                return resourceProvider_gen_usefullink.GetResource("usefullinkRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string usefullinkar
        {
            get
            {
                return resourceProvider_gen_usefullink.GetResource("usefullinkar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string usefullinkarRequired
        {
            get
            {
                return resourceProvider_gen_usefullink.GetResource("usefullinkarRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string servicelogopath
        {
            get
            {
                return resourceProvider_gen_usefullink.GetResource("servicelogopath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string usefullinkurl
        {
            get
            {
                return resourceProvider_gen_usefullink.GetResource("usefullinkurl", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string openinnewtab
        {
            get
            {
                return resourceProvider_gen_usefullink.GetResource("openinnewtab", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string usefullinkdescription
        {
            get
            {
                return resourceProvider_gen_usefullink.GetResource("usefullinkdescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string usefullinkdescriptionar
        {
            get
            {
                return resourceProvider_gen_usefullink.GetResource("usefullinkdescriptionar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
