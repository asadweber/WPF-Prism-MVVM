using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _cnf_smsactivationcode : _Common
    {
         private static IResourceProvider resourceProvider_cnf_smsactivationcode = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_cnf_smsactivationcode.xml"));//DbResourceProvider(); //  
         
         
        public static string smsactivationcodeList
        {
            get
            {
                return resourceProvider_cnf_smsactivationcode.GetResource("smsactivationcodeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string smsactivationcodeCreate
        {
            get
            {
                return resourceProvider_cnf_smsactivationcode.GetResource("smsactivationcodeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string smsactivationcodeUpdate
        {
            get
            {
                return resourceProvider_cnf_smsactivationcode.GetResource("smsactivationcodeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string smsactivationcodeDetails
        {
            get
            {
                return resourceProvider_cnf_smsactivationcode.GetResource("smsactivationcodeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_cnf_smsactivationcode.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_cnf_smsactivationcode.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userid
        {
            get
            {
                return resourceProvider_cnf_smsactivationcode.GetResource("userid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string useridRequired
        {
            get
            {
                return resourceProvider_cnf_smsactivationcode.GetResource("useridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string generatedate
        {
            get
            {
                return resourceProvider_cnf_smsactivationcode.GetResource("generatedate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string generatedateRequired
        {
            get
            {
                return resourceProvider_cnf_smsactivationcode.GetResource("generatedateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string smscodetype
        {
            get
            {
                return resourceProvider_cnf_smsactivationcode.GetResource("smscodetype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string smscodetypeRequired
        {
            get
            {
                return resourceProvider_cnf_smsactivationcode.GetResource("smscodetypeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string smscode
        {
            get
            {
                return resourceProvider_cnf_smsactivationcode.GetResource("smscode", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string smscodeRequired
        {
            get
            {
                return resourceProvider_cnf_smsactivationcode.GetResource("smscodeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_cnf_smsactivationcode.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isactiveRequired
        {
            get
            {
                return resourceProvider_cnf_smsactivationcode.GetResource("isactiveRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string sucessdate
        {
            get
            {
                return resourceProvider_cnf_smsactivationcode.GetResource("sucessdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string smsstatus
        {
            get
            {
                return resourceProvider_cnf_smsactivationcode.GetResource("smsstatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string smssenddate
        {
            get
            {
                return resourceProvider_cnf_smsactivationcode.GetResource("smssenddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string smsresponse
        {
            get
            {
                return resourceProvider_cnf_smsactivationcode.GetResource("smsresponse", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_cnf_smsactivationcode.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_cnf_smsactivationcode.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_cnf_smsactivationcode.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_cnf_smsactivationcode.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


		public static string UserName
		{
			get
			{
				return resourceProvider_cnf_smsactivationcode.GetResource("UserName", CultureInfo.CurrentUICulture.Name) as String;
			}
		}

		public static string UserNameRequired
		{
			get
			{
				return resourceProvider_cnf_smsactivationcode.GetResource("UserNameRequired", CultureInfo.CurrentUICulture.Name) as String;
			}
		}


	}
}
