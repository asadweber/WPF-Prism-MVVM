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
	
	internal sealed partial class reg_punishmentDataAccessObjects : BaseDataAccess, Ireg_punishmentDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "reg_punishmentDataAccessObjects";
        
		public reg_punishmentDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(reg_punishmentEntity reg_punishment, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (reg_punishment.punishmentid.HasValue)
				Database.AddInParameter(cmd, "@PunishmentID", DbType.Int64, reg_punishment.punishmentid);
            if (forDelete) return;
			if (reg_punishment.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, reg_punishment.basicinfoid);
			if (!(string.IsNullOrEmpty(reg_punishment.punishmentreason)))
				Database.AddInParameter(cmd, "@PunishmentReason", DbType.String, reg_punishment.punishmentreason);
			if (!(string.IsNullOrEmpty(reg_punishment.punishmentdetails)))
				Database.AddInParameter(cmd, "@PunishmentDetails", DbType.String, reg_punishment.punishmentdetails);
			if ((reg_punishment.punishmentdate.HasValue))
				Database.AddInParameter(cmd, "@PunishmentDate", DbType.DateTime, reg_punishment.punishmentdate);
			if ((reg_punishment.punishmenttodate.HasValue))
				Database.AddInParameter(cmd, "@PunishmentToDate", DbType.DateTime, reg_punishment.punishmenttodate);
			if (!(string.IsNullOrEmpty(reg_punishment.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, reg_punishment.comment);
			if (!(string.IsNullOrEmpty(reg_punishment.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, reg_punishment.remarks);
			if (!(string.IsNullOrEmpty(reg_punishment.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, reg_punishment.updateinfo);
			if (reg_punishment.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, reg_punishment.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Ireg_punishmentDataAccessObjects.Add(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_punishment_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_punishment, cmd,Database);
                FillSequrityParameters(reg_punishment.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_punishmentDataAccess.Addreg_punishment"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Ireg_punishmentDataAccessObjects.Update(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "reg_punishment_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(reg_punishment, cmd,Database);
                FillSequrityParameters(reg_punishment.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_punishmentDataAccess.Updatereg_punishment"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Ireg_punishmentDataAccessObjects.Delete(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "reg_punishment_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(reg_punishment, cmd,Database, true);
                FillSequrityParameters(reg_punishment.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Ireg_punishmentDataAccess.Deletereg_punishment"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Ireg_punishmentDataAccessObjects.SaveList(IList<reg_punishmentEntity> listAdded, IList<reg_punishmentEntity> listUpdated, IList<reg_punishmentEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "reg_punishment_Ins";
            const string SPUpdate = "reg_punishment_Upd";
            const string SPDelete = "reg_punishment_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (reg_punishmentEntity reg_punishment in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_punishment, cmd, Database, true);
                            FillSequrityParameters(reg_punishment.BaseSecurityParam, cmd, Database);
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
                    }
                }
                if (listUpdated.Count > 0 )
                {
                    foreach (reg_punishmentEntity reg_punishment in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_punishment, cmd, Database);
                            FillSequrityParameters(reg_punishment.BaseSecurityParam, cmd, Database);
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
                    }
                }
                if (listAdded.Count > 0 )
                {
                    foreach (reg_punishmentEntity reg_punishment in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_punishment, cmd, Database);
                            FillSequrityParameters(reg_punishment.BaseSecurityParam, cmd, Database);
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
                    }
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_punishmentDataAccess.Save_reg_punishment"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        
        
       public async Task<long> SaveList(
       Database db , 
       DbTransaction transaction,
       IList<reg_punishmentEntity> listAdded, 
       IList<reg_punishmentEntity> listUpdated, 
       IList<reg_punishmentEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "reg_punishment_Ins";
            const string SPUpdate = "reg_punishment_Upd";
            const string SPDelete = "reg_punishment_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (reg_punishmentEntity reg_punishment in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_punishment, cmd, db, true);
                            FillSequrityParameters(reg_punishment.BaseSecurityParam, cmd, db);
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
                    }
                }
                if (listUpdated.Count > 0 )
                {
                    foreach (reg_punishmentEntity reg_punishment in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_punishment, cmd, db);
                            FillSequrityParameters(reg_punishment.BaseSecurityParam, cmd, db);
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
                    }
                }
                if (listAdded.Count > 0 )
                {
                    foreach (reg_punishmentEntity reg_punishment in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_punishment, cmd, db);
                            FillSequrityParameters(reg_punishment.BaseSecurityParam, cmd, db);
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
                    }
                }

              
            }
            catch (Exception ex)
            {
               
                throw GetDataAccessException(ex, SourceOfException("Ireg_punishmentDataAccess.Save_reg_punishment"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<reg_punishmentEntity>> Ireg_punishmentDataAccessObjects.GetAll(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_punishment_GA";
                IList<reg_punishmentEntity> itemList = new List<reg_punishmentEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, reg_punishment.SortExpression);
                    FillSequrityParameters(reg_punishment.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_punishment, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_punishmentEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_punishmentDataAccess.GetAllreg_punishment"));
            }	
        }
		
        async Task<IList<reg_punishmentEntity>> Ireg_punishmentDataAccessObjects.GetAllByPages(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "reg_punishment_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_punishment.SortExpression);
                    AddPageSizeParameter(cmd, reg_punishment.PageSize);
                    AddCurrentPageParameter(cmd, reg_punishment.CurrentPage);                    
                    FillSequrityParameters(reg_punishment.BaseSecurityParam, cmd, Database);
                    
					FillParameters(reg_punishment, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (reg_punishment.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+reg_punishment.strCommonSerachParam+"%");

                    IList<reg_punishmentEntity> itemList = new List<reg_punishmentEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_punishmentEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						reg_punishment.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_punishmentDataAccess.GetAllByPagesreg_punishment"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<reg_punishmentEntity> Ireg_punishmentDataAccessObjects.GetSingle(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_punishment_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(reg_punishment.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_punishment, cmd, Database);
                    
                    IList<reg_punishmentEntity> itemList = new List<reg_punishmentEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_punishmentEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    
                    if(itemList != null && itemList.Count > 0)
                        return itemList[0];
                    else
                        return null;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_punishmentDataAccess.GetSinglereg_punishment"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<reg_punishmentEntity>> Ireg_punishmentDataAccessObjects.GAPgListView(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "reg_punishment_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_punishment.SortExpression);
                    AddPageSizeParameter(cmd, reg_punishment.PageSize);
                    AddCurrentPageParameter(cmd, reg_punishment.CurrentPage);                    
                    FillSequrityParameters(reg_punishment.BaseSecurityParam, cmd, Database);
                    
					FillParameters(reg_punishment, cmd,Database);
                    
					if (!string.IsNullOrEmpty (reg_punishment.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+reg_punishment.strCommonSerachParam+"%");

                    IList<reg_punishmentEntity> itemList = new List<reg_punishmentEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_punishmentEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						reg_punishment.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_punishmentDataAccess.GAPgListViewreg_punishment"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}