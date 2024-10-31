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
	
	internal sealed partial class tran_finalexamresultDataAccessObjects : BaseDataAccess, Itran_finalexamresultDataAccessObjects
	{

        public async Task<long> AddFinalExamResult(Database db,
        DbTransaction transaction, tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_finalexamresult_Ins";

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                FillParameters(tran_finalexamresult, cmd, db);
                FillSequrityParameters(tran_finalexamresult.BaseSecurityParam, cmd, db);
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
                    throw GetDataAccessException(ex, SourceOfException("tran_finalexamresultDataAccess.AddFinalExamResult"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        public async Task<tran_finalexamresultEntity> GetLatestFinalExamResult(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetLatestFinalExamResult_ByBasicInfoIDRegistrationID";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(tran_finalexamresult.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_finalexamresult, cmd, Database);

                    IList<tran_finalexamresultEntity> itemList = new List<tran_finalexamresultEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_finalexamresultEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_finalexamresultDataAccess.GetLatestFinalExamResult"));
            }
        }

    }
}