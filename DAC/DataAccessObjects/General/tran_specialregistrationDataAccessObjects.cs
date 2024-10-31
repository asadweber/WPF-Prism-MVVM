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

    internal sealed partial class tran_specialregistrationDataAccessObjects : BaseDataAccess, Itran_specialregistrationDataAccessObjects
    {

        #region Constructors

        private string ClassName = "tran_specialregistrationDataAccessObjects";

        public tran_specialregistrationDataAccessObjects(Context context) : base(context)
        {
        }

        private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }

        #endregion

        public static void FillParameters(tran_specialregistrationEntity tran_specialregistration, DbCommand cmd, Database Database, bool forDelete = false)
        {
            if (tran_specialregistration.specialregid.HasValue)
                Database.AddInParameter(cmd, "@SpecialRegID", DbType.Int64, tran_specialregistration.specialregid);
            if (forDelete) return;
            if (!(string.IsNullOrEmpty(tran_specialregistration.civilid)))
                Database.AddInParameter(cmd, "@CivilID", DbType.String, tran_specialregistration.civilid);
            if (tran_specialregistration.batchid.HasValue)
                Database.AddInParameter(cmd, "@BatchID", DbType.Int64, tran_specialregistration.batchid);
            if (tran_specialregistration.candidatetypeid.HasValue)
                Database.AddInParameter(cmd, "@CandidateTypeId", DbType.Int64, tran_specialregistration.candidatetypeid);
            if (!(string.IsNullOrEmpty(tran_specialregistration.emailaddress)))
                Database.AddInParameter(cmd, "@EmailAddress", DbType.String, tran_specialregistration.emailaddress);
            if (!(string.IsNullOrEmpty(tran_specialregistration.mobilenumber)))
                Database.AddInParameter(cmd, "@MobileNumber", DbType.String, tran_specialregistration.mobilenumber);
            if ((tran_specialregistration.sendbysms != null))
                Database.AddInParameter(cmd, "@SendBySMS", DbType.Boolean, tran_specialregistration.sendbysms);
            if ((tran_specialregistration.sendbydigitalid != null))
                Database.AddInParameter(cmd, "@SendByDigitalID", DbType.Boolean, tran_specialregistration.sendbydigitalid);
            if ((tran_specialregistration.sendbyemail != null))
                Database.AddInParameter(cmd, "@SendByEmail", DbType.Boolean, tran_specialregistration.sendbyemail);
            if (!(string.IsNullOrEmpty(tran_specialregistration.paciresponse)))
                Database.AddInParameter(cmd, "@PaciResponse", DbType.String, tran_specialregistration.paciresponse);
            if ((tran_specialregistration.validuntil.HasValue))
                Database.AddInParameter(cmd, "@ValidUntil", DbType.DateTime, tran_specialregistration.validuntil);
            if (tran_specialregistration.isexpired.HasValue)
                Database.AddInParameter(cmd, "@IsExpired", DbType.Boolean, tran_specialregistration.isexpired);
            if (!(string.IsNullOrEmpty(tran_specialregistration.remarks)))
                Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_specialregistration.remarks);
           
        }


        #region Add Operation

        async Task<long> Itran_specialregistrationDataAccessObjects.Add(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_specialregistration_Ins";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_specialregistration, cmd, Database);
                FillSequrityParameters(tran_specialregistration.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_specialregistrationDataAccess.Addtran_specialregistration"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Add Operation

        #region Update Operation

        async Task<long> Itran_specialregistrationDataAccessObjects.Update(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_specialregistration_Upd";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_specialregistration, cmd, Database);
                FillSequrityParameters(tran_specialregistration.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_specialregistrationDataAccess.Updatetran_specialregistration"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation

        #region Delete Operation

        async Task<long> Itran_specialregistrationDataAccessObjects.Delete(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_specialregistration_Del";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_specialregistration, cmd, Database, true);
                FillSequrityParameters(tran_specialregistration.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_specialregistrationDataAccess.Deletetran_specialregistration"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Delete Operation

        #region SaveList<>

        async Task<long> Itran_specialregistrationDataAccessObjects.SaveList(IList<tran_specialregistrationEntity> listAdded, IList<tran_specialregistrationEntity> listUpdated, IList<tran_specialregistrationEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_specialregistration_Ins";
            const string SPUpdate = "tran_specialregistration_Upd";
            const string SPDelete = "tran_specialregistration_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (tran_specialregistrationEntity tran_specialregistration in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_specialregistration, cmd, Database, true);
                            FillSequrityParameters(tran_specialregistration.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_specialregistrationEntity tran_specialregistration in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_specialregistration, cmd, Database);
                            FillSequrityParameters(tran_specialregistration.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_specialregistrationEntity tran_specialregistration in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_specialregistration, cmd, Database);
                            FillSequrityParameters(tran_specialregistration.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_specialregistrationDataAccess.Save_tran_specialregistration"));
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
        IList<tran_specialregistrationEntity> listAdded,
        IList<tran_specialregistrationEntity> listUpdated,
        IList<tran_specialregistrationEntity> listDeleted,
        CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_specialregistration_Ins";
            const string SPUpdate = "tran_specialregistration_Upd";
            const string SPDelete = "tran_specialregistration_Del";



            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (tran_specialregistrationEntity tran_specialregistration in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_specialregistration, cmd, db, true);
                            FillSequrityParameters(tran_specialregistration.BaseSecurityParam, cmd, db);
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
                    foreach (tran_specialregistrationEntity tran_specialregistration in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_specialregistration, cmd, db);
                            FillSequrityParameters(tran_specialregistration.BaseSecurityParam, cmd, db);
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
                    foreach (tran_specialregistrationEntity tran_specialregistration in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_specialregistration, cmd, db);
                            FillSequrityParameters(tran_specialregistration.BaseSecurityParam, cmd, db);
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

                throw GetDataAccessException(ex, SourceOfException("Itran_specialregistrationDataAccess.Save_tran_specialregistration"));
            }
            finally
            {

            }
            return returnCode;
        }

        #endregion SaveList<>

        #region GetAll

        async Task<IList<tran_specialregistrationEntity>> Itran_specialregistrationDataAccessObjects.GetAll(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "tran_specialregistration_GA";
                IList<tran_specialregistrationEntity> itemList = new List<tran_specialregistrationEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, tran_specialregistration.SortExpression);
                    FillSequrityParameters(tran_specialregistration.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_specialregistration, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_specialregistrationEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_specialregistrationDataAccess.GetAlltran_specialregistration"));
            }
        }

        async Task<IList<tran_specialregistrationEntity>> Itran_specialregistrationDataAccessObjects.GetAllByPages(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "tran_specialregistration_GAPg";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_specialregistration.SortExpression);
                    AddPageSizeParameter(cmd, tran_specialregistration.PageSize);
                    AddCurrentPageParameter(cmd, tran_specialregistration.CurrentPage);
                    FillSequrityParameters(tran_specialregistration.BaseSecurityParam, cmd, Database);

                    FillParameters(tran_specialregistration, cmd, Database);

                    if (!string.IsNullOrEmpty(tran_specialregistration.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + tran_specialregistration.strCommonSerachParam + "%");

                    IList<tran_specialregistrationEntity> itemList = new List<tran_specialregistrationEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_specialregistrationEntity(reader));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        tran_specialregistration.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_specialregistrationDataAccess.GetAllByPagestran_specialregistration"));
            }
        }

        #endregion

        #region Save Master/Details

        #endregion


        #region Simple load Single Row
        async Task<tran_specialregistrationEntity> Itran_specialregistrationDataAccessObjects.GetSingle(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "tran_specialregistration_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(tran_specialregistration.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_specialregistration, cmd, Database);

                    IList<tran_specialregistrationEntity> itemList = new List<tran_specialregistrationEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_specialregistrationEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_specialregistrationDataAccess.GetSingletran_specialregistration"));
            }
        }
        #endregion

        #region ForListView Paged Method
        async Task<IList<tran_specialregistrationEntity>> Itran_specialregistrationDataAccessObjects.GAPgListView(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "tran_specialregistration_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_specialregistration.SortExpression);
                    AddPageSizeParameter(cmd, tran_specialregistration.PageSize);
                    AddCurrentPageParameter(cmd, tran_specialregistration.CurrentPage);
                    FillSequrityParameters(tran_specialregistration.BaseSecurityParam, cmd, Database);

                    FillParameters(tran_specialregistration, cmd, Database);

                    if (!string.IsNullOrEmpty(tran_specialregistration.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + tran_specialregistration.strCommonSerachParam + "%");

                    IList<tran_specialregistrationEntity> itemList = new List<tran_specialregistrationEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_specialregistrationEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        tran_specialregistration.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_specialregistrationDataAccess.GAPgListViewtran_specialregistration"));
            }
        }
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion


    }
}