using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _reg_basicinfo : _Common
    {
         private static IResourceProvider resourceProvider_reg_basicinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_reg_basicinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string basicinfoList
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("basicinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoCreate
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("basicinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoUpdate
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("basicinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoDetails
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("basicinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string civilid
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("civilid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilidRequired
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("civilidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passportno
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("passportno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fullname
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("fullname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fullnameRequired
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("fullnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name1
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("name1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string name1Required
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("name1Required", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name2
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("name2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string name2Required
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("name2Required", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name3
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("name3", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name4
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("name4", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name5
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("name5", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string dob
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("dob", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string dobRequired
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("dobRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string birthcountryid
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("birthcountryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string gender
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("gender", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string mob1
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("mob1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string mob1Required
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("mob1Required", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string mob2
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("mob2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string mob3
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("mob3", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string telephone1
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("telephone1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string telephone2
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("telephone2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string telephone3
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("telephone3", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string email
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("email", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string preaddcountryid
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("preaddcountryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string preaddgovernid
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("preaddgovernid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string preaddgovernarate
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("preaddgovernarate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string preaddcityid
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("preaddcityid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string preaddcity
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("preaddcity", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string preaddstreet
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("preaddstreet", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string preaddblock
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("preaddblock", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string preaddhousingno
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("preaddhousingno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string preaddhousingflatno
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("preaddhousingflatno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string preaddress
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("preaddress", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string prepaci
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("prepaci", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string pres_latitude
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("pres_latitude", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string pres_longitude
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("pres_longitude", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string peraddcountryid
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("peraddcountryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string peraddgovernid
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("peraddgovernid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string peraddcityid
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("peraddcityid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string peraddstreet
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("peraddstreet", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string peraddblock
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("peraddblock", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string peraddhousingno
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("peraddhousingno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string peraddhousingflatno
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("peraddhousingflatno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string perpaci
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("perpaci", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string peraddress
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("peraddress", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string perm_latitude
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("perm_latitude", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string perm_longitude
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("perm_longitude", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string maritalstatus
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("maritalstatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string maritalstatusRequired
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("maritalstatusRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string nationalid
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("nationalid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string nationaldate
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("nationaldate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string countrynationalityid
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("countrynationalityid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string countryclassid
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("countryclassid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string residenttypeid
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("residenttypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bloodgroupid
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("bloodgroupid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string relogionid
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("relogionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filepath
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("filepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filename
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("filename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filetype
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("filetype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string extension
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("extension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string userid
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("userid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }       

    }
}
