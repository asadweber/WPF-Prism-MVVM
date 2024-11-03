using KAF.UI.Common;
using Prism.Navigation.Regions;

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
