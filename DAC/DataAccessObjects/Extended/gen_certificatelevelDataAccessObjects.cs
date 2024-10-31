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
	
	internal sealed partial class gen_certificatelevelDataAccessObjects 
	{
        async Task<long> Igen_certificatelevelDataAccessObjects.AddExt(gen_certificatelevelEntity gen_certificateleveldata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_certificatelevel_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_certificateleveldata, cmd,Database);
                FillSequrityParameters(gen_certificateleveldata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<gen_certificatelevelEntity>> Igen_certificatelevelDataAccessObjects.GetAllExt(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_certificatelevel_GA_Ext";
                IList<gen_certificatelevelEntity> itemList = new List<gen_certificatelevelEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_certificatelevel.SortExpression);
                    FillSequrityParameters(gen_certificatelevel.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_certificatelevel, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_certificatelevelEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_certificatelevelDataAccess.GetAllgen_certificatelevel"));
            }	
        }


        async Task<IList<gen_certificatelevelEntity>> Igen_certificatelevelDataAccessObjects.GetCertificateLevelDataForDropDown(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_gen_certificatelevel_GAPgDropDown";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_certificatelevel.SortExpression);
                    AddPageSizeParameter(cmd, gen_certificatelevel.PageSize);
                    AddCurrentPageParameter(cmd, gen_certificatelevel.CurrentPage);
                    FillParameters(gen_certificatelevel, cmd, Database);
                    if (!string.IsNullOrEmpty(gen_certificatelevel.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_certificatelevel.strCommonSerachParam + "%");
                    IList<gen_certificatelevelEntity> itemList = new List<gen_certificatelevelEntity>();
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {

                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_certificatelevelEntity(reader));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_certificatelevel.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_certificatelevelDataAccess.GetDataForDropDown"));
            }
        }

    }
}