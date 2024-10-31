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
	
	internal sealed partial class tran_medexamnotificationDataAccessObjects : BaseDataAccess, Itran_medexamnotificationDataAccessObjects
	{
        public async Task<IList<tran_medexamnotificationEntity>> GetAllByBasicId_RegistrationId(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "KAF_MedExamNotification_GA_ByBasicInfoRegistrationID";
                IList<tran_medexamnotificationEntity> itemList = new List<tran_medexamnotificationEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_medexamnotification.SortExpression);
                    FillSequrityParameters(tran_medexamnotification.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_medexamnotification, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_medexamnotificationEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_medexamnotificationDataAccess.GetAllByBasicId_RegistrationId"));
            }	
        }
            
	}
}