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
	internal sealed partial class tran_volunteerunitclearanceDataAccessObjects : BaseDataAccess, Itran_volunteerunitclearanceDataAccessObjects
	{

        public async Task<long> AddVolunteerUnitClearance(Database db,
        DbTransaction transaction, tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_volunteerunitclearance_Ins";

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                FillParameters(tran_volunteerunitclearance, cmd, db);
                FillSequrityParameters(tran_volunteerunitclearance.BaseSecurityParam, cmd, db);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_volunteerunitclearanceDataAccess.AddVolunteerUnitClearance"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        public async Task<List<tran_volunteerunitclearanceEntity>> GetAllByBasicInfoRegistrationID(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "tran_volunteerunitclearance_GA";
                List<tran_volunteerunitclearanceEntity> itemList = new List<tran_volunteerunitclearanceEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, tran_volunteerunitclearance.SortExpression);
                    FillSequrityParameters(tran_volunteerunitclearance.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_volunteerunitclearance, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_volunteerunitclearanceEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_volunteerunitclearanceDataAccess.GetAlltran_volunteerunitclearance"));
            }
        }

    }
}