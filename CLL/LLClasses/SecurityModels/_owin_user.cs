using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.SecurityModels
{

    public class _owin_user : _Common
    {
        private static IResourceProvider resourceProvider_owin_user = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_owin_user.xml"));//DbResourceProvider(); //  


        public static string userList
        {
            get
            {
                return resourceProvider_owin_user.GetResource("userList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userCreate
        {
            get
            {
                return resourceProvider_owin_user.GetResource("userCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userUpdate
        {
            get
            {
                return resourceProvider_owin_user.GetResource("userUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userDetails
        {
            get
            {
                return resourceProvider_owin_user.GetResource("userDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string applicationid
        {
            get
            {
                return resourceProvider_owin_user.GetResource("applicationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicationidRequired
        {
            get
            {
                return resourceProvider_owin_user.GetResource("applicationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string masteruserid
        {
            get
            {
                return resourceProvider_owin_user.GetResource("masteruserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string masteruseridRequired
        {
            get
            {
                return resourceProvider_owin_user.GetResource("masteruseridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string username
        {
            get
            {
                return resourceProvider_owin_user.GetResource("username", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string usernameRequired
        {
            get
            {
                return resourceProvider_owin_user.GetResource("usernameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emailaddress
        {
            get
            {
                return resourceProvider_owin_user.GetResource("emailaddress", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emailaddressRequired
        {
            get
            {
                return resourceProvider_owin_user.GetResource("emailaddressRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string loweredusername
        {
            get
            {
                return resourceProvider_owin_user.GetResource("loweredusername", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string loweredusernameRequired
        {
            get
            {
                return resourceProvider_owin_user.GetResource("loweredusernameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string mobilenumber
        {
            get
            {
                return resourceProvider_owin_user.GetResource("mobilenumber", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userprofilephoto
        {
            get
            {
                return resourceProvider_owin_user.GetResource("userprofilephoto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isanonymous
        {
            get
            {
                return resourceProvider_owin_user.GetResource("isanonymous", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isanonymousRequired
        {
            get
            {
                return resourceProvider_owin_user.GetResource("isanonymousRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ischildenable
        {
            get
            {
                return resourceProvider_owin_user.GetResource("ischildenable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string masprivatekey
        {
            get
            {
                return resourceProvider_owin_user.GetResource("masprivatekey", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string masprivatekeyRequired
        {
            get
            {
                return resourceProvider_owin_user.GetResource("masprivatekeyRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string maspublickey
        {
            get
            {
                return resourceProvider_owin_user.GetResource("maspublickey", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string maspublickeyRequired
        {
            get
            {
                return resourceProvider_owin_user.GetResource("maspublickeyRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string password
        {
            get
            {
                return resourceProvider_owin_user.GetResource("password", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string passwordRequired
        {
            get
            {
                return resourceProvider_owin_user.GetResource("passwordRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string passwordsalt
        {
            get
            {
                return resourceProvider_owin_user.GetResource("passwordsalt", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string passwordsaltRequired
        {
            get
            {
                return resourceProvider_owin_user.GetResource("passwordsaltRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string passwordkey
        {
            get
            {
                return resourceProvider_owin_user.GetResource("passwordkey", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string passwordkeyRequired
        {
            get
            {
                return resourceProvider_owin_user.GetResource("passwordkeyRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string passwordvector
        {
            get
            {
                return resourceProvider_owin_user.GetResource("passwordvector", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string passwordvectorRequired
        {
            get
            {
                return resourceProvider_owin_user.GetResource("passwordvectorRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string mobilepin
        {
            get
            {
                return resourceProvider_owin_user.GetResource("mobilepin", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string passwordquestion
        {
            get
            {
                return resourceProvider_owin_user.GetResource("passwordquestion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string passwordanswer
        {
            get
            {
                return resourceProvider_owin_user.GetResource("passwordanswer", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string approved
        {
            get
            {
                return resourceProvider_owin_user.GetResource("approved", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string locked
        {
            get
            {
                return resourceProvider_owin_user.GetResource("locked", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string lastlogindate
        {
            get
            {
                return resourceProvider_owin_user.GetResource("lastlogindate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string lastpasschangeddate
        {
            get
            {
                return resourceProvider_owin_user.GetResource("lastpasschangeddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string lastlockoutdate
        {
            get
            {
                return resourceProvider_owin_user.GetResource("lastlockoutdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string failedpasswordattemptcount
        {
            get
            {
                return resourceProvider_owin_user.GetResource("failedpasswordattemptcount", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string comment
        {
            get
            {
                return resourceProvider_owin_user.GetResource("comment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string lastactivitydate
        {
            get
            {
                return resourceProvider_owin_user.GetResource("lastactivitydate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isreviewed
        {
            get
            {
                return resourceProvider_owin_user.GetResource("isreviewed", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reviewedby
        {
            get
            {
                return resourceProvider_owin_user.GetResource("reviewedby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reviewedbyusername
        {
            get
            {
                return resourceProvider_owin_user.GetResource("reviewedbyusername", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string revieweddate
        {
            get
            {
                return resourceProvider_owin_user.GetResource("revieweddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isapproved
        {
            get
            {
                return resourceProvider_owin_user.GetResource("isapproved", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string approvedby
        {
            get
            {
                return resourceProvider_owin_user.GetResource("approvedby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string approvedbyusername
        {
            get
            {
                return resourceProvider_owin_user.GetResource("approvedbyusername", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string approveddate
        {
            get
            {
                return resourceProvider_owin_user.GetResource("approveddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isemailconfirmed
        {
            get
            {
                return resourceProvider_owin_user.GetResource("isemailconfirmed", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emailconfirmationbyuserdate
        {
            get
            {
                return resourceProvider_owin_user.GetResource("emailconfirmationbyuserdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string twofactorenable
        {
            get
            {
                return resourceProvider_owin_user.GetResource("twofactorenable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ismobilenumberconfirmed
        {
            get
            {
                return resourceProvider_owin_user.GetResource("ismobilenumberconfirmed", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string mobilenumberconfirmedbyuserdate
        {
            get
            {
                return resourceProvider_owin_user.GetResource("mobilenumberconfirmedbyuserdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string securitystamp
        {
            get
            {
                return resourceProvider_owin_user.GetResource("securitystamp", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string concurrencystamp
        {
            get
            {
                return resourceProvider_owin_user.GetResource("concurrencystamp", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string webuseronly
        {
            get
            {
                return resourceProvider_owin_user.GetResource("webuseronly", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string newpassword
        {
            get
            {
                return resourceProvider_owin_user.GetResource("newpassword", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string confirmpassword
        {
            get
            {
                return resourceProvider_owin_user.GetResource("confirmpassword", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string passwordmissmatch
        {
            get
            {
                return resourceProvider_owin_user.GetResource("passwordmissmatch", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string fromdate
        {
            get
            {
                return resourceProvider_owin_user.GetResource("fromdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string todate
        {
            get
            {
                return resourceProvider_owin_user.GetResource("todate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string newemailaddress
        {
            get
            {
                return resourceProvider_owin_user.GetResource("newemailaddress", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string pkeyex
        {
            get
            {
                return resourceProvider_owin_user.GetResource("pkeyex", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string pkeyexRequired
        {
            get
            {
                return resourceProvider_owin_user.GetResource("pkeyexRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
    }
}
