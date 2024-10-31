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

    internal sealed partial class tran_volunteersyclearanceDataAccessObjects : BaseDataAccess, Itran_volunteersyclearanceDataAccessObjects
    {

        public async Task<long> AddVolunteerSyClearanceResult(Database db,
        DbTransaction transaction, tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_volunteersyclearance_Ins";

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                FillParameters(tran_volunteersyclearance, cmd, db);
                FillSequrityParameters(tran_volunteersyclearance.BaseSecurityParam, cmd, db);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_volunteersyclearanceDataAccess.AddVolunteerSyClearanceResult"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        public async Task<List<tran_volunteersyclearanceEntity>> GetAllByBasicInfoRegistrationID(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "tran_volunteersyclearance_GA";
                List<tran_volunteersyclearanceEntity> itemList = new List<tran_volunteersyclearanceEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, tran_volunteersyclearance.SortExpression);
                    FillSequrityParameters(tran_volunteersyclearance.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_volunteersyclearance, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd , null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_volunteersyclearanceEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_volunteersyclearanceDataAccess.GetAllByBasicInfoRegistrationID"));
            }
        }

    }
}