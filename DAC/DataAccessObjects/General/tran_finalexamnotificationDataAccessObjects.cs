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

    internal sealed partial class tran_finalexamnotificationDataAccessObjects : BaseDataAccess, Itran_finalexamnotificationDataAccessObjects
    {

        #region Constructors

        private string ClassName = "tran_finalexamnotificationDataAccessObjects";

        public tran_finalexamnotificationDataAccessObjects(Context context) : base(context)
        {
        }

        private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }

        #endregion

        public static void FillParameters(tran_finalexamnotificationEntity tran_finalexamnotification, DbCommand cmd, Database Database, bool forDelete = false)
        {
            if (tran_finalexamnotification.finalexamnotificationid.HasValue)
                Database.AddInParameter(cmd, "@finalexamNotificationID", DbType.Int64, tran_finalexamnotification.finalexamnotificationid);
            if (forDelete) return;
            if (tran_finalexamnotification.batchid.HasValue)
                Database.AddInParameter(cmd, "@BatchID", DbType.Int64, tran_finalexamnotification.batchid);
            if (tran_finalexamnotification.basicinfoid.HasValue)
                Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, tran_finalexamnotification.basicinfoid);
            if (tran_finalexamnotification.registrationid.HasValue)
                Database.AddInParameter(cmd, "@RegistrationID", DbType.Int64, tran_finalexamnotification.registrationid);
            if (tran_finalexamnotification.applicantphaseid.HasValue)
                Database.AddInParameter(cmd, "@ApplicantPhaseID", DbType.Int64, tran_finalexamnotification.applicantphaseid);
            if (!(string.IsNullOrEmpty(tran_finalexamnotification.messagesubject)))
                Database.AddInParameter(cmd, "@MessageSubject", DbType.String, tran_finalexamnotification.messagesubject);
            if (!(string.IsNullOrEmpty(tran_finalexamnotification.messagebody)))
                Database.AddInParameter(cmd, "@MessageBody", DbType.String, tran_finalexamnotification.messagebody);
            if ((tran_finalexamnotification.smsnotification != null))
                Database.AddInParameter(cmd, "@SmsNotification", DbType.Boolean, tran_finalexamnotification.smsnotification);
            if ((tran_finalexamnotification.pacinotification != null))
                Database.AddInParameter(cmd, "@PaciNotification", DbType.Boolean, tran_finalexamnotification.pacinotification);
            if ((tran_finalexamnotification.emailnotification != null))
                Database.AddInParameter(cmd, "@EmailNotification", DbType.Boolean, tran_finalexamnotification.emailnotification);
            if ((tran_finalexamnotification.senddate.HasValue))
                Database.AddInParameter(cmd, "@SendDate", DbType.DateTime, tran_finalexamnotification.senddate);
            if (!(string.IsNullOrEmpty(tran_finalexamnotification.notificationstatus)))
                Database.AddInParameter(cmd, "@NotificationStatus", DbType.String, tran_finalexamnotification.notificationstatus);

            Database.AddInParameter(cmd, "@FileID", DbType.Guid, tran_finalexamnotification.fileid);
            if ((tran_finalexamnotification.fileuploadresult != null))
                Database.AddInParameter(cmd, "@FileUploadResult", DbType.Boolean, tran_finalexamnotification.fileuploadresult);
            if (!(string.IsNullOrEmpty(tran_finalexamnotification.comment)))
                Database.AddInParameter(cmd, "@Comment", DbType.String, tran_finalexamnotification.comment);
            if (!(string.IsNullOrEmpty(tran_finalexamnotification.remarks)))
                Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_finalexamnotification.remarks);
            if (!(string.IsNullOrEmpty(tran_finalexamnotification.updateinfo)))
                Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, tran_finalexamnotification.updateinfo);
            if (tran_finalexamnotification.tranformactionid.HasValue)
                Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, tran_finalexamnotification.tranformactionid);

        }


        #region Add Operation

        async Task<long> Itran_finalexamnotificationDataAccessObjects.Add(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_finalexamnotification_Ins";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_finalexamnotification, cmd, Database);
                FillSequrityParameters(tran_finalexamnotification.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_finalexamnotificationDataAccess.Addtran_finalexamnotification"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Add Operation

        #region Update Operation

        async Task<long> Itran_finalexamnotificationDataAccessObjects.Update(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_finalexamnotification_Upd";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_finalexamnotification, cmd, Database);
                FillSequrityParameters(tran_finalexamnotification.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_finalexamnotificationDataAccess.Updatetran_finalexamnotification"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation

        #region Delete Operation

        async Task<long> Itran_finalexamnotificationDataAccessObjects.Delete(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_finalexamnotification_Del";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_finalexamnotification, cmd, Database, true);
                FillSequrityParameters(tran_finalexamnotification.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_finalexamnotificationDataAccess.Deletetran_finalexamnotification"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Delete Operation

        #region SaveList<>

        async Task<long> Itran_finalexamnotificationDataAccessObjects.SaveList(IList<tran_finalexamnotificationEntity> listAdded, IList<tran_finalexamnotificationEntity> listUpdated, IList<tran_finalexamnotificationEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_finalexamnotification_Ins";
            const string SPUpdate = "tran_finalexamnotification_Upd";
            const string SPDelete = "tran_finalexamnotification_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (tran_finalexamnotificationEntity tran_finalexamnotification in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_finalexamnotification, cmd, Database, true);
                            FillSequrityParameters(tran_finalexamnotification.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_finalexamnotificationEntity tran_finalexamnotification in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_finalexamnotification, cmd, Database);
                            FillSequrityParameters(tran_finalexamnotification.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_finalexamnotificationEntity tran_finalexamnotification in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_finalexamnotification, cmd, Database);
                            FillSequrityParameters(tran_finalexamnotification.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_finalexamnotificationDataAccess.Save_tran_finalexamnotification"));
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
        IList<tran_finalexamnotificationEntity> listAdded,
        IList<tran_finalexamnotificationEntity> listUpdated,
        IList<tran_finalexamnotificationEntity> listDeleted,
        CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_finalexamnotification_Ins";
            const string SPUpdate = "tran_finalexamnotification_Upd";
            const string SPDelete = "tran_finalexamnotification_Del";



            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (tran_finalexamnotificationEntity tran_finalexamnotification in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_finalexamnotification, cmd, db, true);
                            FillSequrityParameters(tran_finalexamnotification.BaseSecurityParam, cmd, db);
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
                    foreach (tran_finalexamnotificationEntity tran_finalexamnotification in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_finalexamnotification, cmd, db);
                            FillSequrityParameters(tran_finalexamnotification.BaseSecurityParam, cmd, db);
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
                    foreach (tran_finalexamnotificationEntity tran_finalexamnotification in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_finalexamnotification, cmd, db);
                            FillSequrityParameters(tran_finalexamnotification.BaseSecurityParam, cmd, db);
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

                throw GetDataAccessException(ex, SourceOfException("Itran_finalexamnotificationDataAccess.Save_tran_finalexamnotification"));
            }
            finally
            {

            }
            return returnCode;
        }

        #endregion SaveList<>

        #region GetAll

        async Task<IList<tran_finalexamnotificationEntity>> Itran_finalexamnotificationDataAccessObjects.GetAll(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "tran_finalexamnotification_GA";
                IList<tran_finalexamnotificationEntity> itemList = new List<tran_finalexamnotificationEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, tran_finalexamnotification.SortExpression);
                    FillSequrityParameters(tran_finalexamnotification.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_finalexamnotification, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_finalexamnotificationEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_finalexamnotificationDataAccess.GetAlltran_finalexamnotification"));
            }
        }

        async Task<IList<tran_finalexamnotificationEntity>> Itran_finalexamnotificationDataAccessObjects.GetAllByPages(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "tran_finalexamnotification_GAPg";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_finalexamnotification.SortExpression);
                    AddPageSizeParameter(cmd, tran_finalexamnotification.PageSize);
                    AddCurrentPageParameter(cmd, tran_finalexamnotification.CurrentPage);
                    FillSequrityParameters(tran_finalexamnotification.BaseSecurityParam, cmd, Database);

                    FillParameters(tran_finalexamnotification, cmd, Database);

                    if (!string.IsNullOrEmpty(tran_finalexamnotification.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + tran_finalexamnotification.strCommonSerachParam + "%");

                    IList<tran_finalexamnotificationEntity> itemList = new List<tran_finalexamnotificationEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_finalexamnotificationEntity(reader));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        tran_finalexamnotification.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_finalexamnotificationDataAccess.GetAllByPagestran_finalexamnotification"));
            }
        }

        #endregion

        #region Save Master/Details

        #endregion


        #region Simple load Single Row
        async Task<tran_finalexamnotificationEntity> Itran_finalexamnotificationDataAccessObjects.GetSingle(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "tran_finalexamnotification_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(tran_finalexamnotification.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_finalexamnotification, cmd, Database);

                    IList<tran_finalexamnotificationEntity> itemList = new List<tran_finalexamnotificationEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_finalexamnotificationEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_finalexamnotificationDataAccess.GetSingletran_finalexamnotification"));
            }
        }
        #endregion

        #region ForListView Paged Method
        async Task<IList<tran_finalexamnotificationEntity>> Itran_finalexamnotificationDataAccessObjects.GAPgListView(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "tran_finalexamnotification_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_finalexamnotification.SortExpression);
                    AddPageSizeParameter(cmd, tran_finalexamnotification.PageSize);
                    AddCurrentPageParameter(cmd, tran_finalexamnotification.CurrentPage);
                    FillSequrityParameters(tran_finalexamnotification.BaseSecurityParam, cmd, Database);

                    FillParameters(tran_finalexamnotification, cmd, Database);

                    if (!string.IsNullOrEmpty(tran_finalexamnotification.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + tran_finalexamnotification.strCommonSerachParam + "%");

                    IList<tran_finalexamnotificationEntity> itemList = new List<tran_finalexamnotificationEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_finalexamnotificationEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        tran_finalexamnotification.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_finalexamnotificationDataAccess.GAPgListViewtran_finalexamnotification"));
            }
        }
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion


    }
}