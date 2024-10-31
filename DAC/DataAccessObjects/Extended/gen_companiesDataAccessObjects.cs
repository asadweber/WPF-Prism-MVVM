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
	
	internal sealed partial class gen_companiesDataAccessObjects 
	{
        async Task<long> Igen_companiesDataAccessObjects.AddExt(gen_companiesEntity gen_companiesdata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_companies_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_companiesdata, cmd,Database);
                FillSequrityParameters(gen_companiesdata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<gen_companiesEntity>> Igen_companiesDataAccessObjects.GetAllExt(gen_companiesEntity gen_companies, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_companies_GA_Ext";
                IList<gen_companiesEntity> itemList = new List<gen_companiesEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_companies.SortExpression);
                    FillSequrityParameters(gen_companies.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_companies, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_companiesEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_companiesDataAccess.GetAllgen_companies"));
            }	
        }

        async Task<IList<gen_companiesEntity>> Igen_companiesDataAccessObjects.GAPgListViewExt(gen_companiesEntity gen_companies, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_companies_GAPgListView_Ext";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_companies.SortExpression);
                    AddPageSizeParameter(cmd, gen_companies.PageSize);
                    AddCurrentPageParameter(cmd, gen_companies.CurrentPage);
                    FillSequrityParameters(gen_companies.BaseSecurityParam, cmd, Database);

                    FillParameters(gen_companies, cmd, Database);

                    if (!string.IsNullOrEmpty(gen_companies.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_companies.strCommonSerachParam + "%");

                    IList<gen_companiesEntity> itemList = new List<gen_companiesEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_companiesEntity(reader, -99));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_companies.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_companiesDataAccess.GAPgListViewExtgen_companies"));
            }
        }

    }
}