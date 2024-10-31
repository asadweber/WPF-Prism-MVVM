using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using BDO.Core.Base;
using Newtonsoft.Json;

namespace BDO.DataAccessObjects.ApiModels
{
    [Serializable]
    [DataContract(Name = "PaciCallBackEntity", Namespace = "http://www.KAF.com/types")]
    public class PaciCallBackEntity : BaseEntity
    {
        public MIDAuthSignResponse MIDAuthSignResponse { get; set; }
    }
    [Serializable]
    public class Challenge
    {
        [DataMember]
        public string ServiceProviderID { get; set; }
        //[DataMember]
       // public string Challenge { get; set; }
        [DataMember]
        public string Datetime { get; set; }
        [DataMember]
        public string Prompt { get; set; }
    }
    [Serializable]
    public class RequestDetails
    {
        [DataMember]
        public string RequestID { get; set; }
        [DataMember]
        public string RequestType { get; set; }
        [DataMember]
        public string ServiceProviderId { get; set; }
        [DataMember]
        public Challenge Challenge { get; set; }
        [DataMember]
        public string CivilNo { get; set; }
    }
    [Serializable]
    public class ResultDetails
    {
        [DataMember]
        public string ResultCode { get; set; }
        [DataMember]
        public string UserAction { get; set; }
        [DataMember]
        public string UserCivilNo { get; set; }
        [DataMember]
        public string UserCertificate { get; set; }
        [DataMember]
        public string SignatureData { get; set; }
        [DataMember]
        public string HashAlgorithm { get; set; }
        [DataMember]
        public string SigningDatatype { get; set; }
        [DataMember]
        public DateTime TransactionDate { get; set; }

    }
    [Serializable]
    public class GovData
    {
        [DataMember]
        public DateTime CivilIdExpiryDate { get; set; }
        [DataMember]
        [JsonProperty("MOIReference ")]
        public string MOIReference { get; set; }
        [DataMember]
        public string SponsorName { get; set; }
    }
    [Serializable]
    public class Address
    {
        [DataMember]
        public string Governerate { get; set; }
        [DataMember]
        public string Area { get; set; }
        [DataMember]
        public string PaciBuildingNumber { get; set; }
        [DataMember]
        public string BuildingType { get; set; }
        [DataMember]
        public string FloorNumber { get; set; }
        [DataMember]
        public string BuildingNumber { get; set; }
        [DataMember]
        public string BlockNumber { get; set; }
        [DataMember]
        public string UnitNumber { get; set; }
        [DataMember]
        public string StreetName { get; set; }
        [DataMember]
        public string UnitType { get; set; }
    }
    [Serializable]
    public class PersonalData
    {
        [DataMember]
        public string CivilID { get; set; }
        [DataMember]
        public string FullNameAr { get; set; }
        [DataMember]
        public string FullNameEn { get; set; }
        [DataMember]
        public string NationalityEn { get; set; }
        [DataMember]
        public string NationalityAr { get; set; }
        [DataMember]
        public DateTime BirthDate { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public string MobileNumber { get; set; }
        [DataMember]
        public string EmailAddress { get; set; }
        [DataMember]
        public string BloodGroup { get; set; }
        [DataMember]
        public string Photo { get; set; }
        [DataMember]
        public DateTime CardExpiryDate { get; set; }
        [DataMember]
        public string DocumentNumber { get; set; }
        [DataMember]
        public string PassportNumber { get; set; }
        [DataMember]
        public GovData GovData { get; set; }
        [DataMember]
        public Address Address { get; set; }
    }
    [Serializable]
    public class Signature
    {
        [DataMember]
        public string SignatureData { get; set; }
        [DataMember]
        public string SigningCertificate { get; set; }
    }
    [Serializable]
    public class MIDAuthSignResponse
    {
        [DataMember]
        public RequestDetails RequestDetails { get; set; }
        [DataMember]
        public ResultDetails ResultDetails { get; set; }
        [DataMember]
        public PersonalData PersonalData { get; set; }
        [DataMember]
        public Signature Signature { get; set; }
    }

  

}