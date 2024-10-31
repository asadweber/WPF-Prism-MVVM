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
using System.Linq;

namespace DAC.Core.DataAccessObjects.General
{
	/// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>
	
	internal sealed partial class reg_relativesworkinginmodDataAccessObjects 
	{
        async Task<long> Ireg_relativesworkinginmodDataAccessObjects.AddExt(reg_relativesworkinginmodEntity reg_relativesworkinginmoddata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_relativesworkinginmod_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_relativesworkinginmoddata, cmd,Database);
                FillSequrityParameters(reg_relativesworkinginmoddata.BaseSecurityParam, cmd, Database);
				AddOutputParameter(cmd);
				try
                {
                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Itran_userpindataDataAccess.Addtran_userpindata"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
        
        async Task<IList<reg_relativesworkinginmodEntity>> Ireg_relativesworkinginmodDataAccessObjects.GetAllExt(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_relativesworkinginmod_GA_Ext";
                IList<reg_relativesworkinginmodEntity> itemList = new List<reg_relativesworkinginmodEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, reg_relativesworkinginmod.SortExpression);
                    FillSequrityParameters(reg_relativesworkinginmod.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_relativesworkinginmod, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_relativesworkinginmodEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_relativesworkinginmodDataAccess.GetAllreg_relativesworkinginmod"));
            }	
        }
       public async Task<reg_relativesworkinginmodEntity> GetAllByImergencyContactID(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_reg_relativesworkinginmod_ImergencyContactID";
                IList<reg_relativesworkinginmodEntity> itemList = new List<reg_relativesworkinginmodEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, reg_relativesworkinginmod.SortExpression);
                    FillSequrityParameters(reg_relativesworkinginmod.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_relativesworkinginmod, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_relativesworkinginmodEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    if (itemList != null && itemList.Count > 0)
                    {
                        return itemList.FirstOrDefault();
                    }
                    else
                    {
                        return new reg_relativesworkinginmodEntity();
                    }

                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_relativesworkinginmodDataAccess.GetAllreg_relativesworkinginmod"));
            }
        }


        public async Task<long> AddOrUpdateOrDelete(
          Database db,
          DbTransaction transaction,
          reg_relativesworkinginmodEntity reg_relativesworkinginmod,
          CancellationToken cancellationToken)
        {
            long returnCode = -99;

            string SPName = string.Empty;
            bool IsDelete=false;
            if(reg_relativesworkinginmod.CurrentState==BDO.Core.Base.BaseEntity.EntityState.Added)
            {
                SPName = "reg_relativesworkinginmod_Ins";
            }
            else if (reg_relativesworkinginmod.CurrentState == BDO.Core.Base.BaseEntity.EntityState.Changed)
            {
                SPName = "reg_relativesworkinginmod_Upd";
            }
            else if (reg_relativesworkinginmod.CurrentState == BDO.Core.Base.BaseEntity.EntityState.Deleted)
            {
                SPName = "reg_relativesworkinginmod_Del";
                IsDelete=true;
            }

            using (DbCommand cmd = Database.GetStoredProcCommand(SPName))
            {
                FillParameters(reg_relativesworkinginmod, cmd, db, IsDelete);
                FillSequrityParameters(reg_relativesworkinginmod.BaseSecurityParam, cmd, db);
                AddOutputParameter(cmd);
                IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                while (!result.IsCompleted)
                {
                }
                returnCode = Database.EndExecuteNonQuery(result);
                if (returnCode < 0)
                {
                    throw new ArgumentException("Error in transaction.");
                }
                cmd.Dispose();
            }

            return returnCode;
        }

    }
}