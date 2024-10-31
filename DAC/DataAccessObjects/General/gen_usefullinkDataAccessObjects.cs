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
	
	internal sealed partial class gen_usefullinkDataAccessObjects : BaseDataAccess, Igen_usefullinkDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_usefullinkDataAccessObjects";
        
		public gen_usefullinkDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_usefullinkEntity gen_usefullink, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_usefullink.usefullinkid.HasValue)
				Database.AddInParameter(cmd, "@UsefulLinkID", DbType.Int64, gen_usefullink.usefullinkid);
            if (forDelete) return;
			if (gen_usefullink.usefullinkcategoryid.HasValue)
				Database.AddInParameter(cmd, "@UsefulLinkCategoryID", DbType.Int64, gen_usefullink.usefullinkcategoryid);
			if (!(string.IsNullOrEmpty(gen_usefullink.usefullink)))
				Database.AddInParameter(cmd, "@UsefulLink", DbType.String, gen_usefullink.usefullink);
			if (!(string.IsNullOrEmpty(gen_usefullink.usefullinkar)))
				Database.AddInParameter(cmd, "@UsefulLinkAR", DbType.String, gen_usefullink.usefullinkar);
			if (!(string.IsNullOrEmpty(gen_usefullink.servicelogopath)))
				Database.AddInParameter(cmd, "@ServiceLogoPath", DbType.String, gen_usefullink.servicelogopath);
			if (!(string.IsNullOrEmpty(gen_usefullink.usefullinkurl)))
				Database.AddInParameter(cmd, "@UsefulLinkURL", DbType.String, gen_usefullink.usefullinkurl);
			if ((gen_usefullink.openinnewtab != null))
				Database.AddInParameter(cmd, "@OpenInNewTab", DbType.Boolean, gen_usefullink.openinnewtab);
			if (!(string.IsNullOrEmpty(gen_usefullink.usefullinkdescription)))
				Database.AddInParameter(cmd, "@UsefulLinkDescription", DbType.String, gen_usefullink.usefullinkdescription);
			if (!(string.IsNullOrEmpty(gen_usefullink.usefullinkdescriptionar)))
				Database.AddInParameter(cmd, "@UsefulLinkDescriptionAR", DbType.String, gen_usefullink.usefullinkdescriptionar);

        }
		
        
		#region Add Operation

        async Task<long> Igen_usefullinkDataAccessObjects.Add(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_usefullink_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_usefullink, cmd,Database);
                FillSequrityParameters(gen_usefullink.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_usefullinkDataAccess.Addgen_usefullink"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_usefullinkDataAccessObjects.Update(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_usefullink_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_usefullink, cmd,Database);
                FillSequrityParameters(gen_usefullink.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_usefullinkDataAccess.Updategen_usefullink"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_usefullinkDataAccessObjects.Delete(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_usefullink_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_usefullink, cmd,Database, true);
                FillSequrityParameters(gen_usefullink.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_usefullinkDataAccess.Deletegen_usefullink"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_usefullinkDataAccessObjects.SaveList(IList<gen_usefullinkEntity> listAdded, IList<gen_usefullinkEntity> listUpdated, IList<gen_usefullinkEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_usefullink_Ins";
            const string SPUpdate = "gen_usefullink_Upd";
            const string SPDelete = "gen_usefullink_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_usefullinkEntity gen_usefullink in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_usefullink, cmd, Database, true);
                            FillSequrityParameters(gen_usefullink.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_usefullinkEntity gen_usefullink in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_usefullink, cmd, Database);
                            FillSequrityParameters(gen_usefullink.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_usefullinkEntity gen_usefullink in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_usefullink, cmd, Database);
                            FillSequrityParameters(gen_usefullink.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_usefullinkDataAccess.Save_gen_usefullink"));
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
       IList<gen_usefullinkEntity> listAdded, 
       IList<gen_usefullinkEntity> listUpdated, 
       IList<gen_usefullinkEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_usefullink_Ins";
            const string SPUpdate = "gen_usefullink_Upd";
            const string SPDelete = "gen_usefullink_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_usefullinkEntity gen_usefullink in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_usefullink, cmd, db, true);
                            FillSequrityParameters(gen_usefullink.BaseSecurityParam, cmd, db);
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
                    foreach (gen_usefullinkEntity gen_usefullink in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_usefullink, cmd, db);
                            FillSequrityParameters(gen_usefullink.BaseSecurityParam, cmd, db);
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
                    foreach (gen_usefullinkEntity gen_usefullink in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_usefullink, cmd, db);
                            FillSequrityParameters(gen_usefullink.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_usefullinkDataAccess.Save_gen_usefullink"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_usefullinkEntity>> Igen_usefullinkDataAccessObjects.GetAll(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_usefullink_GA";
                IList<gen_usefullinkEntity> itemList = new List<gen_usefullinkEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_usefullink.SortExpression);
                    FillSequrityParameters(gen_usefullink.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_usefullink, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_usefullinkEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_usefullinkDataAccess.GetAllgen_usefullink"));
            }	
        }
		
        async Task<IList<gen_usefullinkEntity>> Igen_usefullinkDataAccessObjects.GetAllByPages(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_usefullink_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_usefullink.SortExpression);
                    AddPageSizeParameter(cmd, gen_usefullink.PageSize);
                    AddCurrentPageParameter(cmd, gen_usefullink.CurrentPage);                    
                    FillSequrityParameters(gen_usefullink.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_usefullink, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_usefullink.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_usefullink.strCommonSerachParam+"%");

                    IList<gen_usefullinkEntity> itemList = new List<gen_usefullinkEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_usefullinkEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_usefullink.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_usefullinkDataAccess.GetAllByPagesgen_usefullink"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<gen_usefullinkEntity> Igen_usefullinkDataAccessObjects.GetSingle(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_usefullink_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_usefullink.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_usefullink, cmd, Database);
                    
                    IList<gen_usefullinkEntity> itemList = new List<gen_usefullinkEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_usefullinkEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_usefullinkDataAccess.GetSinglegen_usefullink"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_usefullinkEntity>> Igen_usefullinkDataAccessObjects.GAPgListView(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_usefullink_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_usefullink.SortExpression);
                    AddPageSizeParameter(cmd, gen_usefullink.PageSize);
                    AddCurrentPageParameter(cmd, gen_usefullink.CurrentPage);                    
                    FillSequrityParameters(gen_usefullink.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_usefullink, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_usefullink.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_usefullink.strCommonSerachParam+"%");

                    IList<gen_usefullinkEntity> itemList = new List<gen_usefullinkEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_usefullinkEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_usefullink.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_usefullinkDataAccess.GAPgListViewgen_usefullink"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}