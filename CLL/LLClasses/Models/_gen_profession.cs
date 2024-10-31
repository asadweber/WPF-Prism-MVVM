using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _gen_profession : _Common
    {
         private static IResourceProvider resourceProvider_gen_profession = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_gen_profession.xml"));//DbResourceProvider(); //  
         
         
        public static string professionList
        {
            get
            {
                return resourceProvider_gen_profession.GetResource("professionList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string professionCreate
        {
            get
            {
                return resourceProvider_gen_profession.GetResource("professionCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string professionUpdate
        {
            get
            {
                return resourceProvider_gen_profession.GetResource("professionUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string professionDetails
        {
            get
            {
                return resourceProvider_gen_profession.GetResource("professionDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string professionname
        {
            get
            {
                return resourceProvider_gen_profession.GetResource("professionname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string professionnameRequired
        {
            get
            {
                return resourceProvider_gen_profession.GetResource("professionnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string professiongroupid
        {
            get
            {
                return resourceProvider_gen_profession.GetResource("professiongroupid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string professiongroupidRequired
        {
            get
            {
                return resourceProvider_gen_profession.GetResource("professiongroupidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string comment
        {
            get
            {
                return resourceProvider_gen_profession.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_profession.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_gen_profession.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_gen_profession.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oracleid
        {
            get
            {
                return resourceProvider_gen_profession.GetResource("oracleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
		public static string selectedprofession
		{
			get
			{
				return resourceProvider_gen_profession.GetResource("selectedprofession", CultureInfo.CurrentUICulture.Name) as String;
			}
		}

	}
}
