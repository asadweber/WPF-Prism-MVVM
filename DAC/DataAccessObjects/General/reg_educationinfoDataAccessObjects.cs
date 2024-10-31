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
	
	internal sealed partial class reg_educationinfoDataAccessObjects : BaseDataAccess, Ireg_educationinfoDataAccessObjects
	{
		
	    #region Constructors
        
		private string ClassName = "reg_educationinfoDataAccessObjects";
        
		public reg_educationinfoDataAccessObjects(Context context): base(context)
		{
		}
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        
		#endregion
		
        public static void FillParameters(reg_educationinfoEntity reg_educationinfo, DbCommand cmd,Database Database,bool forDelete=false)
        {
            if (reg_educationinfo.educationid.HasValue)
                Database.AddInParameter(cmd, "@EducationID", DbType.Int64, reg_educationinfo.educationid);
            if (forDelete) return;
            if (reg_educationinfo.basicinfoid.HasValue)
                Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, reg_educationinfo.basicinfoid);
            
            if (reg_educationinfo.batchcandcertificateid.HasValue)
                Database.AddInParameter(cmd, "@BatchCandCertificateID", DbType.Int64, reg_educationinfo.batchcandcertificateid);


            if (reg_educationinfo.certificatelevelid.HasValue)
                Database.AddInParameter(cmd, "@CertificateLevelID", DbType.Int64, reg_educationinfo.certificatelevelid);
            if (reg_educationinfo.certificateid.HasValue)
                Database.AddInParameter(cmd, "@CertificateID", DbType.Int64, reg_educationinfo.certificateid);
            if (reg_educationinfo.certificatesubjectid.HasValue)
                Database.AddInParameter(cmd, "@CertificateSubjectID", DbType.Int64, reg_educationinfo.certificatesubjectid);
            if (reg_educationinfo.educationshiftid.HasValue)
                Database.AddInParameter(cmd, "@EducationShiftID", DbType.Int64, reg_educationinfo.educationshiftid);
            if (reg_educationinfo.edugradeid.HasValue)
                Database.AddInParameter(cmd, "@EduGradeID", DbType.Int64, reg_educationinfo.edugradeid);
            if (reg_educationinfo.edumajorid.HasValue)
                Database.AddInParameter(cmd, "@EduMajorID", DbType.Int64, reg_educationinfo.edumajorid);
            if (reg_educationinfo.instituteid.HasValue)
                Database.AddInParameter(cmd, "@InstituteID", DbType.Int64, reg_educationinfo.instituteid);
            if (reg_educationinfo.countryid.HasValue)
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, reg_educationinfo.countryid);
            if ((reg_educationinfo.passyear.HasValue))
                Database.AddInParameter(cmd, "@PassYear", DbType.DateTime, reg_educationinfo.passyear);
            if ((reg_educationinfo.ispercentage != null))
                Database.AddInParameter(cmd, "@IsPercentage", DbType.Boolean, reg_educationinfo.ispercentage);
            if (reg_educationinfo.points.HasValue)
                Database.AddInParameter(cmd, "@Points", DbType.Decimal, reg_educationinfo.points);
            if (!(string.IsNullOrEmpty(reg_educationinfo.grade)))
                Database.AddInParameter(cmd, "@Grade", DbType.String, reg_educationinfo.grade);
            if (!(string.IsNullOrEmpty(reg_educationinfo.institutename)))
                Database.AddInParameter(cmd, "@InstituteName", DbType.String, reg_educationinfo.institutename);
            if ((reg_educationinfo.isstudying != null))
                Database.AddInParameter(cmd, "@IsStudying", DbType.Boolean, reg_educationinfo.isstudying);
            if (reg_educationinfo.newinstituteid.HasValue)
                Database.AddInParameter(cmd, "@NewInstituteID", DbType.Int64, reg_educationinfo.newinstituteid);
            if (!(string.IsNullOrEmpty(reg_educationinfo.semestername)))
                Database.AddInParameter(cmd, "@SemesterName", DbType.String, reg_educationinfo.semestername);
            if (!(string.IsNullOrEmpty(reg_educationinfo.filepath)))
                Database.AddInParameter(cmd, "@FilePath", DbType.String, reg_educationinfo.filepath);
            if (!(string.IsNullOrEmpty(reg_educationinfo.filename)))
                Database.AddInParameter(cmd, "@FileName", DbType.String, reg_educationinfo.filename);
            if (!(string.IsNullOrEmpty(reg_educationinfo.filetype)))
                Database.AddInParameter(cmd, "@FileType", DbType.String, reg_educationinfo.filetype);
            if (!(string.IsNullOrEmpty(reg_educationinfo.extension)))
                Database.AddInParameter(cmd, "@Extension", DbType.String, reg_educationinfo.extension);
            if (!(string.IsNullOrEmpty(reg_educationinfo.comment)))
                Database.AddInParameter(cmd, "@Comment", DbType.String, reg_educationinfo.comment);
            if (!(string.IsNullOrEmpty(reg_educationinfo.remarks)))
                Database.AddInParameter(cmd, "@Remarks", DbType.String, reg_educationinfo.remarks);
            if (!(string.IsNullOrEmpty(reg_educationinfo.updateinfo)))
                Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, reg_educationinfo.updateinfo);
            if (reg_educationinfo.tranformactionid.HasValue)
                Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, reg_educationinfo.tranformactionid);

        }
		
        
		#region Add Operation

        async Task<long> Ireg_educationinfoDataAccessObjects.Add(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_educationinfo_Ins";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_educationinfo, cmd,Database);
                FillSequrityParameters(reg_educationinfo.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_educationinfoDataAccess.Addreg_educationinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
       
        #endregion Add Operation
		
		#region Update Operation

        async Task<long> Ireg_educationinfoDataAccessObjects.Update(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken)
        {
           long returnCode = -99;
            const string SP = "reg_educationinfo_Upd";
			
            using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
			    FillParameters(reg_educationinfo, cmd,Database);
                FillSequrityParameters(reg_educationinfo.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_educationinfoDataAccess.Updatereg_educationinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
		
		#region Delete Operation

        async Task<long> Ireg_educationinfoDataAccessObjects.Delete(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
           	const string SP = "reg_educationinfo_Del";
			
           	using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
				FillParameters(reg_educationinfo, cmd,Database, true);
                FillSequrityParameters(reg_educationinfo.BaseSecurityParam, cmd, Database);
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
                   throw GetDataAccessException(ex, SourceOfException("Ireg_educationinfoDataAccess.Deletereg_educationinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

		#endregion Delete Operation
        
        #region SaveList<>
		
        async Task<long> Ireg_educationinfoDataAccessObjects.SaveList(IList<reg_educationinfoEntity> listAdded, IList<reg_educationinfoEntity> listUpdated, IList<reg_educationinfoEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "reg_educationinfo_Ins";
            const string SPUpdate = "reg_educationinfo_Upd";
            const string SPDelete = "reg_educationinfo_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (reg_educationinfoEntity reg_educationinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_educationinfo, cmd, Database, true);
                            FillSequrityParameters(reg_educationinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (reg_educationinfoEntity reg_educationinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_educationinfo, cmd, Database);
                            FillSequrityParameters(reg_educationinfo.BaseSecurityParam, cmd, Database);
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
                    foreach (reg_educationinfoEntity reg_educationinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_educationinfo, cmd, Database);
                            FillSequrityParameters(reg_educationinfo.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_educationinfoDataAccess.Save_reg_educationinfo"));
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
       IList<reg_educationinfoEntity> listAdded, 
       IList<reg_educationinfoEntity> listUpdated, 
       IList<reg_educationinfoEntity> listDeleted, 
       CancellationToken cancellationToken) 
       {
            long returnCode = -99;

            const string SPInsert = "reg_educationinfo_Ins";
            const string SPUpdate = "reg_educationinfo_Upd";
            const string SPDelete = "reg_educationinfo_Del";

            
            
            try
            {
                if (listDeleted.Count > 0 )
                {
                    foreach (reg_educationinfoEntity reg_educationinfo in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_educationinfo, cmd, db, true);
                            FillSequrityParameters(reg_educationinfo.BaseSecurityParam, cmd, db);
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
                    foreach (reg_educationinfoEntity reg_educationinfo in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_educationinfo, cmd, db);
                            FillSequrityParameters(reg_educationinfo.BaseSecurityParam, cmd, db);
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
                    foreach (reg_educationinfoEntity reg_educationinfo in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_educationinfo, cmd, db);
                            FillSequrityParameters(reg_educationinfo.BaseSecurityParam, cmd, db);
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
               
                throw GetDataAccessException(ex, SourceOfException("Ireg_educationinfoDataAccess.Save_reg_educationinfo"));
            }
            finally
            {
               
            }
            return returnCode;
        }
        
        #endregion SaveList<>
		
		#region GetAll

        async Task<IList<reg_educationinfoEntity>> Ireg_educationinfoDataAccessObjects.GetAll(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_educationinfo_GA";
                IList<reg_educationinfoEntity> itemList = new List<reg_educationinfoEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, reg_educationinfo.SortExpression);
                    FillSequrityParameters(reg_educationinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_educationinfo, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_educationinfoEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_educationinfoDataAccess.GetAllreg_educationinfo"));
            }	
        }
		
        async Task<IList<reg_educationinfoEntity>> Ireg_educationinfoDataAccessObjects.GetAllByPages(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "reg_educationinfo_GAPg";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_educationinfo.SortExpression);
                    AddPageSizeParameter(cmd, reg_educationinfo.PageSize);
                    AddCurrentPageParameter(cmd, reg_educationinfo.CurrentPage);                    
                    FillSequrityParameters(reg_educationinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(reg_educationinfo, cmd,Database);
                    
                    if (!string.IsNullOrEmpty (reg_educationinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+reg_educationinfo.strCommonSerachParam+"%");

                    IList<reg_educationinfoEntity> itemList = new List<reg_educationinfoEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_educationinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						reg_educationinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_educationinfoDataAccess.GetAllByPagesreg_educationinfo"));
            }
        }
        
        #endregion
        
        #region Save Master/Details
        
        #endregion
        
        
        #region Simple load Single Row
        async Task<reg_educationinfoEntity> Ireg_educationinfoDataAccessObjects.GetSingle(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_educationinfo_GS";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
                    FillSequrityParameters(reg_educationinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_educationinfo, cmd, Database);
                    
                    IList<reg_educationinfoEntity> itemList = new List<reg_educationinfoEntity>();
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_educationinfoEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_educationinfoDataAccess.GetSinglereg_educationinfo"));
            }	
        }
        #endregion
        
        #region ForListView Paged Method
        async Task<IList<reg_educationinfoEntity>> Ireg_educationinfoDataAccessObjects.GAPgListView(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken)
        {
        try
            {
				const string SP = "reg_educationinfo_GAPgListView";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_educationinfo.SortExpression);
                    AddPageSizeParameter(cmd, reg_educationinfo.PageSize);
                    AddCurrentPageParameter(cmd, reg_educationinfo.CurrentPage);                    
                    FillSequrityParameters(reg_educationinfo.BaseSecurityParam, cmd, Database);
                    
					FillParameters(reg_educationinfo, cmd,Database);
                    
					if (!string.IsNullOrEmpty (reg_educationinfo.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String,  "%"+reg_educationinfo.strCommonSerachParam+"%");

                    IList<reg_educationinfoEntity> itemList = new List<reg_educationinfoEntity>();
					
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_educationinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    
                    if(itemList.Count>0)
					{
                        itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						reg_educationinfo.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_educationinfoDataAccess.GAPgListViewreg_educationinfo"));
            }
        }
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion
        
            
	}
}