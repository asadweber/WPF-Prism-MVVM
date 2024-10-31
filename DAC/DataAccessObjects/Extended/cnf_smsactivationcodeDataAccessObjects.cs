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
using System.Linq;
using Microsoft.IdentityModel.Tokens;

namespace DAC.Core.DataAccessObjects.General
{
	/// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>
	
	internal sealed partial class cnf_smsactivationcodeDataAccessObjects 
	{
        async Task<long> Icnf_smsactivationcodeDataAccessObjects.AddExt(cnf_smsactivationcodeEntity cnf_smsactivationcodedata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "cnf_smsactivationcode_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(cnf_smsactivationcodedata, cmd,Database);
                FillSequrityParameters(cnf_smsactivationcodedata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<cnf_smsactivationcodeEntity>> Icnf_smsactivationcodeDataAccessObjects.GetAllExt(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_smsactivationcode_GA_Ext";
                IList<cnf_smsactivationcodeEntity> itemList = new List<cnf_smsactivationcodeEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, cnf_smsactivationcode.SortExpression);
                    FillSequrityParameters(cnf_smsactivationcode.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_smsactivationcode, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_smsactivationcodeEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_smsactivationcodeDataAccess.GetAllcnf_smsactivationcode"));
            }	
        }


        public async Task<long> AddSMSActivationCode(Database db,
       DbTransaction transaction, cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "cnf_smsactivationcode_Ins";

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                FillParameters(cnf_smsactivationcode, cmd, db);
                FillSequrityParameters(cnf_smsactivationcode.BaseSecurityParam, cmd, db);
                AddOutputParameter(cmd);
                try
                {
                    IAsyncResult result = db.BeginExecuteNonQuery(cmd,transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = db.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Icnf_smsactivationcodeDataAccess.AddSMSActivationCode"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }


        async Task<cnf_smsactivationcodeEntity> Icnf_smsactivationcodeDataAccessObjects.CheckActivation(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_cnf_smsactivationcode_BY_CivilID";
                IList<cnf_smsactivationcodeEntity> itemList = new List<cnf_smsactivationcodeEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    Database.AddInParameter(cmd, "@CivilId", DbType.String, cnf_smsactivationcode.UserName);

                    


					IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_smsactivationcodeEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();

                    if(itemList.Count>0)
                    {
                        return itemList.FirstOrDefault();
                    }else
                    { return null; }
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_smsactivationcodeDataAccess.GetAllcnf_smsactivationcode"));
            }
        }

    }
}