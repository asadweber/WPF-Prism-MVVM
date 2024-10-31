using System;
using System.Globalization;
using System.IO;
using CLL.Abstract;

namespace CLL.LLClasses.Models
{

    public class _PreRegistrationResource : _Common
    {
        private static IResourceProvider resourceProvider_gen_batch = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"LanguagesFiles/_PreRegistration.xml"));//DbResourceProvider(); //  



        public static string ErrorTitle
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("ErrorTitle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string SuccessTitle
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("SuccessTitle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string DataRequiredError
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("DataRequiredError", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string DataRequiredErrorAdmin
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("DataRequiredErrorAdmin", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string Batches
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Batches", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string CandidateType
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("CandidateType", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string Profession
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Profession", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ResidentType
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("ResidentType", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string BatchInfoHr
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("BatchInfoHr", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string BasicInfoHr
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("BasicInfoHr", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string WorkingInfoHr
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("WorkingInfoHr", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string CurrentAddress
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("CurrentAddress", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string Nationality
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Nationality", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string Nationality_Class
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Nationality_Class", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string PassportNo
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("PassportNo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string CivilId
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("CivilId", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string SonOfSoldierFatherWorkingStatus
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("SonOfSoldierFatherWorkingStatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string SonOfSoldierFatherMilitaryWorkingStatus
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("SonOfSoldierFatherMilitaryWorkingStatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string FatherMilitaryId
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("FatherMilitaryId", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string ReTypeCivilId
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("ReTypeCivilId", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ReTypeSameCivilIdError
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("ReTypeSameCivilIdError", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        

        public static string SecurityIDNumber
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("SecurityIDNumber", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ReTypeSecurityIDNumber
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("ReTypeSecurityIDNumber", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string SelectedIdType
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("SelectedIdType", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string IdExpiredDate
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("IdExpiredDate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string CivilIdExistingAlert
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("CivilIdExistingAlert", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string FirstName
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("FirstName", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string SecondName
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("SecondName", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string ThirdName
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("ThirdName", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string FourthName
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("FourthName", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string LastName
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("LastName", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string FatherInfoHr
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("FatherInfoHr", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string FatherWife
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("FatherWife", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string MotherHusband
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("MotherHusband", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string FatherWifeInfoHr
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("FatherWifeInfoHr", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string MotherHusbandInfoHr
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("MotherHusbandInfoHr", CultureInfo.CurrentUICulture.Name) as String;
            }
        }



        public static string FinalSubmitHr
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("FinalSubmitHr", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string Submit
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Submit", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string MotherInfoHr
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("MotherInfoHr", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string EducationInfoHeader
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("EducationInfoHeader", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string CertificateLevel
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("CertificateLevel", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string Certificate
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Certificate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string MajorCertificate
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("MajorCertificate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string CertificateIssueDate
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("CertificateIssueDate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string QualificationCountry
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("QualificationCountry", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string Grade
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Grade", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string DateOfBirth
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("DateOfBirth", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string MaritalStatus
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("MaritalStatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string BloodGroup
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("BloodGroup", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string Religion
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Religion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string PlaceOfBirth
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("PlaceOfBirth", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string GPAResult
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("GPAResult", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string CurrentlyStudyingStatus
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("CurrentlyStudyingStatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string CurrentlyNotStudying
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("CurrentlyNotStudying", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string CurrentlyStudying
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("CurrentlyStudying", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string chkSonOfMilitary
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("chkSonOfMilitary", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string chkSonOfDeadMilitary
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("chkSonOfDeadMilitary", CultureInfo.CurrentUICulture.Name) as String;
            }
        }





        public static string SemisterInfo
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("SemisterInfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string InstituteInfo
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("InstituteInfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string Mobile
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Mobile", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string Mobile1
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Mobile1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string Mobile1_Retype
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Mobile1_Retype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string Mobile1_RetypeError
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Mobile1_RetypeError", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string Mobile2
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Mobile2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string Mobile2_Retype
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Mobile2_Retype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string Mobile2_RetypeError
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Mobile2_RetypeError", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string Telephone
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Telephone", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string Telephone1
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Telephone1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string Telephone1_Retype
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Telephone1_Retype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string Telephone1_RetypeError
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Telephone1_RetypeError", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string CurrentlyKuwaitLivingStatus
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("CurrentlyKuwaitLivingStatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string Country
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Country", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string Governate
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Governate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string City
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("City", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string Block
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Block", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string Street
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Street", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string AvenueNo
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("AvenueNo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string BuildingNo
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("BuildingNo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string FlatNo
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("FlatNo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string PACINo
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("PACINo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string OtherAddress
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("OtherAddress", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string BatchIdRequired
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("BatchIdRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string CredentialInformationHrInfo
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("CredentialInformationHrInfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string UserName
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("UserName", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

		

		public static string VerificationCode
		{
			get
			{
				return resourceProvider_gen_batch.GetResource("VerificationCode", CultureInfo.CurrentUICulture.Name) as String;
			}
		}

		public static string ConfirmMobileNumber
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("ConfirmMobileNumber", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string Email
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Email", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string RetypeEmail
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("RetypeEmail", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string Password
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Password", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string ConfirmPassword
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("ConfirmPassword", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string ShowPassword
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("ShowPassword", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string ReTypeSamePasswordError
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("ReTypeSamePasswordError", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string MinimunPasswordLengthError
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("MinimunPasswordLengthError", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string ReTypeSameEmailError
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("ReTypeSameEmailError", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string MobileNumberExistsErrorMsg
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("MobileNumberExistsErrorMsg", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string EmailExistsErrorMsg
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("EmailExistsErrorMsg", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string ContactInformation
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("ContactInformation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string NonKuwaityStatusHr
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("NonKuwaityStatusHr", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string BrotherInfoHeader
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("BrotherInfoHeader", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string SisterInfoHeader
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("SisterInfoHeader", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string Relationship
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Relationship", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string PaternalUncleInfoHeader
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("PaternalUncleInfoHeader", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string PaternalAuntyInfoHeader
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("PaternalAuntyInfoHeader", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string MaternalUncleInfoHeader
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("MaternalUncleInfoHeader", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string MaternalAuntyInfoHeader
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("MaternalAuntyInfoHeader", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string SpouseInfoHeader
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("SpouseInfoHeader", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string SpouseInfoList
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("SpouseInfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string EmergencyContactInfo
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("EmergencyContactInfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string DocumentInfo
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("DocumentInfo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string UploadDocuments
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("UploadDocuments", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string CivilIdAttachment
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("CivilIdAttachment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string BasicProfileAttachment
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("BasicProfileAttachment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string CertificateDocuments
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("CertificateDocuments", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string Documents
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("Documents", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string CompanyType
		{
			get
			{
				return resourceProvider_gen_batch.GetResource("CompanyType", CultureInfo.CurrentUICulture.Name) as String;
			}
		}
		public static string Designation
		{
			get
			{
				return resourceProvider_gen_batch.GetResource("Designation", CultureInfo.CurrentUICulture.Name) as String;
			}
		}

        public static string MotherDocument
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("MotherDocument", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string FatherDocument
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("FatherDocument", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string SpouseDocument
        {
            get
            {
                return resourceProvider_gen_batch.GetResource("SpouseDocument", CultureInfo.CurrentUICulture.Name) as String;
            }
        }



    }
}
