using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace MyMvvmCrossApp3.Core.ViewModels.Main
{
    public class MainViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        public MainViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

        }

        private string _welcome = "Super Welcome";
        public string Welcome
        {
            get => _welcome;
            set => SetProperty(ref _welcome, value);
        }

        private ICommand _submitCommand;
        public ICommand SubmitCommand
        {
            get
            {
                _submitCommand = _submitCommand ?? new MvxCommand(DoSubmit);
                return _submitCommand;
            }
        }

        private void DoSubmit()
        {
            _navigationService.Navigate<SecondViewModel>();
        }
    }
}
