using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_login : _Common
    {
         private static IResourceProvider resourceProvider_tran_login = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_login.xml"));//DbResourceProvider(); //  
         
         
        public static string loginList
        {
            get
            {
                return resourceProvider_tran_login.GetResource("loginList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string loginCreate
        {
            get
            {
                return resourceProvider_tran_login.GetResource("loginCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string loginUpdate
        {
            get
            {
                return resourceProvider_tran_login.GetResource("loginUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string loginDetails
        {
            get
            {
                return resourceProvider_tran_login.GetResource("loginDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string parentserialloginid
        {
            get
            {
                return resourceProvider_tran_login.GetResource("parentserialloginid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string samaccount
        {
            get
            {
                return resourceProvider_tran_login.GetResource("samaccount", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string samaccountRequired
        {
            get
            {
                return resourceProvider_tran_login.GetResource("samaccountRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string samemail
        {
            get
            {
                return resourceProvider_tran_login.GetResource("samemail", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string samemailRequired
        {
            get
            {
                return resourceProvider_tran_login.GetResource("samemailRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string userid
        {
            get
            {
                return resourceProvider_tran_login.GetResource("userid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string useridRequired
        {
            get
            {
                return resourceProvider_tran_login.GetResource("useridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string logindate
        {
            get
            {
                return resourceProvider_tran_login.GetResource("logindate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string logindateRequired
        {
            get
            {
                return resourceProvider_tran_login.GetResource("logindateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string logintoken
        {
            get
            {
                return resourceProvider_tran_login.GetResource("logintoken", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string logintokenRequired
        {
            get
            {
                return resourceProvider_tran_login.GetResource("logintokenRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string refreshtoken
        {
            get
            {
                return resourceProvider_tran_login.GetResource("refreshtoken", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tokenissuedate
        {
            get
            {
                return resourceProvider_tran_login.GetResource("tokenissuedate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tokenissuedateRequired
        {
            get
            {
                return resourceProvider_tran_login.GetResource("tokenissuedateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string expires
        {
            get
            {
                return resourceProvider_tran_login.GetResource("expires", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string expiresRequired
        {
            get
            {
                return resourceProvider_tran_login.GetResource("expiresRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_tran_login.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
