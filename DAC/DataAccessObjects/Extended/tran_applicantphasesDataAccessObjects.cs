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
	
	internal sealed partial class tran_applicantphasesDataAccessObjects 
	{
        async Task<long> Itran_applicantphasesDataAccessObjects.AddExt(tran_applicantphasesEntity tran_applicantphasesdata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_applicantphases_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_applicantphasesdata, cmd,Database);
                FillSequrityParameters(tran_applicantphasesdata.BaseSecurityParam, cmd, Database);
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
        
        async Task<IList<tran_applicantphasesEntity>> Itran_applicantphasesDataAccessObjects.GetAllExt(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_applicantphases_GA_Ext";
                IList<tran_applicantphasesEntity> itemList = new List<tran_applicantphasesEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_applicantphases.SortExpression);
                    FillSequrityParameters(tran_applicantphases.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_applicantphases, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_applicantphasesEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantphasesDataAccess.GetAlltran_applicantphases"));
            }	
        }

        public async Task<long> AddApplicationPhase(Database db,
        DbTransaction transaction, tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "KAF_tran_applicantphases_Ins_EXT";

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                FillParameters(tran_applicantphases, cmd, db);
                FillSequrityParameters(tran_applicantphases.BaseSecurityParam, cmd, db);
                AddOutputParameter(cmd);

                IAsyncResult result = db.BeginExecuteNonQuery(cmd, transaction, null, null);
                while (!result.IsCompleted)
                {
                }
                returnCode = db.EndExecuteNonQuery(result);
                returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                if (returnCode < 0)
                {
                    throw new ArgumentException("Error in transaction.");
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        public async Task<tran_applicantphasesEntity> GetSinglebyBasicInfoIDRegistrationID(Database db,
        DbTransaction transaction, tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_tran_applicantphases_GS_By_BasicRegID";
                using (DbCommand cmd = db.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(tran_applicantphases.BaseSecurityParam, cmd, db);
                    FillParameters(tran_applicantphases, cmd, db);

                    IList<tran_applicantphasesEntity> itemList = new List<tran_applicantphasesEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_applicantphasesEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantphasesDataAccess.GetSingletran_applicantphases"));
            }
        }

        public async Task<tran_applicantphasesEntity> GetSingle2ndLastPhasebyBasicInfoIDRegistrationID(Database db,
        DbTransaction transaction, tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_TranApplicant2ndLastPhases_GS_By_BasicRegID";
                using (DbCommand cmd = db.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(tran_applicantphases.BaseSecurityParam, cmd, db);
                    FillParameters(tran_applicantphases, cmd, db);

                    IList<tran_applicantphasesEntity> itemList = new List<tran_applicantphasesEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_applicantphasesEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantphasesDataAccess.GetSingletran_applicantphases"));
            }
        }

        public async Task<long> UpdateApplicantPhase(Database db,
        DbTransaction transaction, tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_applicantphases_Upd";

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                FillParameters(tran_applicantphases, cmd, db);
                FillSequrityParameters(tran_applicantphases.BaseSecurityParam, cmd, db);
                AddOutputParameter(cmd);
                try
                {
                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Itran_applicantphasesDataAccess.Updatetran_applicantphases"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }


    }
}