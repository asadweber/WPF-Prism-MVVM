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
	
	internal sealed partial class gen_certificatesubjectsDataAccessObjects 
	{
        async Task<long> Igen_certificatesubjectsDataAccessObjects.AddExt(gen_certificatesubjectsEntity gen_certificatesubjectsdata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_certificatesubjects_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_certificatesubjectsdata, cmd,Database);
                FillSequrityParameters(gen_certificatesubjectsdata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<gen_certificatesubjectsEntity>> Igen_certificatesubjectsDataAccessObjects.GetAllExt(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_certificatesubjects_GA_Ext";
                IList<gen_certificatesubjectsEntity> itemList = new List<gen_certificatesubjectsEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_certificatesubjects.SortExpression);
                    FillSequrityParameters(gen_certificatesubjects.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_certificatesubjects, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_certificatesubjectsEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_certificatesubjectsDataAccess.GetAllgen_certificatesubjects"));
            }	
        }

        async Task<IList<gen_certificatesubjectsEntity>> Igen_certificatesubjectsDataAccessObjects.GAPgListViewExt(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_certificatesubjects_GAPgListView_Ext";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_certificatesubjects.SortExpression);
                    AddPageSizeParameter(cmd, gen_certificatesubjects.PageSize);
                    AddCurrentPageParameter(cmd, gen_certificatesubjects.CurrentPage);
                    FillSequrityParameters(gen_certificatesubjects.BaseSecurityParam, cmd, Database);

                    FillParameters(gen_certificatesubjects, cmd, Database);

                    if (!string.IsNullOrEmpty(gen_certificatesubjects.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_certificatesubjects.strCommonSerachParam + "%");

                    IList<gen_certificatesubjectsEntity> itemList = new List<gen_certificatesubjectsEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_certificatesubjectsEntity(reader, -99));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_certificatesubjects.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_certificatesubjectsDataAccess.GAPgListViewgen_certificatesubjects"));
            }
        }



        async Task<IList<gen_certificatesubjectsEntity>> Igen_certificatesubjectsDataAccessObjects.GetMajorSubjectByCertificateIdForDropdown(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_gen_certificatesubjects_GAPg";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_certificatesubjects.SortExpression);
                    AddPageSizeParameter(cmd, gen_certificatesubjects.PageSize);
                    AddCurrentPageParameter(cmd, gen_certificatesubjects.CurrentPage);

                    FillParameters(gen_certificatesubjects, cmd, Database);

                    if (!string.IsNullOrEmpty(gen_certificatesubjects.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_certificatesubjects.strCommonSerachParam + "%");

                    IList<gen_certificatesubjectsEntity> itemList = new List<gen_certificatesubjectsEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_certificatesubjectsEntity(reader));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_certificatesubjects.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_certificatesubjectsDataAccess.GetAllByPagesgen_certificatesubjects"));
            }
        }

    }
}