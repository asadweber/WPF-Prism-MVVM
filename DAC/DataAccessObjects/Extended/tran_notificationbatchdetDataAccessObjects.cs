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



namespace DAC.Core.DataAccessObjects.General
{
    /// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>

    internal sealed partial class tran_notificationbatchdetDataAccessObjects
    {
        async Task<long> Itran_notificationbatchdetDataAccessObjects.AddExt(tran_notificationbatchdetEntity tran_notificationbatchdetdata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_notificationbatchdet_Ins_ext";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_notificationbatchdetdata, cmd, Database);
                FillSequrityParameters(tran_notificationbatchdetdata.BaseSecurityParam, cmd, Database);
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

        async Task<IList<tran_notificationbatchdetEntity>> Itran_notificationbatchdetDataAccessObjects.GetAllExt(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "tran_notificationbatchdet_GA_Ext";
                IList<tran_notificationbatchdetEntity> itemList = new List<tran_notificationbatchdetEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, tran_notificationbatchdet.SortExpression);
                    FillSequrityParameters(tran_notificationbatchdet.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_notificationbatchdet, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_notificationbatchdetEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchdetDataAccess.GetAlltran_notificationbatchdet"));
            }
        }

        async Task<IList<tran_notificationbatchdetEntity>> Itran_notificationbatchdetDataAccessObjects.GetAllByBasicInfoRegistrationID(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_NotificationBatchDet_GA_ByRegistrationID";
                IList<tran_notificationbatchdetEntity> itemList = new List<tran_notificationbatchdetEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddSortExpressionParameter(cmd, tran_notificationbatchdet.SortExpression);
                    FillSequrityParameters(tran_notificationbatchdet.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_notificationbatchdet, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_notificationbatchdetEntity(reader, -99));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchdetDataAccess.GetAllByBasicInfoRegistrationID"));
            }
        }

        public async Task<IList<tran_notificationbatchdetEntity>> GetAllByBasicId_RegistrationId(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_tran_notificationbatchdet_GA_ByBasicId_RegistrationId";
                IList<tran_notificationbatchdetEntity> itemList = new List<tran_notificationbatchdetEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, tran_notificationbatchdet.SortExpression);
                    FillSequrityParameters(tran_notificationbatchdet.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_notificationbatchdet, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_notificationbatchdetEntity(reader, -99));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchdetDataAccess.GetAlltran_notificationbatchdet"));
            }
        }

        public async Task<long> AddNotificationBatchDetList(
       Database db,
       DbTransaction transaction,
       IList<tran_notificationbatchdetEntity> listAdded,
       CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_notificationbatchdet_Ins";
            const string SPUpdate = "tran_notificationbatchdet_Upd";
            const string SPDelete = "tran_notificationbatchdet_Del";

            try
            {
                if (listAdded.Count > 0)
                {
                    foreach (tran_notificationbatchdetEntity tran_notificationbatchdet in listAdded)
                    {
                        using (DbCommand cmd = db.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_notificationbatchdet, cmd, db);
                            FillSequrityParameters(tran_notificationbatchdet.BaseSecurityParam, cmd, db);
                            AddOutputParameter(cmd);

                            IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                            while (!result.IsCompleted)
                            {
                            }
                            returnCode = Database.EndExecuteNonQuery(result);
                            if (returnCode < 0)
                            {
                                throw new ArgumentException("Error in transaction.");
                            }
                            cmd.Dispose();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationbatchdetDataAccess.AddNotificationBatchDetList"));
            }
            finally
            {

            }
            return returnCode;
        }

    }
}