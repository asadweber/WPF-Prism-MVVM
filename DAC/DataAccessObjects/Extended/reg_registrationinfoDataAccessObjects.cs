using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;
using AppConfig.ConfigDAAC;
using DAC.Core.Base;
using System.Threading.Tasks;
using System.Threading;
using IDAC.Core.IDataAccessObjects.General;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.Base;
using BDO.DataAccessObjects.VCApplicantReview;
using AppConfig.HelperClasses;
using BDO.Report;
using System.Collections;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Bson.Serialization.Serializers;
using CLL.LLClasses.Models;

namespace DAC.Core.DataAccessObjects.General
{
    /// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>

    internal sealed partial class reg_registrationinfoDataAccessObjects
    {
        async Task<long> Ireg_registrationinfoDataAccessObjects.AddExt(reg_registrationinfoEntity reg_registrationinfodata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_registrationinfo_Ins_ext";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_registrationinfodata, cmd, Database);
                FillSequrityParameters(reg_registrationinfodata.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Itran_userpindataDataAccess.Addtran_userpindata"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoDataAccessObjects.GetAllExt(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "reg_registrationinfo_GA_Ext";
                IList<reg_registrationinfoEntity> itemList = new List<reg_registrationinfoEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, reg_registrationinfo.SortExpression);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_registrationinfo, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_registrationinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetAllreg_registrationinfo"));
            }
        }


