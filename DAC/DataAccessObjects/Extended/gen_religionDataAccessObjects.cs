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
	
	internal sealed partial class gen_religionDataAccessObjects 
	{
        async Task<long> Igen_religionDataAccessObjects.AddExt(gen_religionEntity gen_religiondata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_religion_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_religiondata, cmd,Database);
                FillSequrityParameters(gen_religiondata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<gen_religionEntity>> Igen_religionDataAccessObjects.GetAllExt(gen_religionEntity gen_religion, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_religion_GA_Ext";
                IList<gen_religionEntity> itemList = new List<gen_religionEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_religion.SortExpression);
                    FillSequrityParameters(gen_religion.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_religion, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_religionEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_religionDataAccess.GetAllgen_religion"));
            }	
        }


        async Task<IList<gen_religionEntity>> Igen_religionDataAccessObjects.GetReligionDataForDropDown(gen_religionEntity gen_religion, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_gen_religion_GAPgDropDown";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_religion.SortExpression);
                    AddPageSizeParameter(cmd, gen_religion.PageSize);
                    AddCurrentPageParameter(cmd, gen_religion.CurrentPage);
                    FillSequrityParameters(gen_religion.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_religion, cmd, Database);
                    if (!string.IsNullOrEmpty(gen_religion.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_religion.strCommonSerachParam + "%");
                    IList<gen_religionEntity> itemList = new List<gen_religionEntity>();
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {

                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_religionEntity(reader));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_religion.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_religionDataAccess.GetDataForDropDown"));
            }
        }

    }
}