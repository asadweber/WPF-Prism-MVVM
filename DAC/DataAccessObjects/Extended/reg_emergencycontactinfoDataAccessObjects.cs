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
using System.Linq;
using BDO.Core.Base;
using CLL.LLClasses.Models;

namespace DAC.Core.DataAccessObjects.General
{
	/// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>
	
	internal sealed partial class reg_emergencycontactinfoDataAccessObjects 
	{
        async Task<long> Ireg_emergencycontactinfoDataAccessObjects.AddExt(reg_emergencycontactinfoEntity reg_emergencycontactinfodata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_emergencycontactinfo_Ins_ext";
			
			using (DbCommand cmd =  Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_emergencycontactinfodata, cmd,Database);
                FillSequrityParameters(reg_emergencycontactinfodata.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Itran_userpindataDataAccess.Addtran_userpindata"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }
        
        async Task<IList<reg_emergencycontactinfoEntity>> Ireg_emergencycontactinfoDataAccessObjects.GetAllExt(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
        {
           try
            {
				const string SP = "reg_emergencycontactinfo_GA_Ext";
                IList<reg_emergencycontactinfoEntity> itemList = new List<reg_emergencycontactinfoEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, reg_emergencycontactinfo.SortExpression);
                    FillSequrityParameters(reg_emergencycontactinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_emergencycontactinfo, cmd, Database);
                    
                    IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_emergencycontactinfoEntity(reader));
                        }
                        reader.Close();
                    }                    
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_emergencycontactinfoDataAccess.GetAllreg_emergencycontactinfo"));
            }	
        }

