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
	
	internal sealed partial class gen_bloodgroupDataAccessObjects 
	{
        async Task<long> Igen_bloodgroupDataAccessObjects.AddExt(gen_bloodgroupEntity gen_bloodgroupdata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_bloodgroup_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_bloodgroupdata, cmd,Database);
                FillSequrityParameters(gen_bloodgroupdata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<gen_bloodgroupEntity>> Igen_bloodgroupDataAccessObjects.GetAllExt(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_bloodgroup_GA_Ext";
                IList<gen_bloodgroupEntity> itemList = new List<gen_bloodgroupEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_bloodgroup.SortExpression);
                    FillSequrityParameters(gen_bloodgroup.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_bloodgroup, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_bloodgroupEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_bloodgroupDataAccess.GetAllgen_bloodgroup"));
            }	
        }

        async Task<IList<gen_bloodgroupEntity>> Igen_bloodgroupDataAccessObjects.GetBloodGroupDataForDropDown(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_gen_bloodgroup_GAPgDropDown";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_bloodgroup.SortExpression);
                    AddPageSizeParameter(cmd, gen_bloodgroup.PageSize);
                    AddCurrentPageParameter(cmd, gen_bloodgroup.CurrentPage);
                    FillSequrityParameters(gen_bloodgroup.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_bloodgroup, cmd, Database);
                    if (!string.IsNullOrEmpty(gen_bloodgroup.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_bloodgroup.strCommonSerachParam + "%");
                    IList<gen_bloodgroupEntity> itemList = new List<gen_bloodgroupEntity>();
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {

                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_bloodgroupEntity(reader));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_bloodgroup.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_bloodgroupDataAccess.GetDataForDropDown"));
            }
        }

    }
}