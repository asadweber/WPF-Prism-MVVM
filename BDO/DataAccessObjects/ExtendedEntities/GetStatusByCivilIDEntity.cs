using BDO.Core.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace BDO.DataAccessObjects.ExtendedEntities
{
    /// <summary>
    /// This object represents the properties and methods of a GetStatusByCivilID.
    /// </summary>
    [Serializable]
    [DataContract(Name = "GetStatusByCivilIDEntity", Namespace = "http://www.11.com/types")]
    public class GetStatusByCivilIDEntity : BaseEntity
    {
        [DataMember]
        public string civilid { get; set; }
        [DataMember]
        public long? basicinfoid { get; set; }
        [DataMember]
        public string name1 { get; set; }
        [DataMember]
        public string name2 { get; set; }
        [DataMember]
        public string name3 { get; set; }
        [DataMember]
        public string name4 { get; set; }
        [DataMember]
        public string name5 { get; set; }
        [DataMember]
        public string fullname { get; set; }
        [DataMember]
        public string nationalid { get; set; }
        [DataMember]
        public DateTime? dob { get; set; }
        [DataMember]
        public string age { get; set; }
        [DataMember]
        public string prepaci { get; set; }
        [DataMember]
        public string mob1 { get; set; }
        [DataMember]
        public string telephone1 { get; set; }
        [DataMember]
        public string telephone3 { get; set; }
        [DataMember]
        public string maritalstatus { get; set; }
        [DataMember]
        public long? certificateid { get; set; }
        [DataMember]
        public string certificatename { get; set; }
        [DataMember]
        public long? certificatesubjectid { get; set; }
        [DataMember]
        public string certificatesubjectname { get; set; }
        [DataMember]
        public string gvname { get; set; }
        [DataMember]
        public string cityname { get; set; }
        [DataMember]
        public string preaddstreet { get; set; }
        [DataMember]
        public string preaddblock { get; set; }
        [DataMember]
        public string preaddhousingno { get; set; }
        [DataMember]
        public string preaddhousingflatno { get; set; }
        [DataMember]
        public string preaddress { get; set; }
        [DataMember]
        public long? casestatusid { get; set; }
        [DataMember]
        public string caseno { get; set; }
        [DataMember]
        public DateTime? caseexpirydate { get; set; }
        [DataMember]
        public string casestatus { get; set; }
        [DataMember]
        public DateTime? createddate { get; set; }

        public GetStatusByCivilIDEntity()
        {
        }

        public GetStatusByCivilIDEntity(IDataReader ireader)
        {
            //LoadFromReader(ireader);
            LoadFromReaderREF(ireader);
        }

        protected void LoadFromReaderREF(IDataReader reader)
        {
            //SqlDataReader reader = (SqlDataReader)ireader;
            if (reader != null && !reader.IsClosed)
            {
                if (!reader.IsDBNull(reader.GetOrdinal("civilid"))) civilid = reader.GetString(reader.GetOrdinal("civilid"));
                if (!reader.IsDBNull(reader.GetOrdinal("basicinfoid"))) basicinfoid = reader.GetInt64(reader.GetOrdinal("basicinfoid"));
                if (!reader.IsDBNull(reader.GetOrdinal("name1"))) name1 = reader.GetString(reader.GetOrdinal("name1"));
                if (!reader.IsDBNull(reader.GetOrdinal("name2"))) name2 = reader.GetString(reader.GetOrdinal("name2"));
                if (!reader.IsDBNull(reader.GetOrdinal("name3"))) name3 = reader.GetString(reader.GetOrdinal("name3"));
                if (!reader.IsDBNull(reader.GetOrdinal("name4"))) name4 = reader.GetString(reader.GetOrdinal("name4"));
                if (!reader.IsDBNull(reader.GetOrdinal("name5"))) name5 = reader.GetString(reader.GetOrdinal("name5"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) fullname = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("nationalid"))) nationalid = reader.GetString(reader.GetOrdinal("nationalid"));
                if (!reader.IsDBNull(reader.GetOrdinal("dob"))) dob = reader.GetDateTime(reader.GetOrdinal("dob"));
                if (!reader.IsDBNull(reader.GetOrdinal("Age"))) age = reader.GetString(reader.GetOrdinal("Age"));
                if (!reader.IsDBNull(reader.GetOrdinal("prepaci"))) prepaci = reader.GetString(reader.GetOrdinal("prepaci"));
                if (!reader.IsDBNull(reader.GetOrdinal("mob1"))) mob1 = reader.GetString(reader.GetOrdinal("mob1"));
                if (!reader.IsDBNull(reader.GetOrdinal("telephone1"))) telephone1 = reader.GetString(reader.GetOrdinal("telephone1"));
                if (!reader.IsDBNull(reader.GetOrdinal("telephone3"))) telephone3 = reader.GetString(reader.GetOrdinal("telephone3"));
                if (!reader.IsDBNull(reader.GetOrdinal("maritalstatus"))) maritalstatus = reader.GetString(reader.GetOrdinal("maritalstatus"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateID"))) certificateid = reader.GetInt64(reader.GetOrdinal("CertificateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("certificatename"))) certificatename = reader.GetString(reader.GetOrdinal("certificatename"));
                if (!reader.IsDBNull(reader.GetOrdinal("CertificateSubjectID"))) certificatesubjectid = reader.GetInt64(reader.GetOrdinal("CertificateSubjectID"));
                if (!reader.IsDBNull(reader.GetOrdinal("certificatesubjectname"))) certificatesubjectname = reader.GetString(reader.GetOrdinal("certificatesubjectname"));
                if (!reader.IsDBNull(reader.GetOrdinal("GvName"))) gvname = reader.GetString(reader.GetOrdinal("GvName"));
                if (!reader.IsDBNull(reader.GetOrdinal("cityname"))) cityname = reader.GetString(reader.GetOrdinal("cityname"));
                if (!reader.IsDBNull(reader.GetOrdinal("preaddstreet"))) preaddstreet = reader.GetString(reader.GetOrdinal("preaddstreet"));
                if (!reader.IsDBNull(reader.GetOrdinal("preaddblock"))) preaddblock = reader.GetString(reader.GetOrdinal("preaddblock"));
                if (!reader.IsDBNull(reader.GetOrdinal("preaddhousingno"))) preaddhousingno = reader.GetString(reader.GetOrdinal("preaddhousingno"));
                if (!reader.IsDBNull(reader.GetOrdinal("preaddhousingflatno"))) preaddhousingflatno = reader.GetString(reader.GetOrdinal("preaddhousingflatno"));
                if (!reader.IsDBNull(reader.GetOrdinal("preaddress"))) preaddress = reader.GetString(reader.GetOrdinal("preaddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("CaseStatusID"))) casestatusid = reader.GetInt64(reader.GetOrdinal("CaseStatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CaseNo"))) caseno = reader.GetString(reader.GetOrdinal("CaseNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("CaseExpiryDate"))) caseexpirydate = reader.GetDateTime(reader.GetOrdinal("CaseExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("CaseStatus"))) casestatus = reader.GetString(reader.GetOrdinal("CaseStatus"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
            }
        }



    }

}
