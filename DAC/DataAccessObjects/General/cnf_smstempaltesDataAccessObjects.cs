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
	
	internal sealed partial class cnf_smstempaltesDataAccessObjects : BaseDataAccess, Icnf_smstempaltesDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "cnf_smstempaltesDataAccessObjects";
        
		public cnf_smstempaltesDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(cnf_smstempaltesEntity cnf_smstempaltes, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (cnf_smstempaltes.smstemplateid.HasValue)
				Database.AddInParameter(cmd, "@SMSTemplateID", DbType.Int64, cnf_smstempaltes.smstemplateid);
            if (forDelete) return;
			if (!(string.IsNullOrEmpty(cnf_smstempaltes.smstemplateshortname)))
				Database.AddInParameter(cmd, "@SMSTemplateShortName", DbType.String, cnf_smstempaltes.smstemplateshortname);
			if (!(string.IsNullOrEmpty(cnf_smstempaltes.smstemplatemsg)))
				Database.AddInParameter(cmd, "@SMSTemplateMSG", DbType.String, cnf_smstempaltes.smstemplatemsg);
			if (!(string.IsNullOrEmpty(cnf_smstempaltes.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, cnf_smstempaltes.comment);
			if (!(string.IsNullOrEmpty(cnf_smstempaltes.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, cnf_smstempaltes.remarks);
			if (!(string.IsNullOrEmpty(cnf_smstempaltes.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, cnf_smstempaltes.updateinfo);
			if (cnf_smstempaltes.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, cnf_smstempaltes.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Icnf_smstempaltesDataAccessObjects.Add(cnf_smstempaltesEntity cnf_smstempaltes, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "cnf_smstempaltes_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(cnf_smstempaltes, cmd,Database);
                FillSequrityParameters(cnf_smstempaltes.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Icnf_smstempaltesDataAccess.Addcnf_smstempaltes"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Icnf_smstempaltesDataAccessObjects.Update(cnf_smstempaltesEntity cnf_smstempaltes, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "cnf_smstempaltes_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(cnf_smstempaltes, cmd,Database);
                FillSequrityParameters(cnf_smstempaltes.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Icnf_smstempaltesDataAccess.Updatecnf_smstempaltes"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Icnf_smstempaltesDataAccessObjects.Delete(cnf_smstempaltesEntity cnf_smstempaltes, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "cnf_smstempaltes_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(cnf_smstempaltes, cmd,Database, true);
                FillSequrityParameters(cnf_smstempaltes.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Icnf_smstempaltesDataAccess.Deletecnf_smstempaltes"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Icnf_smstempaltesDataAccessObjects.SaveList(IList<cnf_smstempaltesEntity> listAdded, IList<cnf_smstempaltesEntity> listUpdated, IList<cnf_smstempaltesEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "cnf_smstempaltes_Ins";
            const string SPUpdate = "cnf_smstempaltes_Upd";
            const string SPDelete = "cnf_smstempaltes_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (cnf_smstempaltesEntity cnf_smstempaltes in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(cnf_smstempaltes, cmd, Database, true);
                            FillSequrityParameters(cnf_smstempaltes.BaseSecurityParam, cmd, Database);
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
                    foreach (cnf_smstempaltesEntity cnf_smstempaltes in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(cnf_smstempaltes, cmd, Database);
                            FillSequrityParameters(cnf_smstempaltes.BaseSecurityParam, cmd, Database);
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
                    foreach (cnf_smstempaltesEntity cnf_smstempaltes in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(cnf_smstempaltes, cmd, Database);
                            FillSequrityParameters(cnf_smstempaltes.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_smstempaltesDataAccess.Save_cnf_smstempaltes"));
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
       IList<cnf_smstempaltesEntity> listAdded, 
       IList<cnf_smstempaltesEntity> listUpdated, 
       IList<cnf_smstempaltesEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "cnf_smstempaltes_Ins";
            const string SPUpdate = "cnf_smstempaltes_Upd";
            const string SPDelete = "cnf_smstempaltes_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (cnf_smstempaltesEntity cnf_smstempaltes in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(cnf_smstempaltes, cmd, db, true);
                            FillSequrityParameters(cnf_smstempaltes.BaseSecurityParam, cmd, db);
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
                    foreach (cnf_smstempaltesEntity cnf_smstempaltes in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(cnf_smstempaltes, cmd, db);
                            FillSequrityParameters(cnf_smstempaltes.BaseSecurityParam, cmd, db);
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
                    foreach (cnf_smstempaltesEntity cnf_smstempaltes in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(cnf_smstempaltes, cmd, db);
                            FillSequrityParameters(cnf_smstempaltes.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Icnf_smstempaltesDataAccess.Save_cnf_smstempaltes"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<cnf_smstempaltesEntity>> Icnf_smstempaltesDataAccessObjects.GetAll(cnf_smstempaltesEntity cnf_smstempaltes, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_smstempaltes_GA";
                IList<cnf_smstempaltesEntity> itemList = new List<cnf_smstempaltesEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, cnf_smstempaltes.SortExpression);
                    FillSequrityParameters(cnf_smstempaltes.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_smstempaltes, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_smstempaltesEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_smstempaltesDataAccess.GetAllcnf_smstempaltes"));
            }	
        }
		
        async Task<IList<cnf_smstempaltesEntity>> Icnf_smstempaltesDataAccessObjects.GetAllByPages(cnf_smstempaltesEntity cnf_smstempaltes, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "cnf_smstempaltes_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_smstempaltes.SortExpression);
                    AddPageSizeParameter(cmd, cnf_smstempaltes.PageSize);
                    AddCurrentPageParameter(cmd, cnf_smstempaltes.CurrentPage);                    
                    FillSequrityParameters(cnf_smstempaltes.BaseSecurityParam, cmd, Database);
                    
					FillParameters(cnf_smstempaltes, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (cnf_smstempaltes.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+cnf_smstempaltes.strCommonSerachParam+"%");

                    IList<cnf_smstempaltesEntity> itemList = new List<cnf_smstempaltesEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_smstempaltesEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						cnf_smstempaltes.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_smstempaltesDataAccess.GetAllByPagescnf_smstempaltes"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<cnf_smstempaltesEntity> Icnf_smstempaltesDataAccessObjects.GetSingle(cnf_smstempaltesEntity cnf_smstempaltes, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "cnf_smstempaltes_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(cnf_smstempaltes.BaseSecurityParam, cmd, Database);
                    FillParameters(cnf_smstempaltes, cmd, Database);
                    
                    IList<cnf_smstempaltesEntity> itemList = new List<cnf_smstempaltesEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_smstempaltesEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Icnf_smstempaltesDataAccess.GetSinglecnf_smstempaltes"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<cnf_smstempaltesEntity>> Icnf_smstempaltesDataAccessObjects.GAPgListView(cnf_smstempaltesEntity cnf_smstempaltes, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "cnf_smstempaltes_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, cnf_smstempaltes.SortExpression);
                    AddPageSizeParameter(cmd, cnf_smstempaltes.PageSize);
                    AddCurrentPageParameter(cmd, cnf_smstempaltes.CurrentPage);                    
                    FillSequrityParameters(cnf_smstempaltes.BaseSecurityParam, cmd, Database);
                    
					FillParameters(cnf_smstempaltes, cmd,Database);
                    
					if (!string.IsNullOrEmpty (cnf_smstempaltes.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+cnf_smstempaltes.strCommonSerachParam+"%");

                    IList<cnf_smstempaltesEntity> itemList = new List<cnf_smstempaltesEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new cnf_smstempaltesEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						cnf_smstempaltes.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Icnf_smstempaltesDataAccess.GAPgListViewcnf_smstempaltes"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}