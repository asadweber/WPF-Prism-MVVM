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
	
	internal sealed partial class gen_faqDataAccessObjects : BaseDataAccess, Igen_faqDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "gen_faqDataAccessObjects";
        
		public gen_faqDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(gen_faqEntity gen_faq, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (gen_faq.faqid.HasValue)
				Database.AddInParameter(cmd, "@FAQID", DbType.Int64, gen_faq.faqid);
            if (forDelete) return;
			if (gen_faq.faqcategoryid.HasValue)
				Database.AddInParameter(cmd, "@FAQCategoryID", DbType.Int64, gen_faq.faqcategoryid);
			if (!(string.IsNullOrEmpty(gen_faq.questions)))
				Database.AddInParameter(cmd, "@Questions", DbType.String, gen_faq.questions);
			if (!(string.IsNullOrEmpty(gen_faq.answers)))
				Database.AddInParameter(cmd, "@Answers", DbType.String, gen_faq.answers);
			if (!(string.IsNullOrEmpty(gen_faq.questionsen)))
				Database.AddInParameter(cmd, "@QuestionsEn", DbType.String, gen_faq.questionsen);
			if (!(string.IsNullOrEmpty(gen_faq.answersen)))
				Database.AddInParameter(cmd, "@AnswersEn", DbType.String, gen_faq.answersen);
			if (!(string.IsNullOrEmpty(gen_faq.tags)))
				Database.AddInParameter(cmd, "@TAGS", DbType.String, gen_faq.tags);
			if (!(string.IsNullOrEmpty(gen_faq.urls)))
				Database.AddInParameter(cmd, "@URLS", DbType.String, gen_faq.urls);

        }
		
        
		#region Add Operation

        async Task<long> Igen_faqDataAccessObjects.Add(gen_faqEntity gen_faq, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_faq_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_faq, cmd,Database);
                FillSequrityParameters(gen_faq.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_faqDataAccess.Addgen_faq"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Igen_faqDataAccessObjects.Update(gen_faqEntity gen_faq, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "gen_faq_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(gen_faq, cmd,Database);
                FillSequrityParameters(gen_faq.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Igen_faqDataAccess.Updategen_faq"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Igen_faqDataAccessObjects.Delete(gen_faqEntity gen_faq, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "gen_faq_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(gen_faq, cmd,Database, true);
                FillSequrityParameters(gen_faq.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Igen_faqDataAccess.Deletegen_faq"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Igen_faqDataAccessObjects.SaveList(IList<gen_faqEntity> listAdded, IList<gen_faqEntity> listUpdated, IList<gen_faqEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "gen_faq_Ins";
            const string SPUpdate = "gen_faq_Upd";
            const string SPDelete = "gen_faq_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_faqEntity gen_faq in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_faq, cmd, Database, true);
                            FillSequrityParameters(gen_faq.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_faqEntity gen_faq in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_faq, cmd, Database);
                            FillSequrityParameters(gen_faq.BaseSecurityParam, cmd, Database);
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
                    foreach (gen_faqEntity gen_faq in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_faq, cmd, Database);
                            FillSequrityParameters(gen_faq.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Igen_faqDataAccess.Save_gen_faq"));
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
       IList<gen_faqEntity> listAdded, 
       IList<gen_faqEntity> listUpdated, 
       IList<gen_faqEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "gen_faq_Ins";
            const string SPUpdate = "gen_faq_Upd";
            const string SPDelete = "gen_faq_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (gen_faqEntity gen_faq in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(gen_faq, cmd, db, true);
                            FillSequrityParameters(gen_faq.BaseSecurityParam, cmd, db);
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
                    foreach (gen_faqEntity gen_faq in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(gen_faq, cmd, db);
                            FillSequrityParameters(gen_faq.BaseSecurityParam, cmd, db);
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
                    foreach (gen_faqEntity gen_faq in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(gen_faq, cmd, db);
                            FillSequrityParameters(gen_faq.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Igen_faqDataAccess.Save_gen_faq"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<gen_faqEntity>> Igen_faqDataAccessObjects.GetAll(gen_faqEntity gen_faq, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_faq_GA";
                IList<gen_faqEntity> itemList = new List<gen_faqEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, gen_faq.SortExpression);
                    FillSequrityParameters(gen_faq.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_faq, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_faqEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_faqDataAccess.GetAllgen_faq"));
            }	
        }
		
        async Task<IList<gen_faqEntity>> Igen_faqDataAccessObjects.GetAllByPages(gen_faqEntity gen_faq, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_faq_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_faq.SortExpression);
                    AddPageSizeParameter(cmd, gen_faq.PageSize);
                    AddCurrentPageParameter(cmd, gen_faq.CurrentPage);                    
                    FillSequrityParameters(gen_faq.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_faq, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (gen_faq.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_faq.strCommonSerachParam+"%");

                    IList<gen_faqEntity> itemList = new List<gen_faqEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_faqEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_faq.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_faqDataAccess.GetAllByPagesgen_faq"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<gen_faqEntity> Igen_faqDataAccessObjects.GetSingle(gen_faqEntity gen_faq, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "gen_faq_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(gen_faq.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_faq, cmd, Database);
                    
                    IList<gen_faqEntity> itemList = new List<gen_faqEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_faqEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_faqDataAccess.GetSinglegen_faq"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<gen_faqEntity>> Igen_faqDataAccessObjects.GAPgListView(gen_faqEntity gen_faq, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "gen_faq_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_faq.SortExpression);
                    AddPageSizeParameter(cmd, gen_faq.PageSize);
                    AddCurrentPageParameter(cmd, gen_faq.CurrentPage);                    
                    FillSequrityParameters(gen_faq.BaseSecurityParam, cmd, Database);
                    
					FillParameters(gen_faq, cmd,Database);
                    
					if (!string.IsNullOrEmpty (gen_faq.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+gen_faq.strCommonSerachParam+"%");

                    IList<gen_faqEntity> itemList = new List<gen_faqEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_faqEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_faq.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_faqDataAccess.GAPgListViewgen_faq"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}