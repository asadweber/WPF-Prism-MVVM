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
	
	internal sealed partial class cnf_fileconfignameDataAccessObjects : BaseDataAccess, Icnf_fileconfignameDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "cnf_fileconfignameDataAccessObjects";
        
		public cnf_fileconfignameDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(cnf_fileconfignameEntity cnf_fileconfigname, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (cnf_fileconfigname.fileconfignameid.HasValue)
				Database.AddInParameter(cmd, "@FileConfigNameID", DbType.Int64, cnf_fileconfigname.fileconfignameid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(cnf_fileconfigname.fileconfigname)))
				Database.AddInParameter(cmd, "@FileConfigName", DbType.String, cnf_fileconfigname.fileconfigname);
			if (!(string.IsNullOrEmpty(cnf_fileconfigname.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, cnf_fileconfigname.remarks);
			if (!(string.IsNullOrEmpty(cnf_fileconfigname.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, cnf_fileconfigname.updateinfo);
			if (cnf_fileconfigname.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, cnf_fileconfigname.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Icnf_fileconfignameDataAccessObjects.Add(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "cnf_fileconfigname_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(cnf_fileconfigname, cmd,Database);
                FillSequrityParameters(cnf_fileconfigname.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Icnf_fileconfignameDataAccess.Addcnf_fileconfigname"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Icnf_fileconfignameDataAccessObjects.Update(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "cnf_fileconfigname_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(cnf_fileconfigname, cmd,Database);
                FillSequrityParameters(cnf_fileconfigname.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Icnf_fileconfignameDataAccess.Updatecnf_fileconfigname"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Icnf_fileconfignameDataAccessObjects.Delete(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "cnf_fileconfigname_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(cnf_fileconfigname, cmd,Database, true);
                FillSequrityParameters(cnf_fileconfigname.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Icnf_fileconfignameDataAccess.Deletecnf_fileconfigname"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Icnf_fileconfignameDataAccessObjects.SaveList(IList<cnf_fileconfignameEntity> listAdded, IList<cnf_fileconfignameEntity> listUpdated, IList<cnf_fileconfignameEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "cnf_fileconfigname_Ins";
            const string SPUpdate = "cnf_fileconfigname_Upd";
            const string SPDelete = "cnf_fileconfigname_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (cnf_fileconfignameEntity cnf_fileconfigname in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(cnf_fileconfigname, cmd, Database, true);
                            FillSequrityParameters(cnf_fileconfigname.BaseSecurityParam, cmd, Database);
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
                    foreach (cnf_fileconfignameEntity cnf_fileconfigname in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(cnf_fileconfigname, cmd, Database);
                            FillSequrityParameters(cnf_fileconfigname.BaseSecurityParam, cmd, Database);
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
                    foreach (cnf_fileconfignameEntity cnf_fileconfigname in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(cnf_fileconfigname, cmd, Database);
                            FillSequrityParameters(cnf_fileconfigname.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_fileconfignameDataAccess.Save_cnf_fileconfigname"));
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
       IList<cnf_fileconfignameEntity> listAdded, 
       IList<cnf_fileconfignameEntity> listUpdated, 
       IList<cnf_fileconfignameEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "cnf_fileconfigname_Ins";
            const string SPUpdate = "cnf_fileconfigname_Upd";
            const string SPDelete = "cnf_fileconfigname_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (cnf_fileconfignameEntity cnf_fileconfigname in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(cnf_fileconfigname, cmd, db, true);
                            FillSequrityParameters(cnf_fileconfigname.BaseSecurityParam, cmd, db);
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
                    foreach (cnf_fileconfignameEntity cnf_fileconfigname in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(cnf_fileconfigname, cmd, db);
                            FillSequrityParameters(cnf_fileconfigname.BaseSecurityParam, cmd, db);
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
                    foreach (cnf_fileconfignameEntity cnf_fileconfigname in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(cnf_fileconfigname, cmd, db);
                            FillSequrityParameters(cnf_fileconfigname.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Icnf_fileconfignameDataAccess.Save_cnf_fileconfigname"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<cnf_fileconfignameEntity>> Icnf_fileconfignameDataAccessObjects.GetAll(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_fileconfigname_GA";
                IList<cnf_fileconfignameEntity> itemList = new List<cnf_fileconfignameEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, cnf_fileconfigname.SortExpression);
                    FillSequrityParameters(cnf_fileconfigname.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_fileconfigname, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_fileconfignameEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_fileconfignameDataAccess.GetAllcnf_fileconfigname"));
            }	
        }
		
        async Task<IList<cnf_fileconfignameEntity>> Icnf_fileconfignameDataAccessObjects.GetAllByPages(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "cnf_fileconfigname_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_fileconfigname.SortExpression);
                    AddPageSizeParameter(cmd, cnf_fileconfigname.PageSize);
                    AddCurrentPageParameter(cmd, cnf_fileconfigname.CurrentPage);                    
                    FillSequrityParameters(cnf_fileconfigname.BaseSecurityParam, cmd, Database);
                    
					FillParameters(cnf_fileconfigname, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (cnf_fileconfigname.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+cnf_fileconfigname.strCommonSerachParam+"%");

                    IList<cnf_fileconfignameEntity> itemList = new List<cnf_fileconfignameEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_fileconfignameEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						cnf_fileconfigname.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_fileconfignameDataAccess.GetAllByPagescnf_fileconfigname"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<cnf_fileconfignameEntity> Icnf_fileconfignameDataAccessObjects.GetSingle(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_fileconfigname_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(cnf_fileconfigname.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_fileconfigname, cmd, Database);
                    
                    IList<cnf_fileconfignameEntity> itemList = new List<cnf_fileconfignameEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_fileconfignameEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_fileconfignameDataAccess.GetSinglecnf_fileconfigname"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<cnf_fileconfignameEntity>> Icnf_fileconfignameDataAccessObjects.GAPgListView(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "cnf_fileconfigname_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_fileconfigname.SortExpression);
                    AddPageSizeParameter(cmd, cnf_fileconfigname.PageSize);
                    AddCurrentPageParameter(cmd, cnf_fileconfigname.CurrentPage);                    
                    FillSequrityParameters(cnf_fileconfigname.BaseSecurityParam, cmd, Database);
                    
					FillParameters(cnf_fileconfigname, cmd,Database);
                    
					if (!string.IsNullOrEmpty (cnf_fileconfigname.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+cnf_fileconfigname.strCommonSerachParam+"%");

                    IList<cnf_fileconfignameEntity> itemList = new List<cnf_fileconfignameEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_fileconfignameEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						cnf_fileconfigname.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_fileconfignameDataAccess.GAPgListViewcnf_fileconfigname"));
            }
        }
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion

        #region for Dropdown 
        async Task<IList<gen_dropdownEntity>> Icnf_fileconfignameDataAccessObjects.GetDataForDropDown(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "cnf_fileconfigname_GAPgDropDown";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_fileconfigname.SortExpression);
                    AddPageSizeParameter(cmd, cnf_fileconfigname.PageSize);
                    AddCurrentPageParameter(cmd, cnf_fileconfigname.CurrentPage);
                    FillSequrityParameters(cnf_fileconfigname.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_fileconfigname, cmd, Database);
                    if (!string.IsNullOrEmpty(cnf_fileconfigname.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + cnf_fileconfigname.strCommonSerachParam + " % ");
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
                        cnf_fileconfigname.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_fileconfignameDataAccess.GetDataForDropDown"));
            }
        }
        #endregion

    }
}