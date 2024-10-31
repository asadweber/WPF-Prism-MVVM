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

    internal sealed partial class gen_newsDataAccessObjects : BaseDataAccess, Igen_newsDataAccessObjects
    {
        public static void FillParameters_Ext(gen_newsEntity gen_news, DbCommand cmd, Database Database, bool forDelete = false)
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

        #region Add_Ext Operation

        async Task<long> Igen_newsDataAccessObjects.Add_Ext(gen_newsEntity gen_news, CancellationToken cancellationToken)
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

        #endregion Add_Ext Operation

        #region Update_Ext Operation

        async Task<long> Igen_newsDataAccessObjects.Update_Ext(gen_newsEntity gen_news, CancellationToken cancellationToken)
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

        #endregion Update_Ext Operation

        #region Delete_Ext Operation

        async Task<long> Igen_newsDataAccessObjects.Delete_Ext(gen_newsEntity gen_news, CancellationToken cancellationToken)
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

        #endregion Delete_Ext Operation

        #region GetAll_Ext
        async Task<IList<gen_newsEntity>> Igen_newsDataAccessObjects.GetAll_Ext(gen_newsEntity gen_news, CancellationToken cancellationToken)
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
        #endregion

        #region Simple load Single_Ext Row
        async Task<gen_newsEntity> Igen_newsDataAccessObjects.GetSingle_Ext(gen_newsEntity gen_news, CancellationToken cancellationToken)
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



    }
}