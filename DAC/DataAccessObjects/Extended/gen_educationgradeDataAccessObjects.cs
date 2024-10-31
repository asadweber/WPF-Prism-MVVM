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
	
	internal sealed partial class gen_educationgradeDataAccessObjects 
	{
        async Task<long> Igen_educationgradeDataAccessObjects.AddExt(gen_educationgradeEntity gen_educationgradedata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_educationgrade_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_educationgradedata, cmd,Database);
                FillSequrityParameters(gen_educationgradedata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<gen_educationgradeEntity>> Igen_educationgradeDataAccessObjects.GetAllExt(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_educationgrade_GA_Ext";
                IList<gen_educationgradeEntity> itemList = new List<gen_educationgradeEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_educationgrade.SortExpression);
                    FillSequrityParameters(gen_educationgrade.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_educationgrade, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_educationgradeEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_educationgradeDataAccess.GetAllgen_educationgrade"));
            }	
        }


        async Task<IList<gen_educationgradeEntity>> Igen_educationgradeDataAccessObjects.GetEducationGradeDataForDropDown(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_gen_educationgrade_GAPg";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_educationgrade.SortExpression);
                    AddPageSizeParameter(cmd, gen_educationgrade.PageSize);
                    AddCurrentPageParameter(cmd, gen_educationgrade.CurrentPage);
                    FillSequrityParameters(gen_educationgrade.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_educationgrade, cmd, Database);
                    if (!string.IsNullOrEmpty(gen_educationgrade.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_educationgrade.strCommonSerachParam + "%");
                    IList<gen_educationgradeEntity> itemList = new List<gen_educationgradeEntity>();
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {

                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_educationgradeEntity(reader));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_educationgrade.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_educationgradeDataAccess.GetDataForDropDown"));
            }
        }

    }
}