using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;
using AppConfig.ConfigDAAC;
using DAC.Core.Base;
using System.Threading.Tasks;
using System.Threading;
using IDAC.Core.IDataAccessObjects.Security;
using BDO.Core.DataAccessObjects.SecurityModels;
using BDO.Core.Base;

namespace DAC.Core.DataAccessObjects.Security
{
	/// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>
	
	internal sealed partial class owin_userstatuschangehistoryDataAccessObjects : BaseDataAccess, Iowin_userstatuschangehistoryDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "owin_userstatuschangehistoryDataAccessObjects";
        
		public owin_userstatuschangehistoryDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(owin_userstatuschangehistoryEntity owin_userstatuschangehistory, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (owin_userstatuschangehistory.serial.HasValue)
				Database.AddInParameter(cmd, "@Serial", DbType.Int64, owin_userstatuschangehistory.serial);
            if (forDelete) return;
			
				Database.AddInParameter(cmd, "@UserID", DbType.Guid, owin_userstatuschangehistory.userid);
			if (owin_userstatuschangehistory.masteruserid.HasValue)
				Database.AddInParameter(cmd, "@MasterUserID", DbType.Int64, owin_userstatuschangehistory.masteruserid);
			if ((owin_userstatuschangehistory.statuschanged != null))
				Database.AddInParameter(cmd, "@StatusChanged", DbType.Boolean, owin_userstatuschangehistory.statuschanged);
			if (!(string.IsNullOrEmpty(owin_userstatuschangehistory.statusremark)))
				Database.AddInParameter(cmd, "@StatusRemark", DbType.String, owin_userstatuschangehistory.statusremark);
			if (!(string.IsNullOrEmpty(owin_userstatuschangehistory.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, owin_userstatuschangehistory.comment);
			if (!(string.IsNullOrEmpty(owin_userstatuschangehistory.extrafld)))
				Database.AddInParameter(cmd, "@ExtraFLD", DbType.String, owin_userstatuschangehistory.extrafld);

        }
		
        
		#region Add Operation

        async Task<long> Iowin_userstatuschangehistoryDataAccessObjects.Add(owin_userstatuschangehistoryEntity owin_userstatuschangehistory, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "owin_userstatuschangehistory_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(owin_userstatuschangehistory, cmd,Database);
                FillSequrityParameters(owin_userstatuschangehistory.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userstatuschangehistoryDataAccess.Addowin_userstatuschangehistory"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Iowin_userstatuschangehistoryDataAccessObjects.Update(owin_userstatuschangehistoryEntity owin_userstatuschangehistory, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "owin_userstatuschangehistory_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(owin_userstatuschangehistory, cmd,Database);
                FillSequrityParameters(owin_userstatuschangehistory.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userstatuschangehistoryDataAccess.Updateowin_userstatuschangehistory"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Iowin_userstatuschangehistoryDataAccessObjects.Delete(owin_userstatuschangehistoryEntity owin_userstatuschangehistory, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "owin_userstatuschangehistory_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(owin_userstatuschangehistory, cmd,Database, true);
                FillSequrityParameters(owin_userstatuschangehistory.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Iowin_userstatuschangehistoryDataAccess.Deleteowin_userstatuschangehistory"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Iowin_userstatuschangehistoryDataAccessObjects.SaveList(IList<owin_userstatuschangehistoryEntity> listAdded, IList<owin_userstatuschangehistoryEntity> listUpdated, IList<owin_userstatuschangehistoryEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "owin_userstatuschangehistory_Ins";
            const string SPUpdate = "owin_userstatuschangehistory_Upd";
            const string SPDelete = "owin_userstatuschangehistory_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_userstatuschangehistoryEntity owin_userstatuschangehistory in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_userstatuschangehistory, cmd, Database, true);
                            FillSequrityParameters(owin_userstatuschangehistory.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_userstatuschangehistoryEntity owin_userstatuschangehistory in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_userstatuschangehistory, cmd, Database);
                            FillSequrityParameters(owin_userstatuschangehistory.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_userstatuschangehistoryEntity owin_userstatuschangehistory in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_userstatuschangehistory, cmd, Database);
                            FillSequrityParameters(owin_userstatuschangehistory.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userstatuschangehistoryDataAccess.Save_owin_userstatuschangehistory"));
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
       IList<owin_userstatuschangehistoryEntity> listAdded, 
       IList<owin_userstatuschangehistoryEntity> listUpdated, 
       IList<owin_userstatuschangehistoryEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "owin_userstatuschangehistory_Ins";
            const string SPUpdate = "owin_userstatuschangehistory_Upd";
            const string SPDelete = "owin_userstatuschangehistory_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_userstatuschangehistoryEntity owin_userstatuschangehistory in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_userstatuschangehistory, cmd, db, true);
                            FillSequrityParameters(owin_userstatuschangehistory.BaseSecurityParam, cmd, db);
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
                    foreach (owin_userstatuschangehistoryEntity owin_userstatuschangehistory in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_userstatuschangehistory, cmd, db);
                            FillSequrityParameters(owin_userstatuschangehistory.BaseSecurityParam, cmd, db);
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
                    foreach (owin_userstatuschangehistoryEntity owin_userstatuschangehistory in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_userstatuschangehistory, cmd, db);
                            FillSequrityParameters(owin_userstatuschangehistory.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Iowin_userstatuschangehistoryDataAccess.Save_owin_userstatuschangehistory"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<owin_userstatuschangehistoryEntity>> Iowin_userstatuschangehistoryDataAccessObjects.GetAll(owin_userstatuschangehistoryEntity owin_userstatuschangehistory, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "owin_userstatuschangehistory_GA";
                IList<owin_userstatuschangehistoryEntity> itemList = new List<owin_userstatuschangehistoryEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, owin_userstatuschangehistory.SortExpression);
                    FillSequrityParameters(owin_userstatuschangehistory.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_userstatuschangehistory, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userstatuschangehistoryEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userstatuschangehistoryDataAccess.GetAllowin_userstatuschangehistory"));
            }	
        }
		
        async Task<IList<owin_userstatuschangehistoryEntity>> Iowin_userstatuschangehistoryDataAccessObjects.GetAllByPages(owin_userstatuschangehistoryEntity owin_userstatuschangehistory, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "owin_userstatuschangehistory_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_userstatuschangehistory.SortExpression);
                    AddPageSizeParameter(cmd, owin_userstatuschangehistory.PageSize);
                    AddCurrentPageParameter(cmd, owin_userstatuschangehistory.CurrentPage);                    
                    FillSequrityParameters(owin_userstatuschangehistory.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_userstatuschangehistory, cmd,Database);

                    IList<owin_userstatuschangehistoryEntity> itemList = new List<owin_userstatuschangehistoryEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userstatuschangehistoryEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_userstatuschangehistory.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userstatuschangehistoryDataAccess.GetAllByPagesowin_userstatuschangehistory"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<owin_userstatuschangehistoryEntity> Iowin_userstatuschangehistoryDataAccessObjects.GetSingle(owin_userstatuschangehistoryEntity owin_userstatuschangehistory, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "owin_userstatuschangehistory_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(owin_userstatuschangehistory.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_userstatuschangehistory, cmd, Database);
                    
                    IList<owin_userstatuschangehistoryEntity> itemList = new List<owin_userstatuschangehistoryEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userstatuschangehistoryEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userstatuschangehistoryDataAccess.GetSingleowin_userstatuschangehistory"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<owin_userstatuschangehistoryEntity>> Iowin_userstatuschangehistoryDataAccessObjects.GAPgListView(owin_userstatuschangehistoryEntity owin_userstatuschangehistory, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "owin_userstatuschangehistory_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_userstatuschangehistory.SortExpression);
                    AddPageSizeParameter(cmd, owin_userstatuschangehistory.PageSize);
                    AddCurrentPageParameter(cmd, owin_userstatuschangehistory.CurrentPage);                    
                    FillSequrityParameters(owin_userstatuschangehistory.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_userstatuschangehistory, cmd,Database);
                    
					if (!string.IsNullOrEmpty (owin_userstatuschangehistory.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+owin_userstatuschangehistory.strCommonSerachParam+"%");

                    IList<owin_userstatuschangehistoryEntity> itemList = new List<owin_userstatuschangehistoryEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userstatuschangehistoryEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_userstatuschangehistory.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userstatuschangehistoryDataAccess.GAPgListViewowin_userstatuschangehistory"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}