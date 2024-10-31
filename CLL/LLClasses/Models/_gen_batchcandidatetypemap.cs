using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_batchcandidatetypemap : _Common
    {
         private static IResourceProvider resourceProvider_gen_batchcandidatetypemap = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_batchcandidatetypemap.xml"));//DbResourceProvider(); //  
         
         
        public static string batchcandidatetypemapList
        {
            get
            {
                return resourceProvider_gen_batchcandidatetypemap.GetResource("batchcandidatetypemapList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchcandidatetypemapCreate
        {
            get
            {
                return resourceProvider_gen_batchcandidatetypemap.GetResource("batchcandidatetypemapCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchcandidatetypemapUpdate
        {
            get
            {
                return resourceProvider_gen_batchcandidatetypemap.GetResource("batchcandidatetypemapUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchcandidatetypemapDetails
        {
            get
            {
                return resourceProvider_gen_batchcandidatetypemap.GetResource("batchcandidatetypemapDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string batchid
        {
            get
            {
                return resourceProvider_gen_batchcandidatetypemap.GetResource("batchid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchidRequired
        {
            get
            {
                return resourceProvider_gen_batchcandidatetypemap.GetResource("batchidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string candidatetypeid
        {
            get
            {
                return resourceProvider_gen_batchcandidatetypemap.GetResource("candidatetypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string candidatetypeidRequired
        {
            get
            {
                return resourceProvider_gen_batchcandidatetypemap.GetResource("candidatetypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string startdate
        {
            get
            {
                return resourceProvider_gen_batchcandidatetypemap.GetResource("startdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string startdateRequired
        {
            get
            {
                return resourceProvider_gen_batchcandidatetypemap.GetResource("startdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string enddate
        {
            get
            {
                return resourceProvider_gen_batchcandidatetypemap.GetResource("enddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string enddateRequired
        {
            get
            {
                return resourceProvider_gen_batchcandidatetypemap.GetResource("enddateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string comment
        {
            get
            {
                return resourceProvider_gen_batchcandidatetypemap.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_batchcandidatetypemap.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
      
    }
}
