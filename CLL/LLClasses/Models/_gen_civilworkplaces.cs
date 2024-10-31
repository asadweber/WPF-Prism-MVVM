using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_civilworkplaces : _Common
    {
         private static IResourceProvider resourceProvider_gen_civilworkplaces = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_civilworkplaces.xml"));//DbResourceProvider(); //  
         
         
        public static string civilworkplacesList
        {
            get
            {
                return resourceProvider_gen_civilworkplaces.GetResource("civilworkplacesList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilworkplacesCreate
        {
            get
            {
                return resourceProvider_gen_civilworkplaces.GetResource("civilworkplacesCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilworkplacesUpdate
        {
            get
            {
                return resourceProvider_gen_civilworkplaces.GetResource("civilworkplacesUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilworkplacesDetails
        {
            get
            {
                return resourceProvider_gen_civilworkplaces.GetResource("civilworkplacesDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string parentid
        {
            get
            {
                return resourceProvider_gen_civilworkplaces.GetResource("parentid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string workplacename
        {
            get
            {
                return resourceProvider_gen_civilworkplaces.GetResource("workplacename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string workplacenameRequired
        {
            get
            {
                return resourceProvider_gen_civilworkplaces.GetResource("workplacenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string workplacenameeng
        {
            get
            {
                return resourceProvider_gen_civilworkplaces.GetResource("workplacenameeng", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string governorateid
        {
            get
            {
                return resourceProvider_gen_civilworkplaces.GetResource("governorateid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string areaid
        {
            get
            {
                return resourceProvider_gen_civilworkplaces.GetResource("areaid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string block
        {
            get
            {
                return resourceProvider_gen_civilworkplaces.GetResource("block", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string address
        {
            get
            {
                return resourceProvider_gen_civilworkplaces.GetResource("address", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_civilworkplaces.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_civilworkplaces.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_civilworkplaces.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
