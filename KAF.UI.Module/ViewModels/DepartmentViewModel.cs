using AutoMapper;
using KAF.Service.Proxy.Client;
using KAF.Service.Proxy.Dto;
using KAF.UI.Common;
using KAF.UI.Common.View;
using KAF.UI.Module.View;
using Prism.Commands;
using Prism.Dialogs;
using Prism.Events;
using Prism.Navigation.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Threading.Tasks;

namespace KAF.UI.Module.ViewModels
{
    public class DepartmentViewModel : BaseViewModel
    {
        #region DI
        private readonly IRegionManager _regionManager;
        private readonly IDialogService _dialogService;
        private readonly IEventAggregator _eventAggregator;
        private readonly IDepartmentApiClient _departmentService;
        private readonly HttpClient _httpClient;

        private IMapper _mapper;
        #endregion

        #region Command
        public DelegateCommand SaveCommand { get; }
        public DelegateCommand UpdateCommand { get; private set; }
        public DelegateCommand DeleteCommand { get; private set; }

        public DelegateCommand CloseCommand { get; }
        public DelegateCommand LoadDataCommand { get; }
        #endregion

        #region Field & Property
        private DepartmentDto _currentDepartment;

        public DepartmentDto CurrentDepartment
        {
            get { return _currentDepartment; }
            set
            {
                SetProperty(ref _currentDepartment, value);
            }
        }

        private ObservableCollection<DepartmentDto> _departmentList;

        public ObservableCollection<DepartmentDto> DepartmentList
        {
            get { return _departmentList; }
            set { SetProperty(ref _departmentList, value); }
        }
        #endregion

        /// <summary>
        ///   Initialize
        /// </summary>
        /// <param name="regionManager"></param>
        /// <param name="dialogService"></param>
        /// <param name="eventAggregation"></param>
        public DepartmentViewModel(IRegionManager regionManager, IDialogService dialogService,
            IEventAggregator eventAggregator,
            HttpClient httpClient,
            IDepartmentApiClient departmentService, IMapper mapper)
        {
            _regionManager = regionManager;
            _dialogService = dialogService;
            _eventAggregator = eventAggregator;
            _mapper = mapper;

            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", ApplicationState.CurrentUser.Token);


            _departmentService = departmentService;

            CurrentDepartment = new DepartmentDto();
            CurrentDepartment.ErrorsChanged += OnDepartmentErrorsChanged;

            SaveCommand = new DelegateCommand(ExecuteSaveCommand, CanSaveExecute)
                .ObservesProperty(() => CurrentDepartment);

            UpdateCommand = new DelegateCommand(ExecuteUpdateCommand, CanUpdateOrDeleteExecute).ObservesProperty(() => CurrentDepartment);
            DeleteCommand = new DelegateCommand(ExecuteDeleteCommand, CanUpdateOrDeleteExecute).ObservesProperty(() => CurrentDepartment);


            CloseCommand = new DelegateCommand(() => ExecuteCloseCommand());
            LoadDataCommand = new DelegateCommand(async () => await LoadDataAsync(), () => !IsBusy);
            LoadDataCommand.Execute();
        }


        #region Validation Handler

        public bool HasErrors => CurrentDepartment.HasErrors;
        private void OnDepartmentErrorsChanged(object? sender, DataErrorsChangedEventArgs e)
        {
            // Reevaluate CanExecute for SaveCommand whenever there's a validation error
            SaveCommand.RaiseCanExecuteChanged();
        }
        private bool CanSaveExecute()
        {
            return !HasErrors; // Command is enabled if there are no errors
        }
        private bool CanUpdateOrDeleteExecute()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Command Implementation
        private async Task LoadDataAsync()
        {
            IsBusy = true;
            try
            {
                DepartmentList = new ObservableCollection<DepartmentDto>(_mapper.Map<List<DepartmentDto>>(await _departmentService.GetAllDepartmentAsync()));
                CurrentDepartment = new DepartmentDto();
            }
            finally
            {
                IsBusy = false;
            }
        }
        private void ExecuteSaveCommand()
        {

            CurrentDepartment.ValidateAllProperties();

            if (!HasErrors)
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
                        LoadDataCommand.Execute();
                    }
                    else if (r.Result == ButtonResult.Cancel)
                    {
                        // Handle Cancel result
                    }
                });

            }

        }




        private void ExecuteUpdateCommand()
        {
            throw new NotImplementedException();
        }

        private void ExecuteDeleteCommand()
        {
            throw new NotImplementedException();
        }

        private void ExecuteCloseCommand()
        {
            _regionManager.RequestNavigate(RegionNameConfig.ContentRegionName, typeof(HomeView).Name);
        }


        #endregion
    }
}
