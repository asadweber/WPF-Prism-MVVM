using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_centralagencysyresult : _Common
    {
         private static IResourceProvider resourceProvider_tran_centralagencysyresult = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_centralagencysyresult.xml"));//DbResourceProvider(); //  
         
         
        public static string centralagencysyresultList
        {
            get
            {
                return resourceProvider_tran_centralagencysyresult.GetResource("centralagencysyresultList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string centralagencysyresultCreate
        {
            get
            {
                return resourceProvider_tran_centralagencysyresult.GetResource("centralagencysyresultCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string centralagencysyresultUpdate
        {
            get
            {
                return resourceProvider_tran_centralagencysyresult.GetResource("centralagencysyresultUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string centralagencysyresultDetails
        {
            get
            {
                return resourceProvider_tran_centralagencysyresult.GetResource("centralagencysyresultDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_tran_centralagencysyresult.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_tran_centralagencysyresult.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string registrationid
        {
            get
            {
                return resourceProvider_tran_centralagencysyresult.GetResource("registrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationidRequired
        {
            get
            {
                return resourceProvider_tran_centralagencysyresult.GetResource("registrationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string centralagencysyresult
        {
            get
            {
                return resourceProvider_tran_centralagencysyresult.GetResource("centralagencysyresult", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string centralagencysycomment
        {
            get
            {
                return resourceProvider_tran_centralagencysyresult.GetResource("centralagencysycomment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string centralagencysyresultdate
        {
            get
            {
                return resourceProvider_tran_centralagencysyresult.GetResource("centralagencysyresultdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_tran_centralagencysyresult.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string issoftdeleted
        {
            get
            {
                return resourceProvider_tran_centralagencysyresult.GetResource("issoftdeleted", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string issoftdeletedRequired
        {
            get
            {
                return resourceProvider_tran_centralagencysyresult.GetResource("issoftdeletedRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_centralagencysyresult.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_centralagencysyresult.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
