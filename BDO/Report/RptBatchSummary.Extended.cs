using System;
using System.Collections.Generic;
using System.Data;
using System.Text;



namespace BDO.Report
{
    public partial class RptBatchSummary
    {

        public RptBatchSummary()
        {

        }
       public RptBatchSummary(IDataReader reader ){
            this.loadFormReader( reader );
        }
        protected void loadFormReader(IDataReader reader)
        {
            if( reader != null && !reader.IsClosed)
            {
                
                if (!reader.IsDBNull(reader.GetOrdinal("BatchNo"))) batchid = reader.GetInt64(reader.GetOrdinal("BatchNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("Registered"))) Registered = reader.GetInt32(reader.GetOrdinal("Registered"));
                if (!reader.IsDBNull(reader.GetOrdinal("Submitted"))) Submitted = reader.GetInt32(reader.GetOrdinal("Submitted"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewPassed"))) ReviewPassed = reader.GetInt32(reader.GetOrdinal("ReviewPassed"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewFailed"))) ReviewFailed = reader.GetInt32(reader.GetOrdinal("ReviewFailed"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewWaiting"))) ReviewWaiting = reader.GetInt32(reader.GetOrdinal("ReviewWaiting"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReviewRollback"))) ReviewRollback = reader.GetInt32(reader.GetOrdinal("ReviewRollback"));
                if (!reader.IsDBNull(reader.GetOrdinal("TotalReadyForSecurity"))) TotalReadyForSecurity = reader.GetInt32(reader.GetOrdinal("TotalReadyForSecurity"));
                if (!reader.IsDBNull(reader.GetOrdinal("TotalForwardedForSecurity"))) TotalForwardedForSecurity = reader.GetInt32(reader.GetOrdinal("TotalForwardedForSecurity"));
                if (!reader.IsDBNull(reader.GetOrdinal("SecurityPassed"))) SecurityPassed = reader.GetInt32(reader.GetOrdinal("SecurityPassed"));
                if (!reader.IsDBNull(reader.GetOrdinal("SecurityFailed"))) SecurityFailed = reader.GetInt32(reader.GetOrdinal("SecurityFailed"));
                if (!reader.IsDBNull(reader.GetOrdinal("SecurityWaiting"))) SecurityWaiting = reader.GetInt32(reader.GetOrdinal("SecurityWaiting"));
                if (!reader.IsDBNull(reader.GetOrdinal("SecurityRollback"))) SecurityRollback = reader.GetInt32(reader.GetOrdinal("SecurityRollback"));
                if (!reader.IsDBNull(reader.GetOrdinal("TotalReadyForUnit"))) TotalReadyForUnit = reader.GetInt32(reader.GetOrdinal("TotalReadyForUnit"));
                if (!reader.IsDBNull(reader.GetOrdinal("TotalForwardedForUnit"))) TotalForwardedForUnit = reader.GetInt32(reader.GetOrdinal("TotalForwardedForUnit"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnitPassed"))) UnitPassed = reader.GetInt32(reader.GetOrdinal("UnitPassed"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnitFailed"))) UnitFailed = reader.GetInt32(reader.GetOrdinal("UnitFailed"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnitWaiting"))) UnitWaiting = reader.GetInt32(reader.GetOrdinal("UnitWaiting"));
                if (!reader.IsDBNull(reader.GetOrdinal("UnitRollback"))) UnitRollback = reader.GetInt32(reader.GetOrdinal("UnitRollback"));
                if (!reader.IsDBNull(reader.GetOrdinal("TotalReadyForMedical"))) TotalReadyForMedical = reader.GetInt32(reader.GetOrdinal("TotalReadyForMedical"));
                if (!reader.IsDBNull(reader.GetOrdinal("TotalForwardedForMedical"))) TotalForwardedForMedical = reader.GetInt32(reader.GetOrdinal("TotalForwardedForMedical"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedicalPassed"))) MedicalPassed = reader.GetInt32(reader.GetOrdinal("MedicalPassed"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedicalFailed"))) MedicalFailed = reader.GetInt32(reader.GetOrdinal("MedicalFailed"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedicalWaiting"))) MedicalWaiting = reader.GetInt32(reader.GetOrdinal("MedicalWaiting"));
                if (!reader.IsDBNull(reader.GetOrdinal("MedicalRollback"))) MedicalRollback = reader.GetInt32(reader.GetOrdinal("MedicalRollback"));
                if (!reader.IsDBNull(reader.GetOrdinal("FinlaExamPassed"))) FinlaExamPassed = reader.GetInt32(reader.GetOrdinal("FinlaExamPassed"));
                if (!reader.IsDBNull(reader.GetOrdinal("FinlaExamFailed"))) FinlaExamFailed = reader.GetInt32(reader.GetOrdinal("FinlaExamFailed"));
                if (!reader.IsDBNull(reader.GetOrdinal("FinlaExamWaiting"))) FinlaExamWaiting = reader.GetInt32(reader.GetOrdinal("FinlaExamWaiting"));
                if (!reader.IsDBNull(reader.GetOrdinal("TotalWaitingForJoin"))) TotalWaitingForJoin = reader.GetInt32(reader.GetOrdinal("TotalWaitingForJoin"));
                if (!reader.IsDBNull(reader.GetOrdinal("TotalJoin"))) TotalJoin = reader.GetInt32(reader.GetOrdinal("TotalJoin"));
               // if (!reader.IsDBNull(reader.GetOrdinal("TotalNotificationWaiting"))) TotalNotificationWaiting = reader.GetInt32(reader.GetOrdinal("TotalNotificationWaiting"));
              //  if (!reader.IsDBNull(reader.GetOrdinal("TotalNotificationSent"))) TotalNotificationSent = reader.GetInt32(reader.GetOrdinal("TotalNotificationSent"));




            }

        }
        }
}
