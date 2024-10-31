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
	
	internal sealed partial class tran_notificationfiledetDataAccessObjects : BaseDataAccess, Itran_notificationfiledetDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "tran_notificationfiledetDataAccessObjects";
        
		public tran_notificationfiledetDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(tran_notificationfiledetEntity tran_notificationfiledet, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (tran_notificationfiledet.filerequestdetid.HasValue)
				Database.AddInParameter(cmd, "@FileRequestDetID", DbType.Int64, tran_notificationfiledet.filerequestdetid);
            if (forDelete) return;
			if (tran_notificationfiledet.filerequestid.HasValue)
				Database.AddInParameter(cmd, "@FileRequestID", DbType.Int64, tran_notificationfiledet.filerequestid);
			if (!(string.IsNullOrEmpty(tran_notificationfiledet.recipientcivilid)))
				Database.AddInParameter(cmd, "@RecipientCivilID", DbType.String, tran_notificationfiledet.recipientcivilid);
			if (!(string.IsNullOrEmpty(tran_notificationfiledet.recipientmobile)))
				Database.AddInParameter(cmd, "@RecipientMobile", DbType.String, tran_notificationfiledet.recipientmobile);
			if (!(string.IsNullOrEmpty(tran_notificationfiledet.recipientemail)))
				Database.AddInParameter(cmd, "@RecipientEmail", DbType.String, tran_notificationfiledet.recipientemail);
			if (!(string.IsNullOrEmpty(tran_notificationfiledet.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, tran_notificationfiledet.updateinfo);
			if (tran_notificationfiledet.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, tran_notificationfiledet.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Itran_notificationfiledetDataAccessObjects.Add(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "tran_notificationfiledet_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(tran_notificationfiledet, cmd,Database);
                FillSequrityParameters(tran_notificationfiledet.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_notificationfiledetDataAccess.Addtran_notificationfiledet"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Itran_notificationfiledetDataAccessObjects.Update(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "tran_notificationfiledet_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(tran_notificationfiledet, cmd,Database);
                FillSequrityParameters(tran_notificationfiledet.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_notificationfiledetDataAccess.Updatetran_notificationfiledet"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Itran_notificationfiledetDataAccessObjects.Delete(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "tran_notificationfiledet_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(tran_notificationfiledet, cmd,Database, true);
                FillSequrityParameters(tran_notificationfiledet.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Itran_notificationfiledetDataAccess.Deletetran_notificationfiledet"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Itran_notificationfiledetDataAccessObjects.SaveList(IList<tran_notificationfiledetEntity> listAdded, IList<tran_notificationfiledetEntity> listUpdated, IList<tran_notificationfiledetEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "tran_notificationfiledet_Ins";
            const string SPUpdate = "tran_notificationfiledet_Upd";
            const string SPDelete = "tran_notificationfiledet_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_notificationfiledetEntity tran_notificationfiledet in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_notificationfiledet, cmd, Database, true);
                            FillSequrityParameters(tran_notificationfiledet.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_notificationfiledetEntity tran_notificationfiledet in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_notificationfiledet, cmd, Database);
                            FillSequrityParameters(tran_notificationfiledet.BaseSecurityParam, cmd, Database);
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
                    foreach (tran_notificationfiledetEntity tran_notificationfiledet in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_notificationfiledet, cmd, Database);
                            FillSequrityParameters(tran_notificationfiledet.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationfiledetDataAccess.Save_tran_notificationfiledet"));
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
       IList<tran_notificationfiledetEntity> listAdded, 
       IList<tran_notificationfiledetEntity> listUpdated, 
       IList<tran_notificationfiledetEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "tran_notificationfiledet_Ins";
            const string SPUpdate = "tran_notificationfiledet_Upd";
            const string SPDelete = "tran_notificationfiledet_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (tran_notificationfiledetEntity tran_notificationfiledet in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(tran_notificationfiledet, cmd, db, true);
                            FillSequrityParameters(tran_notificationfiledet.BaseSecurityParam, cmd, db);
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
                    foreach (tran_notificationfiledetEntity tran_notificationfiledet in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(tran_notificationfiledet, cmd, db);
                            FillSequrityParameters(tran_notificationfiledet.BaseSecurityParam, cmd, db);
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
                    foreach (tran_notificationfiledetEntity tran_notificationfiledet in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(tran_notificationfiledet, cmd, db);
                            FillSequrityParameters(tran_notificationfiledet.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationfiledetDataAccess.Save_tran_notificationfiledet"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<tran_notificationfiledetEntity>> Itran_notificationfiledetDataAccessObjects.GetAll(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_notificationfiledet_GA";
                IList<tran_notificationfiledetEntity> itemList = new List<tran_notificationfiledetEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, tran_notificationfiledet.SortExpression);
                    FillSequrityParameters(tran_notificationfiledet.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_notificationfiledet, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_notificationfiledetEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationfiledetDataAccess.GetAlltran_notificationfiledet"));
            }	
        }
		
        async Task<IList<tran_notificationfiledetEntity>> Itran_notificationfiledetDataAccessObjects.GetAllByPages(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_notificationfiledet_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_notificationfiledet.SortExpression);
                    AddPageSizeParameter(cmd, tran_notificationfiledet.PageSize);
                    AddCurrentPageParameter(cmd, tran_notificationfiledet.CurrentPage);                    
                    FillSequrityParameters(tran_notificationfiledet.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_notificationfiledet, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (tran_notificationfiledet.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_notificationfiledet.strCommonSerachParam+"%");

                    IList<tran_notificationfiledetEntity> itemList = new List<tran_notificationfiledetEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_notificationfiledetEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_notificationfiledet.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationfiledetDataAccess.GetAllByPagestran_notificationfiledet"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<tran_notificationfiledetEntity> Itran_notificationfiledetDataAccessObjects.GetSingle(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "tran_notificationfiledet_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(tran_notificationfiledet.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_notificationfiledet, cmd, Database);
                    
                    IList<tran_notificationfiledetEntity> itemList = new List<tran_notificationfiledetEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_notificationfiledetEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationfiledetDataAccess.GetSingletran_notificationfiledet"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<tran_notificationfiledetEntity>> Itran_notificationfiledetDataAccessObjects.GAPgListView(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "tran_notificationfiledet_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_notificationfiledet.SortExpression);
                    AddPageSizeParameter(cmd, tran_notificationfiledet.PageSize);
                    AddCurrentPageParameter(cmd, tran_notificationfiledet.CurrentPage);                    
                    FillSequrityParameters(tran_notificationfiledet.BaseSecurityParam, cmd, Database);
                    
					FillParameters(tran_notificationfiledet, cmd,Database);
                    
					if (!string.IsNullOrEmpty (tran_notificationfiledet.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+tran_notificationfiledet.strCommonSerachParam+"%");

                    IList<tran_notificationfiledetEntity> itemList = new List<tran_notificationfiledetEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_notificationfiledetEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						tran_notificationfiledet.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationfiledetDataAccess.GAPgListViewtran_notificationfiledet"));
            }
        }
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion

        #region for Dropdown 
        async Task<IList<gen_dropdownEntity>> Itran_notificationfiledetDataAccessObjects.GetDataForDropDown(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "tran_notificationfile_GAPgDropDown";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, tran_notificationfiledet.SortExpression);
                    AddPageSizeParameter(cmd, tran_notificationfiledet.PageSize);
                    AddCurrentPageParameter(cmd, tran_notificationfiledet.CurrentPage);
                    FillSequrityParameters(tran_notificationfiledet.BaseSecurityParam, cmd, Database);
                    FillParameters(tran_notificationfiledet, cmd, Database);
                    if (!string.IsNullOrEmpty(tran_notificationfiledet.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + tran_notificationfiledet.strCommonSerachParam + " % ");
                    IList<gen_dropdownEntity> itemList = new List<gen_dropdownEntity>();
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
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
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        tran_notificationfiledet.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Itran_notificationfiledetDataAccess.GetDataForDropDown"));
            }
        }
        #endregion

    }
}