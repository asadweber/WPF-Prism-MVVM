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
	
	internal sealed partial class gen_countrycityDataAccessObjects 
	{
        async Task<long> Igen_countrycityDataAccessObjects.AddExt(gen_countrycityEntity gen_countrycitydata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_countrycity_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_countrycitydata, cmd,Database);
                FillSequrityParameters(gen_countrycitydata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<gen_countrycityEntity>> Igen_countrycityDataAccessObjects.GetAllExt(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_countrycity_GA_Ext";
                IList<gen_countrycityEntity> itemList = new List<gen_countrycityEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_countrycity.SortExpression);
                    FillSequrityParameters(gen_countrycity.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_countrycity, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_countrycityEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_countrycityDataAccess.GetAllgen_countrycity"));
            }	
        }

        async Task<IList<gen_countrycityEntity>> Igen_countrycityDataAccessObjects.GetGovernateDropDown(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_countrycity_GAPg_Dropdown";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_countrycity.SortExpression);
                    AddPageSizeParameter(cmd, gen_countrycity.PageSize);
                    AddCurrentPageParameter(cmd, gen_countrycity.CurrentPage);
                    FillSequrityParameters(gen_countrycity.BaseSecurityParam, cmd, Database);

                    FillParameters(gen_countrycity, cmd, Database);

                    if (!string.IsNullOrEmpty(gen_countrycity.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_countrycity.strCommonSerachParam + "%");

                    IList<gen_countrycityEntity> itemList = new List<gen_countrycityEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_countrycityEntity(reader));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_countrycity.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_countrycityDataAccess.GetAllByPagesgen_countrycity"));
            }
        }


        async Task<bool> Igen_countrycityDataAccessObjects.CheckHasGovernarate(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken)
        {
            try
            {
                bool hasGovernarate = false;
                const string SP = "gen_countrycity_Check_Has_Governarate";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    Database.AddInParameter(cmd, "@CountryID", DbType.Int64, gen_countrycity.countryid);
                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    Database.EndExecuteNonQuery(result);
                    long total = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    cmd.Dispose();
                    hasGovernarate = total > 0 ? true:false;
                    return hasGovernarate;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_countrycityDataAccess.GetAllByPagesgen_countrycity"));
            }
        }

    }
}