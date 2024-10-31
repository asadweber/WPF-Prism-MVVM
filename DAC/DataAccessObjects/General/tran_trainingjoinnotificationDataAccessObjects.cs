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
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.ExtendedEntities;

namespace DAC.Core.DataAccessObjects.General
{
    /// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>

    internal sealed partial class tran_trainingjoinnotificationDataAccessObjects : BaseDataAccess, Itran_trainingjoinnotificationDataAccessObjects
    {

        #region Constructors

        private string ClassName = "tran_trainingjoinnotificationDataAccessObjects";

        public tran_trainingjoinnotificationDataAccessObjects(Context context) : base(context)
        {
        }

        private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }

        #endregion

        public static void FillParameters(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, DbCommand cmd, Database Database, bool forDelete = false)
        {
            if (tran_trainingjoinnotification.trainingjoinnotificationid.HasValue)
                Database.AddInParameter(cmd, "@trainingjoinNotificationID", DbType.Int64, tran_trainingjoinnotification.trainingjoinnotificationid);
            if (forDelete) return;
            if (tran_trainingjoinnotification.batchid.HasValue)
                Database.AddInParameter(cmd, "@BatchID", DbType.Int64, tran_trainingjoinnotification.batchid);
            if (tran_trainingjoinnotification.basicinfoid.HasValue)
                Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, tran_trainingjoinnotification.basicinfoid);
            if (tran_trainingjoinnotification.registrationid.HasValue)
                Database.AddInParameter(cmd, "@RegistrationID", DbType.Int64, tran_trainingjoinnotification.registrationid);
            if (tran_trainingjoinnotification.applicantphaseid.HasValue)
                Database.AddInParameter(cmd, "@ApplicantPhaseID", DbType.Int64, tran_trainingjoinnotification.applicantphaseid);
            if (!(string.IsNullOrEmpty(tran_trainingjoinnotification.messagesubject)))
                Database.AddInParameter(cmd, "@MessageSubject", DbType.String, tran_trainingjoinnotification.messagesubject);
            if (!(string.IsNullOrEmpty(tran_trainingjoinnotification.messagebody)))
                Database.AddInParameter(cmd, "@MessageBody", DbType.String, tran_trainingjoinnotification.messagebody);
            if ((tran_trainingjoinnotification.smsnotification != null))
                Database.AddInParameter(cmd, "@SmsNotification", DbType.Boolean, tran_trainingjoinnotification.smsnotification);
            if ((tran_trainingjoinnotification.pacinotification != null))
                Database.AddInParameter(cmd, "@PaciNotification", DbType.Boolean, tran_trainingjoinnotification.pacinotification);
            if ((tran_trainingjoinnotification.emailnotification != null))
                Database.AddInParameter(cmd, "@EmailNotification", DbType.Boolean, tran_trainingjoinnotification.emailnotification);
            if ((tran_trainingjoinnotification.senddate.HasValue))
                Database.AddInParameter(cmd, "@SendDate", DbType.DateTime, tran_trainingjoinnotification.senddate);
            if (!(string.IsNullOrEmpty(tran_trainingjoinnotification.notificationstatus)))
                Database.AddInParameter(cmd, "@NotificationStatus", DbType.String, tran_trainingjoinnotification.notificationstatus);

