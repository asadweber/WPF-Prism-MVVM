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
using BDO.DataAccessObjects.VCRegistration;
using BDO.Core.Base;
using DAC.Core.DataAccessObjects.Security.ExtendedPartial;
using AppConfig.EncryptionHandler;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.SecurityModels;
using IDAC.Core.IDataAccessObjects.Security.ExtendedPartial;
using AppConfig.HelperClasses;
using BDO.Core.DataAccessObjects.CommonEntities;
using CLL.LLClasses.Models;
using BDO.DataAccessObjects.Enums;
using System.Transactions;
using static AppConfig.HelperClasses.BasicApplicationConstant;
using System.Net.Http;
using BDO.DataAccessObjects.ExtendedEntities;
using CLL.LLClasses;
using RestSharp;
using Newtonsoft.Json;
using BDO.Base;
using System.Linq;
using System.IO;
using BDO.Report;
using BDO.DataAccessObjects.VCApplicantReview;
using Microsoft.AspNetCore.Identity;
using MongoDB.Bson.Serialization.Serializers;
using Microsoft.IdentityModel.Tokens;

namespace DAC.Core.DataAccessObjects.General
{
    /// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>

    internal sealed partial class reg_basicinfoDataAccessObjects
    {
        async Task<long> Ireg_basicinfoDataAccessObjects.AddExt(reg_basicinfoEntity reg_basicinfodata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_basicinfo_Ins_ext";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_basicinfodata, cmd, Database);
                FillSequrityParameters(reg_basicinfodata.BaseSecurityParam, cmd, Database);
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

        async Task<IList<reg_basicinfoEntity>> Ireg_basicinfoDataAccessObjects.GetAllExt(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "reg_basicinfo_GA_Ext";
                IList<reg_basicinfoEntity> itemList = new List<reg_basicinfoEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, reg_basicinfo.SortExpression);
                    FillSequrityParameters(reg_basicinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_basicinfo, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_basicinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.GetAllreg_basicinfo"));
            }
        }

        async Task<reg_basicinfoEntity> Ireg_basicinfoDataAccessObjects.ValidateMobileNumber(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_reg_basicinfo_ValidateMobileNumber";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(reg_basicinfo.BaseSecurityParam, cmd, Database);
                    Database.AddInParameter(cmd, "@MobileNumber", DbType.String, reg_basicinfo.mob1);

                    IList<reg_basicinfoEntity> itemList = new List<reg_basicinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_basicinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();

                    if (itemList != null && itemList.Count > 0)
                        return itemList[0];
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.GetSinglereg_basicinfo"));
            }
        }

