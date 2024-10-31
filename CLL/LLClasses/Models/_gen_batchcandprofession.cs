using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_batchcandprofession : _Common
    {
         private static IResourceProvider resourceProvider_gen_batchcandprofession = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_batchcandprofession.xml"));//DbResourceProvider(); //  
         
         
        public static string batchcandprofessionList
        {
            get
            {
                return resourceProvider_gen_batchcandprofession.GetResource("batchcandprofessionList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchcandprofessionCreate
        {
            get
            {
                return resourceProvider_gen_batchcandprofession.GetResource("batchcandprofessionCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchcandprofessionUpdate
        {
            get
            {
                return resourceProvider_gen_batchcandprofession.GetResource("batchcandprofessionUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchcandprofessionDetails
        {
            get
            {
                return resourceProvider_gen_batchcandprofession.GetResource("batchcandprofessionDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string batchcandidatetypemapid
        {
            get
            {
                return resourceProvider_gen_batchcandprofession.GetResource("batchcandidatetypemapid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchcandidatetypemapidRequired
        {
            get
            {
                return resourceProvider_gen_batchcandprofession.GetResource("batchcandidatetypemapidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchid
        {
            get
            {
                return resourceProvider_gen_batchcandprofession.GetResource("batchid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchidRequired
        {
            get
            {
                return resourceProvider_gen_batchcandprofession.GetResource("batchidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string candidatetypeid
        {
            get
            {
                return resourceProvider_gen_batchcandprofession.GetResource("candidatetypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string candidatetypeidRequired
        {
            get
            {
                return resourceProvider_gen_batchcandprofession.GetResource("candidatetypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
		public static string professionid
		{
			get
			{
				return resourceProvider_gen_batchcandprofession.GetResource("professionid", CultureInfo.CurrentUICulture.Name) as String;
			}
		}
		public static string professiongroupid
		{
            get
            {
                return resourceProvider_gen_batchcandprofession.GetResource("professiongroupid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string professionidRequired
        {
            get
            {
                return resourceProvider_gen_batchcandprofession.GetResource("professionidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string noofregistration
        {
            get
            {
                return resourceProvider_gen_batchcandprofession.GetResource("noofregistration", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_gen_batchcandprofession.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_gen_batchcandprofession.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_batchcandprofession.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_batchcandprofession.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_batchcandprofession.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_batchcandprofession.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
