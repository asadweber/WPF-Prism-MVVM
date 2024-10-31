using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{
    
    public  class _reg_familly : _Common
    {
         private static IResourceProvider resourceProvider_reg_familly = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_reg_familly.xml"));//DbResourceProvider(); //  
         
         
        public static string famillyList
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("famillyList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string famillyCreate
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("famillyCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string famillyUpdate
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("famillyUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string famillyDetails
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("famillyDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string parentid
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("parentid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isinkuwait
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("isinkuwait", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isinkuwaitRequired
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("isinkuwaitRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string basicinfoid
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string relationshipid
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("relationshipid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string relationshipidRequired
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("relationshipidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familygenderid
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("familygenderid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familyreligionid
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("familyreligionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familybloodgroupid
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("familybloodgroupid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string maritalstatusid
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("maritalstatusid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string parentalstatus
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("parentalstatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string nationalityid
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("nationalityid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string classid
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("classid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string birthcountryid
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("birthcountryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string prevnationalityid
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("prevnationalityid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string birthdate
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("birthdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string civilid
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("civilid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string nationalid
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("nationalid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passportnumber
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("passportnumber", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fullname
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("fullname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name1
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("name1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name2
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("name2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name3
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("name3", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name4
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("name4", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name5
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("name5", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isservedinmilitary
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("isservedinmilitary", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isserving
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("isserving", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string splmilstatus
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("splmilstatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string militaryid
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("militaryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string companyid
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("companyid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string workdesignation
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("workdesignation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string workcompany
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("workcompany", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string companytype
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("companytype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string companyaddress
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("companyaddress", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string enrollmentdate
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("enrollmentdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string previousjob
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("previousjob", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string previousjobdetails
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("previousjobdetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string preaddcountryid
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("preaddcountryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string preaddgovernid
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("preaddgovernid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string preaddgovernarate
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("preaddgovernarate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string preaddcityid
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("preaddcityid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string preaddcity
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("preaddcity", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string preaddstreet
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("preaddstreet", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string preaddblock
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("preaddblock", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string preaddhousingno
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("preaddhousingno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string preaddhousingflatno
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("preaddhousingflatno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string prepaci
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("prepaci", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string preaddress
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("preaddress", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string pres_latitude
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("pres_latitude", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string pres_longitude
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("pres_longitude", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string peraddcountryid
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("peraddcountryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string peraddgovernid
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("peraddgovernid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string peraddcityid
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("peraddcityid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string peraddstreet
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("peraddstreet", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string peraddblock
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("peraddblock", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string peraddhousingno
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("peraddhousingno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string peraddhousingflatno
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("peraddhousingflatno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string perpaci
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("perpaci", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string peraddress
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("peraddress", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string perm_latitude
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("perm_latitude", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string perm_longitude
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("perm_longitude", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string email
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("email", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string mobilephone1
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("mobilephone1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string mobilephone2
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("mobilephone2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string mobilephone3
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("mobilephone3", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string lanphone1
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("lanphone1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string lanphone2
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("lanphone2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string lanphone3
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("lanphone3", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ismarried
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("ismarried", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familymarriagedate
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("familymarriagedate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familymarriagedocno
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("familymarriagedocno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familymarriagedocdate
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("familymarriagedocdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string deathdate
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("deathdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isalive
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("isalive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isfatherside
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("isfatherside", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ismotherside
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("ismotherside", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filepath
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("filepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filename
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("filename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filetype
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("filetype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string extension
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("extension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string securitycardvaliddate
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("securitycardvaliddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comment
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string updateinfo
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tranformactionid
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string spousename
        {
            get
            {
                return resourceProvider_reg_familly.GetResource("spousename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

    }
}
