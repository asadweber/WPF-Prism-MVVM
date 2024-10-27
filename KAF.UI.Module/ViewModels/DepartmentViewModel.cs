using KAF.UI.Common.Model;
using KAF.UI.Common.View;
using KAF.UI.Module.View;
using KAF.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.UI.Module.ViewModels
{
    public class DepartmentViewModel : BaseViewModel
    {
        private readonly IRegionManager _regionManager;
        private readonly IDialogService _dialogService;
        private readonly IEventAggregator _eventAggregator;


        public DelegateCommand SaveCommand { get; private set; }

        public DepartmentViewModel(IRegionManager regionManager, IDialogService dialogService, IEventAggregator eventAggregator)
        {
            _regionManager = regionManager;
            _dialogService = dialogService;
            _eventAggregator = eventAggregator;
            SaveCommand = new DelegateCommand(ExecuteSaveCommand);

        }

        private void ExecuteSaveCommand()
        {
            var parameters = new DialogParameters
                    {
                        { "message", "Are you sure want to save?" }
                    };

            _dialogService.ShowDialog(typeof(ConfirmDialogView).Name, parameters, r =>
            {
                if (r.Result == ButtonResult.OK)
                {
                    // Handle OK result
                }
                else if (r.Result == ButtonResult.Cancel)
                {
                    // Handle Cancel result
                }
            });
        }
    }
}
