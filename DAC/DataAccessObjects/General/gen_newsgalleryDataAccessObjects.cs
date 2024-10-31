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
	
	internal sealed partial class gen_newsgalleryDataAccessObjects : BaseDataAccess, Igen_newsgalleryDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_newsgalleryDataAccessObjects";
        
		public gen_newsgalleryDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_newsgalleryEntity gen_newsgallery, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_newsgallery.newsgalleryid.HasValue)
				Database.AddInParameter(cmd, "@NewsGalleryID", DbType.Int64, gen_newsgallery.newsgalleryid);
            if (forDelete) return;
			if (gen_newsgallery.newsid.HasValue)
				Database.AddInParameter(cmd, "@NewsID", DbType.Int64, gen_newsgallery.newsid);
			if (!(string.IsNullOrEmpty(gen_newsgallery.imagepath)))
				Database.AddInParameter(cmd, "@ImagePath", DbType.String, gen_newsgallery.imagepath);
			if (!(string.IsNullOrEmpty(gen_newsgallery.imagetype)))
				Database.AddInParameter(cmd, "@ImageType", DbType.String, gen_newsgallery.imagetype);
			if (!(string.IsNullOrEmpty(gen_newsgallery.imageextension)))
				Database.AddInParameter(cmd, "@ImageExtension", DbType.String, gen_newsgallery.imageextension);
			if (!(string.IsNullOrEmpty(gen_newsgallery.imagename)))
				Database.AddInParameter(cmd, "@ImageName", DbType.String, gen_newsgallery.imagename);
			if ((gen_newsgallery.isslider != null))
				Database.AddInParameter(cmd, "@IsSlider", DbType.Boolean, gen_newsgallery.isslider);

        }
		
        
		#region Add Operation

        async Task<long> Igen_newsgalleryDataAccessObjects.Add(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_newsgallery_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_newsgallery, cmd,Database);
                FillSequrityParameters(gen_newsgallery.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_newsgalleryDataAccess.Addgen_newsgallery"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_newsgalleryDataAccessObjects.Update(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_newsgallery_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_newsgallery, cmd,Database);
                FillSequrityParameters(gen_newsgallery.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_newsgalleryDataAccess.Updategen_newsgallery"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_newsgalleryDataAccessObjects.Delete(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_newsgallery_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_newsgallery, cmd,Database, true);
                FillSequrityParameters(gen_newsgallery.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_newsgalleryDataAccess.Deletegen_newsgallery"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_newsgalleryDataAccessObjects.SaveList(IList<gen_newsgalleryEntity> listAdded, IList<gen_newsgalleryEntity> listUpdated, IList<gen_newsgalleryEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_newsgallery_Ins";
            const string SPUpdate = "gen_newsgallery_Upd";
            const string SPDelete = "gen_newsgallery_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_newsgalleryEntity gen_newsgallery in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_newsgallery, cmd, Database, true);
                            FillSequrityParameters(gen_newsgallery.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_newsgalleryEntity gen_newsgallery in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_newsgallery, cmd, Database);
                            FillSequrityParameters(gen_newsgallery.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_newsgalleryEntity gen_newsgallery in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_newsgallery, cmd, Database);
                            FillSequrityParameters(gen_newsgallery.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_newsgalleryDataAccess.Save_gen_newsgallery"));
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
       IList<gen_newsgalleryEntity> listAdded, 
       IList<gen_newsgalleryEntity> listUpdated, 
       IList<gen_newsgalleryEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_newsgallery_Ins";
            const string SPUpdate = "gen_newsgallery_Upd";
            const string SPDelete = "gen_newsgallery_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_newsgalleryEntity gen_newsgallery in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_newsgallery, cmd, db, true);
                            FillSequrityParameters(gen_newsgallery.BaseSecurityParam, cmd, db);
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
                    foreach (gen_newsgalleryEntity gen_newsgallery in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_newsgallery, cmd, db);
                            FillSequrityParameters(gen_newsgallery.BaseSecurityParam, cmd, db);
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
                    foreach (gen_newsgalleryEntity gen_newsgallery in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_newsgallery, cmd, db);
                            FillSequrityParameters(gen_newsgallery.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_newsgalleryDataAccess.Save_gen_newsgallery"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_newsgalleryEntity>> Igen_newsgalleryDataAccessObjects.GetAll(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_newsgallery_GA";
                IList<gen_newsgalleryEntity> itemList = new List<gen_newsgalleryEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_newsgallery.SortExpression);
                    FillSequrityParameters(gen_newsgallery.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_newsgallery, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_newsgalleryEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_newsgalleryDataAccess.GetAllgen_newsgallery"));
            }	
        }
		
        async Task<IList<gen_newsgalleryEntity>> Igen_newsgalleryDataAccessObjects.GetAllByPages(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_newsgallery_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_newsgallery.SortExpression);
                    AddPageSizeParameter(cmd, gen_newsgallery.PageSize);
                    AddCurrentPageParameter(cmd, gen_newsgallery.CurrentPage);                    
                    FillSequrityParameters(gen_newsgallery.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_newsgallery, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_newsgallery.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_newsgallery.strCommonSerachParam+"%");

                    IList<gen_newsgalleryEntity> itemList = new List<gen_newsgalleryEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_newsgalleryEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_newsgallery.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_newsgalleryDataAccess.GetAllByPagesgen_newsgallery"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<gen_newsgalleryEntity> Igen_newsgalleryDataAccessObjects.GetSingle(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_newsgallery_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_newsgallery.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_newsgallery, cmd, Database);
                    
                    IList<gen_newsgalleryEntity> itemList = new List<gen_newsgalleryEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_newsgalleryEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_newsgalleryDataAccess.GetSinglegen_newsgallery"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_newsgalleryEntity>> Igen_newsgalleryDataAccessObjects.GAPgListView(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_newsgallery_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_newsgallery.SortExpression);
                    AddPageSizeParameter(cmd, gen_newsgallery.PageSize);
                    AddCurrentPageParameter(cmd, gen_newsgallery.CurrentPage);                    
                    FillSequrityParameters(gen_newsgallery.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_newsgallery, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_newsgallery.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_newsgallery.strCommonSerachParam+"%");

                    IList<gen_newsgalleryEntity> itemList = new List<gen_newsgalleryEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_newsgalleryEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_newsgallery.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_newsgalleryDataAccess.GAPgListViewgen_newsgallery"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}
