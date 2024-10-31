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
	
	internal sealed partial class tran_volunteermedclearanceDataAccessObjects : BaseDataAccess, Itran_volunteermedclearanceDataAccessObjects
	{
        
        public async Task<long> AddVolunteerMedicalClearance(Database db,
        DbTransaction transaction, tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_volunteermedclearance_Ins";

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                FillParameters(tran_volunteermedclearance, cmd, db);
                FillSequrityParameters(tran_volunteermedclearance.BaseSecurityParam, cmd, db);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_volunteermedclearanceDataAccess.AddVolunteerMedicalClearance"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        public async Task<List<tran_volunteermedclearanceEntity>> GetAllByBasicInfoRegistrationID(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "tran_volunteermedclearance_GA";
                List<tran_volunteermedclearanceEntity> itemList = new List<tran_volunteermedclearanceEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, tran_volunteermedclearance.SortExpression);
                    FillSequrityParameters(tran_volunteermedclearance.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_volunteermedclearance, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_volunteermedclearanceEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_volunteermedclearanceDataAccess.GetAlltran_volunteermedclearance"));
            }
        }

    }
}