        public async Task<reg_registrationinfoEntity> GetRegistrationInfoByBasicInfoID(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_reg_registrationinfo_GS_BY_BasicInfoID";
                reg_registrationinfoEntity itemList = new reg_registrationinfoEntity();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    //AddSortExpressionParameter(cmd, reg_registrationinfo.SortExpression);
                    //FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_registrationinfo, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList = new reg_registrationinfoEntity(reader);
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetAllreg_registrationinfo"));
            }
        }


        public async Task<long> SaveRegistrationDetail(
              Database db,
              DbTransaction transaction,
              reg_registrationinfoEntity reg_registrationinfo,
              CancellationToken cancellationToken)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            string SP = string.Empty;

            if (reg_registrationinfo.CurrentState == BaseEntity.EntityState.Added)
            {
                SP = "KAF_reg_registrationinfo_Ins_Ext";

            }
            else if (reg_registrationinfo.CurrentState == BaseEntity.EntityState.Changed)
            {
                SP = "KAF_reg_registrationinfo_Upd_Ext";
            }
            else if (reg_registrationinfo.CurrentState == BaseEntity.EntityState.Deleted)
            {
                SP = "KAF_reg_registrationinfo_Del_Ext";
            }

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {

                if (reg_registrationinfo.CurrentState == BaseEntity.EntityState.Added || reg_registrationinfo.CurrentState == BaseEntity.EntityState.Changed)
                {
                    FillParameters(reg_registrationinfo, cmd, db);
                }
                else
                {
                    FillParameters(reg_registrationinfo, cmd, db, true);
                }

                FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, db);
                AddOutputParameter(cmd);

                IAsyncResult result = db.BeginExecuteNonQuery(cmd, transaction, null, null);
                while (!result.IsCompleted)
                {
                }
                returnCode = db.EndExecuteNonQuery(result);
                PrimaryKeyMaster = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);

                if (returnCode < 0)
                {
                    throw new ArgumentException("Error in transaction.");
                }
                cmd.Dispose();
            }

            return PrimaryKeyMaster;
        }

        public async Task<long> SaveRegistrationDetailFinalSubmit(
              Database db,
              DbTransaction transaction,
              reg_registrationinfoEntity reg_registrationinfo,
              CancellationToken cancellationToken)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            string SP = string.Empty;
            SP = "KAF_reg_registrationinfo_Upd_FinalSubmit";

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {

                if (reg_registrationinfo.CurrentState == BaseEntity.EntityState.Added || reg_registrationinfo.CurrentState == BaseEntity.EntityState.Changed)
                {
                    FillParameters(reg_registrationinfo, cmd, db);
                }
                else
                {
                    FillParameters(reg_registrationinfo, cmd, db, true);
                }

                FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, db);
                AddOutputParameter(cmd);

                IAsyncResult result = db.BeginExecuteNonQuery(cmd, transaction, null, null);
                while (!result.IsCompleted)
                {
                }
                returnCode = db.EndExecuteNonQuery(result);
                PrimaryKeyMaster = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);

                if (returnCode < 0)
                {
                    throw new ArgumentException("Error in transaction.");
                }
                cmd.Dispose();
            }

            return PrimaryKeyMaster;
        }

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoDataAccessObjects.GetFinallySubmittedRegInfoListView(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetFinallySubmittedRegInfo_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_registrationinfo.SortExpression);
                    AddPageSizeParameter(cmd, reg_registrationinfo.PageSize);
                    AddCurrentPageParameter(cmd, reg_registrationinfo.CurrentPage);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);

                    FillParameters(reg_registrationinfo, cmd, Database);

                    if (!string.IsNullOrEmpty(reg_registrationinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + reg_registrationinfo.strCommonSerachParam + "%");

                    //Add Applicant search parameters
                    if (!string.IsNullOrEmpty(reg_registrationinfo.batchidstring))
                        Database.AddInParameter(cmd, "@BatchIDs", DbType.String, reg_registrationinfo.batchidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.candidatetypeidstring))
                        Database.AddInParameter(cmd, "@CandidateTypeIDs", DbType.String, reg_registrationinfo.candidatetypeidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.professionidstring))
                        Database.AddInParameter(cmd, "@ProfessionIDs", DbType.String, reg_registrationinfo.professionidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.nationalityid))
                        Database.AddInParameter(cmd, "@CountryNationalityIDs", DbType.String, reg_registrationinfo.nationalityid);
                    if (reg_registrationinfo.professionid.HasValue)
                        Database.AddInParameter(cmd, "@CertificateID", DbType.Int64, reg_registrationinfo.certificateid);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@CivilID", DbType.Int64, reg_registrationinfo.civilid);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.mobno))
                        Database.AddInParameter(cmd, "@MobNo", DbType.String, reg_registrationinfo.mobno);
                    if (reg_registrationinfo.submittedfromdate.HasValue)
                        Database.AddInParameter(cmd, "@SubmittedFromDate", DbType.DateTime, reg_registrationinfo.submittedfromdate);
                    if (reg_registrationinfo.submittedtodate.HasValue)
                        Database.AddInParameter(cmd, "@SubmittedToDate", DbType.DateTime, reg_registrationinfo.submittedtodate);
                    if (reg_registrationinfo.maxage.HasValue)
                        Database.AddInParameter(cmd, "@AgeTo", DbType.Int64, reg_registrationinfo.maxage);
                    if (reg_registrationinfo.minage.HasValue)
                        Database.AddInParameter(cmd, "@AgeFrom", DbType.Int64, reg_registrationinfo.minage);
                    if (reg_registrationinfo.notificationStatus.HasValue)
                        Database.AddInParameter(cmd, "@NotificationStatus", DbType.Int64, reg_registrationinfo.notificationStatus);

                    IList<reg_registrationinfoEntity> itemList = new List<reg_registrationinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_registrationinfoEntity(reader, -99));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        reg_registrationinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GAPgListViewFinallySubmittedreg_registrationinfo"));
            }
        }

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoDataAccessObjects.GetFinallySubmittedRegInfoListForReview(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetFinallySubmittedRegInfoForReview_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_registrationinfo.SortExpression);
                    AddPageSizeParameter(cmd, reg_registrationinfo.PageSize);
                    AddCurrentPageParameter(cmd, reg_registrationinfo.CurrentPage);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);

                    FillParameters(reg_registrationinfo, cmd, Database);

                    if (!string.IsNullOrEmpty(reg_registrationinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + reg_registrationinfo.strCommonSerachParam + "%");

                    //Add Applicant search parameters for review
                    if (!string.IsNullOrEmpty(reg_registrationinfo.batchidstring))
                        Database.AddInParameter(cmd, "@BatchIDs", DbType.String, reg_registrationinfo.batchidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.candidatetypeidstring))
                        Database.AddInParameter(cmd, "@CandidateTypeIDs", DbType.String, reg_registrationinfo.candidatetypeidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.professionidstring))
                        Database.AddInParameter(cmd, "@ProfessionIDs", DbType.String, reg_registrationinfo.professionidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.nationalityid))
                        Database.AddInParameter(cmd, "@CountryNationalityIDs", DbType.String, reg_registrationinfo.nationalityid);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@CivilID", DbType.Int64, reg_registrationinfo.civilid);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.mobno))
                        Database.AddInParameter(cmd, "@MobNo", DbType.String, reg_registrationinfo.mobno);
                    if (reg_registrationinfo.interviewfromdate.HasValue)
                        Database.AddInParameter(cmd, "@InterviewFromDate", DbType.DateTime, reg_registrationinfo.interviewfromdate);
                    if (reg_registrationinfo.interviewtodate.HasValue)
                        Database.AddInParameter(cmd, "@InterviewToDate", DbType.DateTime, reg_registrationinfo.interviewtodate);
                    if (reg_registrationinfo.auditresult.HasValue)
                        Database.AddInParameter(cmd, "@AuditResult", DbType.Int32, reg_registrationinfo.auditresult);

                    IList<reg_registrationinfoEntity> itemList = new List<reg_registrationinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new ApplicantReviewRegInfoListLoadFromReader(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        reg_registrationinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetFinallySubmittedRegInfoListForReviewreg_registrationinfo"));
            }
        }

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoDataAccessObjects.GetRegInfoListForVolunteerSecurityClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetRegInfoForVolSecurityClearance_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_registrationinfo.SortExpression);
                    AddPageSizeParameter(cmd, reg_registrationinfo.PageSize);
                    AddCurrentPageParameter(cmd, reg_registrationinfo.CurrentPage);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);

                    FillParameters(reg_registrationinfo, cmd, Database);

                    if (!string.IsNullOrEmpty(reg_registrationinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + reg_registrationinfo.strCommonSerachParam + "%");

                    //Add Applicant search parameters for review
                    if (!string.IsNullOrEmpty(reg_registrationinfo.batchidstring))
                        Database.AddInParameter(cmd, "@BatchIDs", DbType.String, reg_registrationinfo.batchidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.candidatetypeidstring))
                        Database.AddInParameter(cmd, "@CandidateTypeIDs", DbType.String, reg_registrationinfo.candidatetypeidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.professionidstring))
                        Database.AddInParameter(cmd, "@ProfessionIDs", DbType.String, reg_registrationinfo.professionidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.nationalityid))
                        Database.AddInParameter(cmd, "@CountryNationalityIDs", DbType.String, reg_registrationinfo.nationalityid);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@CivilID", DbType.Int64, reg_registrationinfo.civilid);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.mobno))
                        Database.AddInParameter(cmd, "@MobNo", DbType.String, reg_registrationinfo.mobno);
                    if (reg_registrationinfo.reviewfromdate.HasValue)
                        Database.AddInParameter(cmd, "@ReviewFromDate", DbType.DateTime, reg_registrationinfo.reviewfromdate);
                    if (reg_registrationinfo.reviewtodate.HasValue)
                        Database.AddInParameter(cmd, "@ReviewToDate", DbType.DateTime, reg_registrationinfo.reviewtodate);
                    if (reg_registrationinfo.issecurityforwarded.HasValue)
                        Database.AddInParameter(cmd, "@IsSecurityForwarded", DbType.Boolean, reg_registrationinfo.issecurityforwarded);

                    IList<reg_registrationinfoEntity> itemList = new List<reg_registrationinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new SyClearanceInfoLoadFromReader(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        reg_registrationinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetRegInfoListForVolunteerSecurityClearance"));
            }
        }

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoDataAccessObjects.GetRegInfoListForSecurityExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetRegInfoForSecurityExam_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_registrationinfo.SortExpression);
                    AddPageSizeParameter(cmd, reg_registrationinfo.PageSize);
                    AddCurrentPageParameter(cmd, reg_registrationinfo.CurrentPage);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);

                    FillParameters(reg_registrationinfo, cmd, Database);

                    if (!string.IsNullOrEmpty(reg_registrationinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + reg_registrationinfo.strCommonSerachParam + "%");

                    //Add Applicant search parameters for review
                    if (!string.IsNullOrEmpty(reg_registrationinfo.batchidstring))
                        Database.AddInParameter(cmd, "@BatchIDs", DbType.String, reg_registrationinfo.batchidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.candidatetypeidstring))
                        Database.AddInParameter(cmd, "@CandidateTypeIDs", DbType.String, reg_registrationinfo.candidatetypeidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.professionidstring))
                        Database.AddInParameter(cmd, "@ProfessionIDs", DbType.String, reg_registrationinfo.professionidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.nationalityid))
                        Database.AddInParameter(cmd, "@CountryNationalityIDs", DbType.String, reg_registrationinfo.nationalityid);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@CivilID", DbType.Int64, reg_registrationinfo.civilid);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.mobno))
                        Database.AddInParameter(cmd, "@MobNo", DbType.String, reg_registrationinfo.mobno);
                    if (reg_registrationinfo.syforwardedfromdate.HasValue)
                        Database.AddInParameter(cmd, "@SyForwardedFromDate", DbType.DateTime, reg_registrationinfo.syforwardedfromdate);
                    if (reg_registrationinfo.syforwardedtodate.HasValue)
                        Database.AddInParameter(cmd, "@SyForwardedToDate", DbType.DateTime, reg_registrationinfo.syforwardedtodate);
                    if (reg_registrationinfo.centralagencysyresult.HasValue)
                        Database.AddInParameter(cmd, "@CentralAgencySyResult", DbType.Boolean, reg_registrationinfo.centralagencysyresult);
                    if (reg_registrationinfo.syexamresult.HasValue)
                        Database.AddInParameter(cmd, "@SyExamResult", DbType.Int32, reg_registrationinfo.syexamresult);

                    IList<reg_registrationinfoEntity> itemList = new List<reg_registrationinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new SyExamInfoLoadFromReader(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        reg_registrationinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetRegInfoListForSecurityExam"));
            }
        }

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoDataAccessObjects.GetRegInfoListForCentralAgencySy(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetRegInfoForCentralAgencySy_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_registrationinfo.SortExpression);
                    AddPageSizeParameter(cmd, reg_registrationinfo.PageSize);
                    AddCurrentPageParameter(cmd, reg_registrationinfo.CurrentPage);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);

                    FillParameters(reg_registrationinfo, cmd, Database);

                    if (!string.IsNullOrEmpty(reg_registrationinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + reg_registrationinfo.strCommonSerachParam + "%");

                    //Add Applicant search parameters for review
                    if (!string.IsNullOrEmpty(reg_registrationinfo.batchidstring))
                        Database.AddInParameter(cmd, "@BatchIDs", DbType.String, reg_registrationinfo.batchidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.candidatetypeidstring))
                        Database.AddInParameter(cmd, "@CandidateTypeIDs", DbType.String, reg_registrationinfo.candidatetypeidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.professionidstring))
                        Database.AddInParameter(cmd, "@ProfessionIDs", DbType.String, reg_registrationinfo.professionidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@CivilID", DbType.Int64, reg_registrationinfo.civilid);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.mobno))
                        Database.AddInParameter(cmd, "@MobNo", DbType.String, reg_registrationinfo.mobno);
                    if (reg_registrationinfo.syforwardedfromdate.HasValue)
                        Database.AddInParameter(cmd, "@SyForwardedFromDate", DbType.DateTime, reg_registrationinfo.syforwardedfromdate);
                    if (reg_registrationinfo.syforwardedtodate.HasValue)
                        Database.AddInParameter(cmd, "@SyForwardedToDate", DbType.DateTime, reg_registrationinfo.syforwardedtodate);
                    if (reg_registrationinfo.centralagencysyresult.HasValue)
                        Database.AddInParameter(cmd, "@CentralAgencySyResult", DbType.Boolean, reg_registrationinfo.centralagencysyresult);

                    IList<reg_registrationinfoEntity> itemList = new List<reg_registrationinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new CentralAgencySyInfoLoadFromReader(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        reg_registrationinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetRegInfoListForCentralAgencySy"));
            }
        }

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoDataAccessObjects.GetRegInfoListForSecurityReTestApproval(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetRegInfoForSecurityReTestApproval_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_registrationinfo.SortExpression);
                    AddPageSizeParameter(cmd, reg_registrationinfo.PageSize);
                    AddCurrentPageParameter(cmd, reg_registrationinfo.CurrentPage);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);

                    FillParameters(reg_registrationinfo, cmd, Database);

                    if (!string.IsNullOrEmpty(reg_registrationinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + reg_registrationinfo.strCommonSerachParam + "%");

                    //Add Applicant search parameters for review
                    if (!string.IsNullOrEmpty(reg_registrationinfo.batchidstring))
                        Database.AddInParameter(cmd, "@BatchIDs", DbType.String, reg_registrationinfo.batchidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.candidatetypeidstring))
                        Database.AddInParameter(cmd, "@CandidateTypeIDs", DbType.String, reg_registrationinfo.candidatetypeidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.professionidstring))
                        Database.AddInParameter(cmd, "@ProfessionIDs", DbType.String, reg_registrationinfo.professionidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.nationalityid))
                        Database.AddInParameter(cmd, "@CountryNationalityIDs", DbType.String, reg_registrationinfo.nationalityid);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@CivilID", DbType.Int64, reg_registrationinfo.civilid);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.mobno))
                        Database.AddInParameter(cmd, "@MobNo", DbType.String, reg_registrationinfo.mobno);
                    if (reg_registrationinfo.resultexpirefromdate.HasValue)
                        Database.AddInParameter(cmd, "@ResultExpireFromDate", DbType.DateTime, reg_registrationinfo.resultexpirefromdate);
                    if (reg_registrationinfo.resultexpiretodate.HasValue)
                        Database.AddInParameter(cmd, "@ResultExpireToDate", DbType.DateTime, reg_registrationinfo.resultexpiretodate);
                    if (reg_registrationinfo.issyretestapproved.HasValue)
                        Database.AddInParameter(cmd, "@isSyReTestApproved", DbType.Boolean, reg_registrationinfo.issyretestapproved);

                    IList<reg_registrationinfoEntity> itemList = new List<reg_registrationinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new SyReTestApprovalListLoadFromReader(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        reg_registrationinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetRegInfoListForSecurityReTestApproval"));
            }
        }

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoDataAccessObjects.GetRegInfoListForVolunteerUnitClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetRegInfoForVolUnitClearance_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_registrationinfo.SortExpression);
                    AddPageSizeParameter(cmd, reg_registrationinfo.PageSize);
                    AddCurrentPageParameter(cmd, reg_registrationinfo.CurrentPage);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);

                    FillParameters(reg_registrationinfo, cmd, Database);

                    if (!string.IsNullOrEmpty(reg_registrationinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + reg_registrationinfo.strCommonSerachParam + "%");

                    //Add Applicant search parameters for review
                    if (!string.IsNullOrEmpty(reg_registrationinfo.batchidstring))
                        Database.AddInParameter(cmd, "@BatchIDs", DbType.String, reg_registrationinfo.batchidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.candidatetypeidstring))
                        Database.AddInParameter(cmd, "@CandidateTypeIDs", DbType.String, reg_registrationinfo.candidatetypeidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.professionidstring))
                        Database.AddInParameter(cmd, "@ProfessionIDs", DbType.String, reg_registrationinfo.professionidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.nationalityid))
                        Database.AddInParameter(cmd, "@CountryNationalityIDs", DbType.String, reg_registrationinfo.nationalityid);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@CivilID", DbType.Int64, reg_registrationinfo.civilid);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.mobno))
                        Database.AddInParameter(cmd, "@MobNo", DbType.String, reg_registrationinfo.mobno);
                    if (reg_registrationinfo.syclearancefromdate.HasValue)
                        Database.AddInParameter(cmd, "@SyClearanceFromDate", DbType.DateTime, reg_registrationinfo.syclearancefromdate);
                    if (reg_registrationinfo.syclearancetodate.HasValue)
                        Database.AddInParameter(cmd, "@SyClearanceToDate", DbType.DateTime, reg_registrationinfo.syclearancetodate);
                    if (reg_registrationinfo.isunitforwarded.HasValue)
                        Database.AddInParameter(cmd, "@IsUnitForwarded", DbType.Boolean, reg_registrationinfo.isunitforwarded);

                    IList<reg_registrationinfoEntity> itemList = new List<reg_registrationinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new VolUnitClearanceInfoLoadFromReader(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        reg_registrationinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetRegInfoListForVolunteerUnitClearance"));
            }
        }

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoDataAccessObjects.GetRegInfoListForUnitClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetRegInfoListForUnitClearance_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_registrationinfo.SortExpression);
                    AddPageSizeParameter(cmd, reg_registrationinfo.PageSize);
                    AddCurrentPageParameter(cmd, reg_registrationinfo.CurrentPage);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);

                    FillParameters(reg_registrationinfo, cmd, Database);

                    if (!string.IsNullOrEmpty(reg_registrationinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + reg_registrationinfo.strCommonSerachParam + "%");

                    //Add Applicant search parameters for review
                    if (!string.IsNullOrEmpty(reg_registrationinfo.batchidstring))
                        Database.AddInParameter(cmd, "@BatchIDs", DbType.String, reg_registrationinfo.batchidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.candidatetypeidstring))
                        Database.AddInParameter(cmd, "@CandidateTypeIDs", DbType.String, reg_registrationinfo.candidatetypeidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.professionidstring))
                        Database.AddInParameter(cmd, "@ProfessionIDs", DbType.String, reg_registrationinfo.professionidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.nationalityid))
                        Database.AddInParameter(cmd, "@CountryNationalityIDs", DbType.String, reg_registrationinfo.nationalityid);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@CivilID", DbType.Int64, reg_registrationinfo.civilid);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.mobno))
                        Database.AddInParameter(cmd, "@MobNo", DbType.String, reg_registrationinfo.mobno);
                    if (reg_registrationinfo.unitforwardedfromdate.HasValue)
                        Database.AddInParameter(cmd, "@UnitForwardedFromDate", DbType.DateTime, reg_registrationinfo.unitforwardedfromdate);
                    if (reg_registrationinfo.unitforwardedtodate.HasValue)
                        Database.AddInParameter(cmd, "@UnitForwardedToDate", DbType.DateTime, reg_registrationinfo.unitforwardedtodate);
                    if (reg_registrationinfo.unitclearanceresult.HasValue)
                        Database.AddInParameter(cmd, "@UnitClearanceResult", DbType.Int32, reg_registrationinfo.unitclearanceresult);

                    IList<reg_registrationinfoEntity> itemList = new List<reg_registrationinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new UnitClearanceInfoLoadFromReader(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        reg_registrationinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetRegInfoListForUnitClearancereg_registrationinfo"));
            }
        }

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoDataAccessObjects.GetRegInfoListForVolunteerMedicalClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetRegInfoForVolMedClearance_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_registrationinfo.SortExpression);
                    AddPageSizeParameter(cmd, reg_registrationinfo.PageSize);
                    AddCurrentPageParameter(cmd, reg_registrationinfo.CurrentPage);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);

                    FillParameters(reg_registrationinfo, cmd, Database);

                    if (!string.IsNullOrEmpty(reg_registrationinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + reg_registrationinfo.strCommonSerachParam + "%");

                    //Add Applicant search parameters for review
                    if (!string.IsNullOrEmpty(reg_registrationinfo.batchidstring))
                        Database.AddInParameter(cmd, "@BatchIDs", DbType.String, reg_registrationinfo.batchidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.candidatetypeidstring))
                        Database.AddInParameter(cmd, "@CandidateTypeIDs", DbType.String, reg_registrationinfo.candidatetypeidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.professionidstring))
                        Database.AddInParameter(cmd, "@ProfessionIDs", DbType.String, reg_registrationinfo.professionidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.nationalityid))
                        Database.AddInParameter(cmd, "@CountryNationalityIDs", DbType.String, reg_registrationinfo.nationalityid);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@CivilID", DbType.Int64, reg_registrationinfo.civilid);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.mobno))
                        Database.AddInParameter(cmd, "@MobNo", DbType.String, reg_registrationinfo.mobno);
                    if (reg_registrationinfo.syclearancefromdate.HasValue)
                        Database.AddInParameter(cmd, "@SyClearanceFromDate", DbType.DateTime, reg_registrationinfo.syclearancefromdate);
                    if (reg_registrationinfo.syclearancetodate.HasValue)
                        Database.AddInParameter(cmd, "@SyClearanceToDate", DbType.DateTime, reg_registrationinfo.syclearancetodate);
                    if (reg_registrationinfo.ismedforwarded.HasValue)
                        Database.AddInParameter(cmd, "@IsMedForwarded", DbType.Boolean, reg_registrationinfo.ismedforwarded);

                    IList<reg_registrationinfoEntity> itemList = new List<reg_registrationinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new VolMedicalClearanceInfoLoadFromReader(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        reg_registrationinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetRegInfoListForVolunteerMedicalClearance"));
            }
        }

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoDataAccessObjects.GetRegInfoListForGeneralMedicalExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetRegInfoForGeneralMedicalExam_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_registrationinfo.SortExpression);
                    AddPageSizeParameter(cmd, reg_registrationinfo.PageSize);
                    AddCurrentPageParameter(cmd, reg_registrationinfo.CurrentPage);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);

                    FillParameters(reg_registrationinfo, cmd, Database);

                    if (!string.IsNullOrEmpty(reg_registrationinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + reg_registrationinfo.strCommonSerachParam + "%");

                    //Add Applicant search parameters for review
                    if (!string.IsNullOrEmpty(reg_registrationinfo.batchidstring))
                        Database.AddInParameter(cmd, "@BatchIDs", DbType.String, reg_registrationinfo.batchidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.candidatetypeidstring))
                        Database.AddInParameter(cmd, "@CandidateTypeIDs", DbType.String, reg_registrationinfo.candidatetypeidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.professionidstring))
                        Database.AddInParameter(cmd, "@ProfessionIDs", DbType.String, reg_registrationinfo.professionidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.nationalityid))
                        Database.AddInParameter(cmd, "@CountryNationalityIDs", DbType.String, reg_registrationinfo.nationalityid);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@CivilID", DbType.Int64, reg_registrationinfo.civilid);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.mobno))
                        Database.AddInParameter(cmd, "@MobNo", DbType.String, reg_registrationinfo.mobno);
                    if (reg_registrationinfo.unitclearancemarkfrom.HasValue)
                        Database.AddInParameter(cmd, "@UnitClearanceMarkFrom", DbType.Decimal, reg_registrationinfo.unitclearancemarkfrom);
                    if (reg_registrationinfo.unitclearancemarkto.HasValue)
                        Database.AddInParameter(cmd, "@UnitClearanceMarkTo", DbType.Decimal, reg_registrationinfo.unitclearancemarkto);
                    if (reg_registrationinfo.medforwardedfromdate.HasValue)
                        Database.AddInParameter(cmd, "@MedForwardedFromDate", DbType.DateTime, reg_registrationinfo.medforwardedfromdate);
                    if (reg_registrationinfo.medforwardedtodate.HasValue)
                        Database.AddInParameter(cmd, "@MedForwardedToDate", DbType.DateTime, reg_registrationinfo.medforwardedtodate);
                    if (reg_registrationinfo.medexamresult.HasValue)
                        Database.AddInParameter(cmd, "@MedExamResult", DbType.Int32, reg_registrationinfo.medexamresult);
                    if (reg_registrationinfo.notificationStatus.HasValue)
                        Database.AddInParameter(cmd, "@NotificationStatus", DbType.Boolean, reg_registrationinfo.notificationStatus);
                    IList<reg_registrationinfoEntity> itemList = new List<reg_registrationinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new GeneralMedicalExamInfoLoadFromReader(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        reg_registrationinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetRegInfoListForGeneralMedicalExam"));
            }
        }

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoDataAccessObjects.GetRegInfoListForPsychologyExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetRegInfoForPsychologyExam_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_registrationinfo.SortExpression);
                    AddPageSizeParameter(cmd, reg_registrationinfo.PageSize);
                    AddCurrentPageParameter(cmd, reg_registrationinfo.CurrentPage);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);

                    FillParameters(reg_registrationinfo, cmd, Database);

                    if (!string.IsNullOrEmpty(reg_registrationinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + reg_registrationinfo.strCommonSerachParam + "%");

                    //Add Applicant search parameters for review
                    if (!string.IsNullOrEmpty(reg_registrationinfo.batchidstring))
                        Database.AddInParameter(cmd, "@BatchIDs", DbType.String, reg_registrationinfo.batchidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.candidatetypeidstring))
                        Database.AddInParameter(cmd, "@CandidateTypeIDs", DbType.String, reg_registrationinfo.candidatetypeidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.professionidstring))
                        Database.AddInParameter(cmd, "@ProfessionIDs", DbType.String, reg_registrationinfo.professionidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.nationalityid))
                        Database.AddInParameter(cmd, "@CountryNationalityIDs", DbType.String, reg_registrationinfo.nationalityid);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@CivilID", DbType.Int64, reg_registrationinfo.civilid);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.mobno))
                        Database.AddInParameter(cmd, "@MobNo", DbType.String, reg_registrationinfo.mobno);
                    if (reg_registrationinfo.medforwardedfromdate.HasValue)
                        Database.AddInParameter(cmd, "@MedForwardedFromDate", DbType.DateTime, reg_registrationinfo.medforwardedfromdate);
                    if (reg_registrationinfo.medforwardedtodate.HasValue)
                        Database.AddInParameter(cmd, "@MedForwardedToDate", DbType.DateTime, reg_registrationinfo.medforwardedtodate);
                    if (reg_registrationinfo.psychoexamresult.HasValue)
                        Database.AddInParameter(cmd, "@PsychoExamResult", DbType.Int32, reg_registrationinfo.psychoexamresult);

                    IList<reg_registrationinfoEntity> itemList = new List<reg_registrationinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new PsychologyExamInfoLoadFromReader(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        reg_registrationinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetRegInfoListForPsychologyExam"));
            }
        }

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoDataAccessObjects.GetRegInfoListForFinalExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetRegInfoForFinalExam_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_registrationinfo.SortExpression);
                    AddPageSizeParameter(cmd, reg_registrationinfo.PageSize);
                    AddCurrentPageParameter(cmd, reg_registrationinfo.CurrentPage);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);

                    FillParameters(reg_registrationinfo, cmd, Database);

                    if (!string.IsNullOrEmpty(reg_registrationinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + reg_registrationinfo.strCommonSerachParam + "%");

                    //Add Applicant search parameters for review
                    if (!string.IsNullOrEmpty(reg_registrationinfo.batchidstring))
                        Database.AddInParameter(cmd, "@BatchIDs", DbType.String, reg_registrationinfo.batchidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.candidatetypeidstring))
                        Database.AddInParameter(cmd, "@CandidateTypeIDs", DbType.String, reg_registrationinfo.candidatetypeidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.professionidstring))
                        Database.AddInParameter(cmd, "@ProfessionIDs", DbType.String, reg_registrationinfo.professionidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.nationalityid))
                        Database.AddInParameter(cmd, "@CountryNationalityIDs", DbType.String, reg_registrationinfo.nationalityid);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@CivilID", DbType.Int64, reg_registrationinfo.civilid);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.mobno))
                        Database.AddInParameter(cmd, "@MobNo", DbType.String, reg_registrationinfo.mobno);
                    if (reg_registrationinfo.medresultfromdate.HasValue)
                        Database.AddInParameter(cmd, "@MedResultFromDate", DbType.DateTime, reg_registrationinfo.medresultfromdate);
                    if (reg_registrationinfo.medresulttodate.HasValue)
                        Database.AddInParameter(cmd, "@MedResultToDate", DbType.DateTime, reg_registrationinfo.medresulttodate);
                    if (reg_registrationinfo.finalexamresult.HasValue)
                        Database.AddInParameter(cmd, "@FinalExamResult", DbType.Int32, reg_registrationinfo.finalexamresult);
                    if (reg_registrationinfo.notificationStatus.HasValue)
                        Database.AddInParameter(cmd, "@NotificationStatus", DbType.Boolean, reg_registrationinfo.notificationStatus);

                    IList<reg_registrationinfoEntity> itemList = new List<reg_registrationinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new FinalExamInfoLoadFromReader(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        reg_registrationinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetRegInfoListForFinalExam"));
            }
        }

        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoDataAccessObjects.GetRegInfoListForTrainingJoin(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetRegInfoForTrainingJoin_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_registrationinfo.SortExpression);
                    AddPageSizeParameter(cmd, reg_registrationinfo.PageSize);
                    AddCurrentPageParameter(cmd, reg_registrationinfo.CurrentPage);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);

                    FillParameters(reg_registrationinfo, cmd, Database);

                    if (!string.IsNullOrEmpty(reg_registrationinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + reg_registrationinfo.strCommonSerachParam + "%");

                    //Add Applicant search parameters for review
                    if (!string.IsNullOrEmpty(reg_registrationinfo.batchidstring))
                        Database.AddInParameter(cmd, "@BatchIDs", DbType.String, reg_registrationinfo.batchidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.candidatetypeidstring))
                        Database.AddInParameter(cmd, "@CandidateTypeIDs", DbType.String, reg_registrationinfo.candidatetypeidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.professionidstring))
                        Database.AddInParameter(cmd, "@ProfessionIDs", DbType.String, reg_registrationinfo.professionidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.nationalityid))
                        Database.AddInParameter(cmd, "@CountryNationalityIDs", DbType.String, reg_registrationinfo.nationalityid);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@CivilID", DbType.Int64, reg_registrationinfo.civilid);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.mobno))
                        Database.AddInParameter(cmd, "@MobNo", DbType.String, reg_registrationinfo.mobno);
                    if (reg_registrationinfo.finalexamresultfromdate.HasValue)
                        Database.AddInParameter(cmd, "@FinalExamResultFromDate", DbType.DateTime, reg_registrationinfo.finalexamresultfromdate);
                    if (reg_registrationinfo.finalexamresulttodate.HasValue)
                        Database.AddInParameter(cmd, "@FinalExamResultToDate", DbType.DateTime, reg_registrationinfo.finalexamresulttodate);
                    if (reg_registrationinfo.notificationStatus.HasValue)
                        Database.AddInParameter(cmd, "@NotificationStatus", DbType.Boolean, reg_registrationinfo.notificationStatus);
                    //if (reg_registrationinfo.finalexamresult.HasValue)
                    //    Database.AddInParameter(cmd, "@FinalExamResult", DbType.Int32, reg_registrationinfo.finalexamresult);

                    IList<reg_registrationinfoEntity> itemList = new List<reg_registrationinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new TrainingJoinInfoLoadFromReader(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        reg_registrationinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetRegInfoListForTrainingJoin"));
            }
        }

        async Task<ApplicantReviewViewModel> Ireg_registrationinfoDataAccessObjects.GetApplicantDetailsByRegistrationIDForReview(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetApplicantDetailsByRegistrationIDForReview_GS";
                ApplicantReviewViewModel objapplicantreviewVM = new ApplicantReviewViewModel();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_registrationinfo, cmd, Database);

                    //IList<reg_registrationinfoEntity> itemList = new List<reg_registrationinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            objapplicantreviewVM.RegistrationInfo = new ApplicantReviewRegInfoLoadFromReader(reader);
                        }
                        reader.Close();
                    }
                    cmd.Dispose();

                    if (objapplicantreviewVM.RegistrationInfo != null)
                    {
                        reg_datacheckedDataAccessObjects objreg_datachecked = new reg_datacheckedDataAccessObjects(this.Context);
                        objapplicantreviewVM.RegDataChecked = (List<reg_datacheckedEntity>)await objreg_datachecked.GetAllRegDataCheckedListByRegistrationID(new reg_datacheckedEntity() { registrationid = objapplicantreviewVM.RegistrationInfo.registrationid }, cancellationToken);

                        return objapplicantreviewVM;
                    }
                    else
                    {
                        throw new Exception("User not Found");
                    }
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetApplicantDetailsByRegistrationIDForReviewreg_registrationinfo"));
            }
        }

        async Task<long> Ireg_registrationinfoDataAccessObjects.ApplicantReviewAuditResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_registrationinfo_Upd_Ext";
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            transactioncodeGen objTranIDGen = new transactioncodeGen();
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillParameters(reg_registrationinfo, cmd, Database);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);

                    if ((reg_registrationinfo.auditresult.HasValue))
                        Database.AddInParameter(cmd, "@AuditResult", DbType.Int32, reg_registrationinfo.auditresult);
                    if (!(string.IsNullOrEmpty(reg_registrationinfo.auditcomment)))
                        Database.AddInParameter(cmd, "@AuditComment", DbType.String, reg_registrationinfo.auditcomment);
                    if ((reg_registrationinfo.auditdate.HasValue))
                        Database.AddInParameter(cmd, "@AuditDate", DbType.DateTime, reg_registrationinfo.auditdate);

                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    if (returnCode > 0)
                    {
                        if (reg_registrationinfo.previousAuditResult != reg_registrationinfo.auditresult)
                        {
                            if (reg_registrationinfo.auditresult == (Int32)AuditResultEnum.Passed)
                            {
                                #region TABLE:Tran_ApplicantPhases
                                tran_applicantphasesDataAccessObjects objtran_applicantphasesDataAccessObjects = new tran_applicantphasesDataAccessObjects(this.Context);
                                tran_applicantphasesEntity objApplicantPhasesEntity = new tran_applicantphasesEntity();
                                objApplicantPhasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                objApplicantPhasesEntity.registrationid = reg_registrationinfo.registrationid;
                                objApplicantPhasesEntity.batchid = reg_registrationinfo.batchid;
                                objApplicantPhasesEntity.phaseid = (long)ApplicantPhasesEnum.Audit;
                                objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Passed;
                                objApplicantPhasesEntity.submitteddate = DateTime.Now;
                                objApplicantPhasesEntity.submittedby = reg_registrationinfo.BaseSecurityParam.userid;
                                objApplicantPhasesEntity.BaseSecurityParam = new SecurityCapsule();
                                objApplicantPhasesEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                await objtran_applicantphasesDataAccessObjects.AddApplicationPhase(Database, transaction, objApplicantPhasesEntity, cancellationToken);
                                #endregion
                            }
                            else if (reg_registrationinfo.auditresult == (Int32)AuditResultEnum.Failed)
                            {
                                #region TABLE:Tran_ApplicantPhases
                                tran_applicantphasesDataAccessObjects objtran_applicantphasesDataAccessObjects = new tran_applicantphasesDataAccessObjects(this.Context);
                                tran_applicantphasesEntity objApplicantPhasesEntity = new tran_applicantphasesEntity();
                                objApplicantPhasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                objApplicantPhasesEntity.registrationid = reg_registrationinfo.registrationid;
                                objApplicantPhasesEntity.batchid = reg_registrationinfo.batchid;
                                objApplicantPhasesEntity.phaseid = (long)ApplicantPhasesEnum.Audit;
                                objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Failed;
                                objApplicantPhasesEntity.submitteddate = DateTime.Now;
                                objApplicantPhasesEntity.submittedby = reg_registrationinfo.BaseSecurityParam.userid;
                                objApplicantPhasesEntity.BaseSecurityParam = new SecurityCapsule();
                                objApplicantPhasesEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                await objtran_applicantphasesDataAccessObjects.AddApplicationPhase(Database, transaction, objApplicantPhasesEntity, cancellationToken);
                                #endregion
                            }
                            else if (reg_registrationinfo.auditresult == (Int32)AuditResultEnum.Rollback)
                            {
                                #region TABLE:Tran_ApplicantPhases
                                tran_applicantphasesDataAccessObjects objtran_applicantphasesDataAccessObjects = new tran_applicantphasesDataAccessObjects(this.Context);
                                tran_applicantphasesEntity objApplicantPhasesEntity = new tran_applicantphasesEntity();
                                objApplicantPhasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                objApplicantPhasesEntity.registrationid = reg_registrationinfo.registrationid;
                                objApplicantPhasesEntity.batchid = reg_registrationinfo.batchid;
                                objApplicantPhasesEntity.phaseid = (long)ApplicantPhasesEnum.FinalSubmitted;
                                objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Rollback;
                                objApplicantPhasesEntity.submitteddate = DateTime.Now;
                                objApplicantPhasesEntity.submittedby = reg_registrationinfo.BaseSecurityParam.userid;
                                objApplicantPhasesEntity.BaseSecurityParam = new SecurityCapsule();
                                objApplicantPhasesEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                await objtran_applicantphasesDataAccessObjects.AddApplicationPhase(Database, transaction, objApplicantPhasesEntity, cancellationToken);
                                #endregion

                                #region TABLE:Reg_DataChecked
                                reg_datacheckedDataAccessObjects objreg_datacheckedDataAccessObjects = new reg_datacheckedDataAccessObjects(this.Context);
                                reg_datacheckedEntity objDataCheckedEntity = new reg_datacheckedEntity();
                                objDataCheckedEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                objDataCheckedEntity.registrationid = reg_registrationinfo.registrationid;
                                objDataCheckedEntity.ischecked = null;
                                IList<reg_datacheckedEntity> objDataCheckedEntityList = await objreg_datacheckedDataAccessObjects.GetAllRegDataChecked(Database, transaction, objDataCheckedEntity, cancellationToken);
                                if (objDataCheckedEntityList != null && objDataCheckedEntityList.Count > 0)
                                {
                                    foreach (var objDataCheckedItem in objDataCheckedEntityList)
                                    {
                                        objDataCheckedItem.isactive = false;
                                        objDataCheckedItem.ischecked = false;
                                        objDataCheckedItem.reviewedbyid = null;
                                        objDataCheckedItem.vieweddate = null;
                                        objDataCheckedItem.comment = null;
                                        await objreg_datacheckedDataAccessObjects.UpdateRegDataCheckedByApplicantTable(Database, transaction, objDataCheckedItem, cancellationToken);
                                    }
                                }
                                #endregion

                                #region TABLE:Tran_RollBackInfo
                                tran_rollbackinfoDataAccessObjects objtran_rollbackinfoDataAccessObjects = new tran_rollbackinfoDataAccessObjects(this.Context);
                                tran_rollbackinfoEntity objRollBackEntity = new tran_rollbackinfoEntity();
                                objRollBackEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                objRollBackEntity.registrationid = reg_registrationinfo.registrationid;
                                objRollBackEntity.type = (long)RollbackByEnum.Admin;
                                objRollBackEntity.trandate = DateTime.Now;
                                objRollBackEntity.remarks = "Rollback By Admin";
                                objRollBackEntity.BaseSecurityParam = new SecurityCapsule();
                                objRollBackEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                await objtran_rollbackinfoDataAccessObjects.AddRollBackInfo(Database, transaction, objRollBackEntity, cancellationToken);
                                #endregion

                            }

                            #region TABLE:Tran_AuditResult
                            tran_auditresultDataAccessObjects objtran_auditresultDataAccessObjects = new tran_auditresultDataAccessObjects(this.Context);
                            tran_auditresultEntity objAuditResultEntity = new tran_auditresultEntity();
                            objAuditResultEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                            objAuditResultEntity.registrationid = reg_registrationinfo.registrationid;
                            objAuditResultEntity.auditresult = reg_registrationinfo.auditresult;
                            objAuditResultEntity.auditcomment = reg_registrationinfo.auditcomment;
                            objAuditResultEntity.auditdate = reg_registrationinfo.auditdate;
                            objAuditResultEntity.issoftdeleted = false;
                            objAuditResultEntity.BaseSecurityParam = new SecurityCapsule();
                            objAuditResultEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                            await objtran_auditresultDataAccessObjects.AddAuditResult(Database, transaction, objAuditResultEntity, cancellationToken);
                            #endregion
                        }

                    }
                    cmd.Dispose();
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.ApplicantReviewAuditResultUpdate"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        async Task<long> Ireg_registrationinfoDataAccessObjects.ForwardSecurityExamination(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "KAF_Reg_Registrationinfo_Upd_FwdSyExam";
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            transactioncodeGen objTranIDGen = new transactioncodeGen();
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillParameters(reg_registrationinfo, cmd, Database);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);

                    if (reg_registrationinfo.issecurityforwarded.HasValue)
                        Database.AddInParameter(cmd, "@IsSecurityForwarded", DbType.Boolean, reg_registrationinfo.issecurityforwarded);
                    if ((reg_registrationinfo.syexamresult.HasValue))
                        Database.AddInParameter(cmd, "@SyExamResult", DbType.Int32, reg_registrationinfo.syexamresult);
                    if (!(string.IsNullOrEmpty(reg_registrationinfo.syexamcomment)))
                        Database.AddInParameter(cmd, "@SyExamComment", DbType.String, reg_registrationinfo.syexamcomment);
                    if ((reg_registrationinfo.syexamresultdate.HasValue))
                        Database.AddInParameter(cmd, "@SyExamResultDate", DbType.DateTime, reg_registrationinfo.syexamresultdate);
                    if ((reg_registrationinfo.centralagencysyresult.HasValue))
                        Database.AddInParameter(cmd, "@CentralAgencySyResult", DbType.Boolean, reg_registrationinfo.centralagencysyresult);
                    if (!(string.IsNullOrEmpty(reg_registrationinfo.centralagencysycomment)))
                        Database.AddInParameter(cmd, "@CentralAgencySyComment", DbType.String, reg_registrationinfo.centralagencysycomment);
                    if ((reg_registrationinfo.centralagencysyresultdate.HasValue))
                        Database.AddInParameter(cmd, "@CentralAgencySyResultDate", DbType.DateTime, reg_registrationinfo.centralagencysyresultdate);

                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    if (returnCode > 0)
                    {
                        #region TABLE:Tran_ApplicantPhases
                        tran_applicantphasesDataAccessObjects objtran_applicantphasesDataAccessObjects = new tran_applicantphasesDataAccessObjects(this.Context);
                        tran_applicantphasesEntity objApplicantPhasesEntity = new tran_applicantphasesEntity();
                        objApplicantPhasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                        objApplicantPhasesEntity.registrationid = reg_registrationinfo.registrationid;
                        objApplicantPhasesEntity.batchid = reg_registrationinfo.batchid;
                        objApplicantPhasesEntity.phaseid = (long)ApplicantPhasesEnum.SecurityCheck;
                        objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.New;
                        objApplicantPhasesEntity.submitteddate = DateTime.Now;
                        objApplicantPhasesEntity.submittedby = reg_registrationinfo.BaseSecurityParam.userid;
                        objApplicantPhasesEntity.BaseSecurityParam = new SecurityCapsule();
                        objApplicantPhasesEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                        await objtran_applicantphasesDataAccessObjects.AddApplicationPhase(Database, transaction, objApplicantPhasesEntity, cancellationToken);
                        #endregion

                        #region TABLE:Tran_VolunteerSyClearance
                        tran_volunteersyclearanceDataAccessObjects objtran_volunteersyclearanceDataAccessObjects = new tran_volunteersyclearanceDataAccessObjects(this.Context);
                        tran_volunteersyclearanceEntity objtran_volunteersyclearanceEntity = new tran_volunteersyclearanceEntity();
                        objtran_volunteersyclearanceEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                        objtran_volunteersyclearanceEntity.registrationid = reg_registrationinfo.registrationid;
                        objtran_volunteersyclearanceEntity.syclearanceresult = (int)SyClearanceResultEnum.Forward;
                        objtran_volunteersyclearanceEntity.issoftdeleted = false;
                        objtran_volunteersyclearanceEntity.BaseSecurityParam = new SecurityCapsule();
                        objtran_volunteersyclearanceEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                        await objtran_volunteersyclearanceDataAccessObjects.AddVolunteerSyClearanceResult(Database, transaction, objtran_volunteersyclearanceEntity, cancellationToken);
                        #endregion

                        #region TABLE:Tran_SyExamResult
                        tran_syexamresultDataAccessObjects objtran_syexamresultDataAccessObjects = new tran_syexamresultDataAccessObjects(this.Context);
                        tran_syexamresultEntity objSyExamResultEntity = new tran_syexamresultEntity();
                        objSyExamResultEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                        objSyExamResultEntity.registrationid = reg_registrationinfo.registrationid;
                        objSyExamResultEntity.syexamresult = (Int32)SyExamResultEnum.Waiting;
                        objSyExamResultEntity.syexamcomment = null;
                        objSyExamResultEntity.syexamresultdate = null;
                        objSyExamResultEntity.issoftdeleted = false;
                        objSyExamResultEntity.BaseSecurityParam = new SecurityCapsule();
                        objSyExamResultEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                        await objtran_syexamresultDataAccessObjects.AddSyExamResult(Database, transaction, objSyExamResultEntity, cancellationToken);
                        #endregion
                    }
                    cmd.Dispose();
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.ForwardSecurityExamination"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        async Task<long> Ireg_registrationinfoDataAccessObjects.GroupForwardSecurityExamination(List<reg_registrationinfoEntity> reg_registrationinfoList, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "KAF_Reg_Registrationinfo_Upd_FwdSyExam";
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            transactioncodeGen objTranIDGen = new transactioncodeGen();
            try
            {
                if (reg_registrationinfoList != null && reg_registrationinfoList.Count > 0)
                {
                    foreach (reg_registrationinfoEntity reg_registrationinfo in reg_registrationinfoList)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                        {


                            FillParameters(reg_registrationinfo, cmd, Database);
                            FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                            AddOutputParameter(cmd);

                            if (reg_registrationinfo.issecurityforwarded.HasValue)
                                Database.AddInParameter(cmd, "@IsSecurityForwarded", DbType.Boolean, reg_registrationinfo.issecurityforwarded);
                            if ((reg_registrationinfo.syexamresult.HasValue))
                                Database.AddInParameter(cmd, "@SyExamResult", DbType.Int32, reg_registrationinfo.syexamresult);
                            if (!(string.IsNullOrEmpty(reg_registrationinfo.syexamcomment)))
                                Database.AddInParameter(cmd, "@SyExamComment", DbType.String, reg_registrationinfo.syexamcomment);
                            if ((reg_registrationinfo.syexamresultdate.HasValue))
                                Database.AddInParameter(cmd, "@SyExamResultDate", DbType.DateTime, reg_registrationinfo.syexamresultdate);
                            if ((reg_registrationinfo.centralagencysyresult.HasValue))
                                Database.AddInParameter(cmd, "@CentralAgencySyResult", DbType.Boolean, reg_registrationinfo.centralagencysyresult);
                            if (!(string.IsNullOrEmpty(reg_registrationinfo.centralagencysycomment)))
                                Database.AddInParameter(cmd, "@CentralAgencySyComment", DbType.String, reg_registrationinfo.centralagencysycomment);
                            if ((reg_registrationinfo.centralagencysyresultdate.HasValue))
                                Database.AddInParameter(cmd, "@CentralAgencySyResultDate", DbType.DateTime, reg_registrationinfo.centralagencysyresultdate);

                            IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                            while (!result.IsCompleted)
                            {
                            }
                            returnCode = Database.EndExecuteNonQuery(result);
                            returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                            if (returnCode > 0)
                            {
                                #region TABLE:Tran_ApplicantPhases
                                tran_applicantphasesDataAccessObjects objtran_applicantphasesDataAccessObjects = new tran_applicantphasesDataAccessObjects(this.Context);
                                tran_applicantphasesEntity objApplicantPhasesEntity = new tran_applicantphasesEntity();
                                objApplicantPhasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                objApplicantPhasesEntity.registrationid = reg_registrationinfo.registrationid;
                                objApplicantPhasesEntity.batchid = reg_registrationinfo.batchid;
                                objApplicantPhasesEntity.phaseid = (long)ApplicantPhasesEnum.SecurityCheck;
                                objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.New;
                                objApplicantPhasesEntity.submitteddate = DateTime.Now;
                                objApplicantPhasesEntity.submittedby = reg_registrationinfo.BaseSecurityParam.userid;
                                objApplicantPhasesEntity.BaseSecurityParam = new SecurityCapsule();
                                objApplicantPhasesEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                await objtran_applicantphasesDataAccessObjects.AddApplicationPhase(Database, transaction, objApplicantPhasesEntity, cancellationToken);
                                #endregion

                                #region TABLE:Tran_VolunteerSyClearance
                                tran_volunteersyclearanceDataAccessObjects objtran_volunteersyclearanceDataAccessObjects = new tran_volunteersyclearanceDataAccessObjects(this.Context);
                                tran_volunteersyclearanceEntity objtran_volunteersyclearanceEntity = new tran_volunteersyclearanceEntity();
                                objtran_volunteersyclearanceEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                objtran_volunteersyclearanceEntity.registrationid = reg_registrationinfo.registrationid;
                                objtran_volunteersyclearanceEntity.syclearanceresult = (int)SyClearanceResultEnum.Forward;
                                objtran_volunteersyclearanceEntity.issoftdeleted = false;
                                objtran_volunteersyclearanceEntity.BaseSecurityParam = new SecurityCapsule();
                                objtran_volunteersyclearanceEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                await objtran_volunteersyclearanceDataAccessObjects.AddVolunteerSyClearanceResult(Database, transaction, objtran_volunteersyclearanceEntity, cancellationToken);
                                #endregion

                                #region TABLE:Tran_SyExamResult
                                tran_syexamresultDataAccessObjects objtran_syexamresultDataAccessObjects = new tran_syexamresultDataAccessObjects(this.Context);
                                tran_syexamresultEntity objSyExamResultEntity = new tran_syexamresultEntity();
                                objSyExamResultEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                objSyExamResultEntity.registrationid = reg_registrationinfo.registrationid;
                                objSyExamResultEntity.syexamresult = (Int32)SyExamResultEnum.Waiting;
                                objSyExamResultEntity.syexamcomment = null;
                                objSyExamResultEntity.syexamresultdate = null;
                                objSyExamResultEntity.issoftdeleted = false;
                                objSyExamResultEntity.BaseSecurityParam = new SecurityCapsule();
                                objSyExamResultEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                await objtran_syexamresultDataAccessObjects.AddSyExamResult(Database, transaction, objSyExamResultEntity, cancellationToken);
                                #endregion
                            }
                            cmd.Dispose();
                        }
                    }
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GroupForwardSecurityExamination"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        async Task<long> Ireg_registrationinfoDataAccessObjects.ApproveSecurityExaminationReTest(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "KAF_Reg_Registrationinfo_Upd_ApproveReTestSyExam";
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            transactioncodeGen objTranIDGen = new transactioncodeGen();
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillParameters(reg_registrationinfo, cmd, Database);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);

                    if (reg_registrationinfo.issyretestapproved.HasValue)
                        Database.AddInParameter(cmd, "@isSyReTestApproved", DbType.Boolean, reg_registrationinfo.issyretestapproved);

                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    if (returnCode > 0)
                    {
                        #region TABLE:Tran_ApplicantReTestApproval
                        tran_applicantretestapprovalDataAccessObjects objtran_applicantretestapprovalDataAccessObjects = new tran_applicantretestapprovalDataAccessObjects(this.Context);
                        tran_applicantretestapprovalEntity objtran_applicantretestapprovalEntity = new tran_applicantretestapprovalEntity();
                        objtran_applicantretestapprovalEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                        objtran_applicantretestapprovalEntity.registrationid = reg_registrationinfo.registrationid;
                        objtran_applicantretestapprovalEntity.resulttypeid = (int)ReTestResultTypeEnum.Security;
                        objtran_applicantretestapprovalEntity.clearanceby = reg_registrationinfo.BaseSecurityParam.updatedbyusername;
                        objtran_applicantretestapprovalEntity.clearancedate = DateTime.Now;
                        objtran_applicantretestapprovalEntity.BaseSecurityParam = new SecurityCapsule();
                        objtran_applicantretestapprovalEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                        await objtran_applicantretestapprovalDataAccessObjects.AddReTestApproval(Database, transaction, objtran_applicantretestapprovalEntity, cancellationToken);
                        #endregion
                    }
                    cmd.Dispose();
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.ApproveSecurityExaminationReTest"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        async Task<long> Ireg_registrationinfoDataAccessObjects.GroupApproveSecurityExaminationReTest(List<reg_registrationinfoEntity> reg_registrationinfoList, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "KAF_Reg_Registrationinfo_Upd_ApproveReTestSyExam";
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            transactioncodeGen objTranIDGen = new transactioncodeGen();
            try
            {
                if (reg_registrationinfoList != null && reg_registrationinfoList.Count > 0)
                {
                    foreach (reg_registrationinfoEntity reg_registrationinfo in reg_registrationinfoList)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                        {
                            FillParameters(reg_registrationinfo, cmd, Database);
                            FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                            AddOutputParameter(cmd);

                            if (reg_registrationinfo.issyretestapproved.HasValue)
                                Database.AddInParameter(cmd, "@isSyReTestApproved", DbType.Boolean, reg_registrationinfo.issyretestapproved);

                            IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                            while (!result.IsCompleted)
                            {
                            }
                            returnCode = Database.EndExecuteNonQuery(result);
                            returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                            if (returnCode > 0)
                            {
                                #region TABLE:Tran_ApplicantReTestApproval
                                tran_applicantretestapprovalDataAccessObjects objtran_applicantretestapprovalDataAccessObjects = new tran_applicantretestapprovalDataAccessObjects(this.Context);
                                tran_applicantretestapprovalEntity objtran_applicantretestapprovalEntity = new tran_applicantretestapprovalEntity();
                                objtran_applicantretestapprovalEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                objtran_applicantretestapprovalEntity.registrationid = reg_registrationinfo.registrationid;
                                objtran_applicantretestapprovalEntity.resulttypeid = (int)ReTestResultTypeEnum.Security;
                                objtran_applicantretestapprovalEntity.clearanceby = reg_registrationinfo.BaseSecurityParam.updatedbyusername;
                                objtran_applicantretestapprovalEntity.clearancedate = DateTime.Now;
                                objtran_applicantretestapprovalEntity.BaseSecurityParam = new SecurityCapsule();
                                objtran_applicantretestapprovalEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                await objtran_applicantretestapprovalDataAccessObjects.AddReTestApproval(Database, transaction, objtran_applicantretestapprovalEntity, cancellationToken);
                                #endregion
                            }
                            cmd.Dispose();
                        }
                    }
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GroupApproveSecurityExaminationReTest"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        async Task<long> Ireg_registrationinfoDataAccessObjects.SecurityExaminationResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "KAF_Reg_Registrationinfo_Upd_SyExamResult";
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            transactioncodeGen objTranIDGen = new transactioncodeGen();
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillParameters(reg_registrationinfo, cmd, Database);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);

                    if ((reg_registrationinfo.syexamresult.HasValue))
                        Database.AddInParameter(cmd, "@SyExamResult", DbType.Int32, reg_registrationinfo.syexamresult);
                    if (!(string.IsNullOrEmpty(reg_registrationinfo.syexamcomment)))
                        Database.AddInParameter(cmd, "@SyExamComment", DbType.String, reg_registrationinfo.syexamcomment);
                    if ((reg_registrationinfo.syexamresultdate.HasValue))
                        Database.AddInParameter(cmd, "@SyExamResultDate", DbType.DateTime, reg_registrationinfo.syexamresultdate);
                    if (reg_registrationinfo.isapplyotherbatchallowed.HasValue)
                        Database.AddInParameter(cmd, "@isApplyOtherBatchAllowed", DbType.Boolean, reg_registrationinfo.isapplyotherbatchallowed);
                    if (reg_registrationinfo.issecurityforwarded.HasValue)
                        Database.AddInParameter(cmd, "@IsSecurityForwarded", DbType.Boolean, reg_registrationinfo.issecurityforwarded);
                    if (reg_registrationinfo.syprofileprint.HasValue)
                        Database.AddInParameter(cmd, "@SyProfilePrint", DbType.Boolean, reg_registrationinfo.syprofileprint);

                    bool issyresultexpired = false;
                    if (reg_registrationinfo.issyresultexpired == true && reg_registrationinfo.syexamresult == (Int32)SyExamResultEnum.Agree)
                    {
                        issyresultexpired = true;
                        reg_registrationinfo.issyresultexpired = false;
                        reg_registrationinfo.issyretestapproved = false;
                        if (reg_registrationinfo.issyresultexpired.HasValue)
                            Database.AddInParameter(cmd, "@isSyResultExpired", DbType.Boolean, reg_registrationinfo.issyresultexpired);
                        if (reg_registrationinfo.issyretestapproved.HasValue)
                            Database.AddInParameter(cmd, "@isSyReTestApproved", DbType.Boolean, reg_registrationinfo.issyretestapproved);
                    }

                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    if (returnCode > 0)
                    {
                        if (reg_registrationinfo.previousSyExamResult != reg_registrationinfo.syexamresult)
                        {
                            #region TABLE:Reg_ApplicantPhases
                            tran_applicantphasesDataAccessObjects objtran_applicantphasesDataAccessObjects = new tran_applicantphasesDataAccessObjects(this.Context);
                            tran_applicantphasesEntity objtran_applicantphasesEntity = new tran_applicantphasesEntity();
                            objtran_applicantphasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                            objtran_applicantphasesEntity.registrationid = reg_registrationinfo.registrationid;
                            objtran_applicantphasesEntity = await objtran_applicantphasesDataAccessObjects.GetSinglebyBasicInfoIDRegistrationID(Database, transaction, objtran_applicantphasesEntity, cancellationToken);

                            if (objtran_applicantphasesEntity != null)
                            {
                                if (objtran_applicantphasesEntity.phaseid == (long)ApplicantPhasesEnum.SecurityCheck
                                    && reg_registrationinfo.syexamresult != (Int32)SyExamResultEnum.Rollback)
                                {
                                    tran_applicantphasesEntity objApplicantPhasesEntity = new tran_applicantphasesEntity();
                                    objApplicantPhasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                    objApplicantPhasesEntity.registrationid = reg_registrationinfo.registrationid;
                                    objApplicantPhasesEntity.batchid = reg_registrationinfo.batchid;
                                    objApplicantPhasesEntity.phaseid = (long)ApplicantPhasesEnum.SecurityCheck;

                                    if (reg_registrationinfo.syexamresult == (Int32)SyExamResultEnum.Waiting)
                                        objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.New;
                                    else if (reg_registrationinfo.syexamresult == (Int32)SyExamResultEnum.Agree)
                                        objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Agree;
                                    else if (reg_registrationinfo.syexamresult == (Int32)SyExamResultEnum.NotAgree)
                                        objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.NotAgree;
                                    else if (reg_registrationinfo.syexamresult == (Int32)SyExamResultEnum.Hold)
                                        objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Hold;

                                    objApplicantPhasesEntity.submitteddate = DateTime.Now;
                                    objApplicantPhasesEntity.submittedby = reg_registrationinfo.BaseSecurityParam.userid;
                                    objApplicantPhasesEntity.BaseSecurityParam = new SecurityCapsule();
                                    objApplicantPhasesEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                    await objtran_applicantphasesDataAccessObjects.AddApplicationPhase(Database, transaction, objApplicantPhasesEntity, cancellationToken);
                                }
                                else if (objtran_applicantphasesEntity.phaseid == (long)ApplicantPhasesEnum.SecurityCheck
                                        && reg_registrationinfo.syexamresult == (Int32)SyExamResultEnum.Rollback
                                        && issyresultexpired == false)
                                {
                                    tran_applicantphasesEntity objApplicantPhasesEntity = new tran_applicantphasesEntity();
                                    objApplicantPhasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                    objApplicantPhasesEntity.registrationid = reg_registrationinfo.registrationid;
                                    objApplicantPhasesEntity.batchid = reg_registrationinfo.batchid;
                                    objApplicantPhasesEntity.phaseid = (long)ApplicantPhasesEnum.Audit;
                                    objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Passed;
                                    objApplicantPhasesEntity.remarks = "Rollback from Security Examination";
                                    objApplicantPhasesEntity.submitteddate = DateTime.Now;
                                    objApplicantPhasesEntity.submittedby = reg_registrationinfo.BaseSecurityParam.userid;
                                    objApplicantPhasesEntity.BaseSecurityParam = new SecurityCapsule();
                                    objApplicantPhasesEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                    await objtran_applicantphasesDataAccessObjects.AddApplicationPhase(Database, transaction, objApplicantPhasesEntity, cancellationToken);

                                    #region TABLE:Tran_VolunteerSyClearance
                                    tran_volunteersyclearanceDataAccessObjects objtran_volunteersyclearanceDataAccessObjects = new tran_volunteersyclearanceDataAccessObjects(this.Context);
                                    tran_volunteersyclearanceEntity objtran_volunteersyclearanceEntity = new tran_volunteersyclearanceEntity();
                                    objtran_volunteersyclearanceEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                    objtran_volunteersyclearanceEntity.registrationid = reg_registrationinfo.registrationid;
                                    objtran_volunteersyclearanceEntity.syclearanceresult = (int)SyClearanceResultEnum.Rollback;
                                    objtran_volunteersyclearanceEntity.remarks = !string.IsNullOrEmpty(reg_registrationinfo.syexamcomment) ? reg_registrationinfo.syexamcomment : "Rollback from Security Examination";
                                    objtran_volunteersyclearanceEntity.issoftdeleted = false;
                                    objtran_volunteersyclearanceEntity.BaseSecurityParam = new SecurityCapsule();
                                    objtran_volunteersyclearanceEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                    await objtran_volunteersyclearanceDataAccessObjects.AddVolunteerSyClearanceResult(Database, transaction, objtran_volunteersyclearanceEntity, cancellationToken);
                                    #endregion
                                }

                                if (objtran_applicantphasesEntity.phaseid == (long)ApplicantPhasesEnum.SecurityCheck
                                    && reg_registrationinfo.syexamresult == (Int32)SyExamResultEnum.Agree
                                    && issyresultexpired == true) {
                                    tran_applicantphasesEntity objtran_2ndlastapplicantphasesEntity = new tran_applicantphasesEntity();
                                    objtran_2ndlastapplicantphasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                    objtran_2ndlastapplicantphasesEntity.registrationid = reg_registrationinfo.registrationid;
                                    objtran_2ndlastapplicantphasesEntity = await objtran_applicantphasesDataAccessObjects.GetSingle2ndLastPhasebyBasicInfoIDRegistrationID(Database, transaction, objtran_2ndlastapplicantphasesEntity, cancellationToken);

                                    tran_applicantphasesEntity objApplicantPhasesEntity = new tran_applicantphasesEntity();
                                    objApplicantPhasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                    objApplicantPhasesEntity.registrationid = reg_registrationinfo.registrationid;
                                    objApplicantPhasesEntity.batchid = reg_registrationinfo.batchid;

                                    if (reg_registrationinfo.ismedresultexpired == true || reg_registrationinfo.ispsychoresultexpired == true)
                                    {
                                        objApplicantPhasesEntity.phaseid = (long)ApplicantPhasesEnum.MedicalCheck;
                                        objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.ReTest;
                                    }
                                    else {
                                        objApplicantPhasesEntity.phaseid = objtran_2ndlastapplicantphasesEntity.phaseid;
                                        objApplicantPhasesEntity.statusid = objtran_2ndlastapplicantphasesEntity.statusid;
                                    }

                                    objApplicantPhasesEntity.submitteddate = DateTime.Now;
                                    objApplicantPhasesEntity.submittedby = reg_registrationinfo.BaseSecurityParam.userid;
                                    objApplicantPhasesEntity.BaseSecurityParam = new SecurityCapsule();
                                    objApplicantPhasesEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                    await objtran_applicantphasesDataAccessObjects.AddApplicationPhase(Database, transaction, objApplicantPhasesEntity, cancellationToken);
                                }
                            }
                            #endregion

                            #region TABLE:Tran_SyExamResult
                            tran_syexamresultDataAccessObjects objtran_syexamresultDataAccessObjects = new tran_syexamresultDataAccessObjects(this.Context);
                            tran_syexamresultEntity objSyExamResultEntity = new tran_syexamresultEntity();
                            objSyExamResultEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                            objSyExamResultEntity.registrationid = reg_registrationinfo.registrationid;
                            objSyExamResultEntity.syexamresult = reg_registrationinfo.syexamresult;
                            objSyExamResultEntity.syexamcomment = reg_registrationinfo.syexamcomment;
                            objSyExamResultEntity.syexamresultdate = reg_registrationinfo.syexamresultdate;
                            objSyExamResultEntity.issoftdeleted = false;
                            objSyExamResultEntity.BaseSecurityParam = new SecurityCapsule();
                            objSyExamResultEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                            await objtran_syexamresultDataAccessObjects.AddSyExamResult(Database, transaction, objSyExamResultEntity, cancellationToken);
                            #endregion
                        }

                        #region TABLE:Reg_StudentFileStorage
                        IList<reg_studentfilestorageEntity> listAdded = reg_registrationinfo.DocumentList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                        IList<reg_studentfilestorageEntity> listUpdated = reg_registrationinfo.DocumentList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                        IList<reg_studentfilestorageEntity> listDeleted = reg_registrationinfo.DocumentList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                        reg_studentfilestorageDataAccessObjects objreg_studentfilestorageDataAccessObjects = new reg_studentfilestorageDataAccessObjects(this.Context);
                        await objreg_studentfilestorageDataAccessObjects.SaveDocumentList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
                        #endregion

                    }
                    cmd.Dispose();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.SecurityExaminationResultUpdate"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        async Task<long> Ireg_registrationinfoDataAccessObjects.CentralAgencySyResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "KAF_Reg_Registrationinfo_Upd_CentralAgencySyResult";
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            transactioncodeGen objTranIDGen = new transactioncodeGen();
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillParameters(reg_registrationinfo, cmd, Database);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);

                    if ((reg_registrationinfo.centralagencysyresult.HasValue))
                        Database.AddInParameter(cmd, "@CentralAgencySyResult", DbType.Boolean, reg_registrationinfo.centralagencysyresult);
                    if (!(string.IsNullOrEmpty(reg_registrationinfo.centralagencysycomment)))
                        Database.AddInParameter(cmd, "@CentralAgencySyComment", DbType.String, reg_registrationinfo.centralagencysycomment);
                    if ((reg_registrationinfo.centralagencysyresultdate.HasValue))
                        Database.AddInParameter(cmd, "@CentralAgencySyResultDate", DbType.DateTime, reg_registrationinfo.centralagencysyresultdate);

                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    if (returnCode > 0)
                    {
                        //if (reg_registrationinfo.syexamresult == (Int32)SyExamResultEnum.Passed)
                        //{
                        //    #region TABLE:Reg_ApplicantPhases
                        //    tran_applicantphasesDataAccessObjects objtran_applicantphasesDataAccessObjects = new tran_applicantphasesDataAccessObjects(this.Context);
                        //    tran_applicantphasesEntity objApplicantPhasesEntity = new tran_applicantphasesEntity();
                        //    objApplicantPhasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                        //    objApplicantPhasesEntity.registrationid = reg_registrationinfo.registrationid;
                        //    objApplicantPhasesEntity.batchid = reg_registrationinfo.batchid;
                        //    objApplicantPhasesEntity.phaseid = (long)ApplicantPhasesEnum.SecurityChecked;
                        //    objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.New;
                        //    objApplicantPhasesEntity.submitteddate = DateTime.Now;
                        //    objApplicantPhasesEntity.submittedby = reg_registrationinfo.BaseSecurityParam.userid;
                        //    objApplicantPhasesEntity.BaseSecurityParam = new SecurityCapsule();
                        //    objApplicantPhasesEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                        //    await objtran_applicantphasesDataAccessObjects.AddApplicationPhase(Database, transaction, objApplicantPhasesEntity, cancellationToken);
                        //    #endregion
                        //}

                        #region TABLE:Tran_CentralAgencySyResult
                        tran_centralagencysyresultDataAccessObjects objtran_centralagencysyresultDataAccessObjects = new tran_centralagencysyresultDataAccessObjects(this.Context);
                        tran_centralagencysyresultEntity objCentralAgencySyResultEntity = new tran_centralagencysyresultEntity();
                        objCentralAgencySyResultEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                        objCentralAgencySyResultEntity.registrationid = reg_registrationinfo.registrationid;
                        objCentralAgencySyResultEntity.centralagencysyresult = reg_registrationinfo.centralagencysyresult;
                        objCentralAgencySyResultEntity.centralagencysycomment = reg_registrationinfo.centralagencysycomment;
                        objCentralAgencySyResultEntity.centralagencysyresultdate = reg_registrationinfo.centralagencysyresultdate;
                        objCentralAgencySyResultEntity.issoftdeleted = false;
                        objCentralAgencySyResultEntity.BaseSecurityParam = new SecurityCapsule();
                        objCentralAgencySyResultEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                        await objtran_centralagencysyresultDataAccessObjects.AddCentralAgencyResult(Database, transaction, objCentralAgencySyResultEntity, cancellationToken);
                        #endregion

                    }
                    cmd.Dispose();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.CentralAgencySyResultUpdate"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        async Task<long> Ireg_registrationinfoDataAccessObjects.ForwardUnitClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "KAF_Reg_Registrationinfo_Upd_FwdUnitClearance";
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            transactioncodeGen objTranIDGen = new transactioncodeGen();
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillParameters(reg_registrationinfo, cmd, Database);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);

                    if (reg_registrationinfo.isunitforwarded.HasValue)
                        Database.AddInParameter(cmd, "@IsUnitForwarded", DbType.Boolean, reg_registrationinfo.isunitforwarded);
                    if ((reg_registrationinfo.unitclearanceresult.HasValue))
                        Database.AddInParameter(cmd, "@UnitClearanceResult", DbType.Int32, reg_registrationinfo.unitclearanceresult);
                    if ((reg_registrationinfo.unitclearancemark.HasValue))
                        Database.AddInParameter(cmd, "@UnitClearanceMarks", DbType.Decimal, reg_registrationinfo.unitclearancemark);
                    if (!(string.IsNullOrEmpty(reg_registrationinfo.unitclearancecomment)))
                        Database.AddInParameter(cmd, "@UnitClearanceComment", DbType.String, reg_registrationinfo.unitclearancecomment);
                    if ((reg_registrationinfo.unitclearanceresultDate.HasValue))
                        Database.AddInParameter(cmd, "@UnitClearanceResultDate", DbType.DateTime, reg_registrationinfo.unitclearanceresultDate);

                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    if (returnCode > 0)
                    {
                        //get applicant phase info
                        tran_applicantphasesDataAccessObjects objtran_applicantphasesDataAccessObjects = new tran_applicantphasesDataAccessObjects(this.Context);
                        tran_applicantphasesEntity existingApplicantPhase = new tran_applicantphasesEntity();
                        existingApplicantPhase.basicinfoid = reg_registrationinfo.basicinfoid;
                        existingApplicantPhase.registrationid = reg_registrationinfo.registrationid;
                        existingApplicantPhase = await objtran_applicantphasesDataAccessObjects.GetSinglebyBasicInfoIDRegistrationID(Database, transaction, existingApplicantPhase, cancellationToken);

                        if (existingApplicantPhase != null)
                        {
                            //get batch details
                            gen_batchDataAccessObjects objgen_batch = new gen_batchDataAccessObjects(this.Context);
                            gen_batchEntity objgen_BatchEntity = await objgen_batch.GetSingleBatchInfo(new gen_batchEntity { batchid = reg_registrationinfo.batchid }, cancellationToken);

                            tran_applicantphasesEntity objApplicantPhasesEntity = new tran_applicantphasesEntity();

                            if (objgen_BatchEntity != null && objgen_BatchEntity.militarytype == (long)MilitaryTypeEnum.Professionals)
                            {
                                if (existingApplicantPhase.phaseid == (long)ApplicantPhasesEnum.SecurityCheck
                                    && existingApplicantPhase.statusid == (long)ApplicantStatusEnum.Agree
                                && reg_registrationinfo.syexamresult == (Int32)SyExamResultEnum.Agree
                                && reg_registrationinfo.isunitforwarded == true)
                                {
                                    objApplicantPhasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                    objApplicantPhasesEntity.registrationid = reg_registrationinfo.registrationid;
                                    objApplicantPhasesEntity.batchid = reg_registrationinfo.batchid;
                                    objApplicantPhasesEntity.phaseid = (long)ApplicantPhasesEnum.UnitCheck;
                                    objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.New;
                                    objApplicantPhasesEntity.submitteddate = DateTime.Now;
                                    objApplicantPhasesEntity.submittedby = reg_registrationinfo.BaseSecurityParam.userid;
                                    objApplicantPhasesEntity.BaseSecurityParam = new SecurityCapsule();
                                    objApplicantPhasesEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                    await objtran_applicantphasesDataAccessObjects.AddApplicationPhase(Database, transaction, objApplicantPhasesEntity, cancellationToken);
                                }

                            }
                        }

                        #region TABLE:Tran_VolunteerUnitClearance
                        tran_volunteerunitclearanceDataAccessObjects objtran_volunteerunitclearanceDataAccessObjects = new tran_volunteerunitclearanceDataAccessObjects(this.Context);
                        tran_volunteerunitclearanceEntity objtran_volunteerunitclearanceEntity = new tran_volunteerunitclearanceEntity();
                        objtran_volunteerunitclearanceEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                        objtran_volunteerunitclearanceEntity.registrationid = reg_registrationinfo.registrationid;
                        objtran_volunteerunitclearanceEntity.unitclearanceresult = (int)VolunteerUnitClearanceResultEnum.Forward;
                        objtran_volunteerunitclearanceEntity.issoftdeleted = false;
                        objtran_volunteerunitclearanceEntity.BaseSecurityParam = new SecurityCapsule();
                        objtran_volunteerunitclearanceEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                        await objtran_volunteerunitclearanceDataAccessObjects.AddVolunteerUnitClearance(Database, transaction, objtran_volunteerunitclearanceEntity, cancellationToken);
                        #endregion

                        #region TABLE:Tran_UnitClearanceResult
                        tran_unitclearanceresultDataAccessObjects objtran_unitclearanceresultDataAccessObjects = new tran_unitclearanceresultDataAccessObjects(this.Context);
                        tran_unitclearanceresultEntity objtran_unitclearanceresultEntity = new tran_unitclearanceresultEntity();
                        objtran_unitclearanceresultEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                        objtran_unitclearanceresultEntity.registrationid = reg_registrationinfo.registrationid;
                        objtran_unitclearanceresultEntity.unitclearanceresult = (Int32)UnitClearanceResultEnum.Waiting;
                        objtran_unitclearanceresultEntity.unitclearancemarks = null;
                        objtran_unitclearanceresultEntity.unitclearancecomment = null;
                        objtran_unitclearanceresultEntity.unitclearanceresultdate = null;
                        objtran_unitclearanceresultEntity.issoftdeleted = false;
                        objtran_unitclearanceresultEntity.BaseSecurityParam = new SecurityCapsule();
                        objtran_unitclearanceresultEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                        await objtran_unitclearanceresultDataAccessObjects.AddUnitClearanceResult(Database, transaction, objtran_unitclearanceresultEntity, cancellationToken);
                        #endregion
                    }
                    cmd.Dispose();
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.ForwardUnitClearance"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        async Task<long> Ireg_registrationinfoDataAccessObjects.GroupForwardUnitClearance(List<reg_registrationinfoEntity> reg_registrationinfoList, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "KAF_Reg_Registrationinfo_Upd_FwdUnitClearance";
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            transactioncodeGen objTranIDGen = new transactioncodeGen();
            try
            {
                if (reg_registrationinfoList != null && reg_registrationinfoList.Count > 0)
                {
                    foreach (reg_registrationinfoEntity reg_registrationinfo in reg_registrationinfoList)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                        {
                            FillParameters(reg_registrationinfo, cmd, Database);
                            FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                            AddOutputParameter(cmd);

                            if (reg_registrationinfo.isunitforwarded.HasValue)
                                Database.AddInParameter(cmd, "@IsUnitForwarded", DbType.Boolean, reg_registrationinfo.isunitforwarded);
                            if ((reg_registrationinfo.unitclearanceresult.HasValue))
                                Database.AddInParameter(cmd, "@UnitClearanceResult", DbType.Int32, reg_registrationinfo.unitclearanceresult);
                            if ((reg_registrationinfo.unitclearancemark.HasValue))
                                Database.AddInParameter(cmd, "@UnitClearanceMarks", DbType.Decimal, reg_registrationinfo.unitclearancemark);
                            if (!(string.IsNullOrEmpty(reg_registrationinfo.unitclearancecomment)))
                                Database.AddInParameter(cmd, "@UnitClearanceComment", DbType.String, reg_registrationinfo.unitclearancecomment);
                            if ((reg_registrationinfo.unitclearanceresultDate.HasValue))
                                Database.AddInParameter(cmd, "@UnitClearanceResultDate", DbType.DateTime, reg_registrationinfo.unitclearanceresultDate);

                            IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                            while (!result.IsCompleted)
                            {
                            }
                            returnCode = Database.EndExecuteNonQuery(result);
                            returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                            if (returnCode > 0)
                            {
                                //get applicant phase info
                                tran_applicantphasesDataAccessObjects objtran_applicantphasesDataAccessObjects = new tran_applicantphasesDataAccessObjects(this.Context);
                                tran_applicantphasesEntity existingApplicantPhase = new tran_applicantphasesEntity();
                                existingApplicantPhase.basicinfoid = reg_registrationinfo.basicinfoid;
                                existingApplicantPhase.registrationid = reg_registrationinfo.registrationid;
                                existingApplicantPhase = await objtran_applicantphasesDataAccessObjects.GetSinglebyBasicInfoIDRegistrationID(Database, transaction, existingApplicantPhase, cancellationToken);

                                if (existingApplicantPhase != null)
                                {
                                    //get batch details
                                    gen_batchDataAccessObjects objgen_batch = new gen_batchDataAccessObjects(this.Context);
                                    gen_batchEntity objgen_BatchEntity = await objgen_batch.GetSingleBatchInfo(new gen_batchEntity { batchid = reg_registrationinfo.batchid }, cancellationToken);

                                    tran_applicantphasesEntity objApplicantPhasesEntity = new tran_applicantphasesEntity();

                                    if (objgen_BatchEntity != null && objgen_BatchEntity.militarytype == (long)MilitaryTypeEnum.Professionals)
                                    {
                                        if (existingApplicantPhase.phaseid == (long)ApplicantPhasesEnum.SecurityCheck
                                            && existingApplicantPhase.statusid == (long)ApplicantStatusEnum.Agree
                                        && reg_registrationinfo.syexamresult == (Int32)SyExamResultEnum.Agree
                                        && reg_registrationinfo.isunitforwarded == true)
                                        {
                                            objApplicantPhasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                            objApplicantPhasesEntity.registrationid = reg_registrationinfo.registrationid;
                                            objApplicantPhasesEntity.batchid = reg_registrationinfo.batchid;
                                            objApplicantPhasesEntity.phaseid = (long)ApplicantPhasesEnum.UnitCheck;
                                            objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.New;
                                            objApplicantPhasesEntity.submitteddate = DateTime.Now;
                                            objApplicantPhasesEntity.submittedby = reg_registrationinfo.BaseSecurityParam.userid;
                                            objApplicantPhasesEntity.BaseSecurityParam = new SecurityCapsule();
                                            objApplicantPhasesEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                            await objtran_applicantphasesDataAccessObjects.AddApplicationPhase(Database, transaction, objApplicantPhasesEntity, cancellationToken);
                                        }

                                    }
                                }

                                #region TABLE:Tran_VolunteerUnitClearance
                                tran_volunteerunitclearanceDataAccessObjects objtran_volunteerunitclearanceDataAccessObjects = new tran_volunteerunitclearanceDataAccessObjects(this.Context);
                                tran_volunteerunitclearanceEntity objtran_volunteerunitclearanceEntity = new tran_volunteerunitclearanceEntity();
                                objtran_volunteerunitclearanceEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                objtran_volunteerunitclearanceEntity.registrationid = reg_registrationinfo.registrationid;
                                objtran_volunteerunitclearanceEntity.unitclearanceresult = (int)VolunteerUnitClearanceResultEnum.Forward;
                                objtran_volunteerunitclearanceEntity.issoftdeleted = false;
                                objtran_volunteerunitclearanceEntity.BaseSecurityParam = new SecurityCapsule();
                                objtran_volunteerunitclearanceEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                await objtran_volunteerunitclearanceDataAccessObjects.AddVolunteerUnitClearance(Database, transaction, objtran_volunteerunitclearanceEntity, cancellationToken);
                                #endregion

                                #region TABLE:Tran_UnitClearanceResult
                                tran_unitclearanceresultDataAccessObjects objtran_unitclearanceresultDataAccessObjects = new tran_unitclearanceresultDataAccessObjects(this.Context);
                                tran_unitclearanceresultEntity objtran_unitclearanceresultEntity = new tran_unitclearanceresultEntity();
                                objtran_unitclearanceresultEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                objtran_unitclearanceresultEntity.registrationid = reg_registrationinfo.registrationid;
                                objtran_unitclearanceresultEntity.unitclearanceresult = (Int32)UnitClearanceResultEnum.Waiting;
                                objtran_unitclearanceresultEntity.unitclearancemarks = null;
                                objtran_unitclearanceresultEntity.unitclearancecomment = null;
                                objtran_unitclearanceresultEntity.unitclearanceresultdate = null;
                                objtran_unitclearanceresultEntity.issoftdeleted = false;
                                objtran_unitclearanceresultEntity.BaseSecurityParam = new SecurityCapsule();
                                objtran_unitclearanceresultEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                await objtran_unitclearanceresultDataAccessObjects.AddUnitClearanceResult(Database, transaction, objtran_unitclearanceresultEntity, cancellationToken);
                                #endregion
                            }
                            cmd.Dispose();
                        }
                    }
                    transaction.Commit();
                }


            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GroupForwardUnitClearance"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        async Task<long> Ireg_registrationinfoDataAccessObjects.UnitClearanceResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "KAF_Reg_Registrationinfo_Upd_UnitClearanceResult";
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            transactioncodeGen objTranIDGen = new transactioncodeGen();
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillParameters(reg_registrationinfo, cmd, Database);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);

                    if ((reg_registrationinfo.unitclearanceresult.HasValue))
                        Database.AddInParameter(cmd, "@UnitClearanceResult", DbType.Int32, reg_registrationinfo.unitclearanceresult);
                    if ((reg_registrationinfo.unitclearancemark.HasValue))
                        Database.AddInParameter(cmd, "@UnitClearanceMarks", DbType.Decimal, reg_registrationinfo.unitclearancemark);
                    if (!(string.IsNullOrEmpty(reg_registrationinfo.unitclearancecomment)))
                        Database.AddInParameter(cmd, "@UnitClearanceComment", DbType.String, reg_registrationinfo.unitclearancecomment);
                    if ((reg_registrationinfo.unitclearanceresultDate.HasValue))
                        Database.AddInParameter(cmd, "@UnitClearanceResultDate", DbType.DateTime, reg_registrationinfo.unitclearanceresultDate);
                    if ((reg_registrationinfo.isunitforwarded.HasValue))
                        Database.AddInParameter(cmd, "@IsUnitForwarded", DbType.Boolean, reg_registrationinfo.isunitforwarded);

                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    if (returnCode > 0)
                    {
                        //get batch details
                        gen_batchDataAccessObjects objgen_batch = new gen_batchDataAccessObjects(this.Context);
                        gen_batchEntity objgen_BatchEntity = await objgen_batch.GetSingleBatchInfo(new gen_batchEntity { batchid = reg_registrationinfo.batchid }, cancellationToken);

                        if (objgen_BatchEntity.militarytype == (long)MilitaryTypeEnum.Professionals)
                        {
                            if (reg_registrationinfo.previousUnitClearanceResult != reg_registrationinfo.unitclearanceresult)
                            {
                                #region TABLE:Reg_ApplicantPhases
                                tran_applicantphasesDataAccessObjects objtran_applicantphasesDataAccessObjects = new tran_applicantphasesDataAccessObjects(this.Context);
                                tran_applicantphasesEntity objtran_applicantphasesEntity = new tran_applicantphasesEntity();
                                objtran_applicantphasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                objtran_applicantphasesEntity.registrationid = reg_registrationinfo.registrationid;
                                objtran_applicantphasesEntity = await objtran_applicantphasesDataAccessObjects.GetSinglebyBasicInfoIDRegistrationID(Database, transaction, objtran_applicantphasesEntity, cancellationToken);

                                if (objtran_applicantphasesEntity != null)
                                {
                                    if (objtran_applicantphasesEntity.phaseid == (long)ApplicantPhasesEnum.UnitCheck
                                        && reg_registrationinfo.unitclearanceresult != (int)UnitClearanceResultEnum.Rollback
                                        && reg_registrationinfo.ismedforwarded == false)
                                    {
                                        tran_applicantphasesEntity objApplicantPhasesEntity = new tran_applicantphasesEntity();
                                        objApplicantPhasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                        objApplicantPhasesEntity.registrationid = reg_registrationinfo.registrationid;
                                        objApplicantPhasesEntity.batchid = reg_registrationinfo.batchid;
                                        objApplicantPhasesEntity.phaseid = (long)ApplicantPhasesEnum.UnitCheck;

                                        if (reg_registrationinfo.unitclearanceresult == (Int32)UnitClearanceResultEnum.Waiting)
                                            objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.New;
                                        else if (reg_registrationinfo.unitclearanceresult == (Int32)UnitClearanceResultEnum.Passed)
                                            objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Passed;
                                        else if (reg_registrationinfo.unitclearanceresult == (Int32)UnitClearanceResultEnum.Failed)
                                            objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Failed;

                                        objApplicantPhasesEntity.submitteddate = DateTime.Now;
                                        objApplicantPhasesEntity.submittedby = reg_registrationinfo.BaseSecurityParam.userid;
                                        objApplicantPhasesEntity.BaseSecurityParam = new SecurityCapsule();
                                        objApplicantPhasesEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                        await objtran_applicantphasesDataAccessObjects.AddApplicationPhase(Database, transaction, objApplicantPhasesEntity, cancellationToken);
                                    }
                                    else if (objtran_applicantphasesEntity.phaseid == (long)ApplicantPhasesEnum.UnitCheck
                                        && reg_registrationinfo.unitclearanceresult == (Int32)UnitClearanceResultEnum.Rollback
                                        && reg_registrationinfo.ismedforwarded == false)
                                    {
                                        tran_applicantphasesEntity objApplicantPhasesEntity = new tran_applicantphasesEntity();
                                        objApplicantPhasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                        objApplicantPhasesEntity.registrationid = reg_registrationinfo.registrationid;
                                        objApplicantPhasesEntity.batchid = reg_registrationinfo.batchid;
                                        objApplicantPhasesEntity.phaseid = (long)ApplicantPhasesEnum.SecurityCheck;
                                        objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Agree;
                                        objApplicantPhasesEntity.remarks = "Rollback from Unit Clearance";
                                        objApplicantPhasesEntity.submitteddate = DateTime.Now;
                                        objApplicantPhasesEntity.submittedby = reg_registrationinfo.BaseSecurityParam.userid;
                                        objApplicantPhasesEntity.BaseSecurityParam = new SecurityCapsule();
                                        objApplicantPhasesEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                        await objtran_applicantphasesDataAccessObjects.AddApplicationPhase(Database, transaction, objApplicantPhasesEntity, cancellationToken);

                                        #region TABLE:Tran_VolunteerUnitClearance
                                        tran_volunteerunitclearanceDataAccessObjects objtran_volunteerunitclearanceDataAccessObjects = new tran_volunteerunitclearanceDataAccessObjects(this.Context);
                                        tran_volunteerunitclearanceEntity objtran_volunteerunitclearanceEntity = new tran_volunteerunitclearanceEntity();
                                        objtran_volunteerunitclearanceEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                        objtran_volunteerunitclearanceEntity.registrationid = reg_registrationinfo.registrationid;
                                        objtran_volunteerunitclearanceEntity.unitclearanceresult = (int)VolunteerUnitClearanceResultEnum.Rollback;
                                        objtran_volunteerunitclearanceEntity.remarks = !string.IsNullOrEmpty(reg_registrationinfo.unitclearancecomment) ? reg_registrationinfo.unitclearancecomment : "Rollback from Unit Clearance";
                                        objtran_volunteerunitclearanceEntity.issoftdeleted = false;
                                        objtran_volunteerunitclearanceEntity.BaseSecurityParam = new SecurityCapsule();
                                        objtran_volunteerunitclearanceEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                        await objtran_volunteerunitclearanceDataAccessObjects.AddVolunteerUnitClearance(Database, transaction, objtran_volunteerunitclearanceEntity, cancellationToken);
                                        #endregion
                                    }
                                }
                                #endregion

                                #region TABLE:Tran_UnitClearanceResult
                                tran_unitclearanceresultDataAccessObjects objtran_unitclearanceresultDataAccessObjects = new tran_unitclearanceresultDataAccessObjects(this.Context);
                                tran_unitclearanceresultEntity objtran_unitclearanceresultEntity = new tran_unitclearanceresultEntity();
                                objtran_unitclearanceresultEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                objtran_unitclearanceresultEntity.registrationid = reg_registrationinfo.registrationid;
                                objtran_unitclearanceresultEntity.unitclearanceresult = reg_registrationinfo.unitclearanceresult;
                                objtran_unitclearanceresultEntity.unitclearancemarks = reg_registrationinfo.unitclearancemark;
                                objtran_unitclearanceresultEntity.unitclearancecomment = reg_registrationinfo.unitclearancecomment;
                                objtran_unitclearanceresultEntity.unitclearanceresultdate = reg_registrationinfo.unitclearanceresultDate;
                                objtran_unitclearanceresultEntity.issoftdeleted = false;
                                objtran_unitclearanceresultEntity.BaseSecurityParam = new SecurityCapsule();
                                objtran_unitclearanceresultEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                await objtran_unitclearanceresultDataAccessObjects.AddUnitClearanceResult(Database, transaction, objtran_unitclearanceresultEntity, cancellationToken);
                                #endregion
                            }

                            #region TABLE:Reg_StudentFileStorage
                            IList<reg_studentfilestorageEntity> listAdded = reg_registrationinfo.DocumentList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                            IList<reg_studentfilestorageEntity> listUpdated = reg_registrationinfo.DocumentList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                            IList<reg_studentfilestorageEntity> listDeleted = reg_registrationinfo.DocumentList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                            reg_studentfilestorageDataAccessObjects objreg_studentfilestorageDataAccessObjects = new reg_studentfilestorageDataAccessObjects(this.Context);
                            await objreg_studentfilestorageDataAccessObjects.SaveDocumentList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
                            #endregion
                        }
                    }
                    cmd.Dispose();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.UnitClearanceResultUpdate"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        async Task<long> Ireg_registrationinfoDataAccessObjects.ForwardMedicalClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "KAF_Reg_Registrationinfo_Upd_FwdMedClearance";
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            transactioncodeGen objTranIDGen = new transactioncodeGen();
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillParameters(reg_registrationinfo, cmd, Database);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);

                    if (reg_registrationinfo.ismedforwarded.HasValue)
                        Database.AddInParameter(cmd, "@IsMedForwarded", DbType.Boolean, reg_registrationinfo.ismedforwarded);
                    if ((reg_registrationinfo.medexamresult.HasValue))
                        Database.AddInParameter(cmd, "@MedExamResult", DbType.Int32, reg_registrationinfo.medexamresult);
                    if (!(string.IsNullOrEmpty(reg_registrationinfo.medexamcomment)))
                        Database.AddInParameter(cmd, "@MedExamComment", DbType.String, reg_registrationinfo.medexamcomment);
                    if ((reg_registrationinfo.medexamresultdate.HasValue))
                        Database.AddInParameter(cmd, "@MedExamResultDate", DbType.DateTime, reg_registrationinfo.medexamresultdate);
                    if ((reg_registrationinfo.psychoexamresult.HasValue))
                        Database.AddInParameter(cmd, "@PsychoExamResult", DbType.Int32, reg_registrationinfo.psychoexamresult);
                    if (!(string.IsNullOrEmpty(reg_registrationinfo.psychoexamcomment)))
                        Database.AddInParameter(cmd, "@PsychoExamComment", DbType.String, reg_registrationinfo.psychoexamcomment);
                    if ((reg_registrationinfo.psychoexamResultDate.HasValue))
                        Database.AddInParameter(cmd, "@PsychoExamResultDate", DbType.DateTime, reg_registrationinfo.psychoexamResultDate);

                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    if (returnCode > 0)
                    {
                        #region TABLE:Tran_ApplicantPhases
                        tran_applicantphasesDataAccessObjects objtran_applicantphasesDataAccessObjects = new tran_applicantphasesDataAccessObjects(this.Context);
                        tran_applicantphasesEntity existingApplicantPhase = new tran_applicantphasesEntity();
                        existingApplicantPhase.basicinfoid = reg_registrationinfo.basicinfoid;
                        existingApplicantPhase.registrationid = reg_registrationinfo.registrationid;
                        existingApplicantPhase = await objtran_applicantphasesDataAccessObjects.GetSinglebyBasicInfoIDRegistrationID(Database, transaction, existingApplicantPhase, cancellationToken);

                        if (existingApplicantPhase != null)
                        {
                            //get batch details
                            gen_batchDataAccessObjects objgen_batch = new gen_batchDataAccessObjects(this.Context);
                            gen_batchEntity objgen_BatchEntity = await objgen_batch.GetSingleBatchInfo(new gen_batchEntity { batchid = reg_registrationinfo.batchid }, cancellationToken);

                            tran_applicantphasesEntity objApplicantPhasesEntity = new tran_applicantphasesEntity();

                            if (objgen_BatchEntity != null
                                && ((existingApplicantPhase.phaseid == (long)ApplicantPhasesEnum.SecurityCheck
                                && existingApplicantPhase.statusid == (long)ApplicantStatusEnum.Agree)
                                || (existingApplicantPhase.phaseid == (long)ApplicantPhasesEnum.UnitCheck
                                && objgen_BatchEntity.militarytype == (long)MilitaryTypeEnum.Professionals
                                && existingApplicantPhase.statusid == (long)ApplicantStatusEnum.Passed)))
                            {
                                objApplicantPhasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                objApplicantPhasesEntity.registrationid = reg_registrationinfo.registrationid;
                                objApplicantPhasesEntity.batchid = reg_registrationinfo.batchid;
                                objApplicantPhasesEntity.phaseid = (long)ApplicantPhasesEnum.MedicalCheck;
                                objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.New;
                                objApplicantPhasesEntity.submitteddate = DateTime.Now;
                                objApplicantPhasesEntity.submittedby = reg_registrationinfo.BaseSecurityParam.userid;
                                objApplicantPhasesEntity.BaseSecurityParam = new SecurityCapsule();
                                objApplicantPhasesEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                await objtran_applicantphasesDataAccessObjects.AddApplicationPhase(Database, transaction, objApplicantPhasesEntity, cancellationToken);

                            }
                        }
                        #endregion

                        #region TABLE:Tran_VolunteerMedClearance
                        tran_volunteermedclearanceDataAccessObjects objtran_volunteermedclearanceDataAccessObjects = new tran_volunteermedclearanceDataAccessObjects(this.Context);
                        tran_volunteermedclearanceEntity objtran_volunteermedclearanceEntity = new tran_volunteermedclearanceEntity();
                        objtran_volunteermedclearanceEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                        objtran_volunteermedclearanceEntity.registrationid = reg_registrationinfo.registrationid;
                        objtran_volunteermedclearanceEntity.medclearanceresult = (int)VolunteerMedClearanceResultEnum.Forward;
                        objtran_volunteermedclearanceEntity.issoftdeleted = false;
                        objtran_volunteermedclearanceEntity.BaseSecurityParam = new SecurityCapsule();
                        objtran_volunteermedclearanceEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                        await objtran_volunteermedclearanceDataAccessObjects.AddVolunteerMedicalClearance(Database, transaction, objtran_volunteermedclearanceEntity, cancellationToken);
                        #endregion

                        #region TABLE:Tran_MedExamResult
                        tran_medexamresultDataAccessObjects objtran_medexamresultDataAccessObjects = new tran_medexamresultDataAccessObjects(this.Context);
                        tran_medexamresultEntity objtran_medexamresultEntity = new tran_medexamresultEntity();
                        objtran_medexamresultEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                        objtran_medexamresultEntity.registrationid = reg_registrationinfo.registrationid;
                        objtran_medexamresultEntity.medexamresult = (Int32)MedExamResultEnum.Waiting;
                        objtran_medexamresultEntity.medexamcomment = null;
                        objtran_medexamresultEntity.medexamresultdate = null;
                        objtran_medexamresultEntity.issoftdeleted = false;
                        objtran_medexamresultEntity.BaseSecurityParam = new SecurityCapsule();
                        objtran_medexamresultEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                        await objtran_medexamresultDataAccessObjects.AddMedExamResult(Database, transaction, objtran_medexamresultEntity, cancellationToken);
                        #endregion

                        #region TABLE:Tran_PsychoExamResult
                        tran_psychoexamresultDataAccessObjects objtran_psychoexamresultDataAccessObjects = new tran_psychoexamresultDataAccessObjects(this.Context);
                        tran_psychoexamresultEntity objtran_psychoexamresultEntity = new tran_psychoexamresultEntity();
                        objtran_psychoexamresultEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                        objtran_psychoexamresultEntity.registrationid = reg_registrationinfo.registrationid;
                        objtran_psychoexamresultEntity.psychoexamresult = (Int32)PsychoExamResultEnum.Waiting;
                        objtran_psychoexamresultEntity.psychoexamcomment = null;
                        objtran_psychoexamresultEntity.psychoexamresultdate = null;
                        objtran_psychoexamresultEntity.issoftdeleted = false;
                        objtran_psychoexamresultEntity.BaseSecurityParam = new SecurityCapsule();
                        objtran_psychoexamresultEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                        await objtran_psychoexamresultDataAccessObjects.AddPsychoExamResult(Database, transaction, objtran_psychoexamresultEntity, cancellationToken);
                        #endregion
                    }
                    cmd.Dispose();
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.ForwardMedicalClearance"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        async Task<long> Ireg_registrationinfoDataAccessObjects.GroupForwardMedicalClearance(List<reg_registrationinfoEntity> reg_registrationinfoList, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "KAF_Reg_Registrationinfo_Upd_FwdMedClearance";
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            transactioncodeGen objTranIDGen = new transactioncodeGen();
            try
            {
                if (reg_registrationinfoList != null && reg_registrationinfoList.Count > 0)
                {
                    foreach (reg_registrationinfoEntity reg_registrationinfo in reg_registrationinfoList)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                        {
                            FillParameters(reg_registrationinfo, cmd, Database);
                            FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                            AddOutputParameter(cmd);

                            if (reg_registrationinfo.ismedforwarded.HasValue)
                                Database.AddInParameter(cmd, "@IsMedForwarded", DbType.Boolean, reg_registrationinfo.ismedforwarded);
                            if ((reg_registrationinfo.medexamresult.HasValue))
                                Database.AddInParameter(cmd, "@MedExamResult", DbType.Int32, reg_registrationinfo.medexamresult);
                            if (!(string.IsNullOrEmpty(reg_registrationinfo.medexamcomment)))
                                Database.AddInParameter(cmd, "@MedExamComment", DbType.String, reg_registrationinfo.medexamcomment);
                            if ((reg_registrationinfo.medexamresultdate.HasValue))
                                Database.AddInParameter(cmd, "@MedExamResultDate", DbType.DateTime, reg_registrationinfo.medexamresultdate);
                            if ((reg_registrationinfo.psychoexamresult.HasValue))
                                Database.AddInParameter(cmd, "@PsychoExamResult", DbType.Int32, reg_registrationinfo.psychoexamresult);
                            if (!(string.IsNullOrEmpty(reg_registrationinfo.psychoexamcomment)))
                                Database.AddInParameter(cmd, "@PsychoExamComment", DbType.String, reg_registrationinfo.psychoexamcomment);
                            if ((reg_registrationinfo.psychoexamResultDate.HasValue))
                                Database.AddInParameter(cmd, "@PsychoExamResultDate", DbType.DateTime, reg_registrationinfo.psychoexamResultDate);

                            IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                            while (!result.IsCompleted)
                            {
                            }
                            returnCode = Database.EndExecuteNonQuery(result);
                            returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                            if (returnCode > 0)
                            {
                                #region TABLE:Tran_ApplicantPhases
                                tran_applicantphasesDataAccessObjects objtran_applicantphasesDataAccessObjects = new tran_applicantphasesDataAccessObjects(this.Context);
                                tran_applicantphasesEntity existingApplicantPhase = new tran_applicantphasesEntity();
                                existingApplicantPhase.basicinfoid = reg_registrationinfo.basicinfoid;
                                existingApplicantPhase.registrationid = reg_registrationinfo.registrationid;
                                existingApplicantPhase = await objtran_applicantphasesDataAccessObjects.GetSinglebyBasicInfoIDRegistrationID(Database, transaction, existingApplicantPhase, cancellationToken);

                                if (existingApplicantPhase != null)
                                {
                                    //get batch details
                                    gen_batchDataAccessObjects objgen_batch = new gen_batchDataAccessObjects(this.Context);
                                    gen_batchEntity objgen_BatchEntity = await objgen_batch.GetSingleBatchInfo(new gen_batchEntity { batchid = reg_registrationinfo.batchid }, cancellationToken);

                                    tran_applicantphasesEntity objApplicantPhasesEntity = new tran_applicantphasesEntity();

                                    if (objgen_BatchEntity != null
                                && ((existingApplicantPhase.phaseid == (long)ApplicantPhasesEnum.SecurityCheck
                                && existingApplicantPhase.statusid == (long)ApplicantStatusEnum.Agree)
                                || (existingApplicantPhase.phaseid == (long)ApplicantPhasesEnum.UnitCheck
                                && objgen_BatchEntity.militarytype == (long)MilitaryTypeEnum.Professionals
                                && existingApplicantPhase.statusid == (long)ApplicantStatusEnum.Passed)))
                                    {
                                        objApplicantPhasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                        objApplicantPhasesEntity.registrationid = reg_registrationinfo.registrationid;
                                        objApplicantPhasesEntity.batchid = reg_registrationinfo.batchid;
                                        objApplicantPhasesEntity.phaseid = (long)ApplicantPhasesEnum.MedicalCheck;
                                        objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.New;
                                        objApplicantPhasesEntity.submitteddate = DateTime.Now;
                                        objApplicantPhasesEntity.submittedby = reg_registrationinfo.BaseSecurityParam.userid;
                                        objApplicantPhasesEntity.BaseSecurityParam = new SecurityCapsule();
                                        objApplicantPhasesEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                        await objtran_applicantphasesDataAccessObjects.AddApplicationPhase(Database, transaction, objApplicantPhasesEntity, cancellationToken);

                                    }
                                }
                                #endregion

                                #region TABLE:Tran_VolunteerMedClearance
                                tran_volunteermedclearanceDataAccessObjects objtran_volunteermedclearanceDataAccessObjects = new tran_volunteermedclearanceDataAccessObjects(this.Context);
                                tran_volunteermedclearanceEntity objtran_volunteermedclearanceEntity = new tran_volunteermedclearanceEntity();
                                objtran_volunteermedclearanceEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                objtran_volunteermedclearanceEntity.registrationid = reg_registrationinfo.registrationid;
                                objtran_volunteermedclearanceEntity.medclearanceresult = (int)VolunteerMedClearanceResultEnum.Forward;
                                objtran_volunteermedclearanceEntity.issoftdeleted = false;
                                objtran_volunteermedclearanceEntity.BaseSecurityParam = new SecurityCapsule();
                                objtran_volunteermedclearanceEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                await objtran_volunteermedclearanceDataAccessObjects.AddVolunteerMedicalClearance(Database, transaction, objtran_volunteermedclearanceEntity, cancellationToken);
                                #endregion

                                #region TABLE:Tran_MedExamResult
                                tran_medexamresultDataAccessObjects objtran_medexamresultDataAccessObjects = new tran_medexamresultDataAccessObjects(this.Context);
                                tran_medexamresultEntity objtran_medexamresultEntity = new tran_medexamresultEntity();
                                objtran_medexamresultEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                objtran_medexamresultEntity.registrationid = reg_registrationinfo.registrationid;
                                objtran_medexamresultEntity.medexamresult = (Int32)MedExamResultEnum.Waiting;
                                objtran_medexamresultEntity.medexamcomment = null;
                                objtran_medexamresultEntity.medexamresultdate = null;
                                objtran_medexamresultEntity.issoftdeleted = false;
                                objtran_medexamresultEntity.BaseSecurityParam = new SecurityCapsule();
                                objtran_medexamresultEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                await objtran_medexamresultDataAccessObjects.AddMedExamResult(Database, transaction, objtran_medexamresultEntity, cancellationToken);
                                #endregion

                                #region TABLE:Tran_PsychoExamResult
                                tran_psychoexamresultDataAccessObjects objtran_psychoexamresultDataAccessObjects = new tran_psychoexamresultDataAccessObjects(this.Context);
                                tran_psychoexamresultEntity objtran_psychoexamresultEntity = new tran_psychoexamresultEntity();
                                objtran_psychoexamresultEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                objtran_psychoexamresultEntity.registrationid = reg_registrationinfo.registrationid;
                                objtran_psychoexamresultEntity.psychoexamresult = (Int32)PsychoExamResultEnum.Waiting;
                                objtran_psychoexamresultEntity.psychoexamcomment = null;
                                objtran_psychoexamresultEntity.psychoexamresultdate = null;
                                objtran_psychoexamresultEntity.issoftdeleted = false;
                                objtran_psychoexamresultEntity.BaseSecurityParam = new SecurityCapsule();
                                objtran_psychoexamresultEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                await objtran_psychoexamresultDataAccessObjects.AddPsychoExamResult(Database, transaction, objtran_psychoexamresultEntity, cancellationToken);
                                #endregion
                            }
                            cmd.Dispose();
                        }
                    }
                    transaction.Commit();
                }


            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GroupForwardMedicalClearance"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        async Task<long> Ireg_registrationinfoDataAccessObjects.GeneralMedicalExaminationResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "KAF_Reg_Registrationinfo_Upd_MedExamResult";
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            transactioncodeGen objTranIDGen = new transactioncodeGen();
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillParameters(reg_registrationinfo, cmd, Database);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);

                    if (reg_registrationinfo.ismedforwarded.HasValue)
                        Database.AddInParameter(cmd, "@IsMedForwarded", DbType.Boolean, reg_registrationinfo.ismedforwarded);
                    if ((reg_registrationinfo.medexamresult.HasValue))
                        Database.AddInParameter(cmd, "@MedExamResult", DbType.Int32, reg_registrationinfo.medexamresult);
                    if (!(string.IsNullOrEmpty(reg_registrationinfo.medexamcomment)))
                        Database.AddInParameter(cmd, "@MedExamComment", DbType.String, reg_registrationinfo.medexamcomment);
                    if ((reg_registrationinfo.medexamresultdate.HasValue))
                        Database.AddInParameter(cmd, "@MedExamResultDate", DbType.DateTime, reg_registrationinfo.medexamresultdate);
                    if (reg_registrationinfo.isapplyotherbatchallowed.HasValue)
                        Database.AddInParameter(cmd, "@isApplyOtherBatchAllowed", DbType.Boolean, reg_registrationinfo.isapplyotherbatchallowed);
                    if (reg_registrationinfo.medexamformprint.HasValue)
                        Database.AddInParameter(cmd, "@MedExamFormPrint", DbType.Boolean, reg_registrationinfo.medexamformprint);

                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    if (returnCode > 0)
                    {
                        if (reg_registrationinfo.previousMedExamResult != reg_registrationinfo.medexamresult)
                        {
                            #region TABLE:Reg_ApplicantPhases
                            tran_applicantphasesDataAccessObjects objtran_applicantphasesDataAccessObjects = new tran_applicantphasesDataAccessObjects(this.Context);
                            tran_applicantphasesEntity objtran_applicantphasesEntity = new tran_applicantphasesEntity();
                            objtran_applicantphasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                            objtran_applicantphasesEntity.registrationid = reg_registrationinfo.registrationid;
                            objtran_applicantphasesEntity = await objtran_applicantphasesDataAccessObjects.GetSinglebyBasicInfoIDRegistrationID(Database, transaction, objtran_applicantphasesEntity, cancellationToken);

                            //get batch details
                            gen_batchDataAccessObjects objgen_batch = new gen_batchDataAccessObjects(this.Context);
                            gen_batchEntity objgen_BatchEntity = await objgen_batch.GetSingleBatchInfo(new gen_batchEntity { batchid = reg_registrationinfo.batchid }, cancellationToken);

                            if (objtran_applicantphasesEntity != null)
                            {
                                if (objtran_applicantphasesEntity.phaseid == (long)ApplicantPhasesEnum.MedicalCheck
                                    && reg_registrationinfo.medexamresult == (Int32)MedExamResultEnum.Fit
                                    && reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Fit)
                                {
                                    tran_applicantphasesEntity objApplicantPhasesEntity = new tran_applicantphasesEntity();
                                    objApplicantPhasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                    objApplicantPhasesEntity.registrationid = reg_registrationinfo.registrationid;
                                    objApplicantPhasesEntity.batchid = reg_registrationinfo.batchid;
                                    objApplicantPhasesEntity.phaseid = (long)ApplicantPhasesEnum.MedicalCheck;
                                    objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Fit;
                                    objApplicantPhasesEntity.submitteddate = DateTime.Now;
                                    objApplicantPhasesEntity.submittedby = reg_registrationinfo.BaseSecurityParam.userid;
                                    objApplicantPhasesEntity.BaseSecurityParam = new SecurityCapsule();
                                    objApplicantPhasesEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                    await objtran_applicantphasesDataAccessObjects.AddApplicationPhase(Database, transaction, objApplicantPhasesEntity, cancellationToken);
                                }
                                else if ((objtran_applicantphasesEntity.phaseid == (long)ApplicantPhasesEnum.MedicalCheck
                                    || objtran_applicantphasesEntity.phaseid == (long)ApplicantPhasesEnum.FinalExam)
                                    && (reg_registrationinfo.medexamresult == (Int32)MedExamResultEnum.Waiting
                                    || reg_registrationinfo.medexamresult == (Int32)MedExamResultEnum.Unfit
                                    || reg_registrationinfo.medexamresult == (Int32)MedExamResultEnum.Hold
                                    || reg_registrationinfo.medexamresult == (Int32)MedExamResultEnum.Absent
                                    || reg_registrationinfo.medexamresult == (Int32)MedExamResultEnum.Incomplete)
                                    && reg_registrationinfo.finalexamresult < 1)
                                {
                                    tran_applicantphasesEntity objApplicantPhasesEntity = new tran_applicantphasesEntity();
                                    objApplicantPhasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                    objApplicantPhasesEntity.registrationid = reg_registrationinfo.registrationid;
                                    objApplicantPhasesEntity.batchid = reg_registrationinfo.batchid;
                                    objApplicantPhasesEntity.phaseid = (long)ApplicantPhasesEnum.MedicalCheck;

                                    if (reg_registrationinfo.medexamresult == (Int32)MedExamResultEnum.Waiting
                                        && reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Waiting)
                                    {
                                        objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.New;
                                    }
                                    else if (reg_registrationinfo.medexamresult == (Int32)MedExamResultEnum.Unfit)
                                    {
                                        objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Unfit;
                                    }
                                    else if (reg_registrationinfo.medexamresult == (Int32)MedExamResultEnum.Hold)
                                    {
                                        objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Hold;
                                    }
                                    else if (reg_registrationinfo.medexamresult == (Int32)MedExamResultEnum.Absent)
                                    {
                                        objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Absent;
                                    }
                                    else if (reg_registrationinfo.medexamresult == (Int32)MedExamResultEnum.Incomplete)
                                    {
                                        objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Incomplete;
                                    }
                                    else if (reg_registrationinfo.medexamresult == (Int32)MedExamResultEnum.Fit
                                        && reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Waiting)
                                    {
                                        objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.New;
                                    }
                                    else if (reg_registrationinfo.medexamresult == (Int32)MedExamResultEnum.Waiting
                                        && reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Fit)
                                    {
                                        objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.New;
                                    }
                                    else if ((reg_registrationinfo.medexamresult == (Int32)MedExamResultEnum.Waiting
                                        || reg_registrationinfo.medexamresult == (Int32)MedExamResultEnum.Fit)
                                        && (reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Unfit
                                        || reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Hold
                                        || reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Absent
                                        || reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Incomplete))
                                    {
                                        if (reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Unfit)
                                            objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Unfit;
                                        else if (reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Hold)
                                            objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Hold;
                                        else if (reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Absent)
                                            objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Absent;
                                        else
                                            objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Incomplete;
                                    }
                                    else if (reg_registrationinfo.medexamresult == (Int32)MedExamResultEnum.Fit
                                            && reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Fit)
                                    {
                                        objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Fit;
                                    }

                                    objApplicantPhasesEntity.submitteddate = DateTime.Now;
                                    objApplicantPhasesEntity.submittedby = reg_registrationinfo.BaseSecurityParam.userid;
                                    objApplicantPhasesEntity.BaseSecurityParam = new SecurityCapsule();
                                    objApplicantPhasesEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                    await objtran_applicantphasesDataAccessObjects.AddApplicationPhase(Database, transaction, objApplicantPhasesEntity, cancellationToken);
                                }
                                else if (objtran_applicantphasesEntity.phaseid == (long)ApplicantPhasesEnum.MedicalCheck
                                    && reg_registrationinfo.medexamresult == (Int32)MedExamResultEnum.Rollback)
                                {
                                    tran_applicantphasesEntity objApplicantPhasesEntity = new tran_applicantphasesEntity();
                                    objApplicantPhasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                    objApplicantPhasesEntity.registrationid = reg_registrationinfo.registrationid;
                                    objApplicantPhasesEntity.batchid = reg_registrationinfo.batchid;
                                    if (objgen_BatchEntity != null && objgen_BatchEntity.militarytype == (long)MilitaryTypeEnum.Professionals)
                                    {
                                        objApplicantPhasesEntity.phaseid = (long)ApplicantPhasesEnum.UnitCheck;
                                        objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Passed;
                                    }
                                    else
                                    {
                                        objApplicantPhasesEntity.phaseid = (long)ApplicantPhasesEnum.SecurityCheck;
                                        objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Agree;
                                    }
                                    objApplicantPhasesEntity.submitteddate = DateTime.Now;
                                    objApplicantPhasesEntity.submittedby = reg_registrationinfo.BaseSecurityParam.userid;
                                    objApplicantPhasesEntity.BaseSecurityParam = new SecurityCapsule();
                                    objApplicantPhasesEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                    await objtran_applicantphasesDataAccessObjects.AddApplicationPhase(Database, transaction, objApplicantPhasesEntity, cancellationToken);

                                    #region TABLE:Tran_VolunteerMedClearance
                                    tran_volunteermedclearanceDataAccessObjects objtran_volunteermedclearanceDataAccessObjects = new tran_volunteermedclearanceDataAccessObjects(this.Context);
                                    tran_volunteermedclearanceEntity objtran_volunteermedclearanceEntity = new tran_volunteermedclearanceEntity();
                                    objtran_volunteermedclearanceEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                    objtran_volunteermedclearanceEntity.registrationid = reg_registrationinfo.registrationid;
                                    objtran_volunteermedclearanceEntity.medclearanceresult = (int)VolunteerMedClearanceResultEnum.Rollback;
                                    objtran_volunteermedclearanceEntity.remarks = !string.IsNullOrEmpty(reg_registrationinfo.medexamcomment) ? reg_registrationinfo.medexamcomment : "Rollback from Medical Examination";
                                    objtran_volunteermedclearanceEntity.issoftdeleted = false;
                                    objtran_volunteermedclearanceEntity.BaseSecurityParam = new SecurityCapsule();
                                    objtran_volunteermedclearanceEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                    await objtran_volunteermedclearanceDataAccessObjects.AddVolunteerMedicalClearance(Database, transaction, objtran_volunteermedclearanceEntity, cancellationToken);
                                    #endregion
                                }
                            }
                            #endregion

                            #region TABLE:Tran_MedExamResult
                            tran_medexamresultDataAccessObjects objtran_medexamresultDataAccessObjects = new tran_medexamresultDataAccessObjects(this.Context);
                            tran_medexamresultEntity objtran_medexamresultEntity = new tran_medexamresultEntity();
                            objtran_medexamresultEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                            objtran_medexamresultEntity.registrationid = reg_registrationinfo.registrationid;
                            objtran_medexamresultEntity.medexamresult = reg_registrationinfo.medexamresult;
                            objtran_medexamresultEntity.medexamcomment = reg_registrationinfo.medexamcomment;
                            objtran_medexamresultEntity.medexamresultdate = reg_registrationinfo.medexamresultdate;
                            objtran_medexamresultEntity.issoftdeleted = false;
                            objtran_medexamresultEntity.BaseSecurityParam = new SecurityCapsule();
                            objtran_medexamresultEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                            await objtran_medexamresultDataAccessObjects.AddMedExamResult(Database, transaction, objtran_medexamresultEntity, cancellationToken);
                            #endregion
                        }

                        #region TABLE:Reg_StudentFileStorage
                        IList<reg_studentfilestorageEntity> listAdded = reg_registrationinfo.DocumentList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                        IList<reg_studentfilestorageEntity> listUpdated = reg_registrationinfo.DocumentList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                        IList<reg_studentfilestorageEntity> listDeleted = reg_registrationinfo.DocumentList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                        reg_studentfilestorageDataAccessObjects objreg_studentfilestorageDataAccessObjects = new reg_studentfilestorageDataAccessObjects(this.Context);
                        await objreg_studentfilestorageDataAccessObjects.SaveDocumentList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
                        #endregion
                    }
                    cmd.Dispose();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GeneralMedicalExaminationResultUpdate"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        async Task<long> Ireg_registrationinfoDataAccessObjects.PsychologyExaminationResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "KAF_Reg_Registrationinfo_Upd_PsychoExamResult";
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            transactioncodeGen objTranIDGen = new transactioncodeGen();
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillParameters(reg_registrationinfo, cmd, Database);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);

                    if ((reg_registrationinfo.psychoexamresult.HasValue))
                        Database.AddInParameter(cmd, "@PsychoExamResult", DbType.Int32, reg_registrationinfo.psychoexamresult);
                    if (!(string.IsNullOrEmpty(reg_registrationinfo.psychoexamcomment)))
                        Database.AddInParameter(cmd, "@PsychoExamComment", DbType.String, reg_registrationinfo.psychoexamcomment);
                    if ((reg_registrationinfo.psychoexamResultDate.HasValue))
                        Database.AddInParameter(cmd, "@PsychoExamResultDate", DbType.DateTime, reg_registrationinfo.psychoexamResultDate);
                    if (reg_registrationinfo.isapplyotherbatchallowed.HasValue)
                        Database.AddInParameter(cmd, "@isApplyOtherBatchAllowed", DbType.Boolean, reg_registrationinfo.isapplyotherbatchallowed);

                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    if (returnCode > 0)
                    {
                        if (reg_registrationinfo.previousPsychoExamResult != reg_registrationinfo.psychoexamresult)
                        {
                            #region TABLE:Reg_ApplicantPhases
                            tran_applicantphasesDataAccessObjects objtran_applicantphasesDataAccessObjects = new tran_applicantphasesDataAccessObjects(this.Context);
                            tran_applicantphasesEntity objtran_applicantphasesEntity = new tran_applicantphasesEntity();
                            objtran_applicantphasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                            objtran_applicantphasesEntity.registrationid = reg_registrationinfo.registrationid;
                            objtran_applicantphasesEntity = await objtran_applicantphasesDataAccessObjects.GetSinglebyBasicInfoIDRegistrationID(Database, transaction, objtran_applicantphasesEntity, cancellationToken);

                            //get batch details
                            gen_batchDataAccessObjects objgen_batch = new gen_batchDataAccessObjects(this.Context);
                            gen_batchEntity objgen_BatchEntity = await objgen_batch.GetSingleBatchInfo(new gen_batchEntity { batchid = reg_registrationinfo.batchid }, cancellationToken);

                            if (objtran_applicantphasesEntity != null)
                            {
                                if (objtran_applicantphasesEntity.phaseid == (long)ApplicantPhasesEnum.MedicalCheck
                                    && reg_registrationinfo.medexamresult == (Int32)MedExamResultEnum.Fit
                                    && reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Fit)
                                {
                                    tran_applicantphasesEntity objApplicantPhasesEntity = new tran_applicantphasesEntity();
                                    objApplicantPhasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                    objApplicantPhasesEntity.registrationid = reg_registrationinfo.registrationid;
                                    objApplicantPhasesEntity.batchid = reg_registrationinfo.batchid;
                                    objApplicantPhasesEntity.phaseid = (long)ApplicantPhasesEnum.MedicalCheck;
                                    objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Fit;
                                    objApplicantPhasesEntity.submitteddate = DateTime.Now;
                                    objApplicantPhasesEntity.submittedby = reg_registrationinfo.BaseSecurityParam.userid;
                                    objApplicantPhasesEntity.BaseSecurityParam = new SecurityCapsule();
                                    objApplicantPhasesEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                    await objtran_applicantphasesDataAccessObjects.AddApplicationPhase(Database, transaction, objApplicantPhasesEntity, cancellationToken);
                                }
                                else if ((objtran_applicantphasesEntity.phaseid == (long)ApplicantPhasesEnum.MedicalCheck
                                    || objtran_applicantphasesEntity.phaseid == (long)ApplicantPhasesEnum.FinalExam)
                                    && (reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Waiting
                                    || reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Unfit
                                    || reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Hold
                                    || reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Absent
                                    || reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Incomplete)
                                    && reg_registrationinfo.finalexamresult < 1)
                                {
                                    tran_applicantphasesEntity objApplicantPhasesEntity = new tran_applicantphasesEntity();
                                    objApplicantPhasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                    objApplicantPhasesEntity.registrationid = reg_registrationinfo.registrationid;
                                    objApplicantPhasesEntity.batchid = reg_registrationinfo.batchid;
                                    objApplicantPhasesEntity.phaseid = (long)ApplicantPhasesEnum.MedicalCheck;

                                    if (reg_registrationinfo.medexamresult == (Int32)MedExamResultEnum.Waiting
                                        && reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Waiting)
                                    {
                                        objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.New;
                                    }
                                    else if (reg_registrationinfo.medexamresult == (Int32)MedExamResultEnum.Fit
                                        && reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Waiting)
                                    {
                                        objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.New;
                                    }
                                    else if ((reg_registrationinfo.medexamresult == (Int32)MedExamResultEnum.Waiting
                                        || reg_registrationinfo.medexamresult == (Int32)MedExamResultEnum.Fit)
                                        && (reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Unfit
                                        || reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Hold
                                        || reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Absent
                                        || reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Incomplete))
                                    {
                                        if (reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Unfit)
                                            objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Unfit;
                                        else if (reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Hold)
                                            objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Hold;
                                        else if (reg_registrationinfo.psychoexamresult == (Int32)PsychoExamResultEnum.Absent)
                                            objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Absent;
                                        else
                                            objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Incomplete;
                                    }
                                    else
                                    {
                                        if (reg_registrationinfo.medexamresult == (Int32)MedExamResultEnum.Unfit)
                                        {
                                            objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Unfit;
                                        }
                                        else if (reg_registrationinfo.medexamresult == (Int32)MedExamResultEnum.Hold)
                                        {
                                            objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Hold;
                                        }
                                        else if (reg_registrationinfo.medexamresult == (Int32)MedExamResultEnum.Absent)
                                        {
                                            objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Absent;
                                        }
                                        else if (reg_registrationinfo.medexamresult == (Int32)MedExamResultEnum.Incomplete)
                                        {
                                            objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Incomplete;
                                        }
                                    }

                                    objApplicantPhasesEntity.submitteddate = DateTime.Now;
                                    objApplicantPhasesEntity.submittedby = reg_registrationinfo.BaseSecurityParam.userid;
                                    objApplicantPhasesEntity.BaseSecurityParam = new SecurityCapsule();
                                    objApplicantPhasesEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                    await objtran_applicantphasesDataAccessObjects.AddApplicationPhase(Database, transaction, objApplicantPhasesEntity, cancellationToken);
                                }
                            }
                            #endregion

                            #region TABLE:Tran_PsychoExamResult
                            if (reg_registrationinfo.previousPsychoExamResult != reg_registrationinfo.psychoexamresult)
                            {
                                tran_psychoexamresultDataAccessObjects objtran_psychoexamresultDataAccessObjects = new tran_psychoexamresultDataAccessObjects(this.Context);
                                tran_psychoexamresultEntity objtran_psychoexamresultEntity = new tran_psychoexamresultEntity();
                                objtran_psychoexamresultEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                objtran_psychoexamresultEntity.registrationid = reg_registrationinfo.registrationid;
                                objtran_psychoexamresultEntity.psychoexamresult = reg_registrationinfo.psychoexamresult;
                                objtran_psychoexamresultEntity.psychoexamcomment = reg_registrationinfo.psychoexamcomment;
                                objtran_psychoexamresultEntity.psychoexamresultdate = reg_registrationinfo.psychoexamResultDate;
                                objtran_psychoexamresultEntity.issoftdeleted = false;
                                objtran_psychoexamresultEntity.BaseSecurityParam = new SecurityCapsule();
                                objtran_psychoexamresultEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                await objtran_psychoexamresultDataAccessObjects.AddPsychoExamResult(Database, transaction, objtran_psychoexamresultEntity, cancellationToken);
                            }
                            #endregion
                        }

                        #region TABLE:Reg_StudentFileStorage
                        IList<reg_studentfilestorageEntity> listAdded = reg_registrationinfo.DocumentList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                        IList<reg_studentfilestorageEntity> listUpdated = reg_registrationinfo.DocumentList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                        IList<reg_studentfilestorageEntity> listDeleted = reg_registrationinfo.DocumentList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                        reg_studentfilestorageDataAccessObjects objreg_studentfilestorageDataAccessObjects = new reg_studentfilestorageDataAccessObjects(this.Context);
                        await objreg_studentfilestorageDataAccessObjects.SaveDocumentList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
                        #endregion
                    }
                    cmd.Dispose();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.PsychologyExaminationResultUpdate"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        async Task<long> Ireg_registrationinfoDataAccessObjects.FinalExaminationResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "KAF_Reg_Registrationinfo_Upd_FinalExamResult";
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            transactioncodeGen objTranIDGen = new transactioncodeGen();
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillParameters(reg_registrationinfo, cmd, Database);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);

                    if ((reg_registrationinfo.finalexamresult.HasValue))
                        Database.AddInParameter(cmd, "@FinalExamResult", DbType.Int32, reg_registrationinfo.finalexamresult);
                    if (!(string.IsNullOrEmpty(reg_registrationinfo.finalexamcomment)))
                        Database.AddInParameter(cmd, "@FinalExamComment", DbType.String, reg_registrationinfo.finalexamcomment);
                    if ((reg_registrationinfo.finalexamResultDate.HasValue))
                        Database.AddInParameter(cmd, "@FinalExamResultDate", DbType.DateTime, reg_registrationinfo.finalexamResultDate);

                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    if (returnCode > 0)
                    {
                        if (reg_registrationinfo.previousFinalExamResult != reg_registrationinfo.finalexamresult)
                        {
                            #region TABLE:Reg_ApplicantPhases
                            tran_applicantphasesDataAccessObjects objtran_applicantphasesDataAccessObjects = new tran_applicantphasesDataAccessObjects(this.Context);
                            tran_applicantphasesEntity objtran_applicantphasesEntity = new tran_applicantphasesEntity();
                            objtran_applicantphasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                            objtran_applicantphasesEntity.registrationid = reg_registrationinfo.registrationid;
                            objtran_applicantphasesEntity = await objtran_applicantphasesDataAccessObjects.GetSinglebyBasicInfoIDRegistrationID(Database, transaction, objtran_applicantphasesEntity, cancellationToken);

                            if (objtran_applicantphasesEntity != null)
                            {
                                if ((objtran_applicantphasesEntity.phaseid == (long)ApplicantPhasesEnum.MedicalCheck
                                    || objtran_applicantphasesEntity.phaseid == (long)ApplicantPhasesEnum.FinalExam)
                                    && reg_registrationinfo.istrgjoinenabled == false)
                                {
                                    tran_applicantphasesEntity objApplicantPhasesEntity = new tran_applicantphasesEntity();
                                    objApplicantPhasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                    objApplicantPhasesEntity.registrationid = reg_registrationinfo.registrationid;
                                    objApplicantPhasesEntity.batchid = reg_registrationinfo.batchid;
                                    objApplicantPhasesEntity.phaseid = (long)ApplicantPhasesEnum.FinalExam;
                                    if (reg_registrationinfo.finalexamresult == (Int32)FinalExamResultEnum.Waiting)
                                    {
                                        objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.New;
                                    }
                                    else if (reg_registrationinfo.finalexamresult == (Int32)FinalExamResultEnum.Passed)
                                    {
                                        objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Passed;
                                    }
                                    else if (reg_registrationinfo.finalexamresult == (Int32)FinalExamResultEnum.Failed)
                                    {
                                        objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Failed;
                                    }
                                    objApplicantPhasesEntity.submitteddate = DateTime.Now;
                                    objApplicantPhasesEntity.submittedby = reg_registrationinfo.BaseSecurityParam.userid;
                                    objApplicantPhasesEntity.BaseSecurityParam = new SecurityCapsule();
                                    objApplicantPhasesEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                    await objtran_applicantphasesDataAccessObjects.AddApplicationPhase(Database, transaction, objApplicantPhasesEntity, cancellationToken);
                                }
                            }
                            #endregion

                            #region TABLE:Tran_FinalExamResult
                            if (reg_registrationinfo.previousFinalExamResult != reg_registrationinfo.finalexamresult)
                            {
                                tran_finalexamresultDataAccessObjects objtran_finalexamresultDataAccessObjects = new tran_finalexamresultDataAccessObjects(this.Context);
                                tran_finalexamresultEntity objtran_finalexamresultEntity = new tran_finalexamresultEntity();
                                objtran_finalexamresultEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                objtran_finalexamresultEntity.registrationid = reg_registrationinfo.registrationid;
                                objtran_finalexamresultEntity.finalexamresult = reg_registrationinfo.finalexamresult;
                                objtran_finalexamresultEntity.finalexamcomment = reg_registrationinfo.finalexamcomment;
                                objtran_finalexamresultEntity.finalexamresultdate = reg_registrationinfo.finalexamResultDate;
                                objtran_finalexamresultEntity.issoftdeleted = false;
                                objtran_finalexamresultEntity.BaseSecurityParam = new SecurityCapsule();
                                objtran_finalexamresultEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                await objtran_finalexamresultDataAccessObjects.AddFinalExamResult(Database, transaction, objtran_finalexamresultEntity, cancellationToken);
                            }
                            #endregion
                        }

                        #region TABLE:Reg_StudentFileStorage
                        IList<reg_studentfilestorageEntity> listAdded = reg_registrationinfo.DocumentList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                        IList<reg_studentfilestorageEntity> listUpdated = reg_registrationinfo.DocumentList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                        IList<reg_studentfilestorageEntity> listDeleted = reg_registrationinfo.DocumentList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                        reg_studentfilestorageDataAccessObjects objreg_studentfilestorageDataAccessObjects = new reg_studentfilestorageDataAccessObjects(this.Context);
                        await objreg_studentfilestorageDataAccessObjects.SaveDocumentList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
                        #endregion
                    }
                    cmd.Dispose();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.FinalExaminationResultUpdate"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        async Task<long> Ireg_registrationinfoDataAccessObjects.TrainingJoinResultUpdate(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "KAF_Reg_Registrationinfo_Upd_TrainingJoinResult";
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            transactioncodeGen objTranIDGen = new transactioncodeGen();
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillParameters(reg_registrationinfo, cmd, Database);
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);

                    if ((reg_registrationinfo.istrgjoinenabled.HasValue))
                        Database.AddInParameter(cmd, "@isTrgJoinEnabled", DbType.Boolean, reg_registrationinfo.istrgjoinenabled);

                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    if (returnCode > 0)
                    {
                        #region TABLE:Reg_ApplicantPhases
                        tran_applicantphasesDataAccessObjects objtran_applicantphasesDataAccessObjects = new tran_applicantphasesDataAccessObjects(this.Context);
                        tran_applicantphasesEntity objtran_applicantphasesEntity = new tran_applicantphasesEntity();
                        objtran_applicantphasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                        objtran_applicantphasesEntity.registrationid = reg_registrationinfo.registrationid;
                        objtran_applicantphasesEntity = await objtran_applicantphasesDataAccessObjects.GetSinglebyBasicInfoIDRegistrationID(Database, transaction, objtran_applicantphasesEntity, cancellationToken);

                        if (objtran_applicantphasesEntity != null)
                        {
                            if ((objtran_applicantphasesEntity.phaseid == (long)ApplicantPhasesEnum.FinalExam
                                || (reg_registrationinfo.previousBatchID != reg_registrationinfo.batchid && objtran_applicantphasesEntity.phaseid == (long)ApplicantPhasesEnum.TrainingJoined))
                                && reg_registrationinfo.istrgjoinenabled == true)
                            {
                                tran_applicantphasesEntity objApplicantPhasesEntity = new tran_applicantphasesEntity();
                                objApplicantPhasesEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                                objApplicantPhasesEntity.registrationid = reg_registrationinfo.registrationid;
                                objApplicantPhasesEntity.batchid = reg_registrationinfo.batchid;
                                objApplicantPhasesEntity.phaseid = (long)ApplicantPhasesEnum.TrainingJoined;
                                objApplicantPhasesEntity.statusid = (long)ApplicantStatusEnum.Completed;
                                objApplicantPhasesEntity.submitteddate = DateTime.Now;
                                objApplicantPhasesEntity.submittedby = reg_registrationinfo.BaseSecurityParam.userid;
                                objApplicantPhasesEntity.BaseSecurityParam = new SecurityCapsule();
                                objApplicantPhasesEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                                await objtran_applicantphasesDataAccessObjects.AddApplicationPhase(Database, transaction, objApplicantPhasesEntity, cancellationToken);
                            }
                        }
                        #endregion

                        #region TABLE:Tran_TrainingJoin
                        tran_trainingjoinDataAccessObjects objtran_trainingjoinDataAccessObjects = new tran_trainingjoinDataAccessObjects(this.Context);
                        tran_trainingjoinEntity objtran_trainingjoinEntity = new tran_trainingjoinEntity();
                        objtran_trainingjoinEntity.trgjoinid = reg_registrationinfo.TrgJoinID;
                        objtran_trainingjoinEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                        objtran_trainingjoinEntity.registrationid = reg_registrationinfo.registrationid;
                        objtran_trainingjoinEntity.trgcentreid = reg_registrationinfo.TrgCentreID;
                        objtran_trainingjoinEntity.joindate = reg_registrationinfo.JoinDate;
                        objtran_trainingjoinEntity.groupno = reg_registrationinfo.GroupNo;
                        objtran_trainingjoinEntity.joiningbatchid = reg_registrationinfo.JoiningBatchID;
                        objtran_trainingjoinEntity.orderno = reg_registrationinfo.OrderNo;
                        objtran_trainingjoinEntity.orderdate = reg_registrationinfo.OrderDate;
                        objtran_trainingjoinEntity.remarks = reg_registrationinfo.TrgJoinRemarks;
                        objtran_trainingjoinEntity.issoftdeleted = false;
                        objtran_trainingjoinEntity.BaseSecurityParam = new SecurityCapsule();
                        objtran_trainingjoinEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                        var volunteerno = await objtran_trainingjoinDataAccessObjects.AddTrainingJoinInfo(Database, transaction, objtran_trainingjoinEntity, cancellationToken);
                        #endregion

                        #region TABLE:Reg_StudentFileStorage
                        IList<reg_studentfilestorageEntity> listAdded = reg_registrationinfo.DocumentList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                        IList<reg_studentfilestorageEntity> listUpdated = reg_registrationinfo.DocumentList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                        IList<reg_studentfilestorageEntity> listDeleted = reg_registrationinfo.DocumentList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                        reg_studentfilestorageDataAccessObjects objreg_studentfilestorageDataAccessObjects = new reg_studentfilestorageDataAccessObjects(this.Context);
                        await objreg_studentfilestorageDataAccessObjects.SaveDocumentList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
                        #endregion

                        if (reg_registrationinfo.previousBatchID != reg_registrationinfo.batchid)
                        {
                            #region TABLE:Tran_ApplicantBatchChange
                            tran_applicantbatchchangeDataAccessObjects objtran_applicantbatchchangeDataAccessObjects = new tran_applicantbatchchangeDataAccessObjects(this.Context);
                            tran_applicantbatchchangeEntity objtran_applicantbatchchangeEntity = new tran_applicantbatchchangeEntity();
                            objtran_applicantbatchchangeEntity.basicinfoid = reg_registrationinfo.basicinfoid;
                            objtran_applicantbatchchangeEntity.registrationid = reg_registrationinfo.registrationid;
                            objtran_applicantbatchchangeEntity.joindate = reg_registrationinfo.JoinDate;
                            objtran_applicantbatchchangeEntity.volunteerno = volunteerno;
                            objtran_applicantbatchchangeEntity.groupno = reg_registrationinfo.GroupNo;
                            objtran_applicantbatchchangeEntity.batchid = reg_registrationinfo.JoiningBatchID;
                            objtran_applicantbatchchangeEntity.remarks = "Batch changed from Training Join";
                            objtran_applicantbatchchangeEntity.issoftdeleted = false;
                            objtran_applicantbatchchangeEntity.BaseSecurityParam = new SecurityCapsule();
                            objtran_applicantbatchchangeEntity.BaseSecurityParam = reg_registrationinfo.BaseSecurityParam;
                            await objtran_applicantbatchchangeDataAccessObjects.AddApplicantBatchChangeInfo(Database, transaction, objtran_applicantbatchchangeEntity, cancellationToken);
                            #endregion
                        }

                    }
                    cmd.Dispose();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.TrainingJoinResultUpdate"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        async Task<reg_registrationinfoEntity> Ireg_registrationinfoDataAccessObjects.GetSingleRegistrationInfoforSecurityExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetRegistrationInfoforSecurityExam_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_registrationinfo, cmd, Database);

                    IList<reg_registrationinfoEntity> itemList = new List<reg_registrationinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new GetSingleSyExamInfoLoadFromReader(reader));
                        }
                        reader.Close();
                    }

                    if (itemList != null && itemList.Count > 0)
                    {
                        //get document list
                        reg_studentfilestorageDataAccessObjects objreg_studentfilestorageDataAccessObjects = new reg_studentfilestorageDataAccessObjects(this.Context);
                        reg_studentfilestorageEntity objreg_studentfilestorageEntity = new reg_studentfilestorageEntity();
                        objreg_studentfilestorageEntity.basicinfoid = itemList[0].basicinfoid;
                        objreg_studentfilestorageEntity.fileconfignameid = (long)FileConfig.SyExam;
                        itemList[0].DocumentList = await objreg_studentfilestorageDataAccessObjects.GetAllByBasicId(objreg_studentfilestorageEntity, cancellationToken);

                        return itemList[0];
                    }
                    else
                        return null;

                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetSingleRegistrationInfoforSecurityExam"));
            }
        }

        async Task<reg_registrationinfoEntity> Ireg_registrationinfoDataAccessObjects.GetSingleRegistrationInfoforUnitClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetRegistrationInfoforUnitClearance_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_registrationinfo, cmd, Database);

                    IList<reg_registrationinfoEntity> itemList = new List<reg_registrationinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new GetSingleUnitClearanceInfoLoadFromReader(reader));
                        }
                        reader.Close();
                    }

                    if (itemList != null && itemList.Count > 0)
                    {
                        //get document list
                        reg_studentfilestorageDataAccessObjects objreg_studentfilestorageDataAccessObjects = new reg_studentfilestorageDataAccessObjects(this.Context);
                        reg_studentfilestorageEntity objreg_studentfilestorageEntity = new reg_studentfilestorageEntity();
                        objreg_studentfilestorageEntity.basicinfoid = itemList[0].basicinfoid;
                        objreg_studentfilestorageEntity.fileconfignameid = (long)FileConfig.UnitClearance;
                        itemList[0].DocumentList = await objreg_studentfilestorageDataAccessObjects.GetAllByBasicId(objreg_studentfilestorageEntity, cancellationToken);

                        return itemList[0];
                    }
                    else
                        return null;

                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetSingleRegistrationInfoforUnitClearance"));
            }
        }

        async Task<reg_registrationinfoEntity> Ireg_registrationinfoDataAccessObjects.GetSingleRegistrationInfoforGeneralMedicalExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetRegistrationInfoforGeneralMedicalExam_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_registrationinfo, cmd, Database);

                    IList<reg_registrationinfoEntity> itemList = new List<reg_registrationinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new GetSingleGeneralMedicalExamInfoLoadFromReader(reader));
                        }
                        reader.Close();
                    }

                    if (itemList != null && itemList.Count > 0)
                    {
                        //get document list
                        reg_studentfilestorageDataAccessObjects objreg_studentfilestorageDataAccessObjects = new reg_studentfilestorageDataAccessObjects(this.Context);
                        reg_studentfilestorageEntity objreg_studentfilestorageEntity = new reg_studentfilestorageEntity();
                        objreg_studentfilestorageEntity.basicinfoid = itemList[0].basicinfoid;
                        objreg_studentfilestorageEntity.fileconfignameid = (long)FileConfig.MedExam;
                        itemList[0].DocumentList = await objreg_studentfilestorageDataAccessObjects.GetAllByBasicId(objreg_studentfilestorageEntity, cancellationToken);

                        return itemList[0];
                    }
                    else
                        return null;

                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetSingleRegistrationInfoforGeneralMedicalExam"));
            }
        }

        async Task<reg_registrationinfoEntity> Ireg_registrationinfoDataAccessObjects.GetSingleRegistrationInfoforPsychologyExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetRegistrationInfoforPsychoExam_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_registrationinfo, cmd, Database);

                    IList<reg_registrationinfoEntity> itemList = new List<reg_registrationinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new GetSinglePsychoExamInfoLoadFromReader(reader));
                        }
                        reader.Close();
                    }

                    if (itemList != null && itemList.Count > 0)
                    {
                        //get document list
                        reg_studentfilestorageDataAccessObjects objreg_studentfilestorageDataAccessObjects = new reg_studentfilestorageDataAccessObjects(this.Context);
                        reg_studentfilestorageEntity objreg_studentfilestorageEntity = new reg_studentfilestorageEntity();
                        objreg_studentfilestorageEntity.basicinfoid = itemList[0].basicinfoid;
                        objreg_studentfilestorageEntity.fileconfignameid = (long)FileConfig.PsychoExam;
                        itemList[0].DocumentList = await objreg_studentfilestorageDataAccessObjects.GetAllByBasicId(objreg_studentfilestorageEntity, cancellationToken);

                        return itemList[0];
                    }
                    else
                        return null;

                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetSingleRegistrationInfoforPsychologyExam"));
            }
        }

        async Task<reg_registrationinfoEntity> Ireg_registrationinfoDataAccessObjects.GetSingleRegistrationInfoforFinalExam(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetRegistrationInfoforFinalExam_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_registrationinfo, cmd, Database);

                    IList<reg_registrationinfoEntity> itemList = new List<reg_registrationinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new GetSingleFinalExamInfoLoadFromReader(reader));
                        }
                        reader.Close();
                    }

                    if (itemList != null && itemList.Count > 0)
                    {
                        //get document list
                        reg_studentfilestorageDataAccessObjects objreg_studentfilestorageDataAccessObjects = new reg_studentfilestorageDataAccessObjects(this.Context);
                        reg_studentfilestorageEntity objreg_studentfilestorageEntity = new reg_studentfilestorageEntity();
                        objreg_studentfilestorageEntity.basicinfoid = itemList[0].basicinfoid;
                        objreg_studentfilestorageEntity.fileconfignameid = (long)FileConfig.FinalExam;
                        itemList[0].DocumentList = await objreg_studentfilestorageDataAccessObjects.GetAllByBasicId(objreg_studentfilestorageEntity, cancellationToken);

                        return itemList[0];
                    }
                    else
                        return null;

                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetSingleRegistrationInfoforFinalExam"));
            }
        }

        async Task<reg_registrationinfoEntity> Ireg_registrationinfoDataAccessObjects.GetSingleRegistrationInfoforTrainingJoin(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetRegistrationInfoforTrainingJoin_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_registrationinfo, cmd, Database);

                    IList<reg_registrationinfoEntity> itemList = new List<reg_registrationinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new GetSingleTrainingJoinInfoLoadFromReader(reader));
                        }
                        reader.Close();
                    }

                    if (itemList != null && itemList.Count > 0)
                    {
                        //get document list
                        reg_studentfilestorageDataAccessObjects objreg_studentfilestorageDataAccessObjects = new reg_studentfilestorageDataAccessObjects(this.Context);
                        reg_studentfilestorageEntity objreg_studentfilestorageEntity = new reg_studentfilestorageEntity();
                        objreg_studentfilestorageEntity.basicinfoid = itemList[0].basicinfoid;
                        objreg_studentfilestorageEntity.fileconfignameid = (long)FileConfig.TrainingJoin;
                        itemList[0].DocumentList = await objreg_studentfilestorageDataAccessObjects.GetAllByBasicId(objreg_studentfilestorageEntity, cancellationToken);

                        return itemList[0];
                    }
                    else
                        return null;

                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetSingleRegistrationInfoforTrainingJoin"));
            }
        }

        async Task<ProfileReportEntity> Ireg_registrationinfoDataAccessObjects.getApplicationList(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                ProfileReportEntity objRegistrationVM = new ProfileReportEntity();

                objRegistrationVM.ApplicationLists = new List<RptApplicationList>();

                using (DbCommand cmd = Database.GetStoredProcCommand("Rpt_ApplicantListInfo"))
                {
                    if (!string.IsNullOrEmpty(reg_registrationinfo.batchidstring))
                        Database.AddInParameter(cmd, "@batchid", DbType.String, reg_registrationinfo.batchidstring);

                    if (reg_registrationinfo.phaseid.HasValue)
                        Database.AddInParameter(cmd, "@phaseid", DbType.Int64, reg_registrationinfo.phaseid);
                    if (reg_registrationinfo.candidatetypeid.HasValue)
                        Database.AddInParameter(cmd, "@candidateTypeId", DbType.Int64, reg_registrationinfo.candidatetypeid);

                    if (!string.IsNullOrEmpty(reg_registrationinfo.professionidstring))
                        Database.AddInParameter(cmd, "@professionId", DbType.String, reg_registrationinfo.professionidstring);

                    if (!string.IsNullOrEmpty(reg_registrationinfo.nationalityid))
                        Database.AddInParameter(cmd, "@nationalityid", DbType.String, reg_registrationinfo.nationalityid);

                    if (reg_registrationinfo.statusid.HasValue)
                        Database.AddInParameter(cmd, "@statusid", DbType.Int64, reg_registrationinfo.statusid);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            objRegistrationVM.ApplicationLists.Add(new RptApplicationList(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }

                return objRegistrationVM;
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetAll"));
            }
        }


        async Task<ProfileReportEntity> Ireg_registrationinfoDataAccessObjects.getApplicationStatus(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                ProfileReportEntity objRegistrationVM = new ProfileReportEntity();

                objRegistrationVM.ApplicationStatus = new List<RptApplicantStatus>();

                using (DbCommand cmd = Database.GetStoredProcCommand("Rpt_ApplicantStatus_ByCivilId"))
                {
                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@civilid", DbType.String, reg_registrationinfo.civilid);




                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            objRegistrationVM.ApplicationStatus.Add(new RptApplicantStatus(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }

                return objRegistrationVM;
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetAll"));
            }
        }


        async Task<ProfileReportEntity> Ireg_registrationinfoDataAccessObjects.getApplicationAssessmentList(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                ProfileReportEntity objRegistrationVM = new ProfileReportEntity();

                objRegistrationVM.ApplicationAssesmentList = new List<RptApplicationAssesmentList>();

                using (DbCommand cmd = Database.GetStoredProcCommand("Rpt_ApplicationAssessmentListInfo"))
                {




                    if (reg_registrationinfo.candidatetypeid.HasValue)
                        Database.AddInParameter(cmd, "@candidateTypeId", DbType.Int64, reg_registrationinfo.candidatetypeid);

                    if (!string.IsNullOrEmpty(reg_registrationinfo.professionidstring))
                        Database.AddInParameter(cmd, "@professionId", DbType.String, reg_registrationinfo.professionidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.batchidstring))
                        Database.AddInParameter(cmd, "@batchid", DbType.String, reg_registrationinfo.batchidstring);



                    if ((reg_registrationinfo.registrationfromdate).HasValue)
                        Database.AddInParameter(cmd, "@FromDate", DbType.String, reg_registrationinfo.registrationfromdate);

                    if ((reg_registrationinfo.registrationtodate).HasValue)
                        Database.AddInParameter(cmd, "@ToDate", DbType.String, reg_registrationinfo.registrationtodate);




                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            objRegistrationVM.ApplicationAssesmentList.Add(new RptApplicationAssesmentList(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }

                return objRegistrationVM;
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetAll"));
            }
        }


        async Task<ProfileReportEntity> Ireg_registrationinfoDataAccessObjects.getBatchSummaryRpt(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                ProfileReportEntity objRegistrationVM = new ProfileReportEntity();

                objRegistrationVM.BatchSummaryRpt = new List<RptBatchSummaryRpt>();

                using (DbCommand cmd = Database.GetStoredProcCommand("Rpt_BatchSummaryRpt"))
                {

                    if (reg_registrationinfo.batchid.HasValue)
                        Database.AddInParameter(cmd, "@batchid", DbType.Int64, reg_registrationinfo.batchid);

                    if ((reg_registrationinfo.registrationfromdate).HasValue)
                        Database.AddInParameter(cmd, "@FromDate", DbType.String, reg_registrationinfo.registrationfromdate);

                    if ((reg_registrationinfo.registrationtodate).HasValue)
                        Database.AddInParameter(cmd, "@ToDate", DbType.String, reg_registrationinfo.registrationtodate);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            objRegistrationVM.BatchSummaryRpt.Add(new RptBatchSummaryRpt(reader));

                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }

                return objRegistrationVM;
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetAll"));
            }
        }


        async Task<ProfileReportEntity> Ireg_registrationinfoDataAccessObjects.getBatchSummaryDetail(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                ProfileReportEntity objRegistrationVM = new ProfileReportEntity();


                objRegistrationVM.BatchSummaryDetail = new List<RptBatchSummary>();

                using (DbCommand cmd = Database.GetStoredProcCommand("Rpt_BatchSummary"))
                {
                    if (reg_registrationinfo.candidatetypeid.HasValue)
                        Database.AddInParameter(cmd, "@candidateTypeId", DbType.Int64, reg_registrationinfo.candidatetypeid);

                    if (!string.IsNullOrEmpty(reg_registrationinfo.professionidstring))
                        Database.AddInParameter(cmd, "@professionId", DbType.String, reg_registrationinfo.professionidstring);
                    if (!string.IsNullOrEmpty(reg_registrationinfo.batchidstring))
                        Database.AddInParameter(cmd, "@batchid", DbType.String, reg_registrationinfo.batchidstring);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            objRegistrationVM.BatchSummaryDetail.Add(new RptBatchSummary(reader));

                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }

                return objRegistrationVM;
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetAll"));
            }
        }


        async Task<ProfileReportEntity> Ireg_registrationinfoDataAccessObjects.getVolunteerClearance(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                ProfileReportEntity objRegistrationVM = new ProfileReportEntity();


                objRegistrationVM.VolunteerClearanceList = new List<RptVolunteerClearanceList>();

                using (DbCommand cmd = Database.GetStoredProcCommand("Rpt_VolunteerClearance"))
                {
                    if (!string.IsNullOrEmpty(reg_registrationinfo.candidatetypeidstring))
                        Database.AddInParameter(cmd, "@candidateTypeId", DbType.String, reg_registrationinfo.candidatetypeidstring);

                    if (!string.IsNullOrEmpty(reg_registrationinfo.professionidstring))
                        Database.AddInParameter(cmd, "@professionId", DbType.String, reg_registrationinfo.professionidstring);

                    if (!string.IsNullOrEmpty(reg_registrationinfo.batchidstring))
                        Database.AddInParameter(cmd, "@batchid", DbType.String, reg_registrationinfo.batchidstring);

                    if (!string.IsNullOrEmpty(reg_registrationinfo.nationalityid))
                        Database.AddInParameter(cmd, "@NationalityId", DbType.String, reg_registrationinfo.nationalityid);

                    if (reg_registrationinfo.clearancetypeid.HasValue)
                    {
                        Database.AddInParameter(cmd, "@ClearanceTypeId", DbType.Int64, reg_registrationinfo.clearancetypeid);
                    }

                    if (reg_registrationinfo.clearancestatusid.HasValue)
                    {
                        Database.AddInParameter(cmd, "@ClearanceStatusId", DbType.Int64, reg_registrationinfo.clearancestatusid);
                    }

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            objRegistrationVM.VolunteerClearanceList.Add(new RptVolunteerClearanceList(reader));

                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }

                return objRegistrationVM;
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetAll"));
            }
        }


        async Task<ProfileReportEntity> Ireg_registrationinfoDataAccessObjects.getVolunteerExamLog(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                ProfileReportEntity objRegistrationVM = new ProfileReportEntity();


                objRegistrationVM.VolunteerExamLogList = new List<RptVolunteerExamLogList>();

                using (DbCommand cmd = Database.GetStoredProcCommand("Rpt_VolunteerExamLog"))
                {
                    if (!string.IsNullOrEmpty(reg_registrationinfo.candidatetypeidstring))
                        Database.AddInParameter(cmd, "@candidateTypeId", DbType.String, reg_registrationinfo.candidatetypeidstring);

                    if (!string.IsNullOrEmpty(reg_registrationinfo.professionidstring))
                        Database.AddInParameter(cmd, "@professionId", DbType.String, reg_registrationinfo.professionidstring);

                    if (!string.IsNullOrEmpty(reg_registrationinfo.batchidstring))
                        Database.AddInParameter(cmd, "@batchid", DbType.String, reg_registrationinfo.batchidstring);

                    if (!string.IsNullOrEmpty(reg_registrationinfo.nationalityid))
                        Database.AddInParameter(cmd, "@NationalityId", DbType.String, reg_registrationinfo.nationalityid);

                    if (reg_registrationinfo.clearancetypeid.HasValue)
                    {
                        Database.AddInParameter(cmd, "@examtypeid", DbType.Int64, reg_registrationinfo.clearancetypeid);
                    }

                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                    {
                        Database.AddInParameter(cmd, "@CivilId", DbType.String, reg_registrationinfo.civilid);
                    }

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            objRegistrationVM.VolunteerExamLogList.Add(new RptVolunteerExamLogList(reader));

                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }

                return objRegistrationVM;
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetAll"));
            }
        }

        async Task<ProfileReportEntity> Ireg_registrationinfoDataAccessObjects.getVolunteerCertificateInfo(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                ProfileReportEntity objRegistrationVM = new ProfileReportEntity();


                objRegistrationVM.VolunteerCertificateInfo = new List<RptVolunteerCertificate>();

                using (DbCommand cmd = Database.GetStoredProcCommand("Rpt_VolunteerCertificate"))
                {
                    if (!string.IsNullOrEmpty(reg_registrationinfo.candidatetypeidstring))
                        Database.AddInParameter(cmd, "@candidateTypeId", DbType.String, reg_registrationinfo.candidatetypeidstring);


                    if (!string.IsNullOrEmpty(reg_registrationinfo.batchidstring))
                        Database.AddInParameter(cmd, "@batchid", DbType.String, reg_registrationinfo.batchidstring);

                    if (!string.IsNullOrEmpty(reg_registrationinfo.nationalityid))
                        Database.AddInParameter(cmd, "@NationalityId", DbType.String, reg_registrationinfo.nationalityid);


                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                    {
                        Database.AddInParameter(cmd, "@CivilId", DbType.String, reg_registrationinfo.civilid);
                    }

                    if (reg_registrationinfo.CertificateLevelId.HasValue)
                    {
                        Database.AddInParameter(cmd, "@Certificatelevelid", DbType.Int64, reg_registrationinfo.CertificateLevelId);
                    }

                    if (reg_registrationinfo.certificateid.HasValue)
                    {
                        Database.AddInParameter(cmd, "@Certificateid", DbType.Int64, reg_registrationinfo.certificateid);
                    }

                    if (reg_registrationinfo.CertificateSubjectId.HasValue)
                    {
                        Database.AddInParameter(cmd, "@Certificatesubjectid", DbType.Int64, reg_registrationinfo.CertificateSubjectId);
                    }

                    if (reg_registrationinfo.phaseid.HasValue)
                    {
                        Database.AddInParameter(cmd, "@PhaseId", DbType.Int64, reg_registrationinfo.phaseid);
                    }

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            objRegistrationVM.VolunteerCertificateInfo.Add(new RptVolunteerCertificate(reader));

                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }

                return objRegistrationVM;
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetAll"));
            }
        }



        async Task<ProfileReportEntity> Ireg_registrationinfoDataAccessObjects.getApplicantAudit(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                ProfileReportEntity objRegistrationVM = new ProfileReportEntity();

                objRegistrationVM.ApplicantAudit = new List<RptApplicantAudit>();


                using (DbCommand cmd = Database.GetStoredProcCommand("Rpt_ApplicantAudited"))
                {


                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@civilId", DbType.String, reg_registrationinfo.civilid);
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {

                            objRegistrationVM.ApplicantAudit.Add(new RptApplicantAudit(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }

                return objRegistrationVM;
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetAll"));
            }
        }


        async Task<ProfileReportEntity> Ireg_registrationinfoDataAccessObjects.getApplicantSmsStatus(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                ProfileReportEntity objRegistrationVM = new ProfileReportEntity();


                objRegistrationVM.ApplicantSmsEmailSendList = new List<RptApplicantSmsStatus>();


                using (DbCommand cmd = Database.GetStoredProcCommand("Rpt_ApplicantSmsStatus"))
                {


                    if (!string.IsNullOrEmpty(reg_registrationinfo.batchidstring))
                    {
                        Database.AddInParameter(cmd, "@batchid", DbType.String, reg_registrationinfo.batchidstring);

                    }
                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@civilId", DbType.Int64, reg_registrationinfo.civilid);


                    if (reg_registrationinfo.candidatetypeid.HasValue)
                        Database.AddInParameter(cmd, "@candidateTypeId", DbType.Int64, reg_registrationinfo.candidatetypeid);


                    if (!string.IsNullOrEmpty(reg_registrationinfo.professionidstring))
                        Database.AddInParameter(cmd, "@professionId", DbType.String, reg_registrationinfo.professionidstring);

                    if ((reg_registrationinfo.smsSendDate).HasValue)
                        Database.AddInParameter(cmd, "@smsSentDate", DbType.String, reg_registrationinfo.smsSendDate);

                    if ((reg_registrationinfo.interviewdate).HasValue)
                        Database.AddInParameter(cmd, "@interViewDate", DbType.String, reg_registrationinfo.interviewdate);

                    Database.AddInParameter(cmd, "@isSent", DbType.Boolean, reg_registrationinfo.notificationStatus);




                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            //objRegistrationVM.ApplicationAssesmentList.Add(new RptApplicationAssesmentList(reader));
                            objRegistrationVM.ApplicantSmsEmailSendList.Add(new RptApplicantSmsStatus(reader));

                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }

                return objRegistrationVM;
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetAll"));
            }
        }


        async Task<ProfileReportEntity> Ireg_registrationinfoDataAccessObjects.getApplicantAllDataBasic(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                ProfileReportEntity objRegistrationVM = new ProfileReportEntity();

                objRegistrationVM.ApplicantAllDataBasic = new List<RptApplicantAllDataBasic>();


                using (DbCommand cmd = Database.GetStoredProcCommand("Rpt_ApplicantAllDataBasic"))
                {


                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@civilId", DbType.String, reg_registrationinfo.civilid);
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            objRegistrationVM.ApplicantAllDataBasic.Add(new RptApplicantAllDataBasic(reader));

                            //objRegistrationVM.ApplicantAudit.Add(new RptApplicantAudit(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }


                #region Education
                objRegistrationVM.EducationInformation = new List<RptEducationInfo>();
                using (DbCommand cmd = Database.GetStoredProcCommand("RPT_Reg_EducationInfo_By_BasicId"))
                {

                    //if (objRegistrationVM.BasicProfile != null)
                    //    Database.AddInParameter(cmd, "@basicinfoid", DbType.String, objRegistrationVM.BasicProfile[0].BasicInfoId);
                    //IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);

                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@CivilID", DbType.String, reg_registrationinfo.civilid);
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);

                    while (!result.IsCompleted)
                    {

                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            objRegistrationVM.EducationInformation.Add(new RptEducationInfo(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }

                #endregion


                #region MedicalResult
                //objRegistrationVM.MedicalInformation = new List<RptMedicalResultInfo>();
                //using (DbCommand cmd = Database.GetStoredProcCommand("RPT_Reg_MedicalResultInfo"))
                //{



                //    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                //        Database.AddInParameter(cmd, "@CivilID", DbType.String, reg_registrationinfo.civilid);
                //    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);

                //    while (!result.IsCompleted)
                //    {

                //    }
                //    using (IDataReader reader = Database.EndExecuteReader(result))
                //    {
                //        while (reader.Read())
                //        {
                //            objRegistrationVM.MedicalInformation.Add(new RptMedicalResultInfo(reader));
                //        }
                //        reader.Close();
                //    }
                //    cmd.Dispose();
                //}

                //#endregion


                //#region PsychoExamResult
                //objRegistrationVM.PsychoExamInformation = new List<RptPsychoExamResultInfo>();
                //using (DbCommand cmd = Database.GetStoredProcCommand("RPT_Reg_PsychoExamResultInfo"))
                //{



                //    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                //        Database.AddInParameter(cmd, "@CivilID", DbType.String, reg_registrationinfo.civilid);
                //    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);

                //    while (!result.IsCompleted)
                //    {

                //    }
                //    using (IDataReader reader = Database.EndExecuteReader(result))
                //    {
                //        while (reader.Read())
                //        {
                //            objRegistrationVM.PsychoExamInformation.Add(new RptPsychoExamResultInfo(reader));
                //        }
                //        reader.Close();
                //    }
                //    cmd.Dispose();
                //}

                //#endregion



                //#region SecExamResult
                //objRegistrationVM.SecExamInformation = new List<RptSecExamResultInfo>();
                //using (DbCommand cmd = Database.GetStoredProcCommand("RPT_Reg_SecExamResultInfo"))
                //{



                //    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                //        Database.AddInParameter(cmd, "@CivilID", DbType.String, reg_registrationinfo.civilid);
                //    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);

                //    while (!result.IsCompleted)
                //    {

                //    }
                //    using (IDataReader reader = Database.EndExecuteReader(result))
                //    {
                //        while (reader.Read())
                //        {
                //            objRegistrationVM.SecExamInformation.Add(new RptSecExamResultInfo(reader));
                //        }
                //        reader.Close();
                //    }
                //    cmd.Dispose();
                //}

                #endregion


                #region ExamResult
                objRegistrationVM.ExamResultInformation = new List<RptPsychoExamResultInfo>();
                using (DbCommand cmd = Database.GetStoredProcCommand("RPT_Reg_ExamResultInfo"))
                {



                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@CivilID", DbType.String, reg_registrationinfo.civilid);
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);

                    while (!result.IsCompleted)
                    {

                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            objRegistrationVM.ExamResultInformation.Add(new RptPsychoExamResultInfo(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }

                #endregion



                #region JoinInfo
                objRegistrationVM.TrainingJoinInformation = new List<RptTrainingJoinInfo>();
                using (DbCommand cmd = Database.GetStoredProcCommand("RPT_TrainingJoinInfo"))
                {



                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@CivilID", DbType.String, reg_registrationinfo.civilid);
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);

                    while (!result.IsCompleted)
                    {

                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            objRegistrationVM.TrainingJoinInformation.Add(new RptTrainingJoinInfo(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }

                #endregion

                return objRegistrationVM;
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetAll"));
            }
        }


        async Task<ProfileReportEntity> Ireg_registrationinfoDataAccessObjects.getMedicalExamForm(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                ProfileReportEntity objRegistrationVM = new ProfileReportEntity();


                objRegistrationVM.MedicalExamForm = new List<RptMedicalExamForm>();


                using (DbCommand cmd = Database.GetStoredProcCommand("RPT_VolunteerMedical_Exam_Form_R"))
                {


                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@civilId", DbType.String, reg_registrationinfo.civilid);




                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {

                            objRegistrationVM.MedicalExamForm.Add(new RptMedicalExamForm(reader));

                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }

                return objRegistrationVM;
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetAll"));
            }
        }


        async Task<ProfileReportEntity> Ireg_registrationinfoDataAccessObjects.getMedicalExamReport(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {

                ProfileReportEntity objRegistrationVM = new ProfileReportEntity();


                objRegistrationVM.MedicalExamReport = new List<RptMedicalExamRep>();


                using (DbCommand cmd = Database.GetStoredProcCommand("rpt_Volunteer_MedicalExam_Rep_R"))
                {


                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@civilId", DbType.String, reg_registrationinfo.civilid);




                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {

                            objRegistrationVM.MedicalExamReport.Add(new RptMedicalExamRep(reader));

                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }

                return objRegistrationVM;
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetAll"));
            }
        }


        async Task<ProfileReportEntity> Ireg_registrationinfoDataAccessObjects.getMedExaSmsStatus(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                ProfileReportEntity objRegistrationVM = new ProfileReportEntity();


                objRegistrationVM.MedExamSmsEmailSendList = new List<RptApplicantSmsStatus>();


                using (DbCommand cmd = Database.GetStoredProcCommand("Rpt_MedicalSmsStatus"))
                {


                    if (!string.IsNullOrEmpty(reg_registrationinfo.batchidstring))
                    {
                        Database.AddInParameter(cmd, "@batchid", DbType.String, reg_registrationinfo.batchidstring);

                    }
                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@civilId", DbType.Int64, reg_registrationinfo.civilid);


                    if (reg_registrationinfo.candidatetypeid.HasValue)
                        Database.AddInParameter(cmd, "@candidateTypeId", DbType.Int64, reg_registrationinfo.candidatetypeid);


                    if (!string.IsNullOrEmpty(reg_registrationinfo.professionidstring))
                        Database.AddInParameter(cmd, "@professionId", DbType.String, reg_registrationinfo.professionidstring);

                    if ((reg_registrationinfo.smsSendDate).HasValue)
                        Database.AddInParameter(cmd, "@smsSentDate", DbType.String, reg_registrationinfo.smsSendDate);

                    if ((reg_registrationinfo.interviewdate).HasValue)
                        Database.AddInParameter(cmd, "@interViewDate", DbType.String, reg_registrationinfo.interviewdate);

                    Database.AddInParameter(cmd, "@isSent", DbType.Boolean, reg_registrationinfo.notificationStatus);




                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                           
                            objRegistrationVM.MedExamSmsEmailSendList.Add(new RptApplicantSmsStatus(reader));

                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }

                return objRegistrationVM;
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetAll"));
            }
        }


        async Task<ProfileReportEntity> Ireg_registrationinfoDataAccessObjects.getFinalExaSmsStatus(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                ProfileReportEntity objRegistrationVM = new ProfileReportEntity();


                objRegistrationVM.FinalExamSmsEmailSendList = new List<RptApplicantSmsStatus>();


                using (DbCommand cmd = Database.GetStoredProcCommand("Rpt_FinalExamSmsStatus"))
                {


                    if (!string.IsNullOrEmpty(reg_registrationinfo.batchidstring))
                    {
                        Database.AddInParameter(cmd, "@batchid", DbType.String, reg_registrationinfo.batchidstring);

                    }
                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@civilId", DbType.Int64, reg_registrationinfo.civilid);


                    if (reg_registrationinfo.candidatetypeid.HasValue)
                        Database.AddInParameter(cmd, "@candidateTypeId", DbType.Int64, reg_registrationinfo.candidatetypeid);


                    if (!string.IsNullOrEmpty(reg_registrationinfo.professionidstring))
                        Database.AddInParameter(cmd, "@professionId", DbType.String, reg_registrationinfo.professionidstring);

                    if ((reg_registrationinfo.smsSendDate).HasValue)
                        Database.AddInParameter(cmd, "@smsSentDate", DbType.String, reg_registrationinfo.smsSendDate);

                    if ((reg_registrationinfo.interviewdate).HasValue)
                        Database.AddInParameter(cmd, "@interViewDate", DbType.String, reg_registrationinfo.interviewdate);

                    Database.AddInParameter(cmd, "@isSent", DbType.Boolean, reg_registrationinfo.notificationStatus);




                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {

                            objRegistrationVM.FinalExamSmsEmailSendList.Add(new RptApplicantSmsStatus(reader));

                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }

                return objRegistrationVM;
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetAll"));
            }
        }


        async Task<ProfileReportEntity> Ireg_registrationinfoDataAccessObjects.getTrainingJoinSmsStatus(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                ProfileReportEntity objRegistrationVM = new ProfileReportEntity();


                objRegistrationVM.TrainingJoinSmsEmailSendList = new List<RptApplicantSmsStatus>();


                using (DbCommand cmd = Database.GetStoredProcCommand("Rpt_TrainingJoinSmsStatus"))
                {


                    if (!string.IsNullOrEmpty(reg_registrationinfo.batchidstring))
                    {
                        Database.AddInParameter(cmd, "@batchid", DbType.String, reg_registrationinfo.batchidstring);

                    }
                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@civilId", DbType.Int64, reg_registrationinfo.civilid);


                    if (reg_registrationinfo.candidatetypeid.HasValue)
                        Database.AddInParameter(cmd, "@candidateTypeId", DbType.Int64, reg_registrationinfo.candidatetypeid);


                    if (!string.IsNullOrEmpty(reg_registrationinfo.professionidstring))
                        Database.AddInParameter(cmd, "@professionId", DbType.String, reg_registrationinfo.professionidstring);

                    if ((reg_registrationinfo.smsSendDate).HasValue)
                        Database.AddInParameter(cmd, "@smsSentDate", DbType.String, reg_registrationinfo.smsSendDate);

                    if ((reg_registrationinfo.interviewdate).HasValue)
                        Database.AddInParameter(cmd, "@interViewDate", DbType.String, reg_registrationinfo.interviewdate);

                    Database.AddInParameter(cmd, "@isSent", DbType.Boolean, reg_registrationinfo.notificationStatus);




                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {

                            objRegistrationVM.TrainingJoinSmsEmailSendList.Add(new RptApplicantSmsStatus(reader));

                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }

                return objRegistrationVM;
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetAll"));
            }
        }



        async Task<ProfileReportEntity> Ireg_registrationinfoDataAccessObjects.getVolunteerContract(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                ProfileReportEntity objRegistrationVM = new ProfileReportEntity();
                objRegistrationVM.VolunteerContractInfo= new List<RptVolunterContractRep>();

                using (DbCommand cmd = Database.GetStoredProcCommand("rpt_VolunteerContract_Rep_R"))
                {
                    if (!string.IsNullOrEmpty(reg_registrationinfo.batchidstring))
                    {
                        Database.AddInParameter(cmd, "@batchid", DbType.String, reg_registrationinfo.batchidstring);

                    }
                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@civilId", DbType.Int64, reg_registrationinfo.civilid);

                    if (!string.IsNullOrEmpty(reg_registrationinfo.basicinfoids))
                        Database.AddInParameter(cmd, "@BasicInfoIDs", DbType.String, reg_registrationinfo.basicinfoids);
                   
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {

                            objRegistrationVM.VolunteerContractInfo.Add(new RptVolunterContractRep(reader));

                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }

                return objRegistrationVM;
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetAll"));
            }
        }


        async Task<ProfileReportEntity> Ireg_registrationinfoDataAccessObjects.getVolunteerTestExtForm(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            try
            {
                ProfileReportEntity objRegistrationVM = new ProfileReportEntity();


                objRegistrationVM.VolunteerTextExtForm = new List<RptVolunteerTextExtForm>();


                using (DbCommand cmd = Database.GetStoredProcCommand("RPT_Volunteer_Test_Ext_R"))
                {


                    if (!string.IsNullOrEmpty(reg_registrationinfo.civilid))
                        Database.AddInParameter(cmd, "@civilId", DbType.String, reg_registrationinfo.civilid);




                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {

                            objRegistrationVM.VolunteerTextExtForm.Add(new RptVolunteerTextExtForm(reader));

                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }

                return objRegistrationVM;
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.GetAll"));
            }
        }

        async Task<long> Ireg_registrationinfoDataAccessObjects.UpdateSyPrintProfile(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "KAF_Upd_RegRegistrationInfo__SyProfilePrint";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_registrationinfo, cmd, Database);

                if (reg_registrationinfo.syprofileprint.HasValue)
                    Database.AddInParameter(cmd, "@SyProfilePrint", DbType.Boolean, reg_registrationinfo.syprofileprint);

                FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.UpdateSyPrintProfile"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        async Task<long> Ireg_registrationinfoDataAccessObjects.UpdateMedExamFormPrint(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "KAF_Upd_RegRegistrationInfo__MedExamFormPrint";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_registrationinfo, cmd, Database);

                if (reg_registrationinfo.medexamformprint.HasValue)
                    Database.AddInParameter(cmd, "@MedExamFormPrint", DbType.Boolean, reg_registrationinfo.medexamformprint);

                FillSequrityParameters(reg_registrationinfo.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ireg_registrationinfoDataAccess.UpdateMedExamFormPrint"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

    }
}