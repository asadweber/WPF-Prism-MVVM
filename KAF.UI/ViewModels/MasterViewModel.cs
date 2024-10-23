using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.UI.ViewModels
{
    public class MasterViewModel : BaseViewModel
    {
        private readonly IRegionManager _regionManager;

        public MasterViewModel(IRegionManager regionManager)
        {
            Title = "KNS";
            _regionManager = regionManager;

              // Navigate to MenuView in MenuRegion and HomeView in formContentRegion at startup
            _regionManager.RequestNavigate("MenuRegion", "MenuView");
            _regionManager.RequestNavigate("formContentRegion", "HomeView");
        }
    }
}
