using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDO.Core.DataAccessObjects.ExtendedEntities
{
    [Serializable]

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class RequestDetails
    {
        public string RequestID { get; set; }
        public string RequestType { get; set; }
        public string ServiceProviderId { get; set; }
        public string Challenge { get; set; }
        public string CivilNo { get; set; }
    }
    [Serializable]

    public class ResultDetails
    {
        public string ResultCode { get; set; }
        public string UserAction { get; set; }
        public string UserCivilNo { get; set; }
        public string UserCertificate { get; set; }
        public string SignatureData { get; set; }
        public string HashAlgorithm { get; set; }
        public string SigningDatatype { get; set; }
        public DateTime TransactionDate { get; set; }
    }
    [Serializable]

    public class GovData
    {
        public DateTime CivilIdExpiryDate { get; set; }
        public string MOIReference { get; set; }
        public string SponsorName { get; set; }
    }
    [Serializable]

    public class Address
    {
        public string Governerate { get; set; }
        public string Area { get; set; }
        public string PaciBuildingNumber { get; set; }
        public string BuildingType { get; set; }
        public string FloorNumber { get; set; }
        public string BuildingNumber { get; set; }
        public string BlockNumber { get; set; }
        public string UnitNumber { get; set; }
        public string StreetName { get; set; }
        public string UnitType { get; set; }
    }
    [Serializable]

    public class PersonalData
    {
        public string CivilID { get; set; }
        public string FullNameAr { get; set; }
        public string FullNameEn { get; set; }
        public string NationalityEn { get; set; }
        public string NationalityAr { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string BloodGroup { get; set; }
        public string Photo { get; set; }
        public DateTime CardExpiryDate { get; set; }
        public string DocumentNumber { get; set; }  
        public string PassportNumber { get; set; }
        public GovData GovData { get; set; }
        public Address Address { get; set; }
    }
    [Serializable]

    public class Signature
    {
        public string SignatureData { get; set; }
        public string SigningCertificate { get; set; }
    }
    [Serializable]

    public class MIDAuthSignResponse
    {
        public RequestDetails RequestDetails { get; set; }
        public ResultDetails ResultDetails { get; set; }
        public PersonalData PersonalData { get; set; }
        public Signature Signature { get; set; }
    }
    [Serializable]

    public class Root
    {
        public MIDAuthSignResponse MIDAuthSignResponse { get; set; }
    }


}
