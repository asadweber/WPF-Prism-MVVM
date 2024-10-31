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
	
	internal sealed partial class cnf_fileconfignameDataAccessObjects : BaseDataAccess, Icnf_fileconfignameDataAccessObjects
	{
        async Task<IList<cnf_fileconfignameEntity>> Icnf_fileconfignameDataAccessObjects.GetAllByBatchID(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_cnf_fileconfigname_GA_ByBatchID";
                IList<cnf_fileconfignameEntity> itemList = new List<cnf_fileconfignameEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, cnf_fileconfigname.SortExpression);
                    FillSequrityParameters(cnf_fileconfigname.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_fileconfigname, cmd, Database);

                    if (cnf_fileconfigname.batchid.HasValue)
                        Database.AddInParameter(cmd, "@BatchID", DbType.Int64, cnf_fileconfigname.batchid);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_fileconfignameEntity(reader, -99));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_fileconfignameDataAccess.GetAllByBatchID"));
            }
        }

    }
}