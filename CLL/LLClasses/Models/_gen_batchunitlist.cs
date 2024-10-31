using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_batchunitlist : _Common
    {
         private static IResourceProvider resourceProvider_gen_batchunitlist = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_batchunitlist.xml"));//DbResourceProvider(); //  
         
         
        public static string batchunitlistList
        {
            get
            {
                return resourceProvider_gen_batchunitlist.GetResource("batchunitlistList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchunitlistCreate
        {
            get
            {
                return resourceProvider_gen_batchunitlist.GetResource("batchunitlistCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchunitlistUpdate
        {
            get
            {
                return resourceProvider_gen_batchunitlist.GetResource("batchunitlistUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchunitlistDetails
        {
            get
            {
                return resourceProvider_gen_batchunitlist.GetResource("batchunitlistDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string batchid
        {
            get
            {
                return resourceProvider_gen_batchunitlist.GetResource("batchid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchidRequired
        {
            get
            {
                return resourceProvider_gen_batchunitlist.GetResource("batchidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string batchno
        {
            get
            {
                return resourceProvider_gen_batchunitlist.GetResource("batchno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entitykey
        {
            get
            {
                return resourceProvider_gen_batchunitlist.GetResource("entitykey", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string entitykeyRequired
        {
            get
            {
                return resourceProvider_gen_batchunitlist.GetResource("entitykeyRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_gen_batchunitlist.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_batchunitlist.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
      
    }
}