		async Task<long> Ireg_emergencycontactinfoDataAccessObjects.AddOrUpdate(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
		{
			long returnCode = -99;
		    string SP = "reg_emergencycontactinfo_Ins";
            if(reg_emergencycontactinfo.emergencycontactid.HasValue)
				SP = "reg_emergencycontactinfo_Upd";
			DbConnection connection = Database.CreateConnection();
			connection.Open();
			DbTransaction transaction = connection.BeginTransaction();
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillParameters(reg_emergencycontactinfo, cmd, Database);
                    FillSequrityParameters(reg_emergencycontactinfo.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);

                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    if (returnCode > 0) {
                        reg_emergencycontactinfo.RelativesWorkingInMOD.imergencycontactid = returnCode;
                        reg_emergencycontactinfo.RelativesWorkingInMOD.BaseSecurityParam = new BDO.Core.Base.SecurityCapsule();
                        reg_emergencycontactinfo.RelativesWorkingInMOD.BaseSecurityParam = reg_emergencycontactinfo.BaseSecurityParam;

                        if(reg_emergencycontactinfo.RelativesWorkingInMOD.regrelativesid.HasValue || reg_emergencycontactinfo.RelativesWorkingInMOD.HasMODRelative)
                        {
                            reg_relativesworkinginmodDataAccessObjects objReg_RelativesWorkingInMOD = new reg_relativesworkinginmodDataAccessObjects(this.Context);
                            await objReg_RelativesWorkingInMOD.AddOrUpdateOrDelete(Database, transaction, reg_emergencycontactinfo.RelativesWorkingInMOD, cancellationToken);
                        }
                    }
                    cmd.Dispose();
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccessObjects.AddOrUpdate"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
			return returnCode;
		}

        async Task<long> Ireg_emergencycontactinfoDataAccessObjects.ApplicantReviewAddOrUpdate(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            string SP = "reg_emergencycontactinfo_Ins";
            if (reg_emergencycontactinfo.emergencycontactid.HasValue)
                SP = "reg_emergencycontactinfo_Upd";
            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillParameters(reg_emergencycontactinfo, cmd, Database);
                    FillSequrityParameters(reg_emergencycontactinfo.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);

                    IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    returnCode = Database.EndExecuteNonQuery(result);
                    returnCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    if (returnCode > 0)
                    {
                        reg_emergencycontactinfo.RelativesWorkingInMOD.imergencycontactid = returnCode;
                        reg_emergencycontactinfo.RelativesWorkingInMOD.BaseSecurityParam = new BDO.Core.Base.SecurityCapsule();
                        reg_emergencycontactinfo.RelativesWorkingInMOD.BaseSecurityParam = reg_emergencycontactinfo.BaseSecurityParam;

                        if (reg_emergencycontactinfo.RelativesWorkingInMOD.regrelativesid.HasValue || reg_emergencycontactinfo.RelativesWorkingInMOD.HasMODRelative)
                        {
                            reg_relativesworkinginmodDataAccessObjects objReg_RelativesWorkingInMOD = new reg_relativesworkinginmodDataAccessObjects(this.Context);
                            await objReg_RelativesWorkingInMOD.AddOrUpdateOrDelete(Database, transaction, reg_emergencycontactinfo.RelativesWorkingInMOD, cancellationToken);
                        }

                        #region TABLE:Reg_DataChecked
                        reg_datacheckedDataAccessObjects objreg_datacheckedDataAccessObjects = new reg_datacheckedDataAccessObjects(this.Context);
                        var applicantTableID = reg_emergencycontactinfo.applicantTableID;
                        var objEntityRegDataChecked = await objreg_datacheckedDataAccessObjects.GetRegDataCheckedByApplicantTable(new reg_datacheckedEntity()
                        {
                            basicinfoid = reg_emergencycontactinfo.basicinfoid,
                            registrationid = reg_emergencycontactinfo.RegistrationID,
                            applicanttableid = applicantTableID
                        }, cancellationToken);
                        if (objEntityRegDataChecked != null)
                        {
                            objEntityRegDataChecked.reviewedbyid = reg_emergencycontactinfo.BaseSecurityParam.userid;
                            objEntityRegDataChecked.vieweddate = DateTime.Now;
                            objEntityRegDataChecked.BaseSecurityParam = new SecurityCapsule();
                            objEntityRegDataChecked.BaseSecurityParam = reg_emergencycontactinfo.BaseSecurityParam;
                            await objreg_datacheckedDataAccessObjects.UpdateRegDataCheckedByApplicantTable(Database, transaction, objEntityRegDataChecked, cancellationToken);
                        }
                        #endregion
                    }
                    cmd.Dispose();
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_basicinfoDataAccessObjects.ApplicantReviewAddOrUpdate"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        public async Task<List<reg_emergencycontactinfoEntity>> GetAllByBasicId(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "KAF_reg_emergencycontactinfo_GA_By_BasicID";
				List<reg_emergencycontactinfoEntity> itemList = new List<reg_emergencycontactinfoEntity>();
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{

					AddSortExpressionParameter(cmd, reg_emergencycontactinfo.SortExpression);
					FillSequrityParameters(reg_emergencycontactinfo.BaseSecurityParam, cmd, Database);
					FillParameters(reg_emergencycontactinfo, cmd, Database);

					IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
					while (!result.IsCompleted)
					{
					}
					using (IDataReader reader = Database.EndExecuteReader(result))
					{
						while (reader.Read())
						{
							itemList.Add(new reg_emergencycontactinfoEntity(reader));
						}
						reader.Close();
					}
					cmd.Dispose();
					if (itemList != null && itemList.Count > 0)
						return itemList;
					else
						return null;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Ireg_emergencycontactinfoDataAccess.GetAllreg_emergencycontactinfo"));
			}
		}

        async Task<reg_emergencycontactinfoEntity> Ireg_emergencycontactinfoDataAccessObjects.GetSingleById(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "reg_emergencycontactinfo_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(reg_emergencycontactinfo.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_emergencycontactinfo, cmd, Database);

                    IList<reg_emergencycontactinfoEntity> itemList = new List<reg_emergencycontactinfoEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_emergencycontactinfoEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();


                    if (itemList != null && itemList.Count > 0)
                    {
                        var objemergencycontactinfo = itemList.FirstOrDefault();
                        reg_relativesworkinginmodDataAccessObjects objreg_relativesworkinginmod = new reg_relativesworkinginmodDataAccessObjects(this.Context);
                        objemergencycontactinfo.RelativesWorkingInMOD = await objreg_relativesworkinginmod.GetAllByImergencyContactID(
                            new reg_relativesworkinginmodEntity() { imergencycontactid = objemergencycontactinfo.emergencycontactid }, cancellationToken);
                        return objemergencycontactinfo;
                    }
                    else
                        return new reg_emergencycontactinfoEntity();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_emergencycontactinfoDataAccess.GetSinglereg_emergencycontactinfo"));
            }
        }

        async Task<long> Ireg_emergencycontactinfoDataAccessObjects.DeleteRegEmgContactInfoWithRelativesWorkingInMOD(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "KAF_RegEmergencyContactInfoWithRelativesWorkingInMOD_Del";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_emergencycontactinfo, cmd, Database, true);
                FillSequrityParameters(reg_emergencycontactinfo.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_emergencycontactinfoDataAccess.Deletereg_emergencycontactinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }


    }
}