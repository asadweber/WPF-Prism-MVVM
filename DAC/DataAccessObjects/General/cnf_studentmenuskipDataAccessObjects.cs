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
	
	internal sealed partial class cnf_studentmenuskipDataAccessObjects : BaseDataAccess, Icnf_studentmenuskipDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "cnf_studentmenuskipDataAccessObjects";
        
		public cnf_studentmenuskipDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(cnf_studentmenuskipEntity cnf_studentmenuskip, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (cnf_studentmenuskip.studentskippedserialid.HasValue)
				Database.AddInParameter(cmd, "@StudentSkippedSerialID", DbType.Int64, cnf_studentmenuskip.studentskippedserialid);
            if (forDelete) return;
			if (cnf_studentmenuskip.usercateogryid.HasValue)
				Database.AddInParameter(cmd, "@UserCateogryID", DbType.Int64, cnf_studentmenuskip.usercateogryid);
			if (cnf_studentmenuskip.appformid.HasValue)
				Database.AddInParameter(cmd, "@AppFormID", DbType.Int64, cnf_studentmenuskip.appformid);
			if (cnf_studentmenuskip.formactionid.HasValue)
				Database.AddInParameter(cmd, "@FormActionID", DbType.Int64, cnf_studentmenuskip.formactionid);
			if (!(string.IsNullOrEmpty(cnf_studentmenuskip.formname)))
				Database.AddInParameter(cmd, "@FormName", DbType.String, cnf_studentmenuskip.formname);
			if ((cnf_studentmenuskip.hasskipped != null))
				Database.AddInParameter(cmd, "@HasSkipped", DbType.Boolean, cnf_studentmenuskip.hasskipped);
			if (!(string.IsNullOrEmpty(cnf_studentmenuskip.skippedprompt)))
				Database.AddInParameter(cmd, "@SkippedPrompt", DbType.String, cnf_studentmenuskip.skippedprompt);
			if (!(string.IsNullOrEmpty(cnf_studentmenuskip.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, cnf_studentmenuskip.comment);
			if (!(string.IsNullOrEmpty(cnf_studentmenuskip.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, cnf_studentmenuskip.remarks);
			if (!(string.IsNullOrEmpty(cnf_studentmenuskip.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, cnf_studentmenuskip.updateinfo);
			if (cnf_studentmenuskip.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, cnf_studentmenuskip.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Icnf_studentmenuskipDataAccessObjects.Add(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "cnf_studentmenuskip_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(cnf_studentmenuskip, cmd,Database);
                FillSequrityParameters(cnf_studentmenuskip.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Icnf_studentmenuskipDataAccess.Addcnf_studentmenuskip"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Icnf_studentmenuskipDataAccessObjects.Update(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "cnf_studentmenuskip_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(cnf_studentmenuskip, cmd,Database);
                FillSequrityParameters(cnf_studentmenuskip.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Icnf_studentmenuskipDataAccess.Updatecnf_studentmenuskip"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Icnf_studentmenuskipDataAccessObjects.Delete(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "cnf_studentmenuskip_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(cnf_studentmenuskip, cmd,Database, true);
                FillSequrityParameters(cnf_studentmenuskip.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Icnf_studentmenuskipDataAccess.Deletecnf_studentmenuskip"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Icnf_studentmenuskipDataAccessObjects.SaveList(IList<cnf_studentmenuskipEntity> listAdded, IList<cnf_studentmenuskipEntity> listUpdated, IList<cnf_studentmenuskipEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "cnf_studentmenuskip_Ins";
            const string SPUpdate = "cnf_studentmenuskip_Upd";
            const string SPDelete = "cnf_studentmenuskip_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (cnf_studentmenuskipEntity cnf_studentmenuskip in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(cnf_studentmenuskip, cmd, Database, true);
                            FillSequrityParameters(cnf_studentmenuskip.BaseSecurityParam, cmd, Database);
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
                    foreach (cnf_studentmenuskipEntity cnf_studentmenuskip in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(cnf_studentmenuskip, cmd, Database);
                            FillSequrityParameters(cnf_studentmenuskip.BaseSecurityParam, cmd, Database);
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
                    foreach (cnf_studentmenuskipEntity cnf_studentmenuskip in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(cnf_studentmenuskip, cmd, Database);
                            FillSequrityParameters(cnf_studentmenuskip.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_studentmenuskipDataAccess.Save_cnf_studentmenuskip"));
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
       IList<cnf_studentmenuskipEntity> listAdded, 
       IList<cnf_studentmenuskipEntity> listUpdated, 
       IList<cnf_studentmenuskipEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "cnf_studentmenuskip_Ins";
            const string SPUpdate = "cnf_studentmenuskip_Upd";
            const string SPDelete = "cnf_studentmenuskip_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (cnf_studentmenuskipEntity cnf_studentmenuskip in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(cnf_studentmenuskip, cmd, db, true);
                            FillSequrityParameters(cnf_studentmenuskip.BaseSecurityParam, cmd, db);
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
                    foreach (cnf_studentmenuskipEntity cnf_studentmenuskip in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(cnf_studentmenuskip, cmd, db);
                            FillSequrityParameters(cnf_studentmenuskip.BaseSecurityParam, cmd, db);
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
                    foreach (cnf_studentmenuskipEntity cnf_studentmenuskip in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(cnf_studentmenuskip, cmd, db);
                            FillSequrityParameters(cnf_studentmenuskip.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Icnf_studentmenuskipDataAccess.Save_cnf_studentmenuskip"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<cnf_studentmenuskipEntity>> Icnf_studentmenuskipDataAccessObjects.GetAll(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_studentmenuskip_GA";
                IList<cnf_studentmenuskipEntity> itemList = new List<cnf_studentmenuskipEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, cnf_studentmenuskip.SortExpression);
                    FillSequrityParameters(cnf_studentmenuskip.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_studentmenuskip, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_studentmenuskipEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_studentmenuskipDataAccess.GetAllcnf_studentmenuskip"));
            }	
        }
		
        async Task<IList<cnf_studentmenuskipEntity>> Icnf_studentmenuskipDataAccessObjects.GetAllByPages(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "cnf_studentmenuskip_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_studentmenuskip.SortExpression);
                    AddPageSizeParameter(cmd, cnf_studentmenuskip.PageSize);
                    AddCurrentPageParameter(cmd, cnf_studentmenuskip.CurrentPage);                    
                    FillSequrityParameters(cnf_studentmenuskip.BaseSecurityParam, cmd, Database);
                    
					FillParameters(cnf_studentmenuskip, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (cnf_studentmenuskip.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+cnf_studentmenuskip.strCommonSerachParam+"%");

                    IList<cnf_studentmenuskipEntity> itemList = new List<cnf_studentmenuskipEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_studentmenuskipEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						cnf_studentmenuskip.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_studentmenuskipDataAccess.GetAllByPagescnf_studentmenuskip"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Icnf_studentmenuskipDataAccessObjects.SaveMasterDetcnf_studentmenuskipdetail(cnf_studentmenuskipEntity masterEntity, 
        IList<cnf_studentmenuskipdetailEntity> listAdded, 
        IList<cnf_studentmenuskipdetailEntity> listUpdated,
        IList<cnf_studentmenuskipdetailEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "cnf_studentmenuskip_Ins";
            const string MasterSPUpdate = "cnf_studentmenuskip_Upd";
            const string MasterSPDelete = "cnf_studentmenuskip_Del";
            
			
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
                                item.studentskippedserialid=PrimaryKeyMaster;
                            }
                        }
                        cnf_studentmenuskipdetailDataAccessObjects objcnf_studentmenuskipdetail=new cnf_studentmenuskipdetailDataAccessObjects(this.Context);
                        objcnf_studentmenuskipdetail.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_studentmenuskipDataAccess.SaveDscnf_studentmenuskip"));
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
        async Task<cnf_studentmenuskipEntity> Icnf_studentmenuskipDataAccessObjects.GetSingle(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_studentmenuskip_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(cnf_studentmenuskip.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_studentmenuskip, cmd, Database);
                    
                    IList<cnf_studentmenuskipEntity> itemList = new List<cnf_studentmenuskipEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_studentmenuskipEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_studentmenuskipDataAccess.GetSinglecnf_studentmenuskip"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<cnf_studentmenuskipEntity>> Icnf_studentmenuskipDataAccessObjects.GAPgListView(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "cnf_studentmenuskip_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_studentmenuskip.SortExpression);
                    AddPageSizeParameter(cmd, cnf_studentmenuskip.PageSize);
                    AddCurrentPageParameter(cmd, cnf_studentmenuskip.CurrentPage);                    
                    FillSequrityParameters(cnf_studentmenuskip.BaseSecurityParam, cmd, Database);
                    
					FillParameters(cnf_studentmenuskip, cmd,Database);
                    
					if (!string.IsNullOrEmpty (cnf_studentmenuskip.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+cnf_studentmenuskip.strCommonSerachParam+"%");

                    IList<cnf_studentmenuskipEntity> itemList = new List<cnf_studentmenuskipEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_studentmenuskipEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						cnf_studentmenuskip.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_studentmenuskipDataAccess.GAPgListViewcnf_studentmenuskip"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Icnf_studentmenuskipDataAccessObjects.GetDataForDropDown(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "cnf_studentmenuskip_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, cnf_studentmenuskip.SortExpression);
					AddPageSizeParameter(cmd, cnf_studentmenuskip.PageSize);
					AddCurrentPageParameter(cmd, cnf_studentmenuskip.CurrentPage);                    
					FillSequrityParameters(cnf_studentmenuskip.BaseSecurityParam, cmd, Database);
					FillParameters(cnf_studentmenuskip, cmd,Database);
					if (!string.IsNullOrEmpty(cnf_studentmenuskip.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + cnf_studentmenuskip.strCommonSerachParam + " % ");
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
						cnf_studentmenuskip.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Icnf_studentmenuskipDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}