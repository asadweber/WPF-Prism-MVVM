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
using System.Collections;

namespace DAC.Core.DataAccessObjects.General
{
    /// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>

    internal sealed partial class gen_newsDataAccessObjects : BaseDataAccess, Igen_newsDataAccessObjects
    {

        #region Constructors

        private string ClassName = "gen_newsDataAccessObjects";

        public gen_newsDataAccessObjects(Context context) : base(context)
        {
        }

        private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }

        #endregion

        public static void FillParameters(gen_newsEntity gen_news, DbCommand cmd, Database Database, bool forDelete = false)
        {
            if (gen_news.newsid.HasValue)
                Database.AddInParameter(cmd, "@NewsID", DbType.Int64, gen_news.newsid);
            if (forDelete) return;
            if (gen_news.newscategoryid.HasValue)
                Database.AddInParameter(cmd, "@NewsCategoryID", DbType.Int64, gen_news.newscategoryid);
            if (!(string.IsNullOrEmpty(gen_news.newsheadlinear)))
                Database.AddInParameter(cmd, "@NewsHeadlineAR", DbType.String, gen_news.newsheadlinear);
            if (!(string.IsNullOrEmpty(gen_news.newsheadline)))
                Database.AddInParameter(cmd, "@NewsHeadline", DbType.String, gen_news.newsheadline);

            Database.AddInParameter(cmd, "@NewsDetailAR", DbType.String, gen_news.newsdetailar);

            Database.AddInParameter(cmd, "@NewsDetail", DbType.String, gen_news.newsdetail);

            Database.AddInParameter(cmd, "@NewsImagePath", DbType.String, gen_news.newsimagepath);


            if ((gen_news.ispublished != null))
                Database.AddInParameter(cmd, "@IsPublished", DbType.Boolean, gen_news.ispublished);
            if ((gen_news.publisheddate.HasValue))
                Database.AddInParameter(cmd, "@PublishedDate", DbType.DateTime, gen_news.publisheddate);
            if (gen_news.publishedby.HasValue)
                Database.AddInParameter(cmd, "@PublishedBy", DbType.Int64, gen_news.publishedby);
            if ((gen_news.isreviewed != null))
                Database.AddInParameter(cmd, "@IsReviewed", DbType.Boolean, gen_news.isreviewed);
            if ((gen_news.revieweddate.HasValue))
                Database.AddInParameter(cmd, "@ReviewedDate", DbType.DateTime, gen_news.revieweddate);
            if (gen_news.reviewedby.HasValue)
                Database.AddInParameter(cmd, "@ReviewedBy", DbType.Int64, gen_news.reviewedby);
            if ((gen_news.showinticker != null))
                Database.AddInParameter(cmd, "@ShowInTicker", DbType.Boolean, gen_news.showinticker);
            if ((gen_news.showinscroller != null))
                Database.AddInParameter(cmd, "@ShowInScroller", DbType.Boolean, gen_news.showinscroller);
            if ((gen_news.showasmodal != null))
                Database.AddInParameter(cmd, "@ShowAsModal", DbType.Boolean, gen_news.showasmodal);

        }


        #region Add Operation

