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
using AppConfig.HelperClasses;
using BDO.Core.Base;
using CLL.LLClasses.Models;



namespace DAC.Core.DataAccessObjects.General
{
    /// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>

    internal sealed partial class tran_notificationbatchDataAccessObjects
    {
        async Task<long> Itran_notificationbatchDataAccessObjects.AddExt(tran_notificationbatchEntity tran_notificationbatchdata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_notificationbatch_Ins_ext";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_notificationbatchdata, cmd, Database);
                FillSequrityParameters(tran_notificationbatchdata.BaseSecurityParam, cmd, Database);
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

        async Task<IList<tran_notificationbatchEntity>> Itran_notificationbatchDataAccessObjects.GetAllExt(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "tran_notificationbatch_GA_Ext";
                IList<tran_notificationbatchEntity> itemList = new List<tran_notificationbatchEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, tran_notificationbatch.SortExpression);
                    FillSequrityParameters(tran_notificationbatch.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_notificationbatch, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_notificationbatchEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchDataAccess.GetAlltran_notificationbatch"));
            }
        }

        async Task<long> Itran_notificationbatchDataAccessObjects.SaveNotificationBatchWithProfileList(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_notificationbatch_Ins";
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            transactioncodeGen objTranIDGen = new transactioncodeGen();
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillParameters(tran_notificationbatch, cmd, Database);
                    FillSequrityParameters(tran_notificationbatch.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);

                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);

                    if (returnCode > 0)
                    {
                        if (tran_notificationbatch.NotificationBatchDetList != null && tran_notificationbatch.NotificationBatchDetList.Count > 0) {
                            
                            #region Tran_NotificationBatchDet
                            foreach (var notificationbatchdet in tran_notificationbatch.NotificationBatchDetList)
                            {
                                notificationbatchdet.notificationbatchid = returnCode;

                                #region TABLE:Tran_ApplicantPhases
                                tran_applicantphasesDataAccessObjects objtran_applicantphasesDataAccessObjects = new tran_applicantphasesDataAccessObjects(this.Context);
                                tran_applicantphasesEntity objtran_applicantphasesEntity = new tran_applicantphasesEntity();
                                objtran_applicantphasesEntity.basicinfoid = notificationbatchdet.basicinfoid;
                                objtran_applicantphasesEntity.registrationid = notificationbatchdet.registrationid;
                                objtran_applicantphasesEntity = await objtran_applicantphasesDataAccessObjects.GetSinglebyBasicInfoIDRegistrationID(Database, transaction, objtran_applicantphasesEntity, cancellationToken);

                                if (objtran_applicantphasesEntity != null && objtran_applicantphasesEntity.phaseid == (long)ApplicantPhasesEnum.FinalSubmitted) {
                                    var objTran_ApplicantPhases = new tran_applicantphasesEntity();
                                    objTran_ApplicantPhases.basicinfoid = notificationbatchdet.basicinfoid;
                                    objTran_ApplicantPhases.registrationid = notificationbatchdet.registrationid;
                                    objTran_ApplicantPhases.batchid = notificationbatchdet.BatchID;
                                    objTran_ApplicantPhases.phaseid = (long)ApplicantPhasesEnum.Audit;
                                    objTran_ApplicantPhases.statusid = (long)ApplicantStatusEnum.New;
                                    objTran_ApplicantPhases.submittedby = notificationbatchdet.BaseSecurityParam.userid;
                                    objTran_ApplicantPhases.submitteddate = DateTime.Now;
                                    objTran_ApplicantPhases.BaseSecurityParam = new SecurityCapsule();
                                    objTran_ApplicantPhases.BaseSecurityParam = notificationbatchdet.BaseSecurityParam;
                                    await objtran_applicantphasesDataAccessObjects.AddApplicationPhase(Database, transaction, objTran_ApplicantPhases, cancellationToken);
                                }
                                #endregion
                            }
                            tran_notificationbatchdetDataAccessObjects objtran_notificationbatchdetDataAccessObjects = new tran_notificationbatchdetDataAccessObjects(this.Context);
                            await objtran_notificationbatchdetDataAccessObjects.AddNotificationBatchDetList(Database, transaction, tran_notificationbatch.NotificationBatchDetList, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchDataAccess.SaveNotificationBatchWithProfileList"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

    }
}