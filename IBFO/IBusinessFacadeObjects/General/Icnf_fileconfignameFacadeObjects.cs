

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Icnf_fileconfignameFacadeObjects")]
    public partial interface Icnf_fileconfignameFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<cnf_fileconfignameEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<cnf_fileconfignameEntity>> GetAll(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<cnf_fileconfignameEntity>> GetAllByPages(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<cnf_fileconfignameEntity> GetSingle(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<cnf_fileconfignameEntity>> GAPgListView(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken);
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion

        [OperationContract]
        Task<IList<gen_dropdownEntity>> GetDataForDropDown(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken);

    }
}
