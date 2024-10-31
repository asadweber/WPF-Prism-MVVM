using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_batch : _Common
    {
         private static IResourceProvider resourceProvider_gen_batch = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_batch.xml"));//DbResourceProvider(); //  
         
         
        public static string batchList
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("batchList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchCreate
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("batchCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchUpdate
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("batchUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchDetails
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("batchDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string batchno
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("batchno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchnoRequired
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("batchnoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string startdate
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("startdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string startdateRequired
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("startdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string enddate
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("enddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string enddateRequired
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("enddateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string lowerage
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("lowerage", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string lowerageRequired
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("lowerageRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string maxage
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("maxage", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string maxageRequired
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("maxageRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string candidatetype
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("candidatetype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string militarytype
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("militarytype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string militarytypeRequired
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("militarytypeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string gender
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("gender", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isactive
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isactiveRequired
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("isactiveRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string comment
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
      
    }
}
