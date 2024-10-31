using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _reg_registrationinfo : _Common
    {
        private static IResourceProvider resourceProvider_reg_registrationinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_reg_registrationinfo.xml"));//DbResourceProvider(); //  


        public static string registrationinfoList
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("registrationinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationinfoCreate
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("registrationinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationinfoUpdate
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("registrationinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationinfoDetails
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("registrationinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string registrationid
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("registrationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoid
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("basicinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoidRequired
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("basicinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string applicationdate
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("applicationdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string appliedfromip
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("appliedfromip", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isactive
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string idtype
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("idtype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string idissuedate
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("idissuedate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string idexpirydate
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("idexpirydate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchcandidatetypemapid
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("batchcandidatetypemapid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchid
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("batchid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string candidatetypeid
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("candidatetypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchcandprofessionmapid
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("batchcandprofessionmapid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string professionid
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("professionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchunitlistid
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("batchunitlistid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string entitykey
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("entitykey", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isspecialregistration
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("isspecialregistration", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isfinal
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("isfinal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string submitteddate
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("submitteddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isexported
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("isexported", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string exporteddate
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("exporteddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string exportedby
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("exportedby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string remarks
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string updateinfo
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("updateinfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tranformactionid
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("tranformactionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string auditresult
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("auditresult", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string auditcomment
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("auditcomment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string auditdate
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("auditdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string issecurityforwarded
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("issecurityforwarded", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string issyresultexpired
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("issyresultexpired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string issyretestapproved
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("issyretestapproved", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ismedresultexpired
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("ismedresultexpired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ismedretestapproved
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("ismedretestapproved", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ispsychoresultexpired
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("ispsychoresultexpired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ispsychoretestapproved
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("ispsychoretestapproved", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string centralagencysyresult
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("centralagencysyresult", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string centralagencysycomment
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("centralagencysycomment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string centralagencysyresultdate
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("centralagencysyresultdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string syexamresult
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("syexamresult", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string syexamcomment
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("syexamcomment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string syexamresultdate
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("syexamresultdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string syprofileprint
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("syprofileprint", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isunitforwarded
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("isunitforwarded", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string unitclearanceresult
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("unitclearanceresult", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string unitclearanceresultDate
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("unitclearanceresultDate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string unitclearancemark
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("unitclearancemark", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string unitclearancecomment
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("unitclearancecomment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ismedforwarded
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("ismedforwarded", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string medexamresult
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("medexamresult", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string medexamcomment
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("medexamcomment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string medexamresultdate
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("medexamresultdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string medexamformprint
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("medexamformprint", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string psychoexamresult
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("psychoexamresult", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string psychoexamcomment
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("psychoexamcomment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string psychoexamResultDate
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("psychoexamResultDate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string finalexamresult
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("finalexamresult", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string finalexamcomment
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("finalexamcomment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string finalexamResultDate
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("finalexamResultDate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string istrgjoinenabled
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("istrgjoinenabled", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string professionselectmessage
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("professionselectmessage", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sendtosecurity
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("sendtosecurity", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sendtounit
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("sendtounit", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string showdocument
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("showdocument", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string showprofilereport
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("showprofilereport", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string notificationstatus
        {
            get
            {
                return resourceProvider_reg_registrationinfo.GetResource("notificationstatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

    }
}