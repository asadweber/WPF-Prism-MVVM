using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_applyanotherbatch : _Common
    {
         private static IResourceProvider resourceProvider_tran_applyanotherbatch = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_applyanotherbatch.xml"));//DbResourceProvider(); //  
         
         
        public static string applyanotherbatchList
        {
            get
            {
                return resourceProvider_tran_applyanotherbatch.GetResource("applyanotherbatchList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applyanotherbatchCreate
        {
            get
            {
                return resourceProvider_tran_applyanotherbatch.GetResource("applyanotherbatchCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applyanotherbatchUpdate
        {
            get
            {
                return resourceProvider_tran_applyanotherbatch.GetResource("applyanotherbatchUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applyanotherbatchDetails
        {
            get
            {
                return resourceProvider_tran_applyanotherbatch.GetResource("applyanotherbatchDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string applyanotherbatchid
        {
            get
            {
                return resourceProvider_tran_applyanotherbatch.GetResource("applyanotherbatchid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applyanotherbatchidRequired
        {
            get
            {
                return resourceProvider_tran_applyanotherbatch.GetResource("applyanotherbatchidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_tran_applyanotherbatch.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_tran_applyanotherbatch.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string registrationid
        {
            get
            {
                return resourceProvider_tran_applyanotherbatch.GetResource("registrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationidRequired
        {
            get
            {
                return resourceProvider_tran_applyanotherbatch.GetResource("registrationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string batchid
        {
            get
            {
                return resourceProvider_tran_applyanotherbatch.GetResource("batchid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchidRequired
        {
            get
            {
                return resourceProvider_tran_applyanotherbatch.GetResource("batchidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string oldbatchid
        {
            get
            {
                return resourceProvider_tran_applyanotherbatch.GetResource("oldbatchid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string candidatetypeid
        {
            get
            {
                return resourceProvider_tran_applyanotherbatch.GetResource("candidatetypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string candidatetypeidRequired
        {
            get
            {
                return resourceProvider_tran_applyanotherbatch.GetResource("candidatetypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string professionid
        {
            get
            {
                return resourceProvider_tran_applyanotherbatch.GetResource("professionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string nationalityid
        {
            get
            {
                return resourceProvider_tran_applyanotherbatch.GetResource("nationalityid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string nationalityidRequired
        {
            get
            {
                return resourceProvider_tran_applyanotherbatch.GetResource("nationalityidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_tran_applyanotherbatch.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string issoftdeleted
        {
            get
            {
                return resourceProvider_tran_applyanotherbatch.GetResource("issoftdeleted", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string issoftdeletedRequired
        {
            get
            {
                return resourceProvider_tran_applyanotherbatch.GetResource("issoftdeletedRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_applyanotherbatch.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_applyanotherbatch.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
