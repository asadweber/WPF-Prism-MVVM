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

    internal sealed partial class tran_trainingjoinDataAccessObjects : BaseDataAccess, Itran_trainingjoinDataAccessObjects
    {
        public async Task<long> AddTrainingJoinInfo(Database db, DbTransaction transaction, tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_trgjoin_Ins_Ext";

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                FillParameters(tran_trainingjoin, cmd, db);
                FillSequrityParameters(tran_trainingjoin.BaseSecurityParam, cmd, db);
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
                    throw GetDataAccessException(ex, SourceOfException("tran_trainingjoinDataAccess.AddTrainingJoinInfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        public async Task<tran_trainingjoinEntity> GetSingleByBasicInfoIDRegistrationID(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_GetTrainingJoin_ByBasicInfoIDRegistrationID";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(tran_trainingjoin.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_trainingjoin, cmd, Database);

                    IList<tran_trainingjoinEntity> itemList = new List<tran_trainingjoinEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_trainingjoinEntity(reader, -99));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_trainingjoinDataAccess.GetSingleByBasicInfoIDRegistrationID"));
            }
        }

    }
}