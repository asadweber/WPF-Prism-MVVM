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
	
	internal sealed partial class gen_countryclassDataAccessObjects 
	{
        async Task<long> Igen_countryclassDataAccessObjects.AddExt(gen_countryclassEntity gen_countryclassdata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_countryclass_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_countryclassdata, cmd,Database);
                FillSequrityParameters(gen_countryclassdata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<gen_countryclassEntity>> Igen_countryclassDataAccessObjects.GetAllExt(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_countryclass_GA_Ext";
                IList<gen_countryclassEntity> itemList = new List<gen_countryclassEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_countryclass.SortExpression);
                    FillSequrityParameters(gen_countryclass.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_countryclass, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_countryclassEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_countryclassDataAccess.GetAllgen_countryclass"));
            }	
        }


        async Task<IList<gen_countryclassEntity>> Igen_countryclassDataAccessObjects.GetCountryClassDropDown(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_gen_countryclass_GAPg";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_countryclass.SortExpression);
                    AddPageSizeParameter(cmd, gen_countryclass.PageSize);
                    AddCurrentPageParameter(cmd, gen_countryclass.CurrentPage);

                    FillParameters(gen_countryclass, cmd, Database);

                    if (!string.IsNullOrEmpty(gen_countryclass.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_countryclass.strCommonSerachParam + "%");

                    IList<gen_countryclassEntity> itemList = new List<gen_countryclassEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_countryclassEntity(reader));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_countryclass.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_countryclassDataAccess.GetAllByPagesgen_countryclass"));
            }
        }
    }
}