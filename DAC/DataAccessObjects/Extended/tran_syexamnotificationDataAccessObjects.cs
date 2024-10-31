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
	
	internal sealed partial class tran_syexamnotificationDataAccessObjects : BaseDataAccess, Itran_syexamnotificationDataAccessObjects
	{
        public async Task<IList<tran_syexamnotificationEntity>> GetAllByBasicId_RegistrationId(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "KAF_SyExamNotification_GA_ByBasicInfoRegistrationID";
                IList<tran_syexamnotificationEntity> itemList = new List<tran_syexamnotificationEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_syexamnotification.SortExpression);
                    FillSequrityParameters(tran_syexamnotification.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_syexamnotification, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_syexamnotificationEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_syexamnotificationDataAccess.GetAllByBasicId_RegistrationId"));
            }	
        }
		
	}
}