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
	
	internal sealed partial class cnf_notificationtempletDataAccessObjects 
	{
        async Task<long> Icnf_notificationtempletDataAccessObjects.AddExt(cnf_notificationtempletEntity cnf_notificationtempletdata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "cnf_notificationtemplet_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(cnf_notificationtempletdata, cmd,Database);
                FillSequrityParameters(cnf_notificationtempletdata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<cnf_notificationtempletEntity>> Icnf_notificationtempletDataAccessObjects.GetAllExt(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_notificationtemplet_GA_Ext";
                IList<cnf_notificationtempletEntity> itemList = new List<cnf_notificationtempletEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, cnf_notificationtemplet.SortExpression);
                    FillSequrityParameters(cnf_notificationtemplet.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_notificationtemplet, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_notificationtempletEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationtempletDataAccess.GetAllcnf_notificationtemplet"));
            }	
        }

        async Task<IList<cnf_notificationtempletEntity>> Icnf_notificationtempletDataAccessObjects.GetNotificationTemplateWithMsgDropDown(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetNotificationTempletWithMsg_GAPgDropDown";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_notificationtemplet.SortExpression);
                    AddPageSizeParameter(cmd, cnf_notificationtemplet.PageSize);
                    AddCurrentPageParameter(cmd, cnf_notificationtemplet.CurrentPage);
                    FillSequrityParameters(cnf_notificationtemplet.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_notificationtemplet, cmd, Database);
                    if (!string.IsNullOrEmpty(cnf_notificationtemplet.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + cnf_notificationtemplet.strCommonSerachParam + " % ");
                    IList<cnf_notificationtempletEntity> itemList = new List<cnf_notificationtempletEntity>();
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {

                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_notificationtempletEntity(reader, -99));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        cnf_notificationtemplet.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_notificationtempletDataAccess.GetDataForDropDown"));
            }
        }

    }
}