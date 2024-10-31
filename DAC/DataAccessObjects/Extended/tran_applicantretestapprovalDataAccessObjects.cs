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
	
	internal sealed partial class tran_applicantretestapprovalDataAccessObjects : BaseDataAccess, Itran_applicantretestapprovalDataAccessObjects
	{
        public async Task<long> AddReTestApproval(Database db, DbTransaction transaction, tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_applicantretestapproval_Ins";

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                FillParameters(tran_applicantretestapproval, cmd, db);
                FillSequrityParameters(tran_applicantretestapproval.BaseSecurityParam, cmd, db);
                AddOutputParameter(cmd);
                try
                {
                    IAsyncResult result = db.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Itran_applicantretestapprovalDataAccess.Addtran_applicantretestapproval"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

	}
}