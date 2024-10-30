using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.SecurityModels
{
    
    public  class _owin_formaction : _Common
    {
         private static IResourceProvider resourceProvider_owin_formaction = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_owin_formaction.xml"));//DbResourceProvider(); //  
         
         
        public static string formactionList
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("formactionList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string formactionCreate
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("formactionCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string formactionUpdate
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("formactionUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string formactionDetails
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("formactionDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string parentid
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("parentid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string actionname
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("actionname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string actionnameRequired
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("actionnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string displaynamear
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("displaynamear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string displayname
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("displayname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string actiontype
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("actiontype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isview
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("isview", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isapi
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("isapi", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isshowonmenu
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("isshowonmenu", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string classicon
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("classicon", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isitem
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("isitem", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string eventname
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("eventname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string sequence
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("sequence", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
