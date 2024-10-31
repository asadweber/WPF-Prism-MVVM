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
using System.Linq;
using Unity.Interception.Utilities;
using System.Transactions;

namespace DAC.Core.DataAccessObjects.General
{
    /// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>

    internal sealed partial class gen_batchcandidatetypemapDataAccessObjects : BaseDataAccess, Igen_batchcandidatetypemapDataAccessObjects
    {

        #region Constructors

        private string ClassName = "gen_batchcandidatetypemapDataAccessObjects";

        public gen_batchcandidatetypemapDataAccessObjects(Context context) : base(context)
        {
        }

        private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }

        #endregion

        public static void FillParameters(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, DbCommand cmd, Database Database, bool forDelete = false)
        {
            if (gen_batchcandidatetypemap.batchcandidatetypemapid.HasValue)
                Database.AddInParameter(cmd, "@BatchCandidateTypeMapID", DbType.Int64, gen_batchcandidatetypemap.batchcandidatetypemapid);
            if (gen_batchcandidatetypemap.batchid.HasValue)
                Database.AddInParameter(cmd, "@BatchID", DbType.Int64, gen_batchcandidatetypemap.batchid);
            if (forDelete) return;
            if (gen_batchcandidatetypemap.candidatetypeid.HasValue)
                Database.AddInParameter(cmd, "@CandidateTypeID", DbType.Int64, gen_batchcandidatetypemap.candidatetypeid);
            //if ((gen_batchcandidatetypemap.startdate.HasValue))
            //	Database.AddInParameter(cmd, "@StartDate", DbType.DateTime, gen_batchcandidatetypemap.startdate);
            //if ((gen_batchcandidatetypemap.enddate.HasValue))
            //	Database.AddInParameter(cmd, "@EndDate", DbType.DateTime, gen_batchcandidatetypemap.enddate);
            if (!(string.IsNullOrEmpty(gen_batchcandidatetypemap.comment)))
                Database.AddInParameter(cmd, "@Comment", DbType.String, gen_batchcandidatetypemap.comment);
            if (!(string.IsNullOrEmpty(gen_batchcandidatetypemap.remarks)))
                Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_batchcandidatetypemap.remarks);
            if (!(string.IsNullOrEmpty(gen_batchcandidatetypemap.candidatetypeidsstring)))
                Database.AddInParameter(cmd, "@CandidateTypeIDs", DbType.String, gen_batchcandidatetypemap.candidatetypeidsstring);
        }


        #region Add Operation

        async Task<long> Igen_batchcandidatetypemapDataAccessObjects.Add(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_batchcandidatetypemap_Upd_Ext";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_batchcandidatetypemap, cmd, Database);
                FillSequrityParameters(gen_batchcandidatetypemap.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    transaction.Commit();
                    // returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatetypemapDataAccess.Addgen_batchcandidatetypemap"));
                }
                cmd.Dispose();
                transaction.Dispose();
            }
            return returnCode;
        }

        #endregion Add Operation

        #region Update Operation

        async Task<long> Igen_batchcandidatetypemapDataAccessObjects.Update(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_batchcandidatetypemap_Upd_Ext";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_batchcandidatetypemap, cmd, Database);
                FillSequrityParameters(gen_batchcandidatetypemap.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    transaction.Commit();
                    //returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatetypemapDataAccess.Updategen_batchcandidatetypemap"));
                }

                cmd.Dispose();
                transaction.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation

        #region Delete Operation

        async Task<long> Igen_batchcandidatetypemapDataAccessObjects.Delete(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            // const string SP = "gen_batchcandidatetypemap_Del";
            const string SP = "gen_batchcandidatetypemap_Del_Ext";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_batchcandidatetypemap, cmd, Database, true);
                FillSequrityParameters(gen_batchcandidatetypemap.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatetypemapDataAccess.Deletegen_batchcandidatetypemap"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Delete Operation

        #region SaveList<>

        async Task<long> Igen_batchcandidatetypemapDataAccessObjects.SaveList(IList<gen_batchcandidatetypemapEntity> listAdded, IList<gen_batchcandidatetypemapEntity> listUpdated, IList<gen_batchcandidatetypemapEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_batchcandidatetypemap_Ins";
            const string SPUpdate = "gen_batchcandidatetypemap_Upd";
            const string SPDelete = "gen_batchcandidatetypemap_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (gen_batchcandidatetypemapEntity gen_batchcandidatetypemap in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_batchcandidatetypemap, cmd, Database, true);
                            FillSequrityParameters(gen_batchcandidatetypemap.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_batchcandidatetypemapEntity gen_batchcandidatetypemap in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_batchcandidatetypemap, cmd, Database);
                            FillSequrityParameters(gen_batchcandidatetypemap.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_batchcandidatetypemapEntity gen_batchcandidatetypemap in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_batchcandidatetypemap, cmd, Database);
                            FillSequrityParameters(gen_batchcandidatetypemap.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatetypemapDataAccess.Save_gen_batchcandidatetypemap"));
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
        IList<gen_batchcandidatetypemapEntity> listAdded,
        IList<gen_batchcandidatetypemapEntity> listUpdated,
        IList<gen_batchcandidatetypemapEntity> listDeleted,
        CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_batchcandidatetypemap_Ins";
            const string SPUpdate = "gen_batchcandidatetypemap_Upd";
            const string SPDelete = "gen_batchcandidatetypemap_Del";



            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (gen_batchcandidatetypemapEntity gen_batchcandidatetypemap in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_batchcandidatetypemap, cmd, db, true);
                            FillSequrityParameters(gen_batchcandidatetypemap.BaseSecurityParam, cmd, db);
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
                    foreach (gen_batchcandidatetypemapEntity gen_batchcandidatetypemap in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_batchcandidatetypemap, cmd, db);
                            FillSequrityParameters(gen_batchcandidatetypemap.BaseSecurityParam, cmd, db);
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
                    foreach (gen_batchcandidatetypemapEntity gen_batchcandidatetypemap in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_batchcandidatetypemap, cmd, db);
                            FillSequrityParameters(gen_batchcandidatetypemap.BaseSecurityParam, cmd, db);
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

                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatetypemapDataAccess.Save_gen_batchcandidatetypemap"));
            }
            finally
            {

            }
            return returnCode;
        }

        #endregion SaveList<>

        #region GetAll

        async Task<IList<gen_batchcandidatetypemapEntity>> Igen_batchcandidatetypemapDataAccessObjects.GetAll(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_batchcandidatetypemap_GA";
                IList<gen_batchcandidatetypemapEntity> itemList = new List<gen_batchcandidatetypemapEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, gen_batchcandidatetypemap.SortExpression);
                    FillSequrityParameters(gen_batchcandidatetypemap.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_batchcandidatetypemap, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchcandidatetypemapEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatetypemapDataAccess.GetAllgen_batchcandidatetypemap"));
            }
        }

        async Task<IList<gen_batchcandidatetypemapEntity>> Igen_batchcandidatetypemapDataAccessObjects.GetAllByPages(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_batchcandidatetypemap_GAPg";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_batchcandidatetypemap.SortExpression);
                    AddPageSizeParameter(cmd, gen_batchcandidatetypemap.PageSize);
                    AddCurrentPageParameter(cmd, gen_batchcandidatetypemap.CurrentPage);
                    FillSequrityParameters(gen_batchcandidatetypemap.BaseSecurityParam, cmd, Database);

                    FillParameters(gen_batchcandidatetypemap, cmd, Database);

                    if (!string.IsNullOrEmpty(gen_batchcandidatetypemap.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_batchcandidatetypemap.strCommonSerachParam + "%");

                    IList<gen_batchcandidatetypemapEntity> itemList = new List<gen_batchcandidatetypemapEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchcandidatetypemapEntity(reader));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_batchcandidatetypemap.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatetypemapDataAccess.GetAllByPagesgen_batchcandidatetypemap"));
            }
        }

        #endregion

        #region Save Master/Details


        async Task<long> Igen_batchcandidatetypemapDataAccessObjects.SaveMasterDetgen_batchcandidatecertificate(gen_batchcandidatetypemapEntity masterEntity,
        IList<gen_batchcandidatecertificateEntity> listAdded,
        IList<gen_batchcandidatecertificateEntity> listUpdated,
        IList<gen_batchcandidatecertificateEntity> listDeleted,
        CancellationToken cancellationToken)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;

            string SP = "";
            const string MasterSPInsert = "gen_batchcandidatetypemap_Ins";
            const string MasterSPUpdate = "gen_batchcandidatetypemap_Upd";
            const string MasterSPDelete = "gen_batchcandidatetypemap_Del";


            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            if (masterEntity.CurrentState == BaseEntity.EntityState.Added)
                SP = MasterSPInsert;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                SP = MasterSPUpdate;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                SP = MasterSPDelete;
            else
            {
                throw new Exception("Nothing to save.");
            }
            DateTime dt = DateTime.Now;

            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Added || masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                    {
                        FillParameters(masterEntity, cmd, Database);
                    }
                    else
                    {
                        FillParameters(masterEntity, cmd, Database, true);
                    }
                    FillSequrityParameters(masterEntity.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd, Database);

                    if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                    {
                        IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                        while (!result.IsCompleted)
                        {
                        }
                        returnCode = Database.EndExecuteNonQuery(result);
                        PrimaryKeyMaster = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                        masterEntity.RETURN_KEY = PrimaryKeyMaster;

                    }
                    else
                    {
                        returnCode = 1;
                    }

                    if (returnCode > 0)
                    {
                        if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                        {
                            foreach (var item in listAdded)
                            {
                                item.batchcandidatetypemapid = PrimaryKeyMaster;
                            }
                        }
                        gen_batchcandidatecertificateDataAccessObjects objgen_batchcandidatecertificate = new gen_batchcandidatecertificateDataAccessObjects(this.Context);
                        objgen_batchcandidatecertificate.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
                    }
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                    cmd.Dispose();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatetypemapDataAccess.SaveDsgen_batchcandidatetypemap"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }


        async Task<long> Igen_batchcandidatetypemapDataAccessObjects.SaveMasterDetgen_batchcandidatereqfile(gen_batchcandidatetypemapEntity masterEntity,
        IList<gen_batchcandidatereqfileEntity> listAdded,
        IList<gen_batchcandidatereqfileEntity> listUpdated,
        IList<gen_batchcandidatereqfileEntity> listDeleted,
        CancellationToken cancellationToken)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;

            string SP = "";
            const string MasterSPInsert = "gen_batchcandidatetypemap_Ins";
            const string MasterSPUpdate = "gen_batchcandidatetypemap_Upd";
            const string MasterSPDelete = "gen_batchcandidatetypemap_Del";


            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            if (masterEntity.CurrentState == BaseEntity.EntityState.Added)
                SP = MasterSPInsert;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                SP = MasterSPUpdate;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                SP = MasterSPDelete;
            else
            {
                throw new Exception("Nothing to save.");
            }
            DateTime dt = DateTime.Now;

            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Added || masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                    {
                        FillParameters(masterEntity, cmd, Database);
                    }
                    else
                    {
                        FillParameters(masterEntity, cmd, Database, true);
                    }
                    FillSequrityParameters(masterEntity.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd, Database);

                    if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                    {
                        IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                        while (!result.IsCompleted)
                        {
                        }
                        returnCode = Database.EndExecuteNonQuery(result);
                        PrimaryKeyMaster = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                        masterEntity.RETURN_KEY = PrimaryKeyMaster;

                    }
                    else
                    {
                        returnCode = 1;
                    }

                    if (returnCode > 0)
                    {
                        if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                        {
                            foreach (var item in listAdded)
                            {
                                item.batchcandidatetypemapid = PrimaryKeyMaster;
                            }
                        }
                        gen_batchcandidatereqfileDataAccessObjects objgen_batchcandidatereqfile = new gen_batchcandidatereqfileDataAccessObjects(this.Context);
                        objgen_batchcandidatereqfile.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
                    }
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                    cmd.Dispose();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatetypemapDataAccess.SaveDsgen_batchcandidatetypemap"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }


        async Task<long> Igen_batchcandidatetypemapDataAccessObjects.SaveMasterDetgen_batchcandprofession(gen_batchcandidatetypemapEntity masterEntity,
        IList<gen_batchcandprofessionEntity> listAdded,
        IList<gen_batchcandprofessionEntity> listUpdated,
        IList<gen_batchcandprofessionEntity> listDeleted,
        CancellationToken cancellationToken)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;

            string SP = "";
            const string MasterSPInsert = "gen_batchcandidatetypemap_Ins";
            const string MasterSPUpdate = "gen_batchcandidatetypemap_Upd";
            const string MasterSPDelete = "gen_batchcandidatetypemap_Del";


            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            if (masterEntity.CurrentState == BaseEntity.EntityState.Added)
                SP = MasterSPInsert;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                SP = MasterSPUpdate;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                SP = MasterSPDelete;
            else
            {
                throw new Exception("Nothing to save.");
            }
            DateTime dt = DateTime.Now;

            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Added || masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                    {
                        FillParameters(masterEntity, cmd, Database);
                    }
                    else
                    {
                        FillParameters(masterEntity, cmd, Database, true);
                    }
                    FillSequrityParameters(masterEntity.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd, Database);

                    if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                    {
                        IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                        while (!result.IsCompleted)
                        {
                        }
                        returnCode = Database.EndExecuteNonQuery(result);
                        PrimaryKeyMaster = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                        masterEntity.RETURN_KEY = PrimaryKeyMaster;

                    }
                    else
                    {
                        returnCode = 1;
                    }

                    if (returnCode > 0)
                    {
                        if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                        {
                            foreach (var item in listAdded)
                            {
                                item.batchcandidatetypemapid = PrimaryKeyMaster;
                            }
                        }
                        gen_batchcandprofessionDataAccessObjects objgen_batchcandprofession = new gen_batchcandprofessionDataAccessObjects(this.Context);
                        objgen_batchcandprofession.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
                    }
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                    cmd.Dispose();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatetypemapDataAccess.SaveDsgen_batchcandidatetypemap"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        #endregion


        #region Simple load Single Row
        async Task<gen_batchcandidatetypemapEntity> Igen_batchcandidatetypemapDataAccessObjects.GetSingle(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_batchcandidatetypemap_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(gen_batchcandidatetypemap.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_batchcandidatetypemap, cmd, Database);

                    IList<gen_batchcandidatetypemapEntity> itemList = new List<gen_batchcandidatetypemapEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchcandidatetypemapEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatetypemapDataAccess.GetSinglegen_batchcandidatetypemap"));
            }
        }
        #endregion

        #region ForListView Paged Method
        async Task<IList<gen_batchcandidatetypemapEntity>> Igen_batchcandidatetypemapDataAccessObjects.GAPgListView(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_batchcandidatetypemap_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_batchcandidatetypemap.SortExpression);
                    AddPageSizeParameter(cmd, gen_batchcandidatetypemap.PageSize);
                    AddCurrentPageParameter(cmd, gen_batchcandidatetypemap.CurrentPage);
                    FillSequrityParameters(gen_batchcandidatetypemap.BaseSecurityParam, cmd, Database);

                    FillParameters(gen_batchcandidatetypemap, cmd, Database);

                    if (!string.IsNullOrEmpty(gen_batchcandidatetypemap.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_batchcandidatetypemap.strCommonSerachParam + "%");

                    IList<gen_batchcandidatetypemapEntity> itemList = new List<gen_batchcandidatetypemapEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_batchcandidatetypemapEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_batchcandidatetypemap.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatetypemapDataAccess.GAPgListViewgen_batchcandidatetypemap"));
            }
        }
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion

        #region for Dropdown 
        async Task<IList<gen_dropdownEntity>> Igen_batchcandidatetypemapDataAccessObjects.GetDataForDropDown(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_batchcandidatetypemap_GAPgDropDown";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_batchcandidatetypemap.SortExpression);
                    AddPageSizeParameter(cmd, gen_batchcandidatetypemap.PageSize);
                    AddCurrentPageParameter(cmd, gen_batchcandidatetypemap.CurrentPage);
                    FillSequrityParameters(gen_batchcandidatetypemap.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_batchcandidatetypemap, cmd, Database);
                    if (!string.IsNullOrEmpty(gen_batchcandidatetypemap.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + gen_batchcandidatetypemap.strCommonSerachParam + " % ");
                    IList<gen_dropdownEntity> itemList = new List<gen_dropdownEntity>();
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {

                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_dropdownEntity(reader));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_batchcandidatetypemap.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatetypemapDataAccess.GetDataForDropDown"));
            }
        }
        #endregion

    }
}