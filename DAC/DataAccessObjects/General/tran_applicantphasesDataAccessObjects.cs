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
	
	internal sealed partial class tran_applicantphasesDataAccessObjects : BaseDataAccess, Itran_applicantphasesDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_applicantphasesDataAccessObjects";
        
		public tran_applicantphasesDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }

        #endregion

        public static void FillParameters(tran_applicantphasesEntity tran_applicantphases, DbCommand cmd, Database Database, bool forDelete = false)
        {
            if (tran_applicantphases.applicantphaseid.HasValue)
                Database.AddInParameter(cmd, "@ApplicantPhaseID", DbType.Int64, tran_applicantphases.applicantphaseid);
            if (forDelete) return;
            if (tran_applicantphases.parentid.HasValue)
                Database.AddInParameter(cmd, "@ParentID", DbType.Int64, tran_applicantphases.parentid);
            if (tran_applicantphases.basicinfoid.HasValue)
                Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, tran_applicantphases.basicinfoid);
            if (tran_applicantphases.registrationid.HasValue)
                Database.AddInParameter(cmd, "@RegistrationID", DbType.Int64, tran_applicantphases.registrationid);
            if (tran_applicantphases.batchid.HasValue)
                Database.AddInParameter(cmd, "@BatchID", DbType.Int64, tran_applicantphases.batchid);
            if (tran_applicantphases.phaseid.HasValue)
                Database.AddInParameter(cmd, "@PhaseID", DbType.Int64, tran_applicantphases.phaseid);
            if (tran_applicantphases.statusid.HasValue)
                Database.AddInParameter(cmd, "@StatusID", DbType.Int64, tran_applicantphases.statusid);
            if ((tran_applicantphases.submitteddate.HasValue))
                Database.AddInParameter(cmd, "@SubmittedDate", DbType.DateTime, tran_applicantphases.submitteddate);

            Database.AddInParameter(cmd, "@SubmittedBy", DbType.Guid, tran_applicantphases.submittedby);
            if (!(string.IsNullOrEmpty(tran_applicantphases.remarks)))
                Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_applicantphases.remarks);
            if (!(string.IsNullOrEmpty(tran_applicantphases.updateinfo)))
                Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, tran_applicantphases.updateinfo);
            if (tran_applicantphases.tranformactionid.HasValue)
                Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, tran_applicantphases.tranformactionid);

        }




        #region Add Operation

        async Task<long> Itran_applicantphasesDataAccessObjects.Add(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_applicantphases_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_applicantphases, cmd,Database);
                FillSequrityParameters(tran_applicantphases.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_applicantphasesDataAccess.Addtran_applicantphases"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Itran_applicantphasesDataAccessObjects.Update(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "tran_applicantphases_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_applicantphases, cmd,Database);
                FillSequrityParameters(tran_applicantphases.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_applicantphasesDataAccess.Updatetran_applicantphases"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Itran_applicantphasesDataAccessObjects.Delete(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "tran_applicantphases_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_applicantphases, cmd,Database, true);
                FillSequrityParameters(tran_applicantphases.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Itran_applicantphasesDataAccess.Deletetran_applicantphases"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Itran_applicantphasesDataAccessObjects.SaveList(IList<tran_applicantphasesEntity> listAdded, IList<tran_applicantphasesEntity> listUpdated, IList<tran_applicantphasesEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_applicantphases_Ins";
            const string SPUpdate = "tran_applicantphases_Upd";
            const string SPDelete = "tran_applicantphases_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_applicantphasesEntity tran_applicantphases in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_applicantphases, cmd, Database, true);
                            FillSequrityParameters(tran_applicantphases.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_applicantphasesEntity tran_applicantphases in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_applicantphases, cmd, Database);
                            FillSequrityParameters(tran_applicantphases.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_applicantphasesEntity tran_applicantphases in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_applicantphases, cmd, Database);
                            FillSequrityParameters(tran_applicantphases.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantphasesDataAccess.Save_tran_applicantphases"));
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
       IList<tran_applicantphasesEntity> listAdded, 
       IList<tran_applicantphasesEntity> listUpdated, 
       IList<tran_applicantphasesEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "tran_applicantphases_Ins";
            const string SPUpdate = "tran_applicantphases_Upd";
            const string SPDelete = "tran_applicantphases_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_applicantphasesEntity tran_applicantphases in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_applicantphases, cmd, db, true);
                            FillSequrityParameters(tran_applicantphases.BaseSecurityParam, cmd, db);
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
                    foreach (tran_applicantphasesEntity tran_applicantphases in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_applicantphases, cmd, db);
                            FillSequrityParameters(tran_applicantphases.BaseSecurityParam, cmd, db);
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
                    foreach (tran_applicantphasesEntity tran_applicantphases in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_applicantphases, cmd, db);
                            FillSequrityParameters(tran_applicantphases.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantphasesDataAccess.Save_tran_applicantphases"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<tran_applicantphasesEntity>> Itran_applicantphasesDataAccessObjects.GetAll(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_applicantphases_GA";
                IList<tran_applicantphasesEntity> itemList = new List<tran_applicantphasesEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_applicantphases.SortExpression);
                    FillSequrityParameters(tran_applicantphases.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_applicantphases, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_applicantphasesEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantphasesDataAccess.GetAlltran_applicantphases"));
            }	
        }
		
        async Task<IList<tran_applicantphasesEntity>> Itran_applicantphasesDataAccessObjects.GetAllByPages(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_applicantphases_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_applicantphases.SortExpression);
                    AddPageSizeParameter(cmd, tran_applicantphases.PageSize);
                    AddCurrentPageParameter(cmd, tran_applicantphases.CurrentPage);                    
                    FillSequrityParameters(tran_applicantphases.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_applicantphases, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (tran_applicantphases.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_applicantphases.strCommonSerachParam+"%");

                    IList<tran_applicantphasesEntity> itemList = new List<tran_applicantphasesEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_applicantphasesEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_applicantphases.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantphasesDataAccess.GetAllByPagestran_applicantphases"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Itran_applicantphasesDataAccessObjects.SaveMasterDettran_notificationbatchdet(tran_applicantphasesEntity masterEntity, 
        IList<tran_notificationbatchdetEntity> listAdded, 
        IList<tran_notificationbatchdetEntity> listUpdated,
        IList<tran_notificationbatchdetEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "tran_applicantphases_Ins";
            const string MasterSPUpdate = "tran_applicantphases_Upd";
            const string MasterSPDelete = "tran_applicantphases_Del";
            
			
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
                                item.applicantphaseid=PrimaryKeyMaster;
                            }
                        }
                        tran_notificationbatchdetDataAccessObjects objtran_notificationbatchdet=new tran_notificationbatchdetDataAccessObjects(this.Context);
                        objtran_notificationbatchdet.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantphasesDataAccess.SaveDstran_applicantphases"));
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
        async Task<tran_applicantphasesEntity> Itran_applicantphasesDataAccessObjects.GetSingle(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_applicantphases_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_applicantphases.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_applicantphases, cmd, Database);
                    
                    IList<tran_applicantphasesEntity> itemList = new List<tran_applicantphasesEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_applicantphasesEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantphasesDataAccess.GetSingletran_applicantphases"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<tran_applicantphasesEntity>> Itran_applicantphasesDataAccessObjects.GAPgListView(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_applicantphases_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_applicantphases.SortExpression);
                    AddPageSizeParameter(cmd, tran_applicantphases.PageSize);
                    AddCurrentPageParameter(cmd, tran_applicantphases.CurrentPage);                    
                    FillSequrityParameters(tran_applicantphases.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_applicantphases, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_applicantphases.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_applicantphases.strCommonSerachParam+"%");

                    IList<tran_applicantphasesEntity> itemList = new List<tran_applicantphasesEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_applicantphasesEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_applicantphases.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_applicantphasesDataAccess.GAPgListViewtran_applicantphases"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Itran_applicantphasesDataAccessObjects.GetDataForDropDown(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "tran_applicantphases_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, tran_applicantphases.SortExpression);
					AddPageSizeParameter(cmd, tran_applicantphases.PageSize);
					AddCurrentPageParameter(cmd, tran_applicantphases.CurrentPage);                    
					FillSequrityParameters(tran_applicantphases.BaseSecurityParam, cmd, Database);
					FillParameters(tran_applicantphases, cmd,Database);
					if (!string.IsNullOrEmpty(tran_applicantphases.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + tran_applicantphases.strCommonSerachParam + " % ");
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
						tran_applicantphases.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Itran_applicantphasesDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}