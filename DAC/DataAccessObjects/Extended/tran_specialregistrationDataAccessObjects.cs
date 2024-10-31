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
	
	internal sealed partial class tran_specialregistrationDataAccessObjects 
	{
        async Task<long> Itran_specialregistrationDataAccessObjects.AddExt(tran_specialregistrationEntity tran_specialregistrationdata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_specialregistration_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_specialregistrationdata, cmd,Database);
                FillSequrityParameters(tran_specialregistrationdata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<tran_specialregistrationEntity>> Itran_specialregistrationDataAccessObjects.GetAllExt(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_specialregistration_GA_Ext";
                IList<tran_specialregistrationEntity> itemList = new List<tran_specialregistrationEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_specialregistration.SortExpression);
                    FillSequrityParameters(tran_specialregistration.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_specialregistration, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_specialregistrationEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_specialregistrationDataAccess.GetAlltran_specialregistration"));
            }	
        }

        public async Task<tran_specialregistrationEntity> GetSingleSpecialRegistrationInfo(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "tran_specialregistration_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(tran_specialregistration.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_specialregistration, cmd, Database);

                    IList<tran_specialregistrationEntity> itemList = new List<tran_specialregistrationEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_specialregistrationEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_specialregistrationDataAccess.GetSingleSpecialRegistrationInfo"));
            }
        }

        public async Task<tran_specialregistrationEntity> GetSingleSpecialRegistration(Database db,
        DbTransaction transaction, tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "tran_specialregistration_GS";
                using (DbCommand cmd = db.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(tran_specialregistration.BaseSecurityParam, cmd, db);
                    FillParameters(tran_specialregistration, cmd, db);

                    IList<tran_specialregistrationEntity> itemList = new List<tran_specialregistrationEntity>();

                    IAsyncResult result = db.BeginExecuteReader(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = db.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_specialregistrationEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_specialregistrationDataAccess.GetSingleSpecialRegistration"));
            }
        }

        public async Task<long> UpdateSpecialRegistration(Database db,
        DbTransaction transaction, tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_specialregistration_Upd";

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                FillParameters(tran_specialregistration, cmd, db);
                FillSequrityParameters(tran_specialregistration.BaseSecurityParam, cmd, db);
                AddOutputParameter(cmd);
                try
                {
                    IAsyncResult result = db.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = db.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Itran_specialregistrationDataAccess.UpdateSpecialRegistration"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

    }
}