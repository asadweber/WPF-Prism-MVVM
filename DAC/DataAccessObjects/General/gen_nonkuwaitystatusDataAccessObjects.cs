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
	
	internal sealed partial class gen_nonkuwaitystatusDataAccessObjects : BaseDataAccess, Igen_nonkuwaitystatusDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_nonkuwaitystatusDataAccessObjects";
        
		public gen_nonkuwaitystatusDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }

        #endregion

        public static void FillParameters(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, DbCommand cmd, Database Database, bool forDelete = false)
        {
            if (gen_nonkuwaitystatus.nonkuwaitystatusid.HasValue)
                Database.AddInParameter(cmd, "@NonKuwaityStatusID", DbType.Int64, gen_nonkuwaitystatus.nonkuwaitystatusid);
            if (forDelete) return;
            if (!(string.IsNullOrEmpty(gen_nonkuwaitystatus.nonkuwaitystatusname)))
                Database.AddInParameter(cmd, "@NonKuwaityStatusName", DbType.String, gen_nonkuwaitystatus.nonkuwaitystatusname);
            if (!(string.IsNullOrEmpty(gen_nonkuwaitystatus.comment)))
                Database.AddInParameter(cmd, "@Comment", DbType.String, gen_nonkuwaitystatus.comment);
            if (!(string.IsNullOrEmpty(gen_nonkuwaitystatus.remarks)))
                Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_nonkuwaitystatus.remarks);
            if (gen_nonkuwaitystatus.statusgroup.HasValue)
                Database.AddInParameter(cmd, "@StatusGroup", DbType.Int32, gen_nonkuwaitystatus.statusgroup);
            if (!(string.IsNullOrEmpty(gen_nonkuwaitystatus.updateinfo)))
                Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, gen_nonkuwaitystatus.updateinfo);
            if (gen_nonkuwaitystatus.tranformactionid.HasValue)
                Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, gen_nonkuwaitystatus.tranformactionid);
            if (gen_nonkuwaitystatus.oracleid.HasValue)
                Database.AddInParameter(cmd, "@OracleID", DbType.Int64, gen_nonkuwaitystatus.oracleid);

        }



        #region Add Operation

        async Task<long> Igen_nonkuwaitystatusDataAccessObjects.Add(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_nonkuwaitystatus_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_nonkuwaitystatus, cmd,Database);
                FillSequrityParameters(gen_nonkuwaitystatus.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_nonkuwaitystatusDataAccess.Addgen_nonkuwaitystatus"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_nonkuwaitystatusDataAccessObjects.Update(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_nonkuwaitystatus_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_nonkuwaitystatus, cmd,Database);
                FillSequrityParameters(gen_nonkuwaitystatus.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_nonkuwaitystatusDataAccess.Updategen_nonkuwaitystatus"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_nonkuwaitystatusDataAccessObjects.Delete(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_nonkuwaitystatus_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_nonkuwaitystatus, cmd,Database, true);
                FillSequrityParameters(gen_nonkuwaitystatus.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_nonkuwaitystatusDataAccess.Deletegen_nonkuwaitystatus"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_nonkuwaitystatusDataAccessObjects.SaveList(IList<gen_nonkuwaitystatusEntity> listAdded, IList<gen_nonkuwaitystatusEntity> listUpdated, IList<gen_nonkuwaitystatusEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_nonkuwaitystatus_Ins";
            const string SPUpdate = "gen_nonkuwaitystatus_Upd";
            const string SPDelete = "gen_nonkuwaitystatus_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_nonkuwaitystatusEntity gen_nonkuwaitystatus in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_nonkuwaitystatus, cmd, Database, true);
                            FillSequrityParameters(gen_nonkuwaitystatus.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_nonkuwaitystatusEntity gen_nonkuwaitystatus in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_nonkuwaitystatus, cmd, Database);
                            FillSequrityParameters(gen_nonkuwaitystatus.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_nonkuwaitystatusEntity gen_nonkuwaitystatus in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_nonkuwaitystatus, cmd, Database);
                            FillSequrityParameters(gen_nonkuwaitystatus.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_nonkuwaitystatusDataAccess.Save_gen_nonkuwaitystatus"));
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
       IList<gen_nonkuwaitystatusEntity> listAdded, 
       IList<gen_nonkuwaitystatusEntity> listUpdated, 
       IList<gen_nonkuwaitystatusEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_nonkuwaitystatus_Ins";
            const string SPUpdate = "gen_nonkuwaitystatus_Upd";
            const string SPDelete = "gen_nonkuwaitystatus_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_nonkuwaitystatusEntity gen_nonkuwaitystatus in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_nonkuwaitystatus, cmd, db, true);
                            FillSequrityParameters(gen_nonkuwaitystatus.BaseSecurityParam, cmd, db);
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
                    foreach (gen_nonkuwaitystatusEntity gen_nonkuwaitystatus in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_nonkuwaitystatus, cmd, db);
                            FillSequrityParameters(gen_nonkuwaitystatus.BaseSecurityParam, cmd, db);
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
                    foreach (gen_nonkuwaitystatusEntity gen_nonkuwaitystatus in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_nonkuwaitystatus, cmd, db);
                            FillSequrityParameters(gen_nonkuwaitystatus.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_nonkuwaitystatusDataAccess.Save_gen_nonkuwaitystatus"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_nonkuwaitystatusEntity>> Igen_nonkuwaitystatusDataAccessObjects.GetAll(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_nonkuwaitystatus_GA";
                IList<gen_nonkuwaitystatusEntity> itemList = new List<gen_nonkuwaitystatusEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_nonkuwaitystatus.SortExpression);
                    FillSequrityParameters(gen_nonkuwaitystatus.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_nonkuwaitystatus, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_nonkuwaitystatusEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_nonkuwaitystatusDataAccess.GetAllgen_nonkuwaitystatus"));
            }	
        }
		
        async Task<IList<gen_nonkuwaitystatusEntity>> Igen_nonkuwaitystatusDataAccessObjects.GetAllByPages(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_nonkuwaitystatus_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_nonkuwaitystatus.SortExpression);
                    AddPageSizeParameter(cmd, gen_nonkuwaitystatus.PageSize);
                    AddCurrentPageParameter(cmd, gen_nonkuwaitystatus.CurrentPage);                    
                    FillSequrityParameters(gen_nonkuwaitystatus.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_nonkuwaitystatus, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_nonkuwaitystatus.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_nonkuwaitystatus.strCommonSerachParam+"%");

                    IList<gen_nonkuwaitystatusEntity> itemList = new List<gen_nonkuwaitystatusEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_nonkuwaitystatusEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_nonkuwaitystatus.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_nonkuwaitystatusDataAccess.GetAllByPagesgen_nonkuwaitystatus"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Igen_nonkuwaitystatusDataAccessObjects.SaveMasterDetreg_nonkuwaitystatus(gen_nonkuwaitystatusEntity masterEntity, 
        IList<reg_nonkuwaitystatusEntity> listAdded, 
        IList<reg_nonkuwaitystatusEntity> listUpdated,
        IList<reg_nonkuwaitystatusEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_nonkuwaitystatus_Ins";
            const string MasterSPUpdate = "gen_nonkuwaitystatus_Upd";
            const string MasterSPDelete = "gen_nonkuwaitystatus_Del";
            
			
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
			
            if (masterEntity.CurrentState == BaseEntity.EntityState.Added)
                SP = MasterSPInsert;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                SP = MasterSPUpdate;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                 SP = MasterSPDelete;
            else
            {
                throw new Exception("Nothing to save.");
            }
            DateTime dt = DateTime.Now;
            
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Added || masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                    {
                        FillParameters(masterEntity, cmd, Database);
                    }
                    else
                    {
                        FillParameters(masterEntity, cmd, Database, true);
                    }
                    FillSequrityParameters(masterEntity.BaseSecurityParam, cmd, Database);                    
                    AddOutputParameter(cmd, Database);
					
					if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                    {
                        IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                        while (!result.IsCompleted)
                        {
                        }
                        returnCode = Database.EndExecuteNonQuery(result);
                                PrimaryKeyMaster = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                                masterEntity.RETURN_KEY = PrimaryKeyMaster;
                        
                    }
                    else
                    {
                        returnCode = 1;
                    }
				
                    if (returnCode>0)
                    {
                        if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                        {
                            foreach (var item in listAdded)
                            {
                                item.nonkuwaitystatusid=PrimaryKeyMaster;
                            }
                        }
                        reg_nonkuwaitystatusDataAccessObjects objreg_nonkuwaitystatus=new reg_nonkuwaitystatusDataAccessObjects(this.Context);
                        objreg_nonkuwaitystatus.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
                    }
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        cmd.Dispose();
                }
				transaction.Commit();                
			}
			catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Igen_nonkuwaitystatusDataAccess.SaveDsgen_nonkuwaitystatus"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
		}
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<gen_nonkuwaitystatusEntity> Igen_nonkuwaitystatusDataAccessObjects.GetSingle(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_nonkuwaitystatus_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_nonkuwaitystatus.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_nonkuwaitystatus, cmd, Database);
                    
                    IList<gen_nonkuwaitystatusEntity> itemList = new List<gen_nonkuwaitystatusEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_nonkuwaitystatusEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_nonkuwaitystatusDataAccess.GetSinglegen_nonkuwaitystatus"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_nonkuwaitystatusEntity>> Igen_nonkuwaitystatusDataAccessObjects.GAPgListView(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_nonkuwaitystatus_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_nonkuwaitystatus.SortExpression);
                    AddPageSizeParameter(cmd, gen_nonkuwaitystatus.PageSize);
                    AddCurrentPageParameter(cmd, gen_nonkuwaitystatus.CurrentPage);                    
                    FillSequrityParameters(gen_nonkuwaitystatus.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_nonkuwaitystatus, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_nonkuwaitystatus.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_nonkuwaitystatus.strCommonSerachParam+"%");

                    IList<gen_nonkuwaitystatusEntity> itemList = new List<gen_nonkuwaitystatusEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_nonkuwaitystatusEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_nonkuwaitystatus.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_nonkuwaitystatusDataAccess.GAPgListViewgen_nonkuwaitystatus"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_nonkuwaitystatusDataAccessObjects.GetDataForDropDown(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "gen_nonkuwaitystatus_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, gen_nonkuwaitystatus.SortExpression);
					AddPageSizeParameter(cmd, gen_nonkuwaitystatus.PageSize);
					AddCurrentPageParameter(cmd, gen_nonkuwaitystatus.CurrentPage);                    
					FillSequrityParameters(gen_nonkuwaitystatus.BaseSecurityParam, cmd, Database);
					FillParameters(gen_nonkuwaitystatus, cmd,Database);
					if (!string.IsNullOrEmpty(gen_nonkuwaitystatus.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + gen_nonkuwaitystatus.strCommonSerachParam + " % ");
					IList<gen_dropdownEntity> itemList = new List<gen_dropdownEntity>();
					IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
					while (!result.IsCompleted)
					{
						
					}
					using (IDataReader reader = Database.EndExecuteReader(result))
					{
						while (reader.Read())
						{
							itemList.Add(new gen_dropdownEntity(reader));
						}
						reader.Close();
					}
					if(itemList.Count>0)
					{
						itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_nonkuwaitystatus.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Igen_nonkuwaitystatusDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}