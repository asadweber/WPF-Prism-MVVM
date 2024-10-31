using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_econtactlist : _Common
    {
         private static IResourceProvider resourceProvider_gen_econtactlist = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_econtactlist.xml"));//DbResourceProvider(); //  
         
         
        public static string econtactlistList
        {
            get
            {
                return resourceProvider_gen_econtactlist.GetResource("econtactlistList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string econtactlistCreate
        {
            get
            {
                return resourceProvider_gen_econtactlist.GetResource("econtactlistCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string econtactlistUpdate
        {
            get
            {
                return resourceProvider_gen_econtactlist.GetResource("econtactlistUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string econtactlistDetails
        {
            get
            {
                return resourceProvider_gen_econtactlist.GetResource("econtactlistDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string emrgrelationshipname
        {
            get
            {
                return resourceProvider_gen_econtactlist.GetResource("emrgrelationshipname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emrgrelationshipnameRequired
        {
            get
            {
                return resourceProvider_gen_econtactlist.GetResource("emrgrelationshipnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_econtactlist.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_econtactlist.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