        async Task<reg_basicinfoEntity> Ireg_basicinfoDataAccessObjects.ValidateEmailAddress(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_reg_basicinfo_ValidateEmailAddress";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(reg_basicinfo.BaseSecurityParam, cmd, Database);
                    Database.AddInParameter(cmd, "@EmailAddress", DbType.String, reg_basicinfo.email);

                    IList<reg_basicinfoEntity> itemList = new List<reg_basicinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_basicinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();

                    if (itemList != null && itemList.Count > 0)
                        return itemList[0];
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.GetSinglereg_basicinfo"));
            }
        }

        async Task<reg_basicinfoEntity> Ireg_basicinfoDataAccessObjects.ValidateCivilIdPolicy(string CivilId, long? BatchId, System.Threading.CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_reg_basicinfo_ValidateCivilIdPolicy";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    if (!string.IsNullOrEmpty(CivilId))
                        Database.AddInParameter(cmd, "@CivilId", DbType.String, CivilId);

                    if (BatchId.HasValue)
                        Database.AddInParameter(cmd, "@BatchId", DbType.Int64, BatchId);

                    IList<reg_basicinfoEntity> itemList = new List<reg_basicinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_basicinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();

                    if (itemList != null && itemList.Count > 0)
                        return itemList[0];
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.GetSinglereg_basicinfo"));
            }
        }




        async Task<long> Ireg_basicinfoDataAccessObjects.SavePreRegistration(RegistrationViewModel request, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster_BasicInfoId = -99;
            const string reg_basicinfo_Ins_SP = "KAF_reg_basicinfo_Ins_ext";
            const string reg_basicinfo_Update_SP = "KAF_reg_basicinfo_Upd_ext";
            const string reg_basicinfo_Delete_SP = "KAF_reg_basicinfo_Del_Ext";

            string SP = "";
            if (request.BasicInfo.CurrentState == BaseEntity.EntityState.Added)
                SP = reg_basicinfo_Ins_SP;
            else if (request.BasicInfo.CurrentState == BaseEntity.EntityState.Changed)
                SP = reg_basicinfo_Update_SP;
            else if (request.BasicInfo.CurrentState == BaseEntity.EntityState.Deleted)
                SP = reg_basicinfo_Delete_SP;

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            transactioncodeGen objTranIDGen = new transactioncodeGen();
            long? masteruserid = 0;
            try
            {

                if (request.OwinUser == null)
                {
                    request.OwinUser = new owin_userEntity();
                    request.OwinUser.username = request.BasicInfo.civilid;
                }

                KAFUserSecurityDataAccess kAFUserSecurityDataAccess = new KAFUserSecurityDataAccess(this.Context);

                var ExistingUser = await kAFUserSecurityDataAccess.GetUserAccountByUserName(Database, transaction, request.OwinUser, cancellationToken);


                //When Apply Another Batch
                //if (SP == reg_basicinfo_Ins_SP)
                //{
                //    ExistingUser.mobilenumber = request.BasicInfo.mob1;
                //    ExistingUser.emailaddress = request.BasicInfo.email;
                //    ExistingUser.BaseSecurityParam = request.BaseSecurityParam;
                //    EncryptionHelper objenc = new EncryptionHelper();
                //    var salt = objenc.GenerateRandomCryptographicKey(128);
                //    HashWithSaltResult ob1 = objenc.EncodePassword(request.OwinUser.password, salt);
                //    ExistingUser.password = ob1.Digest;
                //    ExistingUser.passwordsalt = ob1.Salt;
                //    ExistingUser.passwordkey = objenc.GenerateRandomCryptographicKey(24);
                //    ExistingUser.passwordvector = objenc.GenerateRandomCryptographicKey(32);
                //    await kAFUserSecurityDataAccess.UpdateUserAccountMobile_EmailByUserId(Database, transaction, ExistingUser, cancellationToken);
                //}

                request.BasicInfo.userid = ExistingUser.userid;

                //Check Is Already Profile Exist
                using (DbCommand cmd = Database.GetStoredProcCommand("KAF_reg_basicinfo_By_CivilID"))
                {
                    Database.AddInParameter(cmd, "@CivilID", DbType.String, request.BasicInfo.civilid);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            var obj = new reg_basicinfoEntity(reader);
                            request.BasicInfo.basicinfoid = obj.basicinfoid;
                            request.BasicInfo.CurrentState = BaseEntity.EntityState.Changed;
                            SP = reg_basicinfo_Update_SP;
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (request.BasicInfo.BaseSecurityParam == null)
                    {
                        request.BasicInfo.BaseSecurityParam = new SecurityCapsule();

                        if (!request.BasicInfo.basicinfoid.HasValue)
                            request.BasicInfo.BaseSecurityParam.createdbyusername = Convert.ToString(request.BasicInfo.BaseSecurityParam.createdbyusername);
                        if (request.BasicInfo.basicinfoid.HasValue)
                            request.BasicInfo.BaseSecurityParam.updatedbyusername = Convert.ToString(request.BasicInfo.BaseSecurityParam.updatedbyusername);

                        if (!request.BasicInfo.basicinfoid.HasValue)
                            request.BasicInfo.BaseSecurityParam.createddate = DateTime.Now;
                        if (request.BasicInfo.basicinfoid.HasValue)
                            request.BasicInfo.BaseSecurityParam.updateddate = DateTime.Now;

                        request.BasicInfo.BaseSecurityParam.transid = objTranIDGen.GetRandomAlphaNumericStringForTransactionActivity("TRAN", DateTime.Now);

                    }
                    //FillParameters(request.BasicInfo, cmd, Database);
                    if (request.BasicInfo.CurrentState == BaseEntity.EntityState.Added || request.BasicInfo.CurrentState == BaseEntity.EntityState.Changed)
                    {
                        FillParameters(request.BasicInfo, cmd, Database);
                    }
                    else
                    {
                        FillParameters(request.BasicInfo, cmd, Database, true);
                    }
                    FillSequrityParameters(request.BasicInfo.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);

                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    PrimaryKeyMaster_BasicInfoId = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    if (returnCode > 0)
                    {
                        #region TABLE:Reg_RegistrationInfo

                        request.CurrentRegistration.basicinfoid = PrimaryKeyMaster_BasicInfoId;
                        if (request.CurrentRegistration.BaseSecurityParam == null)
                        {
                            request.CurrentRegistration.BaseSecurityParam = new SecurityCapsule();
                            if (!request.BasicInfo.basicinfoid.HasValue)
                                request.CurrentRegistration.BaseSecurityParam.createdbyusername = Convert.ToString(request.BasicInfo.BaseSecurityParam.createdbyusername);
                            if (!request.BasicInfo.basicinfoid.HasValue)
                                request.CurrentRegistration.BaseSecurityParam.createddate = DateTime.Now;

                            if (request.BasicInfo.basicinfoid.HasValue)
                                request.CurrentRegistration.BaseSecurityParam.updatedbyusername = Convert.ToString(request.BasicInfo.BaseSecurityParam.updatedbyusername);
                            if (request.BasicInfo.basicinfoid.HasValue)
                                request.CurrentRegistration.BaseSecurityParam.updateddate = DateTime.Now;
                            request.CurrentRegistration.BaseSecurityParam.transid = objTranIDGen.GetRandomAlphaNumericStringForTransactionActivity("TRAN", DateTime.Now);
                        }

                        reg_registrationinfoDataAccessObjects objreg_registrationinfo = new reg_registrationinfoDataAccessObjects(this.Context);
                        var registrationid = await objreg_registrationinfo.SaveRegistrationDetail(Database, transaction, request.CurrentRegistration, cancellationToken);
                        #endregion

                        #region TABLE:Tran_ApplicantBatchChange
                        if (request.CurrentRegistration.previousBatchID != null
                            && request.CurrentRegistration.previousBatchID != request.CurrentRegistration.batchid)
                        {
                            tran_applicantbatchchangeDataAccessObjects objtran_applicantbatchchangeDataAccessObjects = new tran_applicantbatchchangeDataAccessObjects(this.Context);
                            tran_applicantbatchchangeEntity objtran_applicantbatchchangeEntity = new tran_applicantbatchchangeEntity();
                            objtran_applicantbatchchangeEntity.basicinfoid = request.CurrentRegistration.basicinfoid;
                            objtran_applicantbatchchangeEntity.registrationid = request.CurrentRegistration.registrationid;
                            objtran_applicantbatchchangeEntity.batchid = request.CurrentRegistration.batchid;
                            objtran_applicantbatchchangeEntity.remarks = "Batch changed from Post Registration";
                            objtran_applicantbatchchangeEntity.issoftdeleted = false;
                            objtran_applicantbatchchangeEntity.BaseSecurityParam = new SecurityCapsule();
                            objtran_applicantbatchchangeEntity.BaseSecurityParam = request.CurrentRegistration.BaseSecurityParam;
                            await objtran_applicantbatchchangeDataAccessObjects.AddApplicantBatchChangeInfo(Database, transaction, objtran_applicantbatchchangeEntity, cancellationToken);
                        }
                        #endregion

                        if (request.BasicInfo.SaveAction == GlobalConstant.SaveAction_PreRegistration)
                        {
                            #region TABLE:Tran_ApplicantPhases
                            var objTran_ApplicantPhases = new tran_applicantphasesEntity();
                            objTran_ApplicantPhases.basicinfoid = PrimaryKeyMaster_BasicInfoId;
                            objTran_ApplicantPhases.registrationid = registrationid;
                            objTran_ApplicantPhases.batchid = request.CurrentRegistration.batchid;
                            objTran_ApplicantPhases.phaseid = (long)ApplicantPhasesEnum.Registered;
                            objTran_ApplicantPhases.statusid = (long)ApplicantStatusEnum.New;
                            objTran_ApplicantPhases.submittedby = request.BasicInfo.userid;
                            objTran_ApplicantPhases.submitteddate = DateTime.Now;

                            objTran_ApplicantPhases.BaseSecurityParam = new SecurityCapsule();
                            objTran_ApplicantPhases.BaseSecurityParam.createdbyusername = Convert.ToString(request.BasicInfo.BaseSecurityParam.createdbyusername);
                            objTran_ApplicantPhases.BaseSecurityParam.createddate = DateTime.Now;
                            objTran_ApplicantPhases.BaseSecurityParam.transid = objTranIDGen.GetRandomAlphaNumericStringForTransactionActivity("TRAN", DateTime.Now);
                            tran_applicantphasesDataAccessObjects objtran_applicantphasesDataAccess = new tran_applicantphasesDataAccessObjects(this.Context);
                            await objtran_applicantphasesDataAccess.AddApplicationPhase(Database, transaction, objTran_ApplicantPhases, cancellationToken);
                            #endregion

                            #region TABLE:Tran_ApplicantBatchChange
                            if (request.CurrentRegistration.previousBatchID == null
                                && request.CurrentRegistration.previousBatchID != request.CurrentRegistration.batchid)
                            {
                                tran_applicantbatchchangeDataAccessObjects objtran_applicantbatchchangeDataAccessObjects = new tran_applicantbatchchangeDataAccessObjects(this.Context);
                                tran_applicantbatchchangeEntity objtran_applicantbatchchangeEntity = new tran_applicantbatchchangeEntity();
                                objtran_applicantbatchchangeEntity.basicinfoid = request.CurrentRegistration.basicinfoid;
                                objtran_applicantbatchchangeEntity.registrationid = registrationid;
                                objtran_applicantbatchchangeEntity.batchid = request.CurrentRegistration.batchid;
                                objtran_applicantbatchchangeEntity.remarks = "Batch created from Pre Registration";
                                objtran_applicantbatchchangeEntity.issoftdeleted = false;
                                objtran_applicantbatchchangeEntity.BaseSecurityParam = new SecurityCapsule();
                                objtran_applicantbatchchangeEntity.BaseSecurityParam = request.CurrentRegistration.BaseSecurityParam;
                                await objtran_applicantbatchchangeDataAccessObjects.AddApplicantBatchChangeInfo(Database, transaction, objtran_applicantbatchchangeEntity, cancellationToken);
                            }
                            #endregion
                        }
                        else if (request.BasicInfo.SaveAction == GlobalConstant.SaveAction_RegBasicInfo)
                        {
                            #region TABLE:Reg_Familly
                            var objreg_famillyEntity = new reg_famillyEntity();
                            objreg_famillyEntity.relationshipid = (long)RelationshipEnum.Father;
                            objreg_famillyEntity.basicinfoid = PrimaryKeyMaster_BasicInfoId;

                            reg_famillyDataAccessObjects objreg_famillyDataAccessObjects = new reg_famillyDataAccessObjects(this.Context);
                            objreg_famillyEntity = await objreg_famillyDataAccessObjects.GetFamiliyMemberByRelationType(Database, transaction, objreg_famillyEntity, cancellationToken);
                            if (objreg_famillyEntity != null && objreg_famillyEntity.familyid.HasValue)
                            {
                                objreg_famillyEntity.name1 = request.BasicInfo.name2;
                                objreg_famillyEntity.name2 = request.BasicInfo.name3;
                                objreg_famillyEntity.name3 = request.BasicInfo.name4;
                                objreg_famillyEntity.name5 = request.BasicInfo.name5;
                                objreg_famillyEntity.fullname = $"{objreg_famillyEntity.name1} {objreg_famillyEntity.name2} {objreg_famillyEntity.name3} {objreg_famillyEntity.name4} {objreg_famillyEntity.name5}";
                                objreg_famillyEntity.BaseSecurityParam.updatedbyusername = Convert.ToString(request.BasicInfo.BaseSecurityParam.updatedbyusername);
                                objreg_famillyEntity.BaseSecurityParam.updateddate = DateTime.Now;
                                await objreg_famillyDataAccessObjects.SaveUpdateExt(Database, transaction, objreg_famillyEntity, cancellationToken);
                            }
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccessObjects.SavePreRegistration"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        public async Task SaveUploadDocumentList(Database db, List<reg_studentfilestorageEntity> DocumentList, long PrimaryKeyMaster_BasicInfoId, DbTransaction transaction, long registrationid, CancellationToken cancellationToken)
        {
            if (DocumentList != null)
            {
                foreach (var item in DocumentList)
                {
                    item.basicinfoid = PrimaryKeyMaster_BasicInfoId;
                    if (item.CurrentState == BaseEntity.EntityState.Added)
                    {
                        item.basicfileid = (long?)null;
                    }
                }
                reg_studentfilestorageDataAccessObjects reg_StudentfilestorageDataAccessObjects = new reg_studentfilestorageDataAccessObjects(this.Context);
                IList<reg_studentfilestorageEntity> listBasicDocumentAdded = DocumentList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<reg_studentfilestorageEntity> listBasicDocumentUpdated = DocumentList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<reg_studentfilestorageEntity> listBasicDocumentDeleted = DocumentList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                await reg_StudentfilestorageDataAccessObjects.SaveList(db, transaction, listBasicDocumentAdded, listBasicDocumentUpdated, listBasicDocumentDeleted, cancellationToken);
            }
        }

        async Task<long> Ireg_basicinfoDataAccessObjects.SubmitFinalRegistration(RegistrationViewModel request, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            transactioncodeGen objTranIDGen = new transactioncodeGen();
            long? masteruserid = 0;
            try
            {
                #region TABLE:Reg_RegistrationInfo

                reg_registrationinfoDataAccessObjects objreg_registrationinfo = new reg_registrationinfoDataAccessObjects(this.Context);
                var registrationid = await objreg_registrationinfo.SaveRegistrationDetailFinalSubmit(Database, transaction, request.CurrentRegistration, cancellationToken);
                #endregion

                #region TABLE:Tran_AuditResult
                tran_auditresultDataAccessObjects objtran_auditresultDataAccessObjects = new tran_auditresultDataAccessObjects(this.Context);

                tran_auditresultEntity existingAuditResult = await objtran_auditresultDataAccessObjects.GetLatestAuditResult(new tran_auditresultEntity() { basicinfoid = request.CurrentRegistration.basicinfoid, registrationid = request.CurrentRegistration.registrationid }, cancellationToken);

                if (existingAuditResult != null && existingAuditResult.auditresult == (long)AuditResultEnum.Rollback)
                {
                    tran_auditresultEntity objAuditResultEntity = new tran_auditresultEntity();
                    objAuditResultEntity.basicinfoid = request.CurrentRegistration.basicinfoid;
                    objAuditResultEntity.registrationid = request.CurrentRegistration.registrationid;
                    objAuditResultEntity.auditresult = 0;
                    objAuditResultEntity.auditcomment = null;
                    objAuditResultEntity.auditdate = null;
                    objAuditResultEntity.issoftdeleted = false;
                    objAuditResultEntity.remarks = "Final submit by applicant after rollback";
                    objAuditResultEntity.BaseSecurityParam = new SecurityCapsule();
                    objAuditResultEntity.BaseSecurityParam = request.CurrentRegistration.BaseSecurityParam;
                    await objtran_auditresultDataAccessObjects.AddAuditResult(Database, transaction, objAuditResultEntity, cancellationToken);
                }
                #endregion

                #region TABLE:Tran_ApplicantPhases
                var objTran_ApplicantPhases = new tran_applicantphasesEntity();
                objTran_ApplicantPhases.basicinfoid = request.CurrentRegistration.basicinfoid;
                objTran_ApplicantPhases.registrationid = registrationid;
                objTran_ApplicantPhases.batchid = request.CurrentRegistration.batchid;
                if (existingAuditResult != null && existingAuditResult.auditresult == (long)AuditResultEnum.Rollback)
                {
                    objTran_ApplicantPhases.phaseid = (long)ApplicantPhasesEnum.Audit;
                }
                else
                {
                    objTran_ApplicantPhases.phaseid = (long)ApplicantPhasesEnum.FinalSubmitted;
                }
                objTran_ApplicantPhases.statusid = (long)ApplicantStatusEnum.New;
                objTran_ApplicantPhases.submittedby = request.BasicInfo.userid;
                objTran_ApplicantPhases.submitteddate = DateTime.Now;

                objTran_ApplicantPhases.BaseSecurityParam = new SecurityCapsule();
                objTran_ApplicantPhases.BaseSecurityParam = request.CurrentRegistration.BaseSecurityParam;

                tran_applicantphasesDataAccessObjects objtran_applicantphasesDataAccess = new tran_applicantphasesDataAccessObjects(this.Context);
                await objtran_applicantphasesDataAccess.AddApplicationPhase(Database, transaction, objTran_ApplicantPhases, cancellationToken);
                #endregion

                reg_datacheckedDataAccessObjects objects = new reg_datacheckedDataAccessObjects(this.Context);
                var dataCheck = new reg_datacheckedEntity();
                dataCheck.basicinfoid = request.CurrentRegistration.basicinfoid;
                dataCheck.registrationid = request.CurrentRegistration.registrationid;
                dataCheck.isMarried = (request.BasicInfo.maritalstatus != (long)MaritalStatusEnum.Unmarried) ? true : false;
                dataCheck.BaseSecurityParam = new SecurityCapsule();
                dataCheck.BaseSecurityParam = request.CurrentRegistration.BaseSecurityParam;
                await objects.AddDataCheck(Database, transaction, dataCheck, cancellationToken);

                returnCode = registrationid;

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccessObjects.SavePreRegistration"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        async Task<RegistrationViewModel> Ireg_basicinfoDataAccessObjects.GetRegisteredApplicantProfileDataByCivilId(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_reg_basicinfo_By_CivilID";
                RegistrationViewModel objRegistrationVM = new RegistrationViewModel();
                objRegistrationVM.BasicInfo = null;
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (!reg_basicinfo.civilid.IsNullOrEmpty())
                    {
                        Database.AddInParameter(cmd, "@CivilID", DbType.String, reg_basicinfo.civilid);
                    }
                    if (!reg_basicinfo.email.IsNullOrEmpty())
                    {
                        Database.AddInParameter(cmd, "@Email", DbType.String, reg_basicinfo.email);
                    }
                    if (!reg_basicinfo.mob1.IsNullOrEmpty())
                    {
                        Database.AddInParameter(cmd, "@Mob1", DbType.String, reg_basicinfo.mob1);
                    }

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            objRegistrationVM.BasicInfo = new reg_basicinfoEntity(reader);
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    if (objRegistrationVM.BasicInfo != null)
                    {
                        reg_registrationinfoDataAccessObjects objreg_registrationinfo = new reg_registrationinfoDataAccessObjects(this.Context);
                        objRegistrationVM.CurrentRegistration = await objreg_registrationinfo.GetRegistrationInfoByBasicInfoID(new reg_registrationinfoEntity() { basicinfoid = objRegistrationVM.BasicInfo.basicinfoid }, cancellationToken);

                        if (objRegistrationVM.CurrentRegistration.isrollbackallowed.HasValue && objRegistrationVM.CurrentRegistration.isrollbackallowed == true)
                        {
                            objRegistrationVM.IsAllowToRollbak = true;
                        }
                        else
                        {
                            objRegistrationVM.IsAllowToRollbak = false;
                        }

                        if (objRegistrationVM.CurrentRegistration.isapplyotherbatchallowed.HasValue && objRegistrationVM.CurrentRegistration.isapplyotherbatchallowed == true)
                        {
                            objRegistrationVM.IsApplyAnotherBatchAllowed = true;
                        }
                        else
                        {
                            objRegistrationVM.IsApplyAnotherBatchAllowed = false;
                        }

                        reg_educationinfoDataAccessObjects reg_EducationinfoDataAccessObjects = new reg_educationinfoDataAccessObjects(this.Context);
                        objRegistrationVM.EducationInfoList = await reg_EducationinfoDataAccessObjects.GetAllByBasicInfoID(new reg_educationinfoEntity() { basicinfoid = objRegistrationVM.BasicInfo.basicinfoid }, cancellationToken);

                        reg_famillyDataAccessObjects objreg_FamillyDataAccessObjects = new reg_famillyDataAccessObjects(this.Context);
                        objRegistrationVM.FatherInfo = await objreg_FamillyDataAccessObjects.GetFamiliyMemberByRelationType(new reg_famillyEntity()
                        {
                            basicinfoid = objRegistrationVM.BasicInfo.basicinfoid,
                            RegistrationID = objRegistrationVM.CurrentRegistration.registrationid,
                            relationshipid = (long)RelationshipEnum.Father
                        }, cancellationToken);

                        objRegistrationVM.MotherInfo = await objreg_FamillyDataAccessObjects.GetFamiliyMemberByRelationType(new reg_famillyEntity()
                        {
                            basicinfoid = objRegistrationVM.BasicInfo.basicinfoid,
                            RegistrationID = objRegistrationVM.CurrentRegistration.registrationid,
                            relationshipid = (long)RelationshipEnum.Mother
                        }, cancellationToken);

                        objRegistrationVM.WifeList = await objreg_FamillyDataAccessObjects.GetFamilyMemberListByRelationType(new reg_famillyEntity()
                        {
                            basicinfoid = objRegistrationVM.BasicInfo.basicinfoid,
                            RegistrationID = objRegistrationVM.CurrentRegistration.registrationid,
                            relationshipid = (long)RelationshipEnum.Wife
                        }, cancellationToken);

                        reg_emergencycontactinfoDataAccessObjects objreg_emergencycontactinfoDataAcces = new reg_emergencycontactinfoDataAccessObjects(this.Context);
                        objRegistrationVM.EmergencyContactList = await objreg_emergencycontactinfoDataAcces.GetAllByBasicId(new reg_emergencycontactinfoEntity() { basicinfoid = objRegistrationVM.BasicInfo.basicinfoid }, cancellationToken);

                        //tran_notificationbatchdetDataAccessObjects objtran_notificationbatchdet = new tran_notificationbatchdetDataAccessObjects(this.Context);
                        //var tran_notificationbatchdetEntity = new tran_notificationbatchdetEntity();
                        //tran_notificationbatchdetEntity.basicinfoid = objRegistrationVM.BasicInfo.basicinfoid;
                        //tran_notificationbatchdetEntity.registrationid = objRegistrationVM.CurrentRegistration.registrationid;
                        //var NotificationCount = await objtran_notificationbatchdet.GetAllByBasicId_RegistrationId(tran_notificationbatchdetEntity, cancellationToken);
                        //if (NotificationCount.Count > 0)
                        //{
                        //    objRegistrationVM.IsAllowToRollbak = false;
                        //}
                        //else
                        //{
                        //    objRegistrationVM.IsAllowToRollbak = true;
                        //}

                        cnf_filerequiredDataAccessObjects objcnf_filerequiredDataAccessObjects = new cnf_filerequiredDataAccessObjects(this.Context);
                        objRegistrationVM.RequiredFileList = await objcnf_filerequiredDataAccessObjects.GetAllRequiredFile(new cnf_filerequiredEntity() { batchid = objRegistrationVM.CurrentRegistration.batchid }, cancellationToken);

                        objRegistrationVM.ApplicantMaritalstatus = objRegistrationVM.BasicInfo.maritalstatus;

                        return objRegistrationVM;
                    }
                    else
                    {
                        throw new Exception("User not Found");
                    }
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.GetAllreg_basicinfo"));
            }
        }

        async Task<RegistrationViewModel> Ireg_basicinfoDataAccessObjects.GetRegistrationDetailsByCivilId(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_reg_basicinfo_By_CivilID";
                RegistrationViewModel objRegistrationVM = new RegistrationViewModel();
                objRegistrationVM.BasicInfo = null;
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (!reg_basicinfo.civilid.IsNullOrEmpty())
                    {
                        Database.AddInParameter(cmd, "@CivilID", DbType.String, reg_basicinfo.civilid);
                    }
                    if (!reg_basicinfo.email.IsNullOrEmpty())
                    {
                        Database.AddInParameter(cmd, "@Email", DbType.String, reg_basicinfo.email);
                    }
                    if (!reg_basicinfo.mob1.IsNullOrEmpty())
                    {
                        Database.AddInParameter(cmd, "@Mob1", DbType.String, reg_basicinfo.mob1);
                    }

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            objRegistrationVM.BasicInfo = new reg_basicinfoEntity(reader);
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    if (objRegistrationVM.BasicInfo != null)
                    {
                        reg_registrationinfoDataAccessObjects objreg_registrationinfo = new reg_registrationinfoDataAccessObjects(this.Context);
                        objRegistrationVM.CurrentRegistration = await objreg_registrationinfo.GetRegistrationInfoByBasicInfoID(new reg_registrationinfoEntity() { basicinfoid = objRegistrationVM.BasicInfo.basicinfoid }, cancellationToken);

                        #region Tran_NotificationBatchDet
                        tran_notificationbatchdetDataAccessObjects objtran_notificationbatchdet = new tran_notificationbatchdetDataAccessObjects(this.Context);
                        var tran_notificationbatchdetEntity = new tran_notificationbatchdetEntity();
                        tran_notificationbatchdetEntity.basicinfoid = objRegistrationVM.BasicInfo.basicinfoid;
                        tran_notificationbatchdetEntity.registrationid = objRegistrationVM.CurrentRegistration.registrationid;
                        objRegistrationVM.NotificationBatchDetailList = (List<tran_notificationbatchdetEntity>)await objtran_notificationbatchdet.GetAllByBasicId_RegistrationId(tran_notificationbatchdetEntity, cancellationToken);
                        #endregion

                        #region Tran_AuditResult
                        tran_auditresultDataAccessObjects objtran_auditresult = new tran_auditresultDataAccessObjects(this.Context);
                        objRegistrationVM.AuditResult = await objtran_auditresult.GetLatestAuditResult(new tran_auditresultEntity() { basicinfoid = objRegistrationVM.BasicInfo.basicinfoid, registrationid = objRegistrationVM.CurrentRegistration.registrationid }, cancellationToken);
                        #endregion

                        #region Tran_VolunteerSyClearance
                        tran_volunteersyclearanceDataAccessObjects objtran_volunteersyclearance = new tran_volunteersyclearanceDataAccessObjects(this.Context);
                        objRegistrationVM.VolSyClearanceList = await objtran_volunteersyclearance.GetAllByBasicInfoRegistrationID(new tran_volunteersyclearanceEntity() { basicinfoid = objRegistrationVM.BasicInfo.basicinfoid, registrationid = objRegistrationVM.CurrentRegistration.registrationid }, cancellationToken);
                        #endregion

                        #region Tran_SyExamResult
                        tran_syexamresultDataAccessObjects objtran_syexamresult = new tran_syexamresultDataAccessObjects(this.Context);
                        objRegistrationVM.SyExamResult = await objtran_syexamresult.GetLatestSyExamResult(new tran_syexamresultEntity() { basicinfoid = objRegistrationVM.BasicInfo.basicinfoid, registrationid = objRegistrationVM.CurrentRegistration.registrationid }, cancellationToken);
                        #endregion

                        #region Tran_SyExamNotification
                        tran_syexamnotificationDataAccessObjects objtran_syexamnotification = new tran_syexamnotificationDataAccessObjects(this.Context);
                        var tran_syexamnotificationEntity = new tran_syexamnotificationEntity();
                        tran_syexamnotificationEntity.basicinfoid = objRegistrationVM.BasicInfo.basicinfoid;
                        tran_syexamnotificationEntity.registrationid = objRegistrationVM.CurrentRegistration.registrationid;
                        objRegistrationVM.SyExamNotificationList = (List<tran_syexamnotificationEntity>)await objtran_syexamnotification.GetAllByBasicId_RegistrationId(tran_syexamnotificationEntity, cancellationToken);
                        #endregion

                        #region Tran_VolunteerUnitClearance
                        tran_volunteerunitclearanceDataAccessObjects objtran_volunteerunitclearance = new tran_volunteerunitclearanceDataAccessObjects(this.Context);
                        objRegistrationVM.VolUnitClearanceList = await objtran_volunteerunitclearance.GetAllByBasicInfoRegistrationID(new tran_volunteerunitclearanceEntity() { basicinfoid = objRegistrationVM.BasicInfo.basicinfoid, registrationid = objRegistrationVM.CurrentRegistration.registrationid }, cancellationToken);
                        #endregion

                        #region Tran_UnitClearanceResult
                        tran_unitclearanceresultDataAccessObjects objtran_unitclearanceresult = new tran_unitclearanceresultDataAccessObjects(this.Context);
                        objRegistrationVM.UnitClearanceResult = await objtran_unitclearanceresult.GetLatestUnitClearanceResult(new tran_unitclearanceresultEntity() { basicinfoid = objRegistrationVM.BasicInfo.basicinfoid, registrationid = objRegistrationVM.CurrentRegistration.registrationid }, cancellationToken);
                        #endregion

                        #region Tran_VolunteerMedClearance
                        tran_volunteermedclearanceDataAccessObjects objtran_volunteermedclearance = new tran_volunteermedclearanceDataAccessObjects(this.Context);
                        objRegistrationVM.VolMedClearanceList = await objtran_volunteermedclearance.GetAllByBasicInfoRegistrationID(new tran_volunteermedclearanceEntity() { basicinfoid = objRegistrationVM.BasicInfo.basicinfoid, registrationid = objRegistrationVM.CurrentRegistration.registrationid }, cancellationToken);
                        #endregion

                        #region Tran_MedExamResult
                        tran_medexamresultDataAccessObjects objtran_medexamresult = new tran_medexamresultDataAccessObjects(this.Context);
                        objRegistrationVM.MedExamResult = await objtran_medexamresult.GetLatestMedExamResult(new tran_medexamresultEntity() { basicinfoid = objRegistrationVM.BasicInfo.basicinfoid, registrationid = objRegistrationVM.CurrentRegistration.registrationid }, cancellationToken);
                        #endregion

                        #region Tran_MedExamNotification
                        tran_medexamnotificationDataAccessObjects objtran_medexamnotification = new tran_medexamnotificationDataAccessObjects(this.Context);
                        var tran_medexamnotificationEntity = new tran_medexamnotificationEntity();
                        tran_medexamnotificationEntity.basicinfoid = objRegistrationVM.BasicInfo.basicinfoid;
                        tran_medexamnotificationEntity.registrationid = objRegistrationVM.CurrentRegistration.registrationid;
                        tran_medexamnotificationEntity.notificationtype = (Int32)MedExamNotificationType.Medical;
                        objRegistrationVM.MedExamNotificationList = (List<tran_medexamnotificationEntity>)await objtran_medexamnotification.GetAllByBasicId_RegistrationId(tran_medexamnotificationEntity, cancellationToken);
                        #endregion

                        #region Tran_PsychoExamResult
                        tran_psychoexamresultDataAccessObjects objtran_psychoexamresult = new tran_psychoexamresultDataAccessObjects(this.Context);
                        objRegistrationVM.PsychoExamResult = await objtran_psychoexamresult.GetLatestPsychoExamResult(new tran_psychoexamresultEntity() { basicinfoid = objRegistrationVM.BasicInfo.basicinfoid, registrationid = objRegistrationVM.CurrentRegistration.registrationid }, cancellationToken);
                        #endregion

                        #region Tran_FinalExamResult
                        tran_finalexamresultDataAccessObjects objtran_finalexamresult = new tran_finalexamresultDataAccessObjects(this.Context);
                        objRegistrationVM.FinalExamResult = await objtran_finalexamresult.GetLatestFinalExamResult(new tran_finalexamresultEntity() { basicinfoid = objRegistrationVM.BasicInfo.basicinfoid, registrationid = objRegistrationVM.CurrentRegistration.registrationid }, cancellationToken);
                        #endregion

                        #region Tran_TrainingJoin
                        tran_trainingjoinDataAccessObjects objtran_trainingjoin = new tran_trainingjoinDataAccessObjects(this.Context);
                        objRegistrationVM.TrgJoin = await objtran_trainingjoin.GetSingleByBasicInfoIDRegistrationID(new tran_trainingjoinEntity() { basicinfoid = objRegistrationVM.BasicInfo.basicinfoid, registrationid = objRegistrationVM.CurrentRegistration.registrationid }, cancellationToken);
                        #endregion

                        #region Tran_SpecialRegistration
                        if (objRegistrationVM.CurrentRegistration.isspecialregistration == true
                            && objRegistrationVM.CurrentRegistration.SpecialRegID != null)
                        {
                            tran_specialregistrationDataAccessObjects objtran_specialregistration = new tran_specialregistrationDataAccessObjects(this.Context);
                            objRegistrationVM.SpecialRegistration = await objtran_specialregistration.GetSingleSpecialRegistrationInfo(new tran_specialregistrationEntity() { specialregid = objRegistrationVM.CurrentRegistration.SpecialRegID }, cancellationToken);
                        }
                        #endregion

                        #region Tran_ApplyAnotherBatch
                        tran_applyanotherbatchDataAccessObjects objtran_applyanotherbatch = new tran_applyanotherbatchDataAccessObjects(this.Context);
                        objRegistrationVM.AppyAnotherBatchList = (List<tran_applyanotherbatchEntity>)await objtran_applyanotherbatch.GetAllByBasicInfoID(new tran_applyanotherbatchEntity() { basicinfoid = objRegistrationVM.CurrentRegistration.basicinfoid }, cancellationToken);
                        #endregion

                        return objRegistrationVM;
                    }
                    else
                    {
                        throw new Exception("User not Found");
                    }
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.GetRegistrationDetailsByCivilId"));
            }
        }

        async Task<RegistrationViewModel> Ireg_basicinfoDataAccessObjects.GetRegisteredApplicantProfileDataByCivilIdForDelete(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_reg_basicinfo_By_CivilIDForDelete";
                RegistrationViewModel objRegistrationVM = new RegistrationViewModel();
                objRegistrationVM.BasicInfo = null;
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (!reg_basicinfo.civilid.IsNullOrEmpty())
                    {
                        Database.AddInParameter(cmd, "@CivilID", DbType.String, reg_basicinfo.civilid);
                    }
                    if (!reg_basicinfo.email.IsNullOrEmpty())
                    {
                        Database.AddInParameter(cmd, "@Email", DbType.String, reg_basicinfo.email);
                    }

                    if (!reg_basicinfo.mob1.IsNullOrEmpty())
                    {
                        Database.AddInParameter(cmd, "@Mob1", DbType.String, reg_basicinfo.mob1);
                    }

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            objRegistrationVM.BasicInfo = new reg_basicinfoEntity(reader);
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    if (objRegistrationVM.BasicInfo != null)
                    {
                        reg_registrationinfoDataAccessObjects objreg_registrationinfo = new reg_registrationinfoDataAccessObjects(this.Context);
                        objRegistrationVM.CurrentRegistration = await objreg_registrationinfo.GetRegistrationInfoByBasicInfoID(new reg_registrationinfoEntity() { basicinfoid = objRegistrationVM.BasicInfo.basicinfoid }, cancellationToken);

                        return objRegistrationVM;
                    }
                    else
                    {
                        throw new Exception("User not Found");
                    }
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.GetRegisteredApplicantProfileDataByCivilIdForDelete"));
            }
        }

        async Task<long> Ireg_basicinfoDataAccessObjects.SaveApplicantReviewBasicInfo(ApplicantReviewViewModel request, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster_BasicInfoId = -99;
            const string SP = "KAF_reg_basicinfo_Upd_ext";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            transactioncodeGen objTranIDGen = new transactioncodeGen();
            long? masteruserid = 0;
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillParameters(request.BasicInfo, cmd, Database);
                    FillSequrityParameters(request.BasicInfo.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);

                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    PrimaryKeyMaster_BasicInfoId = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    if (returnCode > 0)
                    {
                        #region TABLE:Reg_RegistrationInfo

                        request.CurrentRegistration.basicinfoid = PrimaryKeyMaster_BasicInfoId;

                        reg_registrationinfoDataAccessObjects objreg_registrationinfo = new reg_registrationinfoDataAccessObjects(this.Context);
                        var registrationid = await objreg_registrationinfo.SaveRegistrationDetail(Database, transaction, request.CurrentRegistration, cancellationToken);
                        #endregion

                        #region TABLE:Tran_ApplicantBatchChange
                        if (request.CurrentRegistration.previousBatchID != request.CurrentRegistration.batchid)
                        {
                            tran_applicantbatchchangeDataAccessObjects objtran_applicantbatchchangeDataAccessObjects = new tran_applicantbatchchangeDataAccessObjects(this.Context);
                            tran_applicantbatchchangeEntity objtran_applicantbatchchangeEntity = new tran_applicantbatchchangeEntity();
                            objtran_applicantbatchchangeEntity.basicinfoid = request.CurrentRegistration.basicinfoid;
                            objtran_applicantbatchchangeEntity.registrationid = request.CurrentRegistration.registrationid;
                            objtran_applicantbatchchangeEntity.batchid = request.CurrentRegistration.batchid;
                            objtran_applicantbatchchangeEntity.remarks = "Batch changed from Applicant Review";
                            objtran_applicantbatchchangeEntity.issoftdeleted = false;
                            objtran_applicantbatchchangeEntity.BaseSecurityParam = new SecurityCapsule();
                            objtran_applicantbatchchangeEntity.BaseSecurityParam = request.CurrentRegistration.BaseSecurityParam;
                            await objtran_applicantbatchchangeDataAccessObjects.AddApplicantBatchChangeInfo(Database, transaction, objtran_applicantbatchchangeEntity, cancellationToken);
                        }
                        #endregion

                        #region TABLE:Reg_DataChecked
                        reg_datacheckedDataAccessObjects objreg_datacheckedDataAccessObjects = new reg_datacheckedDataAccessObjects(this.Context);
                        var applicantTableID = (long)ApplicantTableEnum.Reg_BasicInfo;
                        var objEntityRegDataChecked = await objreg_datacheckedDataAccessObjects.GetRegDataCheckedByApplicantTable(new reg_datacheckedEntity()
                        {
                            basicinfoid = PrimaryKeyMaster_BasicInfoId,
                            registrationid = registrationid,
                            applicanttableid = applicantTableID
                        }, cancellationToken);
                        if (objEntityRegDataChecked != null)
                        {
                            objEntityRegDataChecked.reviewedbyid = request.BaseSecurityParam.userid;
                            objEntityRegDataChecked.vieweddate = DateTime.Now;
                            if (request.BasicInfo.previousMaritialStatus != request.BasicInfo.maritalstatus)
                            {
                                objEntityRegDataChecked.isMarried = (request.BasicInfo.maritalstatus != (long)MaritalStatusEnum.Unmarried) ? true : false;
                            }
                            objEntityRegDataChecked.BaseSecurityParam = new SecurityCapsule();
                            objEntityRegDataChecked.BaseSecurityParam = request.BaseSecurityParam;
                            await objreg_datacheckedDataAccessObjects.UpdateRegDataCheckedByApplicantTable(Database, transaction, objEntityRegDataChecked, cancellationToken);
                        }
                        #endregion

                        #region TABLE:Tran_ApplicantPhases
                        tran_applicantphasesDataAccessObjects objtran_applicantphasesDataAccessObjects = new tran_applicantphasesDataAccessObjects(this.Context);
                        var objEntityTranApplicantPhases = await objtran_applicantphasesDataAccessObjects.GetSinglebyBasicInfoIDRegistrationID(Database, transaction, new tran_applicantphasesEntity()
                        {
                            basicinfoid = PrimaryKeyMaster_BasicInfoId,
                            registrationid = registrationid
                        }, cancellationToken);
                        if (objEntityTranApplicantPhases != null)
                        {
                            objEntityTranApplicantPhases.batchid = request.CurrentRegistration.batchid;
                            //objEntityRegDataChecked.BaseSecurityParam = new SecurityCapsule();
                            //objEntityRegDataChecked.BaseSecurityParam = request.BaseSecurityParam;
                            await objtran_applicantphasesDataAccessObjects.UpdateApplicantPhase(Database, transaction, objEntityTranApplicantPhases, cancellationToken);
                        }
                        #endregion

                        #region TABLE:Reg_Familly
                        var objreg_famillyEntity = new reg_famillyEntity();
                        objreg_famillyEntity.relationshipid = (long)RelationshipEnum.Father;
                        objreg_famillyEntity.basicinfoid = PrimaryKeyMaster_BasicInfoId;

                        reg_famillyDataAccessObjects objreg_famillyDataAccessObjects = new reg_famillyDataAccessObjects(this.Context);
                        objreg_famillyEntity = await objreg_famillyDataAccessObjects.GetFamiliyMemberByRelationType(Database, transaction, objreg_famillyEntity, cancellationToken);
                        if (objreg_famillyEntity != null && objreg_famillyEntity.familyid.HasValue)
                        {
                            objreg_famillyEntity.name1 = request.BasicInfo.name2;
                            objreg_famillyEntity.name2 = request.BasicInfo.name3;
                            objreg_famillyEntity.name3 = request.BasicInfo.name4;
                            objreg_famillyEntity.name5 = request.BasicInfo.name5;
                            objreg_famillyEntity.fullname = $"{objreg_famillyEntity.name1} {objreg_famillyEntity.name2} {objreg_famillyEntity.name3} {objreg_famillyEntity.name4} {objreg_famillyEntity.name5}";
                            objreg_famillyEntity.BaseSecurityParam.updatedbyusername = Convert.ToString(request.BasicInfo.BaseSecurityParam.updatedbyusername);
                            objreg_famillyEntity.BaseSecurityParam.updateddate = DateTime.Now;
                            await objreg_famillyDataAccessObjects.SaveUpdateExt(Database, transaction, objreg_famillyEntity, cancellationToken);
                        }
                        #endregion
                    }

                    cmd.Dispose();
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccessObjects.SaveApplicantReviewBasicInfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        async Task<IList<reg_basicinfoEntity>> Ireg_basicinfoDataAccessObjects.GetAllRegBasicInfoByMultipleBasicID(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "reg_basicinfo_GA_Ext";
                IList<reg_basicinfoEntity> itemList = new List<reg_basicinfoEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, reg_basicinfo.SortExpression);
                    FillSequrityParameters(reg_basicinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_basicinfo, cmd, Database);

                    if (!(string.IsNullOrEmpty(reg_basicinfo.basicinfoidstring)))
                        Database.AddInParameter(cmd, "@BasicInfoIDs", DbType.String, reg_basicinfo.basicinfoidstring);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_basicinfoEntity(reader, -99));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.GetAllRegBasicInfoByMultipleBasicIDreg_basicinfo"));
            }
        }

        async Task<long> Ireg_basicinfoDataAccessObjects.RollbackFinalSubmit(RegistrationViewModel request, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;
            const string Rollback_SP = "KAF_reg_basicinfo_RollbackFinalSubmit";


            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            long? masteruserid = 0;
            try
            {

                using (DbCommand cmd = Database.GetStoredProcCommand(Rollback_SP))
                {
                    request.BasicInfo.BaseSecurityParam = new SecurityCapsule();
                    request.BasicInfo.BaseSecurityParam = request.BaseSecurityParam;

                    Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, request.BasicInfo.basicinfoid);
                    Database.AddInParameter(cmd, "@RegistrationID", DbType.Int64, request.CurrentRegistration.registrationid);
                    Database.AddInParameter(cmd, "@PhaseID", DbType.Int64, ApplicantPhasesEnum.FinalSubmitted);
                    Database.AddInParameter(cmd, "@RollbackBy", DbType.Int64, RollbackByEnum.User);


                    FillSequrityParameters(request.BasicInfo.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);

                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);

                    if (returnCode > 0)
                    {
                        #region TABLE:Tran_ApplicantPhases
                        var objTran_ApplicantPhases = new tran_applicantphasesEntity();
                        objTran_ApplicantPhases.basicinfoid = request.CurrentRegistration.basicinfoid;
                        objTran_ApplicantPhases.registrationid = request.CurrentRegistration.registrationid;
                        objTran_ApplicantPhases.batchid = request.CurrentRegistration.batchid;
                        objTran_ApplicantPhases.phaseid = (long)ApplicantPhasesEnum.Registered;
                        objTran_ApplicantPhases.statusid = (long)ApplicantStatusEnum.New;
                        objTran_ApplicantPhases.submittedby = request.BasicInfo.userid;
                        objTran_ApplicantPhases.submitteddate = DateTime.Now;

                        objTran_ApplicantPhases.BaseSecurityParam = new SecurityCapsule();
                        objTran_ApplicantPhases.BaseSecurityParam = request.CurrentRegistration.BaseSecurityParam;

                        tran_applicantphasesDataAccessObjects objtran_applicantphasesDataAccess = new tran_applicantphasesDataAccessObjects(this.Context);
                        await objtran_applicantphasesDataAccess.AddApplicationPhase(Database, transaction, objTran_ApplicantPhases, cancellationToken);
                        #endregion
                    }

                    cmd.Dispose();
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccessObjects.RollbackFinalSubmit"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }


        async Task<ProfileReportEntity> Ireg_basicinfoDataAccessObjects.GetRegistrationProfileDataWithDetailByBasicId(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            try
            {
                ProfileReportEntity objRegistrationVM = new ProfileReportEntity();
                objRegistrationVM.BasicProfile = new List<RptBasicInfo>();

                using (DbCommand cmd = Database.GetStoredProcCommand("RPT_reg_basicinfo_By_BasicId"))
                {
                    if (reg_basicinfo.basicinfoid.HasValue)
                        Database.AddInParameter(cmd, "@basicinfoid", DbType.String, reg_basicinfo.basicinfoid);
                    if (!string.IsNullOrEmpty(reg_basicinfo.civilid))
                        Database.AddInParameter(cmd, "@civilid", DbType.String, reg_basicinfo.civilid);
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            objRegistrationVM.BasicProfile.Add(new RptBasicInfo(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }
                objRegistrationVM.RegistrationInfo = new List<RptRegistrationInfo>();
                using (DbCommand cmd = Database.GetStoredProcCommand("RPT_reg_registration_By_BasicId"))
                {
                    if (objRegistrationVM.BasicProfile != null)
                        Database.AddInParameter(cmd, "@basicinfoid", DbType.String, objRegistrationVM.BasicProfile[0].BasicInfoId);
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            objRegistrationVM.RegistrationInfo.Add(new RptRegistrationInfo(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }


                reg_famillyDataAccessObjects objreg_FamillyDataAccessObjects = new reg_famillyDataAccessObjects(this.Context);

                objRegistrationVM.SpouseInfo = await objreg_FamillyDataAccessObjects.GetFamilyMemberListByRelationType(new reg_famillyEntity()
                {
                    basicinfoid = reg_basicinfo.basicinfoid,
                    RegistrationID = objRegistrationVM.RegistrationInfo.FirstOrDefault().RegistrationId,
                    relationshipid = (long)RelationshipEnum.Wife
                }, cancellationToken);


                //#region Father

                //objRegistrationVM.FatherInfo = new List<RptfatherInfo>();
                //using (DbCommand cmd = Database.GetStoredProcCommand("RPT_FatherInfo_By_BasicId"))
                //{

                //    if (reg_basicinfo.basicinfoid.HasValue)
                //        Database.AddInParameter(cmd, "@basicinfoid", DbType.String, reg_basicinfo.basicinfoid);
                //    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                //    while (!result.IsCompleted)
                //    {

                //    }
                //    using (IDataReader reader = Database.EndExecuteReader(result))
                //    {
                //        while (reader.Read())
                //        {
                //            objRegistrationVM.FatherInfo.Add(new RptfatherInfo(reader));
                //        }
                //        reader.Close();
                //    }
                //    cmd.Dispose();
                //}
                //#endregion

                #region Wife
                //objRegistrationVM.WifeInfo = new List<RptWifeInfo>();
                //using (DbCommand cmd = Database.GetStoredProcCommand("RPT_WifeInfo_By_BasicId"))
                //{
                //    if (reg_basicinfo.basicinfoid.HasValue)
                //        Database.AddInParameter(cmd, "@basicinfoid", DbType.String, reg_basicinfo.basicinfoid);
                //    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                //    while (!result.IsCompleted)
                //    {

                //    }
                //    using (IDataReader reader = Database.EndExecuteReader(result))
                //    {
                //        while (reader.Read())
                //        {
                //            objRegistrationVM.WifeInfo.Add(new RptWifeInfo(reader));
                //        }
                //        reader.Close();
                //    }
                //    cmd.Dispose();
                //}

                #endregion


                #region Mother

                //objRegistrationVM.MotherInfo = new List<RptMotherInfo>();
                //using (DbCommand cmd = Database.GetStoredProcCommand("RPT_MotherInfo_By_BasicId"))
                //{

                //    if (reg_basicinfo.basicinfoid.HasValue)
                //        Database.AddInParameter(cmd, "@basicinfoid", DbType.String, reg_basicinfo.basicinfoid);
                //    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                //    while (!result.IsCompleted)
                //    {

                //    }
                //    using (IDataReader reader = Database.EndExecuteReader(result))
                //    {
                //        while (reader.Read())
                //        {
                //            objRegistrationVM.MotherInfo.Add(new RptMotherInfo(reader));
                //            //objRegistrationVM.FatherInfo.Add(new RptfatherInfo(reader));
                //        }
                //        reader.Close();
                //    }
                //    cmd.Dispose();
                //}




                //Mother Husband
                //if (objRegistrationVM.MotherInfo != null)
                //{
                //    foreach (var item in objRegistrationVM.MotherInfo)
                //    {
                //        await GetFamiliMemberSpouseInfo(reg_basicinfo, objRegistrationVM, objreg_FamillyDataAccessObjects, item, cancellationToken);
                //    }
                //}
                #endregion

                #region Brother
                //objRegistrationVM.BrotherInfo = new List<RptBrotherInfo>();
                //using (DbCommand cmd = Database.GetStoredProcCommand("RPT_BrotherInfo_By_BasicId"))
                //{
                //    if (reg_basicinfo.basicinfoid.HasValue)
                //        Database.AddInParameter(cmd, "@basicinfoid", DbType.String, reg_basicinfo.basicinfoid);
                //    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                //    while (!result.IsCompleted)
                //    {

                //    }
                //    using (IDataReader reader = Database.EndExecuteReader(result))
                //    {
                //        while (reader.Read())
                //        {

                //            objRegistrationVM.BrotherInfo.Add(new RptBrotherInfo(reader));

                //        }
                //        reader.Close();
                //    }
                //    cmd.Dispose();
                //}


                #endregion

                #region Sister

                //objRegistrationVM.SisterInfo = new List<RptSisterInfo>();
                //using (DbCommand cmd = Database.GetStoredProcCommand("RPT_SisterInfo_By_BasicId"))
                //{
                //    if (reg_basicinfo.basicinfoid.HasValue)
                //        Database.AddInParameter(cmd, "@basicinfoid", DbType.String, reg_basicinfo.basicinfoid);
                //    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                //    while (!result.IsCompleted)
                //    {

                //    }
                //    using (IDataReader reader = Database.EndExecuteReader(result))
                //    {
                //        while (reader.Read())
                //        {

                //            objRegistrationVM.SisterInfo.Add(new RptSisterInfo(reader));

                //        }
                //        reader.Close();
                //    }
                //    cmd.Dispose();
                //}

                //objRegistrationVM.SisterInfo = await objreg_FamillyDataAccessObjects.GetFamilyMemberListByRelationType(new reg_famillyEntity()
                //{
                //    basicinfoid = reg_basicinfo.basicinfoid,
                //    RegistrationID = objRegistrationVM.RegistrationInfo.FirstOrDefault().RegistrationId,
                //    relationshipid = (long)RelationshipEnum.Sister
                //}, cancellationToken);



                //Sister Husband
                //if (objRegistrationVM.SisterInfo != null)
                //{
                //    foreach (var item in objRegistrationVM.SisterInfo)
                //    {
                //        await GetFamiliMemberSpouseInfo(reg_basicinfo, objRegistrationVM, objreg_FamillyDataAccessObjects, item, cancellationToken);
                //    }
                //}
                #endregion


                #region Education
                objRegistrationVM.EducationInformation = new List<RptEducationInfo>();
                using (DbCommand cmd = Database.GetStoredProcCommand("RPT_Reg_EducationInfo_By_BasicId"))
                {

                    if (objRegistrationVM.BasicProfile != null)
                        Database.AddInParameter(cmd, "@basicinfoid", DbType.String, objRegistrationVM.BasicProfile[0].BasicInfoId);
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

                #region Uncle

                //objRegistrationVM.PaternalUncle = new List<RptUncleInfo>();
                //using (DbCommand cmd = Database.GetStoredProcCommand("RPT_UncleInfo_By_BasicId"))
                //{
                //    if (reg_basicinfo.basicinfoid.HasValue)
                //        Database.AddInParameter(cmd, "@basicinfoid", DbType.String, reg_basicinfo.basicinfoid);
                //    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                //    while (!result.IsCompleted)
                //    {

                //    }
                //    using (IDataReader reader = Database.EndExecuteReader(result))
                //    {
                //        while (reader.Read())
                //        {

                //            objRegistrationVM.PaternalUncle.Add(new RptUncleInfo(reader));

                //        }
                //        reader.Close();
                //    }
                //    cmd.Dispose();
                //}
                #endregion

                #region Aunty
                //objRegistrationVM.PaternalAunty = new List<RptAuntyInfo>();
                //using (DbCommand cmd = Database.GetStoredProcCommand("RPT_Rpt_AuntyInfo_By_BasicId"))
                //{
                //    if (reg_basicinfo.basicinfoid.HasValue)
                //        Database.AddInParameter(cmd, "@basicinfoid", DbType.String, reg_basicinfo.basicinfoid);
                //    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                //    while (!result.IsCompleted)
                //    {

                //    }
                //    using (IDataReader reader = Database.EndExecuteReader(result))
                //    {
                //        while (reader.Read())
                //        {

                //            objRegistrationVM.PaternalAunty.Add(new RptAuntyInfo(reader));

                //        }
                //        reader.Close();
                //    }
                //    cmd.Dispose();
                //}
                #endregion

                #region Family Info

                objRegistrationVM.FamilyInfo = new List<RptFamilyInfo>();


                using (DbCommand cmd = Database.GetStoredProcCommand("RPT_FamilyInfo_By_BasicId"))
                {

                    if (objRegistrationVM.BasicProfile != null)
                        Database.AddInParameter(cmd, "@basicinfoid", DbType.String, objRegistrationVM.BasicProfile[0].BasicInfoId);

                    //if (reg_basicinfo.basicinfoid.HasValue)
                    //    Database.AddInParameter(cmd, "@basicinfoid", DbType.String, reg_basicinfo.basicinfoid);


                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {

                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {

                            objRegistrationVM.FamilyInfo.Add(new RptFamilyInfo(reader));

                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                }
                #endregion

                #region  MaternalAunty
                //objRegistrationVM.MaternalAunty = new List<RptFamilyInfo>();
                //using (DbCommand cmd = Database.GetStoredProcCommand("RPT_Rpt_FamilyInfo_By_BasicId"))
                //{
                //    if (reg_basicinfo.basicinfoid.HasValue)
                //        Database.AddInParameter(cmd, "@basicinfoid", DbType.String, reg_basicinfo.basicinfoid);
                //    Database.AddInParameter(cmd, "@relationshipid", DbType.Int64, (long)RelationshipEnum.MaternalAunty);
                //    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                //    while (!result.IsCompleted)
                //    {

                //    }
                //    using (IDataReader reader = Database.EndExecuteReader(result))
                //    {
                //        while (reader.Read())
                //        {

                //            objRegistrationVM.MaternalAunty.Add(new RptFamilyInfo(reader));

                //        }
                //        reader.Close();
                //    }
                //    cmd.Dispose();
                //}
                #endregion

                #region Emergency Contact
                objRegistrationVM.EmergencyContact = new List<RptEmergencyContactInfo>();


                using (DbCommand cmd = Database.GetStoredProcCommand("RPT_EmergencyContactInfo_By_BasicId"))
                {
                    if (objRegistrationVM.BasicProfile != null)
                        Database.AddInParameter(cmd, "@basicinfoid", DbType.String, objRegistrationVM.BasicProfile[0].BasicInfoId);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {

                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {

                            objRegistrationVM.EmergencyContact.Add(new RptEmergencyContactInfo(reader));

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
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.GetAllreg_basicinfo"));
            }
        }






        private static async Task GetFamiliMemberSpouseInfo(reg_basicinfoEntity reg_basicinfo, ProfileReportEntity objRegistrationVM, reg_famillyDataAccessObjects objreg_FamillyDataAccessObjects, reg_famillyEntity item, CancellationToken cancellationToken)
        {
            item.FamilyMemeberSpouseList = new List<reg_famillyEntity>();
            item.FamilyMemeberSpouseList = await objreg_FamillyDataAccessObjects.GetFamilyMememberSpouseList(new reg_famillyEntity()
            {
                basicinfoid = reg_basicinfo.basicinfoid,
                RegistrationID = objRegistrationVM.RegistrationInfo.FirstOrDefault().RegistrationId,
                parentid = item.familyid,
                relationshipid = (long)RelationshipEnum.Spouse
            }, cancellationToken);
        }

        async Task<ApplicantReviewViewModel> Ireg_basicinfoDataAccessObjects.GetRegisteredApplicantProfileDataByBasicInfoId(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetRegBasicInfoByCivilID_GS";
                ApplicantReviewViewModel objApplicantReviewVM = new ApplicantReviewViewModel();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, reg_basicinfo.basicinfoid);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            objApplicantReviewVM.BasicInfo = new reg_basicinfoEntity(reader);
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    if (objApplicantReviewVM.BasicInfo != null)
                    {
                        reg_registrationinfoDataAccessObjects objreg_registrationinfo = new reg_registrationinfoDataAccessObjects(this.Context);
                        objApplicantReviewVM.CurrentRegistration = await objreg_registrationinfo.GetRegistrationInfoByBasicInfoID(new reg_registrationinfoEntity() { basicinfoid = objApplicantReviewVM.BasicInfo.basicinfoid }, cancellationToken);

                        reg_educationinfoDataAccessObjects reg_EducationinfoDataAccessObjects = new reg_educationinfoDataAccessObjects(this.Context);
                        objApplicantReviewVM.EducationInfoList = await reg_EducationinfoDataAccessObjects.GetAllByBasicInfoID(new reg_educationinfoEntity() { basicinfoid = objApplicantReviewVM.BasicInfo.basicinfoid }, cancellationToken);

                        reg_famillyDataAccessObjects objreg_FamillyDataAccessObjects = new reg_famillyDataAccessObjects(this.Context);
                        objApplicantReviewVM.FatherInfo = await objreg_FamillyDataAccessObjects.GetFamiliyMemberByRelationType(new reg_famillyEntity()
                        {
                            basicinfoid = objApplicantReviewVM.BasicInfo.basicinfoid,
                            RegistrationID = objApplicantReviewVM.CurrentRegistration.registrationid,
                            fileConfigId = (long)FileConfig.FatherDocument,
                            relationshipid = (long)RelationshipEnum.Father
                        }, cancellationToken);

                        objApplicantReviewVM.MotherInfo = await objreg_FamillyDataAccessObjects.GetFamiliyMemberByRelationType(new reg_famillyEntity()
                        {
                            basicinfoid = objApplicantReviewVM.BasicInfo.basicinfoid,
                            RegistrationID = objApplicantReviewVM.CurrentRegistration.registrationid,
                            fileConfigId = (long)FileConfig.MotherDocument,

                            relationshipid = (long)RelationshipEnum.Mother
                        }, cancellationToken);

                        objApplicantReviewVM.WifeList = await objreg_FamillyDataAccessObjects.GetFamilyMemberListByRelationType(new reg_famillyEntity()
                        {
                            basicinfoid = objApplicantReviewVM.BasicInfo.basicinfoid,
                            RegistrationID = objApplicantReviewVM.CurrentRegistration.registrationid,
                            fileConfigId = (long)FileConfig.WifeDocument,
                            relationshipid = (long)RelationshipEnum.Wife
                        }, cancellationToken);

                        reg_emergencycontactinfoDataAccessObjects objreg_emergencycontactinfoDataAcces = new reg_emergencycontactinfoDataAccessObjects(this.Context);
                        objApplicantReviewVM.EmergencyContactList = await objreg_emergencycontactinfoDataAcces.GetAllByBasicId(new reg_emergencycontactinfoEntity() { basicinfoid = objApplicantReviewVM.BasicInfo.basicinfoid }, cancellationToken);


                        //reg_studentfilestorageDataAccessObjects objreg_studentfilestorageDataAccessObjects = new reg_studentfilestorageDataAccessObjects(this.Context);
                        //objApplicantReviewVM.BasicInfo.DocumentList = await objreg_studentfilestorageDataAccessObjects.GetAllByBasicId_FileConfigType(new reg_studentfilestorageEntity()
                        //{
                        //    basicinfoid = objApplicantReviewVM.BasicInfo.basicinfoid,
                        //    fileconfigid = (long)FileConfig.PersonalDocument,
                        //    CurrentState = BaseEntity.EntityState.Unchanged,

                        //}, cancellationToken);

                        reg_datacheckedDataAccessObjects objreg_DataCheckedDataAccessObjects = new reg_datacheckedDataAccessObjects(this.Context);
                        objApplicantReviewVM.regDataCheckedEntity = await objreg_DataCheckedDataAccessObjects.GetNotCheckedRegDataCheckedByApplicantTableID(new reg_datacheckedEntity()
                        {
                            basicinfoid = objApplicantReviewVM.BasicInfo.basicinfoid,
                            registrationid = objApplicantReviewVM.CurrentRegistration.registrationid,
                            applicanttableid = reg_basicinfo.ApplicantTableID,
                            ischecked = true
                        }, cancellationToken);

                        //reg_studentfilestorageDataAccessObjects objreg_studentfilestorageDataAccessObjects = new reg_studentfilestorageDataAccessObjects(this.Context);
                        //objApplicantReviewVM.Documents = await objreg_studentfilestorageDataAccessObjects.GetAllByBasicId(new reg_studentfilestorageEntity()
                        //{
                        //    basicinfoid = objApplicantReviewVM.BasicInfo.basicinfoid,
                        //}, cancellationToken);

                        cnf_filerequiredDataAccessObjects objcnf_filerequiredDataAccessObjects = new cnf_filerequiredDataAccessObjects(this.Context);
                        objApplicantReviewVM.RequiredFileList = await objcnf_filerequiredDataAccessObjects.GetAllRequiredFile(new cnf_filerequiredEntity() { batchid = objApplicantReviewVM.CurrentRegistration.batchid }, cancellationToken);

                        objApplicantReviewVM.ApplicantMaritalstatus = objApplicantReviewVM.BasicInfo.maritalstatus;

                        return objApplicantReviewVM;
                    }
                    else
                    {
                        throw new Exception("User not Found");
                    }
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.GetRegisteredApplicantProfileDataByBasicInfoId"));
            }
        }


        async Task<RegistrationViewModel> Ireg_basicinfoDataAccessObjects.GetRegisteredApplicantCurrentBatchDataByBasicId(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetRegBasicInfoByCivilID_GS";
                RegistrationViewModel objRegistrationVM = new RegistrationViewModel();
                objRegistrationVM.BasicInfo = null;
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, reg_basicinfo.basicinfoid);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            objRegistrationVM.BasicInfo = new reg_basicinfoEntity(reader);
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    if (objRegistrationVM.BasicInfo != null)
                    {
                        reg_registrationinfoDataAccessObjects objreg_registrationinfo = new reg_registrationinfoDataAccessObjects(this.Context);
                        objRegistrationVM.CurrentRegistration = await objreg_registrationinfo.GetRegistrationInfoByBasicInfoID(new reg_registrationinfoEntity() { basicinfoid = objRegistrationVM.BasicInfo.basicinfoid }, cancellationToken);

                        return objRegistrationVM;
                    }
                    else
                    {
                        throw new Exception("User not Found");
                    }
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.GetAllreg_basicinfo"));
            }
        }


        async Task<long> Ireg_basicinfoDataAccessObjects.RegisterAnotherBatchSave(RegistrationViewModel request, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster_BasicInfoId = -99;
            const string reg_basicinfo_Ins_SP = "KAF_reg_basicinfo_Ins_ext";
            const string reg_basicinfo_Update_SP = "KAF_reg_basicinfo_Upd_ext";
            const string reg_basicinfo_Delete_SP = "KAF_reg_basicinfo_Del_Ext";

            string SP = "";
            if (request.BasicInfo.CurrentState == BaseEntity.EntityState.Added)
                SP = reg_basicinfo_Ins_SP;
            else if (request.BasicInfo.CurrentState == BaseEntity.EntityState.Changed)
                SP = reg_basicinfo_Update_SP;
            else if (request.BasicInfo.CurrentState == BaseEntity.EntityState.Deleted)
                SP = reg_basicinfo_Delete_SP;

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            transactioncodeGen objTranIDGen = new transactioncodeGen();
            long? masteruserid = 0;
            try
            {
                #region Update Nationality
                const string _spNationality = "KAF_reg_basicinfo_Upd_Nationality";
                Reg_ApplicantDataCheckedEntity objdata = new Reg_ApplicantDataCheckedEntity();
                using (DbCommand cmd = Database.GetStoredProcCommand(_spNationality))
                {
                    FillSequrityParameters(request.BasicInfo.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);
                    Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, request.BasicInfo.basicinfoid);
                    Database.AddInParameter(cmd, "@CountryNationalityID", DbType.Int64, request.BasicInfo.countrynationalityid);

                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    if (returnCode < 0)
                    {
                        throw new ArgumentException("Error in transaction.");
                    }
                    cmd.Dispose();
                }
                #endregion

                #region TABLE:Reg_RegistrationInfo

                reg_registrationinfoDataAccessObjects objreg_registrationinfo = new reg_registrationinfoDataAccessObjects(this.Context);
                var registrationid = await objreg_registrationinfo.SaveRegistrationDetail(Database, transaction, request.CurrentRegistration, cancellationToken);
                #endregion

                #region TABLE:Tran_ApplicantPhases
                var objTran_ApplicantPhases = new tran_applicantphasesEntity();
                objTran_ApplicantPhases.basicinfoid = request.CurrentRegistration.basicinfoid;
                objTran_ApplicantPhases.registrationid = registrationid;
                objTran_ApplicantPhases.batchid = request.CurrentRegistration.batchid;
                objTran_ApplicantPhases.phaseid = (long)ApplicantPhasesEnum.Registered;
                objTran_ApplicantPhases.statusid = (long)ApplicantStatusEnum.New;
                objTran_ApplicantPhases.submittedby = request.BasicInfo.userid;
                objTran_ApplicantPhases.submitteddate = DateTime.Now;

                objTran_ApplicantPhases.BaseSecurityParam = new SecurityCapsule();
                objTran_ApplicantPhases.BaseSecurityParam = request.CurrentRegistration.BaseSecurityParam;

                tran_applicantphasesDataAccessObjects objtran_applicantphasesDataAccess = new tran_applicantphasesDataAccessObjects(this.Context);
                await objtran_applicantphasesDataAccess.AddApplicationPhase(Database, transaction, objTran_ApplicantPhases, cancellationToken);
                #endregion

                #region TABLE:Tran_ApplyAnotherBatch
                var objtran_applyanotherbatchEntity = new tran_applyanotherbatchEntity();
                objtran_applyanotherbatchEntity.basicinfoid = request.CurrentRegistration.basicinfoid;
                objtran_applyanotherbatchEntity.registrationid = registrationid;
                objtran_applyanotherbatchEntity.batchid = request.CurrentRegistration.batchid;
                objtran_applyanotherbatchEntity.oldbatchid = request.CurrentRegistration.previousBatchID;
                objtran_applyanotherbatchEntity.candidatetypeid = request.CurrentRegistration.candidatetypeid;
                objtran_applyanotherbatchEntity.professionid = request.CurrentRegistration.professionid;
                objtran_applyanotherbatchEntity.nationalityid = request.BasicInfo.countrynationalityid;
                objtran_applyanotherbatchEntity.issoftdeleted = false;
                objtran_applyanotherbatchEntity.remarks = "Apply another batch by user";
                objtran_applyanotherbatchEntity.BaseSecurityParam = new SecurityCapsule();
                objtran_applyanotherbatchEntity.BaseSecurityParam = request.CurrentRegistration.BaseSecurityParam;
                tran_applyanotherbatchDataAccessObjects objtran_applyanotherbatchDataAccessObjects = new tran_applyanotherbatchDataAccessObjects(this.Context);
                await objtran_applyanotherbatchDataAccessObjects.AddApplyAnotherBatch(Database, transaction, objtran_applyanotherbatchEntity, cancellationToken);
                #endregion

                returnCode = 1;
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccessObjects.SavePreRegistration"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        async Task<Reg_ApplicantDataCheckedEntity> Ireg_basicinfoDataAccessObjects.GetRegistrationDataInfoStatusCheck(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetRegistrationDataInfoStatusCheck";
                Reg_ApplicantDataCheckedEntity objdata = new Reg_ApplicantDataCheckedEntity();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, reg_basicinfo.basicinfoid);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            objdata = new Reg_ApplicantDataCheckedEntity(reader);
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return objdata;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.GetRegistrationDataInfoStatusCheck"));
            }
        }

        async Task<long> Ireg_basicinfoDataAccessObjects.DeleteApplicantbyBasicInfoID(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "KAF_ProcessFullProfileDelete";
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (reg_basicinfo.basicinfoid.HasValue)
                        Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, reg_basicinfo.basicinfoid);
                    if (!reg_basicinfo.civilid.IsNullOrEmpty())
                        Database.AddInParameter(cmd, "@CivilID", DbType.String, reg_basicinfo.civilid);
                    AddOutputParameter(cmd);

                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);

                    cmd.Dispose();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.DeleteApplicantbyBasicInfoIDreg_basicinfo"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        public async Task<long> SaveSpecialRegistrationBasicInfo(Database db, DbTransaction transaction, reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_basicinfo_Ins";

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                FillParameters(reg_basicinfo, cmd, db);
                FillSequrityParameters(reg_basicinfo.BaseSecurityParam, cmd, db);
                AddOutputParameter(cmd);
                try
                {
                    IAsyncResult result = db.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = db.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.AddSpecialRegistrationreg_basicinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        async Task<long> Ireg_basicinfoDataAccessObjects.UpdateApplicantContactInfo(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "KAF_Reg_BasicInfo_Upd_ApplicantContactInfo";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                if (!(string.IsNullOrEmpty(reg_basicinfo.civilid)))
                    Database.AddInParameter(cmd, "@CivilID", DbType.String, reg_basicinfo.civilid);
                if (!(string.IsNullOrEmpty(reg_basicinfo.mob1)))
                    Database.AddInParameter(cmd, "@Mob1", DbType.String, reg_basicinfo.mob1);
                if (!(string.IsNullOrEmpty(reg_basicinfo.email)))
                    Database.AddInParameter(cmd, "@Email", DbType.String, reg_basicinfo.email);

                FillSequrityParameters(reg_basicinfo.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccess.UpdateApplicantContactInfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

    }
}

