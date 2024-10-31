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

    internal sealed partial class gen_professionDataAccessObjects
    {
        async Task<long> Igen_professionDataAccessObjects.AddExt(gen_professionEntity gen_professiondata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_profession_Ins_ext";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_professiondata, cmd, Database);
                FillSequrityParameters(gen_professiondata.BaseSecurityParam, cmd, Database);
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

        async Task<IList<gen_professionEntity>> Igen_professionDataAccessObjects.GetAllExt(gen_professionEntity gen_profession, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_profession_GA_Ext";
                IList<gen_professionEntity> itemList = new List<gen_professionEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, gen_profession.SortExpression);
                    FillSequrityParameters(gen_profession.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_profession, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_professionEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_professionDataAccess.GetAllgen_profession"));
            }
        }

        async Task<IList<gen_professionEntity>> Igen_professionDataAccessObjects.GAPgListViewExt(gen_professionEntity gen_profession, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_profession_GAPgListView_Ext";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_profession.SortExpression);
                    AddPageSizeParameter(cmd, gen_profession.PageSize);
                    AddCurrentPageParameter(cmd, gen_profession.CurrentPage);
                    FillSequrityParameters(gen_profession.BaseSecurityParam, cmd, Database);

                    FillParameters(gen_profession, cmd, Database);

                    if (!string.IsNullOrEmpty(gen_profession.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_profession.strCommonSerachParam + "%");

                    IList<gen_professionEntity> itemList = new List<gen_professionEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_professionEntity(reader, -99));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_profession.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_professionDataAccess.GAPgListViewExtgen_profession"));
            }
        }

        async Task<IList<gen_professionEntity>> Igen_professionDataAccessObjects.GetAllProfessionbyProfessionGroupID(gen_professionEntity gen_profession, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_profession_GA";
                IList<gen_professionEntity> itemList = new List<gen_professionEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, gen_profession.SortExpression);
                    Database.AddInParameter(cmd, "@ProfessionGroupID", DbType.Int64, gen_profession.professiongroupid);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_professionEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_professionDataAccess.GetAllProfessionbyProfessionGroupIDgen_profession"));
            }
        }


        #region for Dropdown 
        async Task<IList<gen_professionEntity>> Igen_professionDataAccessObjects.GetProfessionDropDown(gen_professionEntity gen_profession, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_gen_profession_GAPgDropDown";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_profession.SortExpression);
                    AddPageSizeParameter(cmd, gen_profession.PageSize);
                    AddCurrentPageParameter(cmd, gen_profession.CurrentPage);
                    FillParameters(gen_profession, cmd, Database);
                    if (!string.IsNullOrEmpty(gen_profession.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_profession.strCommonSerachParam + "%");


                    Database.AddInParameter(cmd, "@BatchCandidateTypeMapID", DbType.Int64, gen_profession.BatchCandidateTypeMapId);

                    IList<gen_professionEntity> itemList = new List<gen_professionEntity>();
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {

                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            var obj = new gen_professionEntity(reader);
                            if (!reader.IsDBNull(reader.GetOrdinal("BatchCandProfessionMapID"))) obj.BatchCandProfessionMapID = reader.GetInt64(reader.GetOrdinal("BatchCandProfessionMapID"));
                            itemList.Add(obj);
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_profession.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_professionDataAccess.GetDataForDropDown"));
            }
        }

        //For Web Admin
        async Task<IList<gen_professionEntity>> Igen_professionDataAccessObjects.GetBatchCandidateTypeWiseProfessionDropDown(gen_professionEntity gen_profession, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_profession_BatchCandidateType_GAPgDropDown";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_profession.SortExpression);
                    AddPageSizeParameter(cmd, gen_profession.PageSize);
                    AddCurrentPageParameter(cmd, gen_profession.CurrentPage);
                    FillParameters(gen_profession, cmd, Database);
                    if (!string.IsNullOrEmpty(gen_profession.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_profession.strCommonSerachParam + "%");

                    Database.AddInParameter(cmd, "@BatchIDs", DbType.String, gen_profession.BatchIdString);
                    if (gen_profession.CandidateTypeId.HasValue)
                        Database.AddInParameter(cmd, "@CandidateTypeID", DbType.Int64, gen_profession.CandidateTypeId);

                    IList<gen_professionEntity> itemList = new List<gen_professionEntity>();
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {

                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_professionEntity(reader, "ext"));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_profession.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_professionDataAccess.GetBatchCandidateTypeWiseProfessionDropDown"));
            }
        }

        async Task<IList<gen_professionEntity>> Igen_professionDataAccessObjects.GetMultiBatchCandidateTypeWiseProfessionDropDown(gen_professionEntity gen_profession, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_profession_MultiBatchCandidateType_GAPgDropDown";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_profession.SortExpression);
                    AddPageSizeParameter(cmd, gen_profession.PageSize);
                    AddCurrentPageParameter(cmd, gen_profession.CurrentPage);
                    FillParameters(gen_profession, cmd, Database);
                    if (!string.IsNullOrEmpty(gen_profession.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_profession.strCommonSerachParam + "%");

                    Database.AddInParameter(cmd, "@BatchIDs", DbType.String, gen_profession.BatchIdString);
                    if (!string.IsNullOrEmpty(gen_profession.CandidateTypeIDString))
                        Database.AddInParameter(cmd, "@CandidateTypeIDs", DbType.String, gen_profession.CandidateTypeIDString);

                    IList<gen_professionEntity> itemList = new List<gen_professionEntity>();
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {

                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_professionEntity(reader, "ext"));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_profession.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_professionDataAccess.GetMultiBatchCandidateTypeWiseProfessionDropDown"));
            }
        }
        #endregion

    }
}