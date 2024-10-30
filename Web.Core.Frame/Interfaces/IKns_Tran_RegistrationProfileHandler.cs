using System.Threading.Tasks;

namespace Web.Core.Frame.Interfaces
{
    public partial interface IKns_Tran_RegistrationProfileHandler<in TUseCaseResponse>
    {
        void GetAll(TUseCaseResponse response);

        void Delete(TUseCaseResponse response);

        void GetAllPaged(TUseCaseResponse response);

        void GetListView(TUseCaseResponse response);

        void GetSingle(TUseCaseResponse response);

        void Save(TUseCaseResponse response);

        void Update(TUseCaseResponse response);

        void Error(TUseCaseResponse response);
        
        
        void GetAllRecruitSituation(TUseCaseResponse response);
		void GetReport(TUseCaseResponse response);

	}
}
