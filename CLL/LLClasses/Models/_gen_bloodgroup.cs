using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_bloodgroup : _Common
    {
         private static IResourceProvider resourceProvider_gen_bloodgroup = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_bloodgroup.xml"));//DbResourceProvider(); //  
         
         
        public static string bloodgroupList
        {
            get
            {
                return resourceProvider_gen_bloodgroup.GetResource("bloodgroupList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bloodgroupCreate
        {
            get
            {
                return resourceProvider_gen_bloodgroup.GetResource("bloodgroupCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bloodgroupUpdate
        {
            get
            {
                return resourceProvider_gen_bloodgroup.GetResource("bloodgroupUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bloodgroupDetails
        {
            get
            {
                return resourceProvider_gen_bloodgroup.GetResource("bloodgroupDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string bloodgroupname
        {
            get
            {
                return resourceProvider_gen_bloodgroup.GetResource("bloodgroupname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bloodgroupnameRequired
        {
            get
            {
                return resourceProvider_gen_bloodgroup.GetResource("bloodgroupnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_bloodgroup.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_bloodgroup.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_bloodgroup.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_bloodgroup.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_bloodgroup.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
