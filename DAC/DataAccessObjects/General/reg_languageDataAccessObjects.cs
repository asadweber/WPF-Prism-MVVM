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
	
	internal sealed partial class reg_languageDataAccessObjects : BaseDataAccess, Ireg_languageDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "reg_languageDataAccessObjects";
        
		public reg_languageDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(reg_languageEntity reg_language, DbCommand cmd,Database Database,bool forDelete=false)
        {
			if (reg_language.languageprofid.HasValue)
				Database.AddInParameter(cmd, "@LanguageProfID", DbType.Int64, reg_language.languageprofid);
            if (forDelete) return;
			if (reg_language.basicinfoid.HasValue)
				Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, reg_language.basicinfoid);
			if (reg_language.languageid.HasValue)
				Database.AddInParameter(cmd, "@LanguageID", DbType.Int64, reg_language.languageid);
			if (reg_language.speakingskillproficiencyid.HasValue)
				Database.AddInParameter(cmd, "@SpeakingSkillProficiencyID", DbType.Int64, reg_language.speakingskillproficiencyid);
			if (reg_language.readingskillproficiencyid.HasValue)
				Database.AddInParameter(cmd, "@ReadingSkillProficiencyID", DbType.Int64, reg_language.readingskillproficiencyid);
			if (reg_language.writingskillproficiencyid.HasValue)
				Database.AddInParameter(cmd, "@WritingSkillProficiencyID", DbType.Int64, reg_language.writingskillproficiencyid);
			if (!(string.IsNullOrEmpty(reg_language.comment)))
				Database.AddInParameter(cmd, "@Comment", DbType.String, reg_language.comment);
			if (!(string.IsNullOrEmpty(reg_language.remarks)))
				Database.AddInParameter(cmd, "@Remarks", DbType.String, reg_language.remarks);
			if (!(string.IsNullOrEmpty(reg_language.updateinfo)))
				Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, reg_language.updateinfo);
			if (reg_language.tranformactionid.HasValue)
				Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, reg_language.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Ireg_languageDataAccessObjects.Add(reg_languageEntity reg_language, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_language_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_language, cmd,Database);
                FillSequrityParameters(reg_language.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_languageDataAccess.Addreg_language"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Ireg_languageDataAccessObjects.Update(reg_languageEntity reg_language, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "reg_language_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(reg_language, cmd,Database);
                FillSequrityParameters(reg_language.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_languageDataAccess.Updatereg_language"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Ireg_languageDataAccessObjects.Delete(reg_languageEntity reg_language, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "reg_language_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(reg_language, cmd,Database, true);
                FillSequrityParameters(reg_language.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Ireg_languageDataAccess.Deletereg_language"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Ireg_languageDataAccessObjects.SaveList(IList<reg_languageEntity> listAdded, IList<reg_languageEntity> listUpdated, IList<reg_languageEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "reg_language_Ins";
            const string SPUpdate = "reg_language_Upd";
            const string SPDelete = "reg_language_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (reg_languageEntity reg_language in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_language, cmd, Database, true);
                            FillSequrityParameters(reg_language.BaseSecurityParam, cmd, Database);
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
                    foreach (reg_languageEntity reg_language in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_language, cmd, Database);
                            FillSequrityParameters(reg_language.BaseSecurityParam, cmd, Database);
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
                    foreach (reg_languageEntity reg_language in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_language, cmd, Database);
                            FillSequrityParameters(reg_language.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_languageDataAccess.Save_reg_language"));
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
       IList<reg_languageEntity> listAdded, 
       IList<reg_languageEntity> listUpdated, 
       IList<reg_languageEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "reg_language_Ins";
            const string SPUpdate = "reg_language_Upd";
            const string SPDelete = "reg_language_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (reg_languageEntity reg_language in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_language, cmd, db, true);
                            FillSequrityParameters(reg_language.BaseSecurityParam, cmd, db);
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
                    foreach (reg_languageEntity reg_language in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_language, cmd, db);
                            FillSequrityParameters(reg_language.BaseSecurityParam, cmd, db);
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
                    foreach (reg_languageEntity reg_language in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_language, cmd, db);
                            FillSequrityParameters(reg_language.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ireg_languageDataAccess.Save_reg_language"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<reg_languageEntity>> Ireg_languageDataAccessObjects.GetAll(reg_languageEntity reg_language, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_language_GA";
                IList<reg_languageEntity> itemList = new List<reg_languageEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, reg_language.SortExpression);
                    FillSequrityParameters(reg_language.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_language, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_languageEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_languageDataAccess.GetAllreg_language"));
            }	
        }
		
        async Task<IList<reg_languageEntity>> Ireg_languageDataAccessObjects.GetAllByPages(reg_languageEntity reg_language, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "reg_language_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_language.SortExpression);
                    AddPageSizeParameter(cmd, reg_language.PageSize);
                    AddCurrentPageParameter(cmd, reg_language.CurrentPage);                    
                    FillSequrityParameters(reg_language.BaseSecurityParam, cmd, Database);
                    
					FillParameters(reg_language, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (reg_language.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+reg_language.strCommonSerachParam+"%");

                    IList<reg_languageEntity> itemList = new List<reg_languageEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_languageEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						reg_language.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_languageDataAccess.GetAllByPagesreg_language"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<reg_languageEntity> Ireg_languageDataAccessObjects.GetSingle(reg_languageEntity reg_language, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_language_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(reg_language.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_language, cmd, Database);
                    
                    IList<reg_languageEntity> itemList = new List<reg_languageEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_languageEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_languageDataAccess.GetSinglereg_language"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<reg_languageEntity>> Ireg_languageDataAccessObjects.GAPgListView(reg_languageEntity reg_language, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "reg_language_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_language.SortExpression);
                    AddPageSizeParameter(cmd, reg_language.PageSize);
                    AddCurrentPageParameter(cmd, reg_language.CurrentPage);                    
                    FillSequrityParameters(reg_language.BaseSecurityParam, cmd, Database);
                    
					FillParameters(reg_language, cmd,Database);
                    
					if (!string.IsNullOrEmpty (reg_language.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+reg_language.strCommonSerachParam+"%");

                    IList<reg_languageEntity> itemList = new List<reg_languageEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_languageEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						reg_language.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_languageDataAccess.GAPgListViewreg_language"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}