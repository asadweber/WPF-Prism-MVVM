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
	
	internal sealed partial class owin_userprefferencessettingsDataAccessObjects : BaseDataAccess, Iowin_userprefferencessettingsDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "owin_userprefferencessettingsDataAccessObjects";
        
		public owin_userprefferencessettingsDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(owin_userprefferencessettingsEntity owin_userprefferencessettings, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (owin_userprefferencessettings.serialno.HasValue)
				Database.AddInParameter(cmd, "@SerialNo", DbType.Int64, owin_userprefferencessettings.serialno);
            if (forDelete) return;
			
				Database.AddInParameter(cmd, "@UserID", DbType.Guid, owin_userprefferencessettings.userid);
			if (owin_userprefferencessettings.masteruserid.HasValue)
				Database.AddInParameter(cmd, "@MasterUserID", DbType.Int64, owin_userprefferencessettings.masteruserid);
			if (owin_userprefferencessettings.appformid.HasValue)
				Database.AddInParameter(cmd, "@AppFormID", DbType.Int64, owin_userprefferencessettings.appformid);
			if (owin_userprefferencessettings.prepagesize.HasValue)
				Database.AddInParameter(cmd, "@PrePageSize", DbType.Int32, owin_userprefferencessettings.prepagesize);

        }
		
        
		#region Add Operation

        async Task<long> Iowin_userprefferencessettingsDataAccessObjects.Add(owin_userprefferencessettingsEntity owin_userprefferencessettings, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "owin_userprefferencessettings_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(owin_userprefferencessettings, cmd,Database);
                FillSequrityParameters(owin_userprefferencessettings.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userprefferencessettingsDataAccess.Addowin_userprefferencessettings"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Iowin_userprefferencessettingsDataAccessObjects.Update(owin_userprefferencessettingsEntity owin_userprefferencessettings, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "owin_userprefferencessettings_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(owin_userprefferencessettings, cmd,Database);
                FillSequrityParameters(owin_userprefferencessettings.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Iowin_userprefferencessettingsDataAccess.Updateowin_userprefferencessettings"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Iowin_userprefferencessettingsDataAccessObjects.Delete(owin_userprefferencessettingsEntity owin_userprefferencessettings, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "owin_userprefferencessettings_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(owin_userprefferencessettings, cmd,Database, true);
                FillSequrityParameters(owin_userprefferencessettings.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Iowin_userprefferencessettingsDataAccess.Deleteowin_userprefferencessettings"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Iowin_userprefferencessettingsDataAccessObjects.SaveList(IList<owin_userprefferencessettingsEntity> listAdded, IList<owin_userprefferencessettingsEntity> listUpdated, IList<owin_userprefferencessettingsEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "owin_userprefferencessettings_Ins";
            const string SPUpdate = "owin_userprefferencessettings_Upd";
            const string SPDelete = "owin_userprefferencessettings_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_userprefferencessettingsEntity owin_userprefferencessettings in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_userprefferencessettings, cmd, Database, true);
                            FillSequrityParameters(owin_userprefferencessettings.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_userprefferencessettingsEntity owin_userprefferencessettings in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_userprefferencessettings, cmd, Database);
                            FillSequrityParameters(owin_userprefferencessettings.BaseSecurityParam, cmd, Database);
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
                    foreach (owin_userprefferencessettingsEntity owin_userprefferencessettings in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_userprefferencessettings, cmd, Database);
                            FillSequrityParameters(owin_userprefferencessettings.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userprefferencessettingsDataAccess.Save_owin_userprefferencessettings"));
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
       IList<owin_userprefferencessettingsEntity> listAdded, 
       IList<owin_userprefferencessettingsEntity> listUpdated, 
       IList<owin_userprefferencessettingsEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "owin_userprefferencessettings_Ins";
            const string SPUpdate = "owin_userprefferencessettings_Upd";
            const string SPDelete = "owin_userprefferencessettings_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (owin_userprefferencessettingsEntity owin_userprefferencessettings in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(owin_userprefferencessettings, cmd, db, true);
                            FillSequrityParameters(owin_userprefferencessettings.BaseSecurityParam, cmd, db);
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
                    foreach (owin_userprefferencessettingsEntity owin_userprefferencessettings in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(owin_userprefferencessettings, cmd, db);
                            FillSequrityParameters(owin_userprefferencessettings.BaseSecurityParam, cmd, db);
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
                    foreach (owin_userprefferencessettingsEntity owin_userprefferencessettings in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(owin_userprefferencessettings, cmd, db);
                            FillSequrityParameters(owin_userprefferencessettings.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Iowin_userprefferencessettingsDataAccess.Save_owin_userprefferencessettings"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<owin_userprefferencessettingsEntity>> Iowin_userprefferencessettingsDataAccessObjects.GetAll(owin_userprefferencessettingsEntity owin_userprefferencessettings, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "owin_userprefferencessettings_GA";
                IList<owin_userprefferencessettingsEntity> itemList = new List<owin_userprefferencessettingsEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, owin_userprefferencessettings.SortExpression);
                    FillSequrityParameters(owin_userprefferencessettings.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_userprefferencessettings, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userprefferencessettingsEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userprefferencessettingsDataAccess.GetAllowin_userprefferencessettings"));
            }	
        }
		
        async Task<IList<owin_userprefferencessettingsEntity>> Iowin_userprefferencessettingsDataAccessObjects.GetAllByPages(owin_userprefferencessettingsEntity owin_userprefferencessettings, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "owin_userprefferencessettings_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_userprefferencessettings.SortExpression);
                    AddPageSizeParameter(cmd, owin_userprefferencessettings.PageSize);
                    AddCurrentPageParameter(cmd, owin_userprefferencessettings.CurrentPage);                    
                    FillSequrityParameters(owin_userprefferencessettings.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_userprefferencessettings, cmd,Database);

                    IList<owin_userprefferencessettingsEntity> itemList = new List<owin_userprefferencessettingsEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userprefferencessettingsEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_userprefferencessettings.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userprefferencessettingsDataAccess.GetAllByPagesowin_userprefferencessettings"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<owin_userprefferencessettingsEntity> Iowin_userprefferencessettingsDataAccessObjects.GetSingle(owin_userprefferencessettingsEntity owin_userprefferencessettings, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "owin_userprefferencessettings_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(owin_userprefferencessettings.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_userprefferencessettings, cmd, Database);
                    
                    IList<owin_userprefferencessettingsEntity> itemList = new List<owin_userprefferencessettingsEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userprefferencessettingsEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Iowin_userprefferencessettingsDataAccess.GetSingleowin_userprefferencessettings"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<owin_userprefferencessettingsEntity>> Iowin_userprefferencessettingsDataAccessObjects.GAPgListView(owin_userprefferencessettingsEntity owin_userprefferencessettings, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "owin_userprefferencessettings_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_userprefferencessettings.SortExpression);
                    AddPageSizeParameter(cmd, owin_userprefferencessettings.PageSize);
                    AddCurrentPageParameter(cmd, owin_userprefferencessettings.CurrentPage);                    
                    FillSequrityParameters(owin_userprefferencessettings.BaseSecurityParam, cmd, Database);
                    
					FillParameters(owin_userprefferencessettings, cmd,Database);
                    
					if (!string.IsNullOrEmpty (owin_userprefferencessettings.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+owin_userprefferencessettings.strCommonSerachParam+"%");

                    IList<owin_userprefferencessettingsEntity> itemList = new List<owin_userprefferencessettingsEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userprefferencessettingsEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						owin_userprefferencessettings.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userprefferencessettingsDataAccess.GAPgListViewowin_userprefferencessettings"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
	}
}