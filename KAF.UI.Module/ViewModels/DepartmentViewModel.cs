using KAF.UI.Common.Model;
using KAF.UI.Common.View;
using KAF.UI.Module.View;
using KAF.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public DelegateCommand CloseCommand { get; private set; }
        public DelegateCommand LoadDataCommand { get; private set; }


        private Department _currentDepartment;

        public Department CurrentDepartment
        {
            get { return _currentDepartment; }
            set { SetProperty(ref _currentDepartment, value); }
        }

        private ObservableCollection<Department> _departmentList;

        public ObservableCollection<Department> DepartmentList
        {
            get { return _departmentList; }
            set { SetProperty(ref _departmentList, value); }
        }


        /// <summary>
        ///   Initialize
        /// </summary>
        /// <param name="regionManager"></param>
        /// <param name="dialogService"></param>
        /// <param name="eventAggregation"></param>
        public DepartmentViewModel(IRegionManager regionManager, IDialogService dialogService, IEventAggregator eventAggregator)
        {
            _regionManager = regionManager;
            _dialogService = dialogService;
            _eventAggregator = eventAggregator;

            CurrentDepartment=new Department();

            SaveCommand = new DelegateCommand(() => ExecuteSaveCommand());
            CloseCommand = new DelegateCommand(() => ExecuteCloseCommand());
            LoadDataCommand = new DelegateCommand(async () => await LoadDataAsync(), () => !IsBusy);
            LoadDataCommand.Execute();
        }

        private async Task LoadDataAsync()
        {
            IsBusy = true;
            try
            {
                // Simulate a long-running task
                await Task.Delay(3000);
                //TO-Do


            }
            finally
            {
                IsBusy = false;
            }
        }

        private void ExecuteCloseCommand()
        {
            _regionManager.RequestNavigate(RegionNameConfig.ContentRegionName, typeof(HomeView).Name);
        }

        private void ExecuteSaveCommand()
        {
            var parameters = new DialogParameters
            {
                {
                    "message", "Are you sure want to save?"
                }
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
