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
	
	internal sealed partial class tran_syexamresultDataAccessObjects : BaseDataAccess, Itran_syexamresultDataAccessObjects
	{

        public async Task<long> AddSyExamResult(Database db, DbTransaction transaction, tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_syexamresult_Ins";

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                FillParameters(tran_syexamresult, cmd, db);
                FillSequrityParameters(tran_syexamresult.BaseSecurityParam, cmd, db);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_syexamresultDataAccess.Addtran_syexamresult"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        public async Task<tran_syexamresultEntity> GetLatestSyExamResult(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetLatestSyExamResult_ByBasicInfoIDRegistrationID";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(tran_syexamresult.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_syexamresult, cmd, Database);

                    IList<tran_syexamresultEntity> itemList = new List<tran_syexamresultEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_syexamresultEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_syexamresultDataAccess.GetLatestSyExamResult"));
            }
        }

    }
}