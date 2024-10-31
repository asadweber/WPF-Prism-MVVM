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
using BDO.Core.DataAccessObjects.ExtendedEntities;

namespace DAC.Core.DataAccessObjects.General
{
    /// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>

    internal sealed partial class gen_countryDataAccessObjects
    {
        async Task<long> Igen_countryDataAccessObjects.AddExt(gen_countryEntity gen_countrydata, CancellationToken cancellationToken)
        {
            long returnCode = -99;
            const string SP = "gen_country_Ins_ext";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(gen_countrydata, cmd, Database);
                FillSequrityParameters(gen_countrydata.BaseSecurityParam, cmd, Database);
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

        async Task<IList<gen_countryEntity>> Igen_countryDataAccessObjects.GetAllExt(gen_countryEntity gen_country, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_country_GA_Ext";
                IList<gen_countryEntity> itemList = new List<gen_countryEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, gen_country.SortExpression);
                    FillSequrityParameters(gen_country.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_country, cmd, Database);

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_countryEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_countryDataAccess.GetAllgen_country"));
            }
        }




        async Task<IList<gen_countryEntity>> Igen_countryDataAccessObjects.GetCountryDropDown(gen_countryEntity gen_country, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_gen_country_GAPgDropdown";
                IList<gen_countryEntity> itemList = new List<gen_countryEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_country.SortExpression);
                    AddPageSizeParameter(cmd, gen_country.PageSize);
                    AddCurrentPageParameter(cmd, gen_country.CurrentPage);
                    //FillSequrityParameters(gen_country.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_country, cmd, Database);
                    if (!string.IsNullOrEmpty(gen_country.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_country.strCommonSerachParam + "%");



                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_countryEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_country.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }

                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_countryDataAccess.GetAllgen_country"));
            }
        }


        async Task<gen_countryEntity> Igen_countryDataAccessObjects.GetSingleByCountryId(gen_countryEntity gen_country, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "KAF_gen_country_GS_ById";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    Database.AddInParameter(cmd, "@CountryID", DbType.Int64, gen_country.countryid);

                    IList<gen_countryEntity> itemList = new List<gen_countryEntity>();

                    IAsyncResult result = Database.BeginExecuteReader(cmd, null, null);
                    while (!result.IsCompleted)
                    {
                    }
                    using (IDataReader reader = Database.EndExecuteReader(result))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_countryEntity(reader));
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
                throw GetDataAccessException(ex, SourceOfException("Igen_countryDataAccess.GetSinglegen_country"));
            }
        }

        async Task<IList<gen_dropdownEntity>> Igen_countryDataAccessObjects.GetNationalityForDropDown(gen_countryEntity gen_country, CancellationToken cancellationToken)
        {
            try
            {
                const string SP = "gen_country_nationality_GAPgDropDown";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_country.SortExpression);
                    AddPageSizeParameter(cmd, gen_country.PageSize);
                    AddCurrentPageParameter(cmd, gen_country.CurrentPage);
                    FillSequrityParameters(gen_country.BaseSecurityParam, cmd, Database);
                    FillParameters(gen_country, cmd, Database);
                    if (!string.IsNullOrEmpty(gen_country.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_country.strCommonSerachParam + "%");
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
                        gen_country.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Igen_countryDataAccess.GetNationalityForDropDown"));
            }
        }

    }
}