        async Task<long> Igen_newsDataAccessObjects.Add(gen_newsEntity gen_news, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_news_Ins";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_news, cmd, Database);
                FillSequrityParameters(gen_news.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_newsDataAccess.Addgen_news"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Add Operation

        #region Update Operation

        async Task<long> Igen_newsDataAccessObjects.Update(gen_newsEntity gen_news, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_news_Upd";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_news, cmd, Database);
                FillSequrityParameters(gen_news.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_newsDataAccess.Updategen_news"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation

        #region Delete Operation

        async Task<long> Igen_newsDataAccessObjects.Delete(gen_newsEntity gen_news, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_news_Del";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_news, cmd, Database, true);
                FillSequrityParameters(gen_news.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_newsDataAccess.Deletegen_news"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Delete Operation

        #region SaveList<>

        async Task<long> Igen_newsDataAccessObjects.SaveList(IList<gen_newsEntity> listAdded, IList<gen_newsEntity> listUpdated, IList<gen_newsEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_news_Ins";
            const string SPUpdate = "gen_news_Upd";
            const string SPDelete = "gen_news_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (gen_newsEntity gen_news in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_news, cmd, Database, true);
                            FillSequrityParameters(gen_news.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_newsEntity gen_news in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_news, cmd, Database);
                            FillSequrityParameters(gen_news.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_newsEntity gen_news in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_news, cmd, Database);
                            FillSequrityParameters(gen_news.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_newsDataAccess.Save_gen_news"));
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
        IList<gen_newsEntity> listAdded,
        IList<gen_newsEntity> listUpdated,
        IList<gen_newsEntity> listDeleted,
        CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_news_Ins";
            const string SPUpdate = "gen_news_Upd";
            const string SPDelete = "gen_news_Del";



            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (gen_newsEntity gen_news in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_news, cmd, db, true);
                            FillSequrityParameters(gen_news.BaseSecurityParam, cmd, db);
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
                    foreach (gen_newsEntity gen_news in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_news, cmd, db);
                            FillSequrityParameters(gen_news.BaseSecurityParam, cmd, db);
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
                    foreach (gen_newsEntity gen_news in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_news, cmd, db);
                            FillSequrityParameters(gen_news.BaseSecurityParam, cmd, db);
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

                throw GetDataAccessException(ex, SourceOfException("Igen_newsDataAccess.Save_gen_news"));
            }
            finally
            {

            }
            return returnCode;
        }

        #endregion SaveList<>

        #region GetAll

        async Task<IList<gen_newsEntity>> Igen_newsDataAccessObjects.GetAll(gen_newsEntity gen_news, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_news_GA";
                IList<gen_newsEntity> itemList = new List<gen_newsEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, gen_news.SortExpression);
                    FillSequrityParameters(gen_news.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_news, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_newsEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_newsDataAccess.GetAllgen_news"));
            }
        }

        async Task<IList<gen_newsEntity>> Igen_newsDataAccessObjects.GetAllByPages(gen_newsEntity gen_news, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_news_GAPg";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_news.SortExpression);
                    AddPageSizeParameter(cmd, gen_news.PageSize);
                    AddCurrentPageParameter(cmd, gen_news.CurrentPage);
                    FillSequrityParameters(gen_news.BaseSecurityParam, cmd, Database);

                    FillParameters(gen_news, cmd, Database);

                    if (!string.IsNullOrEmpty(gen_news.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_news.strCommonSerachParam + "%");

                    IList<gen_newsEntity> itemList = new List<gen_newsEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_newsEntity(reader));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_news.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_newsDataAccess.GetAllByPagesgen_news"));
            }
        }

        #endregion

        #region Save Master/Details


        async Task<long> Igen_newsDataAccessObjects.SaveMasterDetgen_newsgallery(gen_newsEntity masterEntity,
        IList<gen_newsgalleryEntity> listAdded,
        IList<gen_newsgalleryEntity> listUpdated,
        IList<gen_newsgalleryEntity> listDeleted,
        CancellationToken cancellationToken)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;

            string SP = "";
            const string MasterSPInsert = "gen_news_Ins";
            const string MasterSPUpdate = "gen_news_Upd";
            const string MasterSPDelete = "gen_news_Del";


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
                                item.newsid = PrimaryKeyMaster;
                            }
                        }
                        if ((listAdded != null && listAdded.Count > 0) || (listUpdated != null && listUpdated.Count > 0) || (listDeleted != null && listDeleted.Count > 0))
                        {
                            gen_newsgalleryDataAccessObjects objgen_newsgallery = new gen_newsgalleryDataAccessObjects(this.Context);
                            objgen_newsgallery.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
                        }
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
                throw GetDataAccessException(ex, SourceOfException("Igen_newsDataAccessObjects.SaveMasterDetgen_newsgallary"));
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
        async Task<gen_newsEntity> Igen_newsDataAccessObjects.GetSingle(gen_newsEntity gen_news, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_news_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(gen_news.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_news, cmd, Database);

                    IList<gen_newsEntity> itemList = new List<gen_newsEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_newsEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_newsDataAccess.GetSinglegen_news"));
            }
        }
        #endregion

        #region ForListView Paged Method
        async Task<IList<gen_newsEntity>> Igen_newsDataAccessObjects.GAPgListView(gen_newsEntity gen_news, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_news_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_news.SortExpression);
                    AddPageSizeParameter(cmd, gen_news.PageSize);
                    AddCurrentPageParameter(cmd, gen_news.CurrentPage);
                    FillSequrityParameters(gen_news.BaseSecurityParam, cmd, Database);

                    FillParameters(gen_news, cmd, Database);

                    if (!string.IsNullOrEmpty(gen_news.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_news.strCommonSerachParam + "%");

                    IList<gen_newsEntity> itemList = new List<gen_newsEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_newsEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_news.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_newsDataAccess.GAPgListViewgen_news"));
            }
        }
        #endregion

        #region Extras Reviewed, Published, Archived

        async Task<long> Igen_newsDataAccessObjects.UpdatePublished(gen_newsEntity gen_news, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_news_UpdPub";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_news, cmd, Database);
                FillSequrityParameters(gen_news.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_newsDataAccess.UpdatePublishedgen_news"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
        async Task<long> Igen_newsDataAccessObjects.UpdateReviewed(gen_newsEntity gen_news, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_news_UpdRev";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_news, cmd, Database);
                FillSequrityParameters(gen_news.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_newsDataAccess.UpdateReviewedgen_news"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
        #endregion


    }
}