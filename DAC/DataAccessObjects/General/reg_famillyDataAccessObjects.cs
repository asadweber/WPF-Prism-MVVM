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

    internal sealed partial class reg_famillyDataAccessObjects : BaseDataAccess, Ireg_famillyDataAccessObjects
    {

        #region Constructors

        private string ClassName = "reg_famillyDataAccessObjects";

        public reg_famillyDataAccessObjects(Context context) : base(context)
        {
        }

        private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }

        #endregion

        public static void FillParameters(reg_famillyEntity reg_familly, DbCommand cmd, Database Database, bool forDelete = false)
        {
            if (reg_familly.familyid.HasValue)
                Database.AddInParameter(cmd, "@FamilyID", DbType.Int64, reg_familly.familyid);
            if (forDelete) return;
            if (reg_familly.parentid.HasValue)
                Database.AddInParameter(cmd, "@ParentID", DbType.Int64, reg_familly.parentid);
            if ((reg_familly.isinkuwait != null))
                Database.AddInParameter(cmd, "@IsInKuwait", DbType.Boolean, reg_familly.isinkuwait);
            if (reg_familly.basicinfoid.HasValue)
                Database.AddInParameter(cmd, "@BasicInfoID", DbType.Int64, reg_familly.basicinfoid);
            if (reg_familly.relationshipid.HasValue)
                Database.AddInParameter(cmd, "@RelationshipID", DbType.Int64, reg_familly.relationshipid);
            if (reg_familly.familygenderid.HasValue)
                Database.AddInParameter(cmd, "@FamilyGenderID", DbType.Int64, reg_familly.familygenderid);
            if (reg_familly.familyreligionid.HasValue)
                Database.AddInParameter(cmd, "@FamilyReligionID", DbType.Int64, reg_familly.familyreligionid);
            if (reg_familly.familybloodgroupid.HasValue)
                Database.AddInParameter(cmd, "@FamilyBloodGroupID", DbType.Int64, reg_familly.familybloodgroupid);
            if (reg_familly.maritalstatusid.HasValue)
                Database.AddInParameter(cmd, "@MaritalStatusID", DbType.Int64, reg_familly.maritalstatusid);
            if (reg_familly.parentalstatus.HasValue)
                Database.AddInParameter(cmd, "@ParentalStatus", DbType.Int64, reg_familly.parentalstatus);
            if (reg_familly.nationalityid.HasValue)
                Database.AddInParameter(cmd, "@NationalityID", DbType.Int64, reg_familly.nationalityid);
            if (reg_familly.classid.HasValue)
                Database.AddInParameter(cmd, "@ClassID", DbType.Int64, reg_familly.classid);
            if (reg_familly.birthcountryid.HasValue)
                Database.AddInParameter(cmd, "@BirthCountryID", DbType.Int64, reg_familly.birthcountryid);
            if (reg_familly.prevnationalityid.HasValue)
                Database.AddInParameter(cmd, "@PrevNationalityID", DbType.Int64, reg_familly.prevnationalityid);
            if ((reg_familly.birthdate.HasValue))
                Database.AddInParameter(cmd, "@BirthDate", DbType.DateTime, reg_familly.birthdate);
            if (!(string.IsNullOrEmpty(reg_familly.civilid)))
                Database.AddInParameter(cmd, "@CivilID", DbType.String, reg_familly.civilid);
            if (!(string.IsNullOrEmpty(reg_familly.nationalid)))
                Database.AddInParameter(cmd, "@NationalID", DbType.String, reg_familly.nationalid);
            if (!(string.IsNullOrEmpty(reg_familly.passportnumber)))
                Database.AddInParameter(cmd, "@PassportNumber", DbType.String, reg_familly.passportnumber);
            if (!(string.IsNullOrEmpty(reg_familly.fullname)))
                Database.AddInParameter(cmd, "@FullName", DbType.String, reg_familly.fullname);
            if (!(string.IsNullOrEmpty(reg_familly.name1)))
                Database.AddInParameter(cmd, "@Name1", DbType.String, reg_familly.name1);
            if (!(string.IsNullOrEmpty(reg_familly.name2)))
                Database.AddInParameter(cmd, "@Name2", DbType.String, reg_familly.name2);
            if (!(string.IsNullOrEmpty(reg_familly.name3)))
                Database.AddInParameter(cmd, "@Name3", DbType.String, reg_familly.name3);
            if (!(string.IsNullOrEmpty(reg_familly.name4)))
                Database.AddInParameter(cmd, "@Name4", DbType.String, reg_familly.name4);
            if (!(string.IsNullOrEmpty(reg_familly.name5)))
                Database.AddInParameter(cmd, "@Name5", DbType.String, reg_familly.name5);
            if ((reg_familly.isservedinmilitary != null))
                Database.AddInParameter(cmd, "@IsServedInMilitary", DbType.Boolean, reg_familly.isservedinmilitary);
            if ((reg_familly.isserving != null))
                Database.AddInParameter(cmd, "@IsServing", DbType.Boolean, reg_familly.isserving);
            if (reg_familly.splmilstatus.HasValue)
                Database.AddInParameter(cmd, "@SplMilStatus", DbType.Int64, reg_familly.splmilstatus);
            if (!(string.IsNullOrEmpty(reg_familly.militaryid)))
                Database.AddInParameter(cmd, "@MilitaryID", DbType.String, reg_familly.militaryid);
            if (reg_familly.companyid.HasValue)
                Database.AddInParameter(cmd, "@CompanyID", DbType.Int64, reg_familly.companyid);
            if (!(string.IsNullOrEmpty(reg_familly.workdesignation)))
                Database.AddInParameter(cmd, "@WorkDesignation", DbType.String, reg_familly.workdesignation);
            if (!(string.IsNullOrEmpty(reg_familly.workcompany)))
                Database.AddInParameter(cmd, "@WorkCompany", DbType.String, reg_familly.workcompany);
            if (reg_familly.companytype.HasValue)
                Database.AddInParameter(cmd, "@CompanyType", DbType.Int64, reg_familly.companytype);
            if (!(string.IsNullOrEmpty(reg_familly.companyaddress)))
                Database.AddInParameter(cmd, "@CompanyAddress", DbType.String, reg_familly.companyaddress);
            if ((reg_familly.enrollmentdate.HasValue))
                Database.AddInParameter(cmd, "@EnrollmentDate", DbType.DateTime, reg_familly.enrollmentdate);
            if (!(string.IsNullOrEmpty(reg_familly.previousjob)))
                Database.AddInParameter(cmd, "@PreviousJob", DbType.String, reg_familly.previousjob);
            if (!(string.IsNullOrEmpty(reg_familly.previousjobdetails)))
                Database.AddInParameter(cmd, "@PreviousJobDetails", DbType.String, reg_familly.previousjobdetails);
            if (reg_familly.preaddcountryid.HasValue)
                Database.AddInParameter(cmd, "@PreAddCountryID", DbType.Int64, reg_familly.preaddcountryid);
            if (reg_familly.preaddgovernid.HasValue)
                Database.AddInParameter(cmd, "@PreAddGovernID", DbType.Int64, reg_familly.preaddgovernid);
            if (!(string.IsNullOrEmpty(reg_familly.preaddgovernarate)))
                Database.AddInParameter(cmd, "@preaddgovernarate", DbType.String, reg_familly.preaddgovernarate);
            if (reg_familly.preaddcityid.HasValue)
                Database.AddInParameter(cmd, "@PreAddCityID", DbType.Int64, reg_familly.preaddcityid);
            if (!(string.IsNullOrEmpty(reg_familly.preaddcity)))
                Database.AddInParameter(cmd, "@preaddcity", DbType.String, reg_familly.preaddcity);
            if (!(string.IsNullOrEmpty(reg_familly.preaddstreet)))
                Database.AddInParameter(cmd, "@PreAddStreet", DbType.String, reg_familly.preaddstreet);
            if (!(string.IsNullOrEmpty(reg_familly.preaddblock)))
                Database.AddInParameter(cmd, "@PreAddBlock", DbType.String, reg_familly.preaddblock);
            if (!(string.IsNullOrEmpty(reg_familly.preaddhousingno)))
                Database.AddInParameter(cmd, "@PreAddHousingNo", DbType.String, reg_familly.preaddhousingno);
            if (!(string.IsNullOrEmpty(reg_familly.preaddhousingflatno)))
                Database.AddInParameter(cmd, "@PreAddHousingFlatNo", DbType.String, reg_familly.preaddhousingflatno);
            if (!(string.IsNullOrEmpty(reg_familly.prepaci)))
                Database.AddInParameter(cmd, "@PrePaci", DbType.String, reg_familly.prepaci);
            if (!(string.IsNullOrEmpty(reg_familly.preaddress)))
                Database.AddInParameter(cmd, "@PreAddress", DbType.String, reg_familly.preaddress);
            if (!(string.IsNullOrEmpty(reg_familly.pres_latitude)))
                Database.AddInParameter(cmd, "@Pres_Latitude", DbType.String, reg_familly.pres_latitude);
            if (!(string.IsNullOrEmpty(reg_familly.pres_longitude)))
                Database.AddInParameter(cmd, "@Pres_Longitude", DbType.String, reg_familly.pres_longitude);
            if (reg_familly.peraddcountryid.HasValue)
                Database.AddInParameter(cmd, "@PerAddCountryID", DbType.Int64, reg_familly.peraddcountryid);
            if (reg_familly.peraddgovernid.HasValue)
                Database.AddInParameter(cmd, "@PerAddGovernID", DbType.Int64, reg_familly.peraddgovernid);
            if (reg_familly.peraddcityid.HasValue)
                Database.AddInParameter(cmd, "@PerAddCityID", DbType.Int64, reg_familly.peraddcityid);
            if (!(string.IsNullOrEmpty(reg_familly.peraddstreet)))
                Database.AddInParameter(cmd, "@PerAddStreet", DbType.String, reg_familly.peraddstreet);
            if (!(string.IsNullOrEmpty(reg_familly.peraddblock)))
                Database.AddInParameter(cmd, "@PerAddBlock", DbType.String, reg_familly.peraddblock);
            if (!(string.IsNullOrEmpty(reg_familly.peraddhousingno)))
                Database.AddInParameter(cmd, "@PerAddHousingNo", DbType.String, reg_familly.peraddhousingno);
            if (!(string.IsNullOrEmpty(reg_familly.peraddhousingflatno)))
                Database.AddInParameter(cmd, "@PerAddHousingFlatNo", DbType.String, reg_familly.peraddhousingflatno);
            if (!(string.IsNullOrEmpty(reg_familly.perpaci)))
                Database.AddInParameter(cmd, "@PerPaci", DbType.String, reg_familly.perpaci);
            if (!(string.IsNullOrEmpty(reg_familly.peraddress)))
                Database.AddInParameter(cmd, "@PerAddress", DbType.String, reg_familly.peraddress);
            if (!(string.IsNullOrEmpty(reg_familly.perm_latitude)))
                Database.AddInParameter(cmd, "@Perm_Latitude", DbType.String, reg_familly.perm_latitude);
            if (!(string.IsNullOrEmpty(reg_familly.perm_longitude)))
                Database.AddInParameter(cmd, "@Perm_Longitude", DbType.String, reg_familly.perm_longitude);
            if (!(string.IsNullOrEmpty(reg_familly.email)))
                Database.AddInParameter(cmd, "@Email", DbType.String, reg_familly.email);
            if (!(string.IsNullOrEmpty(reg_familly.mobilephone1)))
                Database.AddInParameter(cmd, "@MobilePhone1", DbType.String, reg_familly.mobilephone1);
            if (!(string.IsNullOrEmpty(reg_familly.mobilephone2)))
                Database.AddInParameter(cmd, "@MobilePhone2", DbType.String, reg_familly.mobilephone2);
            if (!(string.IsNullOrEmpty(reg_familly.mobilephone3)))
                Database.AddInParameter(cmd, "@MobilePhone3", DbType.String, reg_familly.mobilephone3);
            if (!(string.IsNullOrEmpty(reg_familly.lanphone1)))
                Database.AddInParameter(cmd, "@LanPhone1", DbType.String, reg_familly.lanphone1);
            if (!(string.IsNullOrEmpty(reg_familly.lanphone2)))
                Database.AddInParameter(cmd, "@LanPhone2", DbType.String, reg_familly.lanphone2);
            if (!(string.IsNullOrEmpty(reg_familly.lanphone3)))
                Database.AddInParameter(cmd, "@LanPhone3", DbType.String, reg_familly.lanphone3);
            if ((reg_familly.ismarried != null))
                Database.AddInParameter(cmd, "@IsMarried", DbType.Boolean, reg_familly.ismarried);
            if ((reg_familly.familymarriagedate.HasValue))
                Database.AddInParameter(cmd, "@FamilyMarriageDate", DbType.DateTime, reg_familly.familymarriagedate);
            if (!(string.IsNullOrEmpty(reg_familly.familymarriagedocno)))
                Database.AddInParameter(cmd, "@FamilyMarriageDocNo", DbType.String, reg_familly.familymarriagedocno);
            if ((reg_familly.familymarriagedocdate.HasValue))
                Database.AddInParameter(cmd, "@FamilyMarriageDocDate", DbType.DateTime, reg_familly.familymarriagedocdate);
            if ((reg_familly.deathdate.HasValue))
                Database.AddInParameter(cmd, "@DeathDate", DbType.DateTime, reg_familly.deathdate);
            if ((reg_familly.isalive != null))
                Database.AddInParameter(cmd, "@IsAlive", DbType.Boolean, reg_familly.isalive);
            if ((reg_familly.isfatherside != null))
                Database.AddInParameter(cmd, "@IsFatherSide", DbType.Boolean, reg_familly.isfatherside);
            if ((reg_familly.ismotherside != null))
                Database.AddInParameter(cmd, "@IsMotherSide", DbType.Boolean, reg_familly.ismotherside);
            if (!(string.IsNullOrEmpty(reg_familly.filepath)))
                Database.AddInParameter(cmd, "@FilePath", DbType.String, reg_familly.filepath);
            if (!(string.IsNullOrEmpty(reg_familly.filename)))
                Database.AddInParameter(cmd, "@FileName", DbType.String, reg_familly.filename);
            if (!(string.IsNullOrEmpty(reg_familly.filetype)))
                Database.AddInParameter(cmd, "@FileType", DbType.String, reg_familly.filetype);
            if (!(string.IsNullOrEmpty(reg_familly.extension)))
                Database.AddInParameter(cmd, "@Extension", DbType.String, reg_familly.extension);
            if ((reg_familly.securitycardvaliddate.HasValue))
                Database.AddInParameter(cmd, "@SecurityCardValidDate", DbType.DateTime, reg_familly.securitycardvaliddate);
            if (!(string.IsNullOrEmpty(reg_familly.comment)))
                Database.AddInParameter(cmd, "@Comment", DbType.String, reg_familly.comment);
            if (!(string.IsNullOrEmpty(reg_familly.remarks)))
                Database.AddInParameter(cmd, "@Remarks", DbType.String, reg_familly.remarks);
            if (!(string.IsNullOrEmpty(reg_familly.updateinfo)))
                Database.AddInParameter(cmd, "@UpdateInfo", DbType.String, reg_familly.updateinfo);
            if (reg_familly.tranformactionid.HasValue)
                Database.AddInParameter(cmd, "@TranFormActionID", DbType.Int64, reg_familly.tranformactionid);

        }


        #region Add Operation

        async Task<long> Ireg_famillyDataAccessObjects.Add(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_familly_Ins";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_familly, cmd, Database);
                FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_famillyDataAccess.Addreg_familly"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Add Operation

        #region Update Operation

        async Task<long> Ireg_famillyDataAccessObjects.Update(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_familly_Upd";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_familly, cmd, Database);
                FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_famillyDataAccess.Updatereg_familly"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation

        #region Delete Operation

        async Task<long> Ireg_famillyDataAccessObjects.Delete(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "reg_familly_Del";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(reg_familly, cmd, Database, true);
                FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, Database);
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
                    throw GetDataAccessException(ex, SourceOfException("Ireg_famillyDataAccess.Deletereg_familly"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Delete Operation

        #region SaveList<>

        async Task<long> Ireg_famillyDataAccessObjects.SaveList(IList<reg_famillyEntity> listAdded, IList<reg_famillyEntity> listUpdated, IList<reg_famillyEntity> listDeleted, CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "reg_familly_Ins";
            const string SPUpdate = "reg_familly_Upd";
            const string SPDelete = "reg_familly_Del";

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (reg_famillyEntity reg_familly in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_familly, cmd, Database, true);
                            FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, Database);
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
                if (listUpdated.Count > 0)
                {
                    foreach (reg_famillyEntity reg_familly in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_familly, cmd, Database);
                            FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, Database);
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
                if (listAdded.Count > 0)
                {
                    foreach (reg_famillyEntity reg_familly in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_familly, cmd, Database);
                            FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, Database);
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
                throw GetDataAccessException(ex, SourceOfException("Ireg_famillyDataAccess.Save_reg_familly"));
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
        Database db,
        DbTransaction transaction,
        IList<reg_famillyEntity> listAdded,
        IList<reg_famillyEntity> listUpdated,
        IList<reg_famillyEntity> listDeleted,
        CancellationToken cancellationToken)
        {
            long returnCode = -99;

            const string SPInsert = "reg_familly_Ins";
            const string SPUpdate = "reg_familly_Upd";
            const string SPDelete = "reg_familly_Del";



            try
            {
                if (listDeleted.Count > 0)
                {
                    foreach (reg_famillyEntity reg_familly in listDeleted)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPDelete))
                        {
                            FillParameters(reg_familly, cmd, db, true);
                            FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, db);
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
                if (listUpdated.Count > 0)
                {
                    foreach (reg_famillyEntity reg_familly in listUpdated)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPUpdate))
                        {
                            FillParameters(reg_familly, cmd, db);
                            FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, db);
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
                if (listAdded.Count > 0)
                {
                    foreach (reg_famillyEntity reg_familly in listAdded)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand(SPInsert))
                        {
                            FillParameters(reg_familly, cmd, db);
                            FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, db);
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

                throw GetDataAccessException(ex, SourceOfException("Ireg_famillyDataAccess.Save_reg_familly"));
            }
            finally
            {

            }
            return returnCode;
        }

        #endregion SaveList<>

        #region GetAll

        async Task<IList<reg_famillyEntity>> Ireg_famillyDataAccessObjects.GetAll(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "reg_familly_GA";
                IList<reg_famillyEntity> itemList = new List<reg_famillyEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, reg_familly.SortExpression);
                    FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_familly, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_famillyEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_famillyDataAccess.GetAllreg_familly"));
            }
        }

        async Task<IList<reg_famillyEntity>> Ireg_famillyDataAccessObjects.GetAllByPages(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "reg_familly_GAPg";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_familly.SortExpression);
                    AddPageSizeParameter(cmd, reg_familly.PageSize);
                    AddCurrentPageParameter(cmd, reg_familly.CurrentPage);
                    FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, Database);

                    FillParameters(reg_familly, cmd, Database);

                    if (!string.IsNullOrEmpty(reg_familly.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + reg_familly.strCommonSerachParam + "%");

                    IList<reg_famillyEntity> itemList = new List<reg_famillyEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_famillyEntity(reader));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        reg_familly.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_famillyDataAccess.GetAllByPagesreg_familly"));
            }
        }

        #endregion

        #region Save Master/Details


        async Task<long> Ireg_famillyDataAccessObjects.SaveMasterDetreg_familly(reg_famillyEntity masterEntity,
        IList<reg_famillyEntity> listAdded,
        IList<reg_famillyEntity> listUpdated,
        IList<reg_famillyEntity> listDeleted,
        CancellationToken cancellationToken)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;

            string SP = "";
            const string MasterSPInsert = "reg_familly_Ins";
            const string MasterSPUpdate = "reg_familly_Upd";
            const string MasterSPDelete = "reg_familly_Del";


            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            if (masterEntity.CurrentState == BaseEntity.EntityState.Added)
                SP = MasterSPInsert;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                SP = MasterSPUpdate;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                SP = MasterSPDelete;
            else
            {
                throw new Exception("Nothing to save.");
            }
            DateTime dt = DateTime.Now;

            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Added || masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                    {
                        FillParameters(masterEntity, cmd, Database);
                    }
                    else
                    {
                        FillParameters(masterEntity, cmd, Database, true);
                    }
                    FillSequrityParameters(masterEntity.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd, Database);

                    if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                    {
                        IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                        while (!result.IsCompleted)
                        {
                        }
                        returnCode = Database.EndExecuteNonQuery(result);
                        PrimaryKeyMaster = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                        masterEntity.RETURN_KEY = PrimaryKeyMaster;

                    }
                    else
                    {
                        returnCode = 1;
                    }

                    if (returnCode > 0)
                    {
                        if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                        {
                            foreach (var item in listAdded)
                            {
                                item.parentid = PrimaryKeyMaster;
                            }
                        }
                        reg_famillyDataAccessObjects objreg_familly = new reg_famillyDataAccessObjects(this.Context);
                        objreg_familly.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
                    }
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                    cmd.Dispose();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_famillyDataAccess.SaveDsreg_familly"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }


        async Task<long> Ireg_famillyDataAccessObjects.SaveMasterDetreg_nonkuwaitystatus(reg_famillyEntity masterEntity,
        IList<reg_nonkuwaitystatusEntity> listAdded,
        IList<reg_nonkuwaitystatusEntity> listUpdated,
        IList<reg_nonkuwaitystatusEntity> listDeleted,
        CancellationToken cancellationToken)
        {
            long returnCode = -99;
            Int64 PrimaryKeyMaster = -99;

            string SP = "";
            const string MasterSPInsert = "reg_familly_Ins";
            const string MasterSPUpdate = "reg_familly_Upd";
            const string MasterSPDelete = "reg_familly_Del";


            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            if (masterEntity.CurrentState == BaseEntity.EntityState.Added)
                SP = MasterSPInsert;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                SP = MasterSPUpdate;
            else if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                SP = MasterSPDelete;
            else
            {
                throw new Exception("Nothing to save.");
            }
            DateTime dt = DateTime.Now;

            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Added || masterEntity.CurrentState == BaseEntity.EntityState.Changed)
                    {
                        FillParameters(masterEntity, cmd, Database);
                    }
                    else
                    {
                        FillParameters(masterEntity, cmd, Database, true);
                    }
                    FillSequrityParameters(masterEntity.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd, Database);

                    if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                    {
                        IAsyncResult result = Database.BeginExecuteNonQuery(cmd, transaction, null, null);
                        while (!result.IsCompleted)
                        {
                        }
                        returnCode = Database.EndExecuteNonQuery(result);
                        PrimaryKeyMaster = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                        masterEntity.RETURN_KEY = PrimaryKeyMaster;

                    }
                    else
                    {
                        returnCode = 1;
                    }

                    if (returnCode > 0)
                    {
                        if (masterEntity.CurrentState != BaseEntity.EntityState.Deleted)
                        {
                            foreach (var item in listAdded)
                            {
                                item.familyid = PrimaryKeyMaster;
                            }
                        }
                        reg_nonkuwaitystatusDataAccessObjects objreg_nonkuwaitystatus = new reg_nonkuwaitystatusDataAccessObjects(this.Context);
                        objreg_nonkuwaitystatus.SaveList(Database, transaction, listAdded, listUpdated, listDeleted, cancellationToken);
                    }
                    if (masterEntity.CurrentState == BaseEntity.EntityState.Deleted)
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                    cmd.Dispose();
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("Ireg_famillyDataAccess.SaveDsreg_familly"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        #endregion


        #region Simple load Single Row
        async Task<reg_famillyEntity> Ireg_famillyDataAccessObjects.GetSingle(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "reg_familly_GS";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_familly, cmd, Database);

                    IList<reg_famillyEntity> itemList = new List<reg_famillyEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_famillyEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();

                    if (itemList != null && itemList.Count > 0)
                        return itemList[0];
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_famillyDataAccess.GetSinglereg_familly"));
            }
        }
        #endregion

        #region ForListView Paged Method
        async Task<IList<reg_famillyEntity>> Ireg_famillyDataAccessObjects.GAPgListView(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "reg_familly_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_familly.SortExpression);
                    AddPageSizeParameter(cmd, reg_familly.PageSize);
                    AddCurrentPageParameter(cmd, reg_familly.CurrentPage);
                    FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, Database);

                    FillParameters(reg_familly, cmd, Database);

                    if (!string.IsNullOrEmpty(reg_familly.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + reg_familly.strCommonSerachParam + "%");

                    IList<reg_famillyEntity> itemList = new List<reg_famillyEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new reg_famillyEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        reg_familly.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_famillyDataAccess.GAPgListViewreg_familly"));
            }
        }
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion

        #region for Dropdown 
        async Task<IList<gen_dropdownEntity>> Ireg_famillyDataAccessObjects.GetDataForDropDown(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "reg_familly_GAPgDropDown";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, reg_familly.SortExpression);
                    AddPageSizeParameter(cmd, reg_familly.PageSize);
                    AddCurrentPageParameter(cmd, reg_familly.CurrentPage);
                    FillSequrityParameters(reg_familly.BaseSecurityParam, cmd, Database);
                    FillParameters(reg_familly, cmd, Database);
                    if (!string.IsNullOrEmpty(reg_familly.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, " % " + reg_familly.strCommonSerachParam + " % ");
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
                        reg_familly.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Ireg_famillyDataAccess.GetDataForDropDown"));
            }
        }
        #endregion

    }
}