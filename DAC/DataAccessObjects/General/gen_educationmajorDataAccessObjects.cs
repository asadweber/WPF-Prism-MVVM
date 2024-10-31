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
	
	internal sealed partial class gen_educationmajorDataAccessObjects : BaseDataAccess, Igen_educationmajorDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_educationmajorDataAccessObjects";
        
		public gen_educationmajorDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_educationmajorEntity gen_educationmajor, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_educationmajor.edumajorid.HasValue)
				Database.AddInParameter(cmd, "@EduMajorID", DbType.Int64, gen_educationmajor.edumajorid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(gen_educationmajor.educationmajorname)))
				Database.AddInParameter(cmd, "@EducationMajorName", DbType.String, gen_educationmajor.educationmajorname);
			if (!(string.IsNullOrEmpty(gen_educationmajor.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, gen_educationmajor.comment);
			if (!(string.IsNullOrEmpty(gen_educationmajor.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_educationmajor.remarks);
			if (!(string.IsNullOrEmpty(gen_educationmajor.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, gen_educationmajor.updateinfo);
			if (gen_educationmajor.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, gen_educationmajor.tranformactionid);
			if (gen_educationmajor.oracleid.HasValue)
				Database.AddInParameter(cmd, "@OracleID", DbType.Int64, gen_educationmajor.oracleid);

        }
		
        
		#region Add Operation

        async Task<long> Igen_educationmajorDataAccessObjects.Add(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_educationmajor_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_educationmajor, cmd,Database);
                FillSequrityParameters(gen_educationmajor.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_educationmajorDataAccess.Addgen_educationmajor"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_educationmajorDataAccessObjects.Update(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_educationmajor_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_educationmajor, cmd,Database);
                FillSequrityParameters(gen_educationmajor.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_educationmajorDataAccess.Updategen_educationmajor"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_educationmajorDataAccessObjects.Delete(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_educationmajor_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_educationmajor, cmd,Database, true);
                FillSequrityParameters(gen_educationmajor.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_educationmajorDataAccess.Deletegen_educationmajor"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_educationmajorDataAccessObjects.SaveList(IList<gen_educationmajorEntity> listAdded, IList<gen_educationmajorEntity> listUpdated, IList<gen_educationmajorEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_educationmajor_Ins";
            const string SPUpdate = "gen_educationmajor_Upd";
            const string SPDelete = "gen_educationmajor_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_educationmajorEntity gen_educationmajor in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_educationmajor, cmd, Database, true);
                            FillSequrityParameters(gen_educationmajor.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_educationmajorEntity gen_educationmajor in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_educationmajor, cmd, Database);
                            FillSequrityParameters(gen_educationmajor.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_educationmajorEntity gen_educationmajor in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_educationmajor, cmd, Database);
                            FillSequrityParameters(gen_educationmajor.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_educationmajorDataAccess.Save_gen_educationmajor"));
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
       IList<gen_educationmajorEntity> listAdded, 
       IList<gen_educationmajorEntity> listUpdated, 
       IList<gen_educationmajorEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_educationmajor_Ins";
            const string SPUpdate = "gen_educationmajor_Upd";
            const string SPDelete = "gen_educationmajor_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_educationmajorEntity gen_educationmajor in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_educationmajor, cmd, db, true);
                            FillSequrityParameters(gen_educationmajor.BaseSecurityParam, cmd, db);
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
                    foreach (gen_educationmajorEntity gen_educationmajor in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_educationmajor, cmd, db);
                            FillSequrityParameters(gen_educationmajor.BaseSecurityParam, cmd, db);
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
                    foreach (gen_educationmajorEntity gen_educationmajor in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_educationmajor, cmd, db);
                            FillSequrityParameters(gen_educationmajor.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_educationmajorDataAccess.Save_gen_educationmajor"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_educationmajorEntity>> Igen_educationmajorDataAccessObjects.GetAll(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_educationmajor_GA";
                IList<gen_educationmajorEntity> itemList = new List<gen_educationmajorEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_educationmajor.SortExpression);
                    FillSequrityParameters(gen_educationmajor.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_educationmajor, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_educationmajorEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_educationmajorDataAccess.GetAllgen_educationmajor"));
            }	
        }
		
        async Task<IList<gen_educationmajorEntity>> Igen_educationmajorDataAccessObjects.GetAllByPages(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_educationmajor_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_educationmajor.SortExpression);
                    AddPageSizeParameter(cmd, gen_educationmajor.PageSize);
                    AddCurrentPageParameter(cmd, gen_educationmajor.CurrentPage);                    
                    FillSequrityParameters(gen_educationmajor.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_educationmajor, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_educationmajor.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_educationmajor.strCommonSerachParam+"%");

                    IList<gen_educationmajorEntity> itemList = new List<gen_educationmajorEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_educationmajorEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_educationmajor.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_educationmajorDataAccess.GetAllByPagesgen_educationmajor"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        
        async Task<long> Igen_educationmajorDataAccessObjects.SaveMasterDetreg_educationinfo(gen_educationmajorEntity masterEntity, 
        IList<reg_educationinfoEntity> listAdded, 
        IList<reg_educationinfoEntity> listUpdated,
        IList<reg_educationinfoEntity> listDeleted, 
        CancellationToken cancellationToken)
        {
			long returnCode = -99;
                Int64 PrimaryKeyMaster = -99;
            
            string SP = "";
            const string MasterSPInsert = "gen_educationmajor_Ins";
            const string MasterSPUpdate = "gen_educationmajor_Upd";
            const string MasterSPDelete = "gen_educationmajor_Del";
            
			
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
                                item.edumajorid=PrimaryKeyMaster;
                            }
                        }
                        reg_educationinfoDataAccessObjects objreg_educationinfo=new reg_educationinfoDataAccessObjects(this.Context);
                        objreg_educationinfo.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_educationmajorDataAccess.SaveDsgen_educationmajor"));
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
        async Task<gen_educationmajorEntity> Igen_educationmajorDataAccessObjects.GetSingle(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_educationmajor_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_educationmajor.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_educationmajor, cmd, Database);
                    
                    IList<gen_educationmajorEntity> itemList = new List<gen_educationmajorEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_educationmajorEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_educationmajorDataAccess.GetSinglegen_educationmajor"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_educationmajorEntity>> Igen_educationmajorDataAccessObjects.GAPgListView(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_educationmajor_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_educationmajor.SortExpression);
                    AddPageSizeParameter(cmd, gen_educationmajor.PageSize);
                    AddCurrentPageParameter(cmd, gen_educationmajor.CurrentPage);                    
                    FillSequrityParameters(gen_educationmajor.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_educationmajor, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_educationmajor.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_educationmajor.strCommonSerachParam+"%");

                    IList<gen_educationmajorEntity> itemList = new List<gen_educationmajorEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_educationmajorEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_educationmajor.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_educationmajorDataAccess.GAPgListViewgen_educationmajor"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_educationmajorDataAccessObjects.GetDataForDropDown(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "gen_educationmajor_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, gen_educationmajor.SortExpression);
					AddPageSizeParameter(cmd, gen_educationmajor.PageSize);
					AddCurrentPageParameter(cmd, gen_educationmajor.CurrentPage);                    
					FillSequrityParameters(gen_educationmajor.BaseSecurityParam, cmd, Database);
					FillParameters(gen_educationmajor, cmd,Database);
					if (!string.IsNullOrEmpty(gen_educationmajor.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + gen_educationmajor.strCommonSerachParam + " % ");
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
						gen_educationmajor.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Igen_educationmajorDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}