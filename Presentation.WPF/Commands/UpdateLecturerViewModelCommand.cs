﻿
using Presentation.WPF.State.Navigators;
using Presentation.WPF.ViewModels.Factories;
using System;
using System.Windows.Input;

namespace Presentation.WPF.Commands
{
    /// <summary>
    /// Class UpdateLecturerViewModelCommand
    /// Write your documentation here
    /// </summary>
    public class UpdateLecturerViewModelCommand : ICommand
    {
        private readonly INavigator _navigator;
        private readonly ILectuerViewModelFactory _viewModelFactory;

        public event EventHandler CanExecuteChanged;

        #region constructor

        public UpdateLecturerViewModelCommand(INavigator navigator, ILectuerViewModelFactory viewModelFactory)
        {
            _navigator = navigator;
            _viewModelFactory = viewModelFactory;
        }

        #endregion
   

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is LViewType viewType)
            {
                _navigator.CurrentViewModel = _viewModelFactory.CreateViewModel(viewType);
            }
        }
    }
}