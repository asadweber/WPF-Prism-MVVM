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

namespace DAC.Core.DataAccessObjects.General
{
    /// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>

    internal sealed partial class gen_batchcandidatetypemapDataAccessObjects
    {
        async Task<long> Igen_batchcandidatetypemapDataAccessObjects.AddExt(gen_batchcandidatetypemapEntity gen_batchcandidatetypemapdata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_batchcandidatetypemap_Ins_ext";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_batchcandidatetypemapdata, cmd, Database);
                FillSequrityParameters(gen_batchcandidatetypemapdata.BaseSecurityParam, cmd, Database);
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

        async Task<IList<gen_batchcandidatetypemapEntity>> Igen_batchcandidatetypemapDataAccessObjects.GetAllExt(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_batchcandidatetypemap_GA_Ext";
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

        async Task<IList<gen_batchcandidatetypemapEntity>> Igen_batchcandidatetypemapDataAccessObjects.GAPgListViewExt(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken)
        {
            try
            {
                // const string SP = "gen_batchcandidatetypemap_GAPgListView_Ext";//
                const string SP = "gen_batchcandidatetypemap_GAPgListView_Ext_New"; 
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
                            itemList.Add(new gen_batchcandidatetypemapEntity(reader, -99));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatetypemapDataAccess.GAPgListViewExtgen_batchcandidatetypemap"));
            }
        }


        async Task<IList<gen_dropdownEntity>> Igen_batchcandidatetypemapDataAccessObjects.GetDataForDropDownExt(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_batchcandidatetypemap_GAPgDropDown_Ext";
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
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatetypemapDataAccess.GetDataForDropDownExt"));
            }
        }

        async Task<gen_batchcandidatetypemapEntity> Igen_batchcandidatetypemapDataAccessObjects.GetSingleByBatchCandidateTypeID(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_batchcandidatetypemap_GS_ByBatchCandidateTypeID";
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
                throw GetDataAccessException(ex, SourceOfException("Igen_batchcandidatetypemapDataAccess.GetSingleByBatchCandidateTypeID"));
            }
        }

    }
}