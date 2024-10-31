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
	
	internal sealed partial class cnf_notificationconfigdetlDataAccessObjects 
	{
        async Task<long> Icnf_notificationconfigdetlDataAccessObjects.AddExt(cnf_notificationconfigdetlEntity cnf_notificationconfigdetldata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "cnf_notificationconfigdetl_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(cnf_notificationconfigdetldata, cmd,Database);
                FillSequrityParameters(cnf_notificationconfigdetldata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<cnf_notificationconfigdetlEntity>> Icnf_notificationconfigdetlDataAccessObjects.GetAllExt(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_notificationconfigdetl_GA_Ext";
                IList<cnf_notificationconfigdetlEntity> itemList = new List<cnf_notificationconfigdetlEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, cnf_notificationconfigdetl.SortExpression);
                    FillSequrityParameters(cnf_notificationconfigdetl.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_notificationconfigdetl, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_notificationconfigdetlEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationconfigdetlDataAccess.GetAllcnf_notificationconfigdetl"));
            }	
        }

        async Task<IList<cnf_notificationconfigdetlEntity>> Icnf_notificationconfigdetlDataAccessObjects.GAPgListViewExt(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "cnf_notificationconfigdetl_GAPgListView_Ext";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_notificationconfigdetl.SortExpression);
                    AddPageSizeParameter(cmd, cnf_notificationconfigdetl.PageSize);
                    AddCurrentPageParameter(cmd, cnf_notificationconfigdetl.CurrentPage);
                    FillSequrityParameters(cnf_notificationconfigdetl.BaseSecurityParam, cmd, Database);

                    FillParameters(cnf_notificationconfigdetl, cmd, Database);

                    if (!string.IsNullOrEmpty(cnf_notificationconfigdetl.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + cnf_notificationconfigdetl.strCommonSerachParam + "%");

                    IList<cnf_notificationconfigdetlEntity> itemList = new List<cnf_notificationconfigdetlEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_notificationconfigdetlEntity(reader, -99));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        cnf_notificationconfigdetl.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationconfigdetlDataAccess.GAPgListViewExtcnf_notificationconfigdetl"));
            }
        }

        async Task<cnf_notificationconfigdetlEntity> Icnf_notificationconfigdetlDataAccessObjects.GetSingleExt(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "cnf_notificationconfigdetl_GS_Ext";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(cnf_notificationconfigdetl.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_notificationconfigdetl, cmd, Database);

                    IList<cnf_notificationconfigdetlEntity> itemList = new List<cnf_notificationconfigdetlEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_notificationconfigdetlEntity(reader, "ext"));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();

                    if (itemList != null && itemList.Count > 0)
                        return itemList[0];
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationconfigdetlDataAccess.GetSingleExtcnf_notificationconfigdetl"));
            }
        }

    }
}