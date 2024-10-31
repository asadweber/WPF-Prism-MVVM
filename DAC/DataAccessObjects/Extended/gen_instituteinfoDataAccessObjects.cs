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
	
	internal sealed partial class gen_instituteinfoDataAccessObjects 
	{
        async Task<long> Igen_instituteinfoDataAccessObjects.AddExt(gen_instituteinfoEntity gen_instituteinfodata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_instituteinfo_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_instituteinfodata, cmd,Database);
                FillSequrityParameters(gen_instituteinfodata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<gen_instituteinfoEntity>> Igen_instituteinfoDataAccessObjects.GetAllExt(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_instituteinfo_GA_Ext";
                IList<gen_instituteinfoEntity> itemList = new List<gen_instituteinfoEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_instituteinfo.SortExpression);
                    FillSequrityParameters(gen_instituteinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_instituteinfo, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_instituteinfoEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_instituteinfoDataAccess.GetAllgen_instituteinfo"));
            }	
        }

        async Task<IList<gen_instituteinfoEntity>> Igen_instituteinfoDataAccessObjects.GetInstituteInfoDataForDropDown(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_gen_instituteinfo_GAPgDropDown";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_instituteinfo.SortExpression);
                    AddPageSizeParameter(cmd, gen_instituteinfo.PageSize);
                    AddCurrentPageParameter(cmd, gen_instituteinfo.CurrentPage);
                    FillSequrityParameters(gen_instituteinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_instituteinfo, cmd, Database);
                    if (!string.IsNullOrEmpty(gen_instituteinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_instituteinfo.strCommonSerachParam + "%");
                    IList<gen_instituteinfoEntity> itemList = new List<gen_instituteinfoEntity>();
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {

                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_instituteinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_instituteinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_instituteinfoDataAccess.GetDataForDropDown"));
            }
        }

        async Task<IList<gen_instituteinfoEntity>> Igen_instituteinfoDataAccessObjects.GAPgListViewExt(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_instituteinfo_GAPgListView_Ext";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_instituteinfo.SortExpression);
                    AddPageSizeParameter(cmd, gen_instituteinfo.PageSize);
                    AddCurrentPageParameter(cmd, gen_instituteinfo.CurrentPage);
                    FillSequrityParameters(gen_instituteinfo.BaseSecurityParam, cmd, Database);

                    FillParameters(gen_instituteinfo, cmd, Database);

                    if (!string.IsNullOrEmpty(gen_instituteinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_instituteinfo.strCommonSerachParam + "%");

                    IList<gen_instituteinfoEntity> itemList = new List<gen_instituteinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_instituteinfoEntity(reader, -99));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_instituteinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_instituteinfoDataAccess.GAPgListViewExtgen_instituteinfo"));
            }
        }

    }
}