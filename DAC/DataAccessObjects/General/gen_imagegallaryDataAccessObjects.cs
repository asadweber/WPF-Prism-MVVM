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
	
	internal sealed partial class gen_imagegallaryDataAccessObjects : BaseDataAccess, Igen_imagegallaryDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_imagegallaryDataAccessObjects";
        
		public gen_imagegallaryDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_imagegallaryEntity gen_imagegallary, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_imagegallary.imagegallaryid.HasValue)
				Database.AddInParameter(cmd, "@ImageGallaryID", DbType.Int64, gen_imagegallary.imagegallaryid);
            if (forDelete) return;
			if (gen_imagegallary.imagegallarycategoryid.HasValue)
				Database.AddInParameter(cmd, "@ImageGallaryCategoryID", DbType.Int64, gen_imagegallary.imagegallarycategoryid);
			if (!(string.IsNullOrEmpty(gen_imagegallary.imagepath)))
				Database.AddInParameter(cmd, "@ImagePath", DbType.String, gen_imagegallary.imagepath);
			if (!(string.IsNullOrEmpty(gen_imagegallary.imagetype)))
				Database.AddInParameter(cmd, "@ImageType", DbType.String, gen_imagegallary.imagetype);
			if (!(string.IsNullOrEmpty(gen_imagegallary.imageextension)))
				Database.AddInParameter(cmd, "@ImageExtension", DbType.String, gen_imagegallary.imageextension);
			if (!(string.IsNullOrEmpty(gen_imagegallary.imagename)))
				Database.AddInParameter(cmd, "@ImageName", DbType.String, gen_imagegallary.imagename);
			if (!(string.IsNullOrEmpty(gen_imagegallary.headingtextar)))
				Database.AddInParameter(cmd, "@HeadingTextAR", DbType.String, gen_imagegallary.headingtextar);
			if (!(string.IsNullOrEmpty(gen_imagegallary.headingtext)))
				Database.AddInParameter(cmd, "@HeadingText", DbType.String, gen_imagegallary.headingtext);
			if (!(string.IsNullOrEmpty(gen_imagegallary.bodytextar)))
				Database.AddInParameter(cmd, "@BodyTextAR", DbType.String, gen_imagegallary.bodytextar);
			if (!(string.IsNullOrEmpty(gen_imagegallary.bodytext)))
				Database.AddInParameter(cmd, "@BodyText", DbType.String, gen_imagegallary.bodytext);
			if ((gen_imagegallary.isslider != null))
				Database.AddInParameter(cmd, "@IsSlider", DbType.Boolean, gen_imagegallary.isslider);

        }
		
        
		#region Add Operation

        async Task<long> Igen_imagegallaryDataAccessObjects.Add(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_imagegallary_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_imagegallary, cmd,Database);
                FillSequrityParameters(gen_imagegallary.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_imagegallaryDataAccess.Addgen_imagegallary"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_imagegallaryDataAccessObjects.Update(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_imagegallary_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_imagegallary, cmd,Database);
                FillSequrityParameters(gen_imagegallary.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_imagegallaryDataAccess.Updategen_imagegallary"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_imagegallaryDataAccessObjects.Delete(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_imagegallary_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_imagegallary, cmd,Database, true);
                FillSequrityParameters(gen_imagegallary.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_imagegallaryDataAccess.Deletegen_imagegallary"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_imagegallaryDataAccessObjects.SaveList(IList<gen_imagegallaryEntity> listAdded, IList<gen_imagegallaryEntity> listUpdated, IList<gen_imagegallaryEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_imagegallary_Ins";
            const string SPUpdate = "gen_imagegallary_Upd";
            const string SPDelete = "gen_imagegallary_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_imagegallaryEntity gen_imagegallary in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_imagegallary, cmd, Database, true);
                            FillSequrityParameters(gen_imagegallary.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_imagegallaryEntity gen_imagegallary in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_imagegallary, cmd, Database);
                            FillSequrityParameters(gen_imagegallary.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_imagegallaryEntity gen_imagegallary in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_imagegallary, cmd, Database);
                            FillSequrityParameters(gen_imagegallary.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_imagegallaryDataAccess.Save_gen_imagegallary"));
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
       IList<gen_imagegallaryEntity> listAdded, 
       IList<gen_imagegallaryEntity> listUpdated, 
       IList<gen_imagegallaryEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_imagegallary_Ins";
            const string SPUpdate = "gen_imagegallary_Upd";
            const string SPDelete = "gen_imagegallary_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_imagegallaryEntity gen_imagegallary in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_imagegallary, cmd, db, true);
                            FillSequrityParameters(gen_imagegallary.BaseSecurityParam, cmd, db);
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
                    foreach (gen_imagegallaryEntity gen_imagegallary in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_imagegallary, cmd, db);
                            FillSequrityParameters(gen_imagegallary.BaseSecurityParam, cmd, db);
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
                    foreach (gen_imagegallaryEntity gen_imagegallary in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_imagegallary, cmd, db);
                            FillSequrityParameters(gen_imagegallary.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_imagegallaryDataAccess.Save_gen_imagegallary"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_imagegallaryEntity>> Igen_imagegallaryDataAccessObjects.GetAll(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_imagegallary_GA";
                IList<gen_imagegallaryEntity> itemList = new List<gen_imagegallaryEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_imagegallary.SortExpression);
                    FillSequrityParameters(gen_imagegallary.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_imagegallary, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_imagegallaryEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_imagegallaryDataAccess.GetAllgen_imagegallary"));
            }	
        }
		
        async Task<IList<gen_imagegallaryEntity>> Igen_imagegallaryDataAccessObjects.GetAllByPages(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_imagegallary_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_imagegallary.SortExpression);
                    AddPageSizeParameter(cmd, gen_imagegallary.PageSize);
                    AddCurrentPageParameter(cmd, gen_imagegallary.CurrentPage);                    
                    FillSequrityParameters(gen_imagegallary.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_imagegallary, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_imagegallary.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_imagegallary.strCommonSerachParam+"%");

                    IList<gen_imagegallaryEntity> itemList = new List<gen_imagegallaryEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_imagegallaryEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_imagegallary.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_imagegallaryDataAccess.GetAllByPagesgen_imagegallary"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<gen_imagegallaryEntity> Igen_imagegallaryDataAccessObjects.GetSingle(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_imagegallary_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_imagegallary.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_imagegallary, cmd, Database);
                    
                    IList<gen_imagegallaryEntity> itemList = new List<gen_imagegallaryEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_imagegallaryEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_imagegallaryDataAccess.GetSinglegen_imagegallary"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_imagegallaryEntity>> Igen_imagegallaryDataAccessObjects.GAPgListView(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_imagegallary_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_imagegallary.SortExpression);
                    AddPageSizeParameter(cmd, gen_imagegallary.PageSize);
                    AddCurrentPageParameter(cmd, gen_imagegallary.CurrentPage);                    
                    FillSequrityParameters(gen_imagegallary.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_imagegallary, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_imagegallary.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_imagegallary.strCommonSerachParam+"%");

                    IList<gen_imagegallaryEntity> itemList = new List<gen_imagegallaryEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_imagegallaryEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_imagegallary.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_imagegallaryDataAccess.GAPgListViewgen_imagegallary"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}