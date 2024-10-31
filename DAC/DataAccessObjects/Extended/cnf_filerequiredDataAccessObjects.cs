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
using BDO.Core.Base;



namespace DAC.Core.DataAccessObjects.General
{
	/// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>
	
	internal sealed partial class cnf_filerequiredDataAccessObjects 
	{
        async Task<long> Icnf_filerequiredDataAccessObjects.AddExt(cnf_filerequiredEntity cnf_filerequireddata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "cnf_filerequired_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(cnf_filerequireddata, cmd,Database);
                FillSequrityParameters(cnf_filerequireddata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<cnf_filerequiredEntity>> Icnf_filerequiredDataAccessObjects.GetAllExt(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_filerequired_GA_Ext";
                IList<cnf_filerequiredEntity> itemList = new List<cnf_filerequiredEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, cnf_filerequired.SortExpression);
                    FillSequrityParameters(cnf_filerequired.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_filerequired, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_filerequiredEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_filerequiredDataAccess.GetAllcnf_filerequired"));
            }	
        }

        async Task<IList<cnf_filerequiredEntity>> Icnf_filerequiredDataAccessObjects.GAPgListViewExt(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "cnf_filerequired_GAPgListView_Ext";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_filerequired.SortExpression);
                    AddPageSizeParameter(cmd, cnf_filerequired.PageSize);
                    AddCurrentPageParameter(cmd, cnf_filerequired.CurrentPage);
                    FillSequrityParameters(cnf_filerequired.BaseSecurityParam, cmd, Database);

                    FillParameters(cnf_filerequired, cmd, Database);

                    if (!string.IsNullOrEmpty(cnf_filerequired.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + cnf_filerequired.strCommonSerachParam + "%");

                    IList<cnf_filerequiredEntity> itemList = new List<cnf_filerequiredEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_filerequiredEntity(reader, -99));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        cnf_filerequired.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_filerequiredDataAccess.GAPgListViewExtcnf_filerequired"));
            }
        }

        public async Task<List<cnf_filerequiredEntity>> GetAllRequiredFile(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "cnf_filerequired_GA";
                List<cnf_filerequiredEntity> itemList = new List<cnf_filerequiredEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, cnf_filerequired.SortExpression);
                    FillSequrityParameters(cnf_filerequired.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_filerequired, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new CnfFileRequiredBatchwiseListLoadFromReader(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_filerequiredDataAccess.GetAllcnf_filerequired"));
            }
        }

    }
}