using AppConfig.EncryptionHandler;
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using IBFO.Core.IBusinessFacadeObjects.General;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BFO.Core.BusinessFacadeObjects.General
{
    public sealed partial class tran_loginFacadeObjects 
    {
	
		async Task<IList<RefreshToken>> Itran_loginFacadeObjects.GetAllTokenByUser(tran_loginEntity tran_login, CancellationToken cancellationToken)
		{
			try
			{
				List<RefreshToken> obj = new List<RefreshToken>();
				var objlist = await DataAccessFactory.Createtran_loginDataAccess().GetAllTokenByUser(tran_login, cancellationToken);
				if (objlist != null && objlist.Count > 0)
				{

					foreach (tran_loginEntity objsingle in objlist)
					{
						obj.Add(new RefreshToken( 
							objsingle.refreshtoken, 
							objsingle.expires.GetValueOrDefault(),  
							objsingle.userid.GetValueOrDefault(), 
							objsingle.BaseSecurityParam.ipaddress));
					}
					return obj;
				}

				return obj; 
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<RefreshToken> Itran_loginFacade.GetAllTokenByUser"));
            }
		}
        
	}
}