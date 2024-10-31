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
	
	internal sealed partial class gen_residenttypeDataAccessObjects : BaseDataAccess, Igen_residenttypeDataAccessObjects
	{
		
        
        #region for Dropdown 
		async Task<IList<gen_residenttypeEntity>> Igen_residenttypeDataAccessObjects.GetResidentTypeDataForDropDown(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken)
		{
			try
			{
				const string SP = "KAF_gen_residenttype_GAPgDropDown";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					AddTotalRecordParameter(cmd);
					AddSortExpressionParameter(cmd, gen_residenttype.SortExpression);
					AddPageSizeParameter(cmd, gen_residenttype.PageSize);
					AddCurrentPageParameter(cmd, gen_residenttype.CurrentPage);                    
					//FillSequrityParameters(gen_residenttype.BaseSecurityParam, cmd, Database);
					FillParameters(gen_residenttype, cmd,Database);

					if (!string.IsNullOrEmpty(gen_residenttype.strCommonSerachParam))
						Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, "%" + gen_residenttype.strCommonSerachParam + "%");
					
					IList<gen_residenttypeEntity> itemList = new List<gen_residenttypeEntity>();
					IAsyncResult result = Database.BeginExecuteReader(cmd, null,null);
					while (!result.IsCompleted)
					{
						
					}
					using (IDataReader reader = Database.EndExecuteReader(result))
					{
						while (reader.Read())
						{
							itemList.Add(new gen_residenttypeEntity(reader));
						}
						reader.Close();
					}
					if(itemList.Count>0)
					{
						itemList[0].RETURN_KEY   = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
						gen_residenttype.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
					}
					cmd.Dispose();
					return itemList;
				}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("Igen_residenttypeDataAccess.GetDataForDropDown"));
			}
		}
		#endregion
    
	}
}