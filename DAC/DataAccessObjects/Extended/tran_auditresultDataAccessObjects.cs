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
using BDO.Core.DataAccessObjects.ExtendedEntities;

namespace DAC.Core.DataAccessObjects.General
{
	/// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>
	
	internal sealed partial class tran_auditresultDataAccessObjects : BaseDataAccess, Itran_auditresultDataAccessObjects
	{

        public async Task<long> AddAuditResult(Database db,
        DbTransaction transaction, tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_auditresult_Ins";

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                FillParameters(tran_auditresult, cmd, db);
                FillSequrityParameters(tran_auditresult.BaseSecurityParam, cmd, db);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_auditresultDataAccess.Addtran_auditresult"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        public async Task<tran_auditresultEntity> GetLatestAuditResult(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetLatestAuditResult_ByBasicInfoIDRegistrationID";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(tran_auditresult.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_auditresult, cmd, Database);

                    IList<tran_auditresultEntity> itemList = new List<tran_auditresultEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_auditresultEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_auditresultDataAccess.GetLatestAuditResult"));
            }
        }

    }
}