            Database.AddInParameter(cmd, "@FileID", DbType.Guid, tran_trainingjoinnotification.fileid);
            if ((tran_trainingjoinnotification.fileuploadresult != null))
                Database.AddInParameter(cmd, "@FileUploadResult", DbType.Boolean, tran_trainingjoinnotification.fileuploadresult);
            if (!(string.IsNullOrEmpty(tran_trainingjoinnotification.comment)))
                Database.AddInParameter(cmd, "@Comment", DbType.String, tran_trainingjoinnotification.comment);
            if (!(string.IsNullOrEmpty(tran_trainingjoinnotification.remarks)))
                Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_trainingjoinnotification.remarks);
            if (!(string.IsNullOrEmpty(tran_trainingjoinnotification.updateinfo)))
                Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, tran_trainingjoinnotification.updateinfo);
            if (tran_trainingjoinnotification.tranformactionid.HasValue)
                Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, tran_trainingjoinnotification.tranformactionid);

        }


        #region Add Operation

        async Task<long> Itran_trainingjoinnotificationDataAccessObjects.Add(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_trainingjoinnotification_Ins";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_trainingjoinnotification, cmd, Database);
                FillSequrityParameters(tran_trainingjoinnotification.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_trainingjoinnotificationDataAccess.Addtran_trainingjoinnotification"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Add Operation

        #region Update Operation

        async Task<long> Itran_trainingjoinnotificationDataAccessObjects.Update(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_trainingjoinnotification_Upd";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_trainingjoinnotification, cmd, Database);
                FillSequrityParameters(tran_trainingjoinnotification.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_trainingjoinnotificationDataAccess.Updatetran_trainingjoinnotification"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation

        #region Delete Operation

        async Task<long> Itran_trainingjoinnotificationDataAccessObjects.Delete(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_trainingjoinnotification_Del";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_trainingjoinnotification, cmd, Database, true);
                FillSequrityParameters(tran_trainingjoinnotification.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_trainingjoinnotificationDataAccess.Deletetran_trainingjoinnotification"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Delete Operation

        #region SaveList<>

        async Task<long> Itran_trainingjoinnotificationDataAccessObjects.SaveList(IList<tran_trainingjoinnotificationEntity> listAdded, IList<tran_trainingjoinnotificationEntity> listUpdated, IList<tran_trainingjoinnotificationEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_trainingjoinnotification_Ins";
            const string SPUpdate = "tran_trainingjoinnotification_Upd";
            const string SPDelete = "tran_trainingjoinnotification_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (tran_trainingjoinnotificationEntity tran_trainingjoinnotification in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_trainingjoinnotification, cmd, Database, true);
                            FillSequrityParameters(tran_trainingjoinnotification.BaseSecurityParam, cmd, Database);
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
                if (listUpdated.Count > 0)
                {
                    foreach (tran_trainingjoinnotificationEntity tran_trainingjoinnotification in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_trainingjoinnotification, cmd, Database);
                            FillSequrityParameters(tran_trainingjoinnotification.BaseSecurityParam, cmd, Database);
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
                if (listAdded.Count > 0)
                {
                    foreach (tran_trainingjoinnotificationEntity tran_trainingjoinnotification in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_trainingjoinnotification, cmd, Database);
                            FillSequrityParameters(tran_trainingjoinnotification.BaseSecurityParam, cmd, Database);
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

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Itran_trainingjoinnotificationDataAccess.Save_tran_trainingjoinnotification"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }


        public async Task<long> SaveList(
        Database db,
        DbTransaction transaction,
        IList<tran_trainingjoinnotificationEntity> listAdded,
        IList<tran_trainingjoinnotificationEntity> listUpdated,
        IList<tran_trainingjoinnotificationEntity> listDeleted,
        CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_trainingjoinnotification_Ins";
            const string SPUpdate = "tran_trainingjoinnotification_Upd";
            const string SPDelete = "tran_trainingjoinnotification_Del";



            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (tran_trainingjoinnotificationEntity tran_trainingjoinnotification in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_trainingjoinnotification, cmd, db, true);
                            FillSequrityParameters(tran_trainingjoinnotification.BaseSecurityParam, cmd, db);
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
                if (listUpdated.Count > 0)
                {
                    foreach (tran_trainingjoinnotificationEntity tran_trainingjoinnotification in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_trainingjoinnotification, cmd, db);
                            FillSequrityParameters(tran_trainingjoinnotification.BaseSecurityParam, cmd, db);
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
                if (listAdded.Count > 0)
                {
                    foreach (tran_trainingjoinnotificationEntity tran_trainingjoinnotification in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_trainingjoinnotification, cmd, db);
                            FillSequrityParameters(tran_trainingjoinnotification.BaseSecurityParam, cmd, db);
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

                throw GetDataAccessException(ex, SourceOfException("Itran_trainingjoinnotificationDataAccess.Save_tran_trainingjoinnotification"));
            }
            finally
            {

            }
            return returnCode;
        }

        #endregion SaveList<>

        #region GetAll

        async Task<IList<tran_trainingjoinnotificationEntity>> Itran_trainingjoinnotificationDataAccessObjects.GetAll(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "tran_trainingjoinnotification_GA";
                IList<tran_trainingjoinnotificationEntity> itemList = new List<tran_trainingjoinnotificationEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, tran_trainingjoinnotification.SortExpression);
                    FillSequrityParameters(tran_trainingjoinnotification.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_trainingjoinnotification, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_trainingjoinnotificationEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_trainingjoinnotificationDataAccess.GetAlltran_trainingjoinnotification"));
            }
        }

        async Task<IList<tran_trainingjoinnotificationEntity>> Itran_trainingjoinnotificationDataAccessObjects.GetAllByPages(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "tran_trainingjoinnotification_GAPg";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_trainingjoinnotification.SortExpression);
                    AddPageSizeParameter(cmd, tran_trainingjoinnotification.PageSize);
                    AddCurrentPageParameter(cmd, tran_trainingjoinnotification.CurrentPage);
                    FillSequrityParameters(tran_trainingjoinnotification.BaseSecurityParam, cmd, Database);

                    FillParameters(tran_trainingjoinnotification, cmd, Database);

                    if (!string.IsNullOrEmpty(tran_trainingjoinnotification.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + tran_trainingjoinnotification.strCommonSerachParam + "%");

                    IList<tran_trainingjoinnotificationEntity> itemList = new List<tran_trainingjoinnotificationEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_trainingjoinnotificationEntity(reader));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        tran_trainingjoinnotification.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_trainingjoinnotificationDataAccess.GetAllByPagestran_trainingjoinnotification"));
            }
        }

        #endregion

        #region Save Master/Details

        #endregion


        #region Simple load Single Row
        async Task<tran_trainingjoinnotificationEntity> Itran_trainingjoinnotificationDataAccessObjects.GetSingle(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "tran_trainingjoinnotification_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(tran_trainingjoinnotification.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_trainingjoinnotification, cmd, Database);

                    IList<tran_trainingjoinnotificationEntity> itemList = new List<tran_trainingjoinnotificationEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_trainingjoinnotificationEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_trainingjoinnotificationDataAccess.GetSingletran_trainingjoinnotification"));
            }
        }
        #endregion

        #region ForListView Paged Method
        async Task<IList<tran_trainingjoinnotificationEntity>> Itran_trainingjoinnotificationDataAccessObjects.GAPgListView(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "tran_trainingjoinnotification_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_trainingjoinnotification.SortExpression);
                    AddPageSizeParameter(cmd, tran_trainingjoinnotification.PageSize);
                    AddCurrentPageParameter(cmd, tran_trainingjoinnotification.CurrentPage);
                    FillSequrityParameters(tran_trainingjoinnotification.BaseSecurityParam, cmd, Database);

                    FillParameters(tran_trainingjoinnotification, cmd, Database);

                    if (!string.IsNullOrEmpty(tran_trainingjoinnotification.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + tran_trainingjoinnotification.strCommonSerachParam + "%");

                    IList<tran_trainingjoinnotificationEntity> itemList = new List<tran_trainingjoinnotificationEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_trainingjoinnotificationEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        tran_trainingjoinnotification.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_trainingjoinnotificationDataAccess.GAPgListViewtran_trainingjoinnotification"));
            }
        }
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion


    }
}