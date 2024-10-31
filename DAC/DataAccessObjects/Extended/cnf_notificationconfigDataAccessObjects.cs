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
using BDO.Core.DataAccessObjects.ExtendedEntities;

namespace DAC.Core.DataAccessObjects.General
{
	/// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>
	
	internal sealed partial class cnf_notificationconfigDataAccessObjects 
	{
        async Task<long> Icnf_notificationconfigDataAccessObjects.AddExt(cnf_notificationconfigEntity cnf_notificationconfigdata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "cnf_notificationconfig_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(cnf_notificationconfigdata, cmd,Database);
                FillSequrityParameters(cnf_notificationconfigdata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<cnf_notificationconfigEntity>> Icnf_notificationconfigDataAccessObjects.GetAllExt(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_notificationconfig_GA_Ext";
                IList<cnf_notificationconfigEntity> itemList = new List<cnf_notificationconfigEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, cnf_notificationconfig.SortExpression);
                    FillSequrityParameters(cnf_notificationconfig.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_notificationconfig, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_notificationconfigEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationconfigDataAccess.GetAllcnf_notificationconfig"));
            }	
        }

        async Task<IList<cnf_notificationconfigEntity>> Icnf_notificationconfigDataAccessObjects.GAPgListViewExt(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "cnf_notificationconfig_GAPgListView_Ext";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_notificationconfig.SortExpression);
                    AddPageSizeParameter(cmd, cnf_notificationconfig.PageSize);
                    AddCurrentPageParameter(cmd, cnf_notificationconfig.CurrentPage);
                    FillSequrityParameters(cnf_notificationconfig.BaseSecurityParam, cmd, Database);

                    FillParameters(cnf_notificationconfig, cmd, Database);

                    if (!string.IsNullOrEmpty(cnf_notificationconfig.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + cnf_notificationconfig.strCommonSerachParam + "%");

                    IList<cnf_notificationconfigEntity> itemList = new List<cnf_notificationconfigEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_notificationconfigEntity(reader, -99));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        cnf_notificationconfig.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationconfigDataAccess.GAPgListViewExtcnf_notificationconfig"));
            }
        }

        async Task<IList<gen_dropdownEntity>> Icnf_notificationconfigDataAccessObjects.GetDataForDropDownExt(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "cnf_notificationconfig_GAPgDropDown_Ext";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_notificationconfig.SortExpression);
                    AddPageSizeParameter(cmd, cnf_notificationconfig.PageSize);
                    AddCurrentPageParameter(cmd, cnf_notificationconfig.CurrentPage);
                    FillSequrityParameters(cnf_notificationconfig.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_notificationconfig, cmd, Database);
                    if (!string.IsNullOrEmpty(cnf_notificationconfig.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + cnf_notificationconfig.strCommonSerachParam + " % ");
                    IList<gen_dropdownEntity> itemList = new List<gen_dropdownEntity>();
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {

                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_dropdownEntity(reader));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        cnf_notificationconfig.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationconfigDataAccess.GetDataForDropDownExt"));
            }
        }

    }
}