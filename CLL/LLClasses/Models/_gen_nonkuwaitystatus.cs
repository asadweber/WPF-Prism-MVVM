using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_nonkuwaitystatus : _Common
    {
         private static IResourceProvider resourceProvider_gen_nonkuwaitystatus = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_nonkuwaitystatus.xml"));//DbResourceProvider(); //  
         
         
        public static string nonkuwaitystatusList
        {
            get
            {
                return resourceProvider_gen_nonkuwaitystatus.GetResource("nonkuwaitystatusList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string nonkuwaitystatusCreate
        {
            get
            {
                return resourceProvider_gen_nonkuwaitystatus.GetResource("nonkuwaitystatusCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string nonkuwaitystatusUpdate
        {
            get
            {
                return resourceProvider_gen_nonkuwaitystatus.GetResource("nonkuwaitystatusUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string nonkuwaitystatusDetails
        {
            get
            {
                return resourceProvider_gen_nonkuwaitystatus.GetResource("nonkuwaitystatusDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string nonkuwaitystatusname
        {
            get
            {
                return resourceProvider_gen_nonkuwaitystatus.GetResource("nonkuwaitystatusname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string nonkuwaitystatusnameRequired
        {
            get
            {
                return resourceProvider_gen_nonkuwaitystatus.GetResource("nonkuwaitystatusnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_nonkuwaitystatus.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_nonkuwaitystatus.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string statusgroup
        {
            get
            {
                return resourceProvider_gen_nonkuwaitystatus.GetResource("statusgroup", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_nonkuwaitystatus.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_nonkuwaitystatus.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_nonkuwaitystatus.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
