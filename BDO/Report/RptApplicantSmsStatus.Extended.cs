using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BDO.Report
{
    public partial class RptApplicantSmsStatus
    {
        public class RptApplicationSmsStatus
        {

        }

        public RptApplicantSmsStatus(IDataReader reader)
        {
            this.loadFormLoader(reader);
        }
        protected void loadFormLoader(IDataReader reader)
        {

            if (reader != null && !reader.IsClosed)
            {
                if (!reader.IsDBNull(reader.GetOrdinal("RegistrationID"))) RegistrationID = reader.GetInt64(reader.GetOrdinal("RegistrationID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BatchNo"))) BatchNo = reader.GetInt64(reader.GetOrdinal("BatchNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) CivilId = reader.GetString(reader.GetOrdinal("CivilID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Mobile"))) mobile = reader.GetString(reader.GetOrdinal("Mobile"));
                if (!reader.IsDBNull(reader.GetOrdinal("smsSendStatus"))) smsSendStatus = reader.GetBoolean(reader.GetOrdinal("smsSendStatus"));
                if (!reader.IsDBNull(reader.GetOrdinal("smsSendDate"))) smsSendDate = reader.GetDateTime(reader.GetOrdinal("smsSendDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("emailSendStatus"))) emailSendStatus = reader.GetBoolean(reader.GetOrdinal("emailSendStatus"));
                if (!reader.IsDBNull(reader.GetOrdinal("emailSendDate"))) emailSentDate = reader.GetDateTime(reader.GetOrdinal("emailSendDate"));

                if (!reader.IsDBNull(reader.GetOrdinal("paciSendStatus"))) paciSendStatus = reader.GetBoolean(reader.GetOrdinal("paciSendStatus"));
                if (!reader.IsDBNull(reader.GetOrdinal("paciSendDate"))) paciSendDate = reader.GetDateTime(reader.GetOrdinal("paciSendDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("InterviewDate"))) InterviewDate = reader.GetDateTime(reader.GetOrdinal("InterviewDate"));


            }

        }
    }
}
