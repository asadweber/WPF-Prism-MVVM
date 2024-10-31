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
	
	internal sealed partial class tran_exportprofileDataAccessObjects : BaseDataAccess, Itran_exportprofileDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_exportprofileDataAccessObjects";
        
		public tran_exportprofileDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_exportprofileEntity tran_exportprofile, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_exportprofile.profileexportid.HasValue)
				Database.AddInParameter(cmd, "@ProfileExportID", DbType.Int64, tran_exportprofile.profileexportid);
            if (forDelete) return;
			if (tran_exportprofile.registrationid.HasValue)
				Database.AddInParameter(cmd, "@RegistrationID", DbType.Int64, tran_exportprofile.registrationid);
			if (tran_exportprofile.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, tran_exportprofile.basicinfoid);
			if (tran_exportprofile.batchid.HasValue)
				Database.AddInParameter(cmd, "@BatchID", DbType.Int64, tran_exportprofile.batchid);
			if ((tran_exportprofile.exporteddate.HasValue))
				Database.AddInParameter(cmd, "@ExportedDate", DbType.DateTime, tran_exportprofile.exporteddate);
			if (!(string.IsNullOrEmpty(tran_exportprofile.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, tran_exportprofile.remarks);
			if (!(string.IsNullOrEmpty(tran_exportprofile.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, tran_exportprofile.updateinfo);
			if (tran_exportprofile.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, tran_exportprofile.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Itran_exportprofileDataAccessObjects.Add(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_exportprofile_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_exportprofile, cmd,Database);
                FillSequrityParameters(tran_exportprofile.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_exportprofileDataAccess.Addtran_exportprofile"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Itran_exportprofileDataAccessObjects.Update(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "tran_exportprofile_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_exportprofile, cmd,Database);
                FillSequrityParameters(tran_exportprofile.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_exportprofileDataAccess.Updatetran_exportprofile"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Itran_exportprofileDataAccessObjects.Delete(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "tran_exportprofile_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_exportprofile, cmd,Database, true);
                FillSequrityParameters(tran_exportprofile.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Itran_exportprofileDataAccess.Deletetran_exportprofile"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Itran_exportprofileDataAccessObjects.SaveList(IList<tran_exportprofileEntity> listAdded, IList<tran_exportprofileEntity> listUpdated, IList<tran_exportprofileEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_exportprofile_Ins";
            const string SPUpdate = "tran_exportprofile_Upd";
            const string SPDelete = "tran_exportprofile_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_exportprofileEntity tran_exportprofile in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_exportprofile, cmd, Database, true);
                            FillSequrityParameters(tran_exportprofile.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_exportprofileEntity tran_exportprofile in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_exportprofile, cmd, Database);
                            FillSequrityParameters(tran_exportprofile.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_exportprofileEntity tran_exportprofile in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_exportprofile, cmd, Database);
                            FillSequrityParameters(tran_exportprofile.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_exportprofileDataAccess.Save_tran_exportprofile"));
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
       IList<tran_exportprofileEntity> listAdded, 
       IList<tran_exportprofileEntity> listUpdated, 
       IList<tran_exportprofileEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "tran_exportprofile_Ins";
            const string SPUpdate = "tran_exportprofile_Upd";
            const string SPDelete = "tran_exportprofile_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_exportprofileEntity tran_exportprofile in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_exportprofile, cmd, db, true);
                            FillSequrityParameters(tran_exportprofile.BaseSecurityParam, cmd, db);
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
                    foreach (tran_exportprofileEntity tran_exportprofile in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_exportprofile, cmd, db);
                            FillSequrityParameters(tran_exportprofile.BaseSecurityParam, cmd, db);
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
                    foreach (tran_exportprofileEntity tran_exportprofile in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_exportprofile, cmd, db);
                            FillSequrityParameters(tran_exportprofile.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_exportprofileDataAccess.Save_tran_exportprofile"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<tran_exportprofileEntity>> Itran_exportprofileDataAccessObjects.GetAll(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_exportprofile_GA";
                IList<tran_exportprofileEntity> itemList = new List<tran_exportprofileEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_exportprofile.SortExpression);
                    FillSequrityParameters(tran_exportprofile.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_exportprofile, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_exportprofileEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_exportprofileDataAccess.GetAlltran_exportprofile"));
            }	
        }
		
        async Task<IList<tran_exportprofileEntity>> Itran_exportprofileDataAccessObjects.GetAllByPages(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_exportprofile_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_exportprofile.SortExpression);
                    AddPageSizeParameter(cmd, tran_exportprofile.PageSize);
                    AddCurrentPageParameter(cmd, tran_exportprofile.CurrentPage);                    
                    FillSequrityParameters(tran_exportprofile.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_exportprofile, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (tran_exportprofile.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_exportprofile.strCommonSerachParam+"%");

                    IList<tran_exportprofileEntity> itemList = new List<tran_exportprofileEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_exportprofileEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_exportprofile.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_exportprofileDataAccess.GetAllByPagestran_exportprofile"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<tran_exportprofileEntity> Itran_exportprofileDataAccessObjects.GetSingle(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_exportprofile_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_exportprofile.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_exportprofile, cmd, Database);
                    
                    IList<tran_exportprofileEntity> itemList = new List<tran_exportprofileEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_exportprofileEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_exportprofileDataAccess.GetSingletran_exportprofile"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<tran_exportprofileEntity>> Itran_exportprofileDataAccessObjects.GAPgListView(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_exportprofile_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_exportprofile.SortExpression);
                    AddPageSizeParameter(cmd, tran_exportprofile.PageSize);
                    AddCurrentPageParameter(cmd, tran_exportprofile.CurrentPage);                    
                    FillSequrityParameters(tran_exportprofile.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_exportprofile, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_exportprofile.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_exportprofile.strCommonSerachParam+"%");

                    IList<tran_exportprofileEntity> itemList = new List<tran_exportprofileEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_exportprofileEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_exportprofile.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_exportprofileDataAccess.GAPgListViewtran_exportprofile"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}