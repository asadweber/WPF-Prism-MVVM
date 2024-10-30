using KAF.UI.Common;

namespace KAF.UI.Module.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private readonly IRegionManager _regionManager;

        public HomeViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }


    }
}
