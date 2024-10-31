using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_rank : _Common
    {
         private static IResourceProvider resourceProvider_gen_rank = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_rank.xml"));//DbResourceProvider(); //  
         
         
        public static string rankList
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("rankList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string rankCreate
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("rankCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string rankUpdate
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("rankUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string rankDetails
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("rankDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string forceid
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("forceid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string rankname
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("rankname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ranknameRequired
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("ranknameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string rankfor
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("rankfor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string rankforRequired
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("rankforRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
