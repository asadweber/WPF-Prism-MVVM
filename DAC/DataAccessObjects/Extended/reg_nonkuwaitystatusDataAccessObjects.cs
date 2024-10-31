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
	
	internal sealed partial class reg_nonkuwaitystatusDataAccessObjects 
	{

        public async Task<IList<reg_nonkuwaitystatusEntity>> GetAll(Database db,
       DbTransaction transaction, reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "reg_nonkuwaitystatus_GA";
                IList<reg_nonkuwaitystatusEntity> itemList = new List<reg_nonkuwaitystatusEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, reg_nonkuwaitystatus.SortExpression);
                    FillSequrityParameters(reg_nonkuwaitystatus.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_nonkuwaitystatus, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_nonkuwaitystatusEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_nonkuwaitystatusDataAccess.GetAllreg_nonkuwaitystatus"));
            }
        }
        async Task<long> Ireg_nonkuwaitystatusDataAccessObjects.AddExt(reg_nonkuwaitystatusEntity reg_nonkuwaitystatusdata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_nonkuwaitystatus_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_nonkuwaitystatusdata, cmd,Database);
                FillSequrityParameters(reg_nonkuwaitystatusdata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<reg_nonkuwaitystatusEntity>> Ireg_nonkuwaitystatusDataAccessObjects.GetAllExt(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_nonkuwaitystatus_GA_Ext";
                IList<reg_nonkuwaitystatusEntity> itemList = new List<reg_nonkuwaitystatusEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, reg_nonkuwaitystatus.SortExpression);
                    FillSequrityParameters(reg_nonkuwaitystatus.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_nonkuwaitystatus, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_nonkuwaitystatusEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_nonkuwaitystatusDataAccess.GetAllreg_nonkuwaitystatus"));
            }	
        }
        
	}
}