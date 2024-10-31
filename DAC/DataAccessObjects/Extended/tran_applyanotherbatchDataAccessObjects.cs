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
	
	internal sealed partial class tran_applyanotherbatchDataAccessObjects : BaseDataAccess, Itran_applyanotherbatchDataAccessObjects
	{
		
        public async Task<long> AddApplyAnotherBatch(Database db,
        DbTransaction transaction, tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_applyanotherbatch_Ins";
			
			using (DbCommand cmd =  db.GetStoredProcCommand(SP))
            {
                FillParameters(tran_applyanotherbatch, cmd, db);
                FillSequrityParameters(tran_applyanotherbatch.BaseSecurityParam, cmd, db);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_applyanotherbatchDataAccess.AddApplyAnotherBatch"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        public async Task<IList<tran_applyanotherbatchEntity>> GetAllByBasicInfoID(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetAllApplyAnotherBatch_ByBasicInfoID";
                IList<tran_applyanotherbatchEntity> itemList = new List<tran_applyanotherbatchEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddSortExpressionParameter(cmd, tran_applyanotherbatch.SortExpression);
                    FillSequrityParameters(tran_applyanotherbatch.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_applyanotherbatch, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_applyanotherbatchEntity(reader, -99));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_applyanotherbatchDataAccess.GetAlltran_applyanotherbatch"));
            }
        }

    }
}