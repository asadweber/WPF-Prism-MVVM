using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _tran_trainingjoin : _Common
    {
         private static IResourceProvider resourceProvider_tran_trainingjoin = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_tran_trainingjoin.xml"));//DbResourceProvider(); //  
         
         
        public static string trainingjoinList
        {
            get
            {
                return resourceProvider_tran_trainingjoin.GetResource("trainingjoinList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string trainingjoinCreate
        {
            get
            {
                return resourceProvider_tran_trainingjoin.GetResource("trainingjoinCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string trainingjoinUpdate
        {
            get
            {
                return resourceProvider_tran_trainingjoin.GetResource("trainingjoinUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string trainingjoinDetails
        {
            get
            {
                return resourceProvider_tran_trainingjoin.GetResource("trainingjoinDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_tran_trainingjoin.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_tran_trainingjoin.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string registrationid
        {
            get
            {
                return resourceProvider_tran_trainingjoin.GetResource("registrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationidRequired
        {
            get
            {
                return resourceProvider_tran_trainingjoin.GetResource("registrationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string trgcentreid
        {
            get
            {
                return resourceProvider_tran_trainingjoin.GetResource("trgcentreid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string trgcentreidRequired
        {
            get
            {
                return resourceProvider_tran_trainingjoin.GetResource("trgcentreidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string joindate
        {
            get
            {
                return resourceProvider_tran_trainingjoin.GetResource("joindate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string joindateRequired
        {
            get
            {
                return resourceProvider_tran_trainingjoin.GetResource("joindateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string volunteerno
        {
            get
            {
                return resourceProvider_tran_trainingjoin.GetResource("volunteerno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string volunteernoRequired
        {
            get
            {
                return resourceProvider_tran_trainingjoin.GetResource("volunteernoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string groupno
        {
            get
            {
                return resourceProvider_tran_trainingjoin.GetResource("groupno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string joiningbatchid
        {
            get
            {
                return resourceProvider_tran_trainingjoin.GetResource("joiningbatchid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string joiningbatchidRequired
        {
            get
            {
                return resourceProvider_tran_trainingjoin.GetResource("joiningbatchidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string orderno
        {
            get
            {
                return resourceProvider_tran_trainingjoin.GetResource("orderno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ordernoRequired
        {
            get
            {
                return resourceProvider_tran_trainingjoin.GetResource("ordernoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string orderdate
        {
            get
            {
                return resourceProvider_tran_trainingjoin.GetResource("orderdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string orderdateRequired
        {
            get
            {
                return resourceProvider_tran_trainingjoin.GetResource("orderdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string remarks
        {
            get
            {
                return resourceProvider_tran_trainingjoin.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string issoftdeleted
        {
            get
            {
                return resourceProvider_tran_trainingjoin.GetResource("issoftdeleted", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string issoftdeletedRequired
        {
            get
            {
                return resourceProvider_tran_trainingjoin.GetResource("issoftdeletedRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_tran_trainingjoin.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_tran_trainingjoin.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
