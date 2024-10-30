using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.SecurityModels
{
    
    public  class _owin_userstatuschangehistory : _Common
    {
         private static IResourceProvider resourceProvider_owin_userstatuschangehistory = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_owin_userstatuschangehistory.xml"));//DbResourceProvider(); //  
         
         
        public static string userstatuschangehistoryList
        {
            get
            {
                return resourceProvider_owin_userstatuschangehistory.GetResource("userstatuschangehistoryList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userstatuschangehistoryCreate
        {
            get
            {
                return resourceProvider_owin_userstatuschangehistory.GetResource("userstatuschangehistoryCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userstatuschangehistoryUpdate
        {
            get
            {
                return resourceProvider_owin_userstatuschangehistory.GetResource("userstatuschangehistoryUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userstatuschangehistoryDetails
        {
            get
            {
                return resourceProvider_owin_userstatuschangehistory.GetResource("userstatuschangehistoryDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string userid
        {
            get
            {
                return resourceProvider_owin_userstatuschangehistory.GetResource("userid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string useridRequired
        {
            get
            {
                return resourceProvider_owin_userstatuschangehistory.GetResource("useridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string masteruserid
        {
            get
            {
                return resourceProvider_owin_userstatuschangehistory.GetResource("masteruserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string masteruseridRequired
        {
            get
            {
                return resourceProvider_owin_userstatuschangehistory.GetResource("masteruseridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string statuschanged
        {
            get
            {
                return resourceProvider_owin_userstatuschangehistory.GetResource("statuschanged", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string statusremark
        {
            get
            {
                return resourceProvider_owin_userstatuschangehistory.GetResource("statusremark", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusremarkRequired
        {
            get
            {
                return resourceProvider_owin_userstatuschangehistory.GetResource("statusremarkRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_owin_userstatuschangehistory.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string extrafld
        {
            get
            {
                return resourceProvider_owin_userstatuschangehistory.GetResource("extrafld", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
