using Autopark.Infrastructure.Commands;
using Autopark.ViewModels.Base;
using System;
using System.Windows;
using System.Windows.Input;

namespace Autopark.ViewModels
{
    class MainWindowViewModel : BaseViewModel
    {
        #region Поля

        #region Текущая вкладка

        private int _SelectedPageIndex = 0;

        public int SelectedPageIndex { get => _SelectedPageIndex; set => Set(ref _SelectedPageIndex, value); }

        #endregion

        #endregion


        #region Команды

        #region MinimizeAppCommand

        public ICommand MinimizeAppCommand { get; }

        private bool CanMinimizeAppCommandExecute(object o) => true;

        private void OnMinimizeAppCommandExecuted(object o) => Application.Current.MainWindow.WindowState = WindowState.Minimized;

        #endregion

        #region MaximizeAppCommand

        public ICommand MaximizeAppCommand { get; }

        private bool CanMaximizeAppCommandExecute(object o) => true;

        private void OnMaximizeAppCommandExecuted(object o) => Application.Current.MainWindow.WindowState =
           Application.Current.MainWindow.WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;

        #endregion

        #region CloseAppCommand

        public ICommand CloseAppCommand { get; }

        private bool CanCloseAppCommandExecute(object o) => true;

        private void OnCloseAppCommandExecuted(object o) => Application.Current.Shutdown();

        #endregion

        #region OpenTabCommand

        public ICommand OpenTabCommand { get; }

        private bool CanOpenTabCommandExecute(object o) => true;

        private void OnOpenTabCommandExecuted(object o)
        {
            object[] tabInfo = (object[])o;
            SelectedPageIndex = Convert.ToInt32(tabInfo[0]);
            Title = tabInfo[1].ToString();
        }

        #endregion

        #endregion

        public MainWindowViewModel()
        {
            #region Комманды

            MinimizeAppCommand = new ActionCommand(OnMinimizeAppCommandExecuted, CanMinimizeAppCommandExecute);
            MaximizeAppCommand = new ActionCommand(OnMaximizeAppCommandExecuted, CanMaximizeAppCommandExecute);
            CloseAppCommand = new ActionCommand(OnCloseAppCommandExecuted, CanCloseAppCommandExecute);
            OpenTabCommand = new ActionCommand(OnOpenTabCommandExecuted, CanOpenTabCommandExecute);

            #endregion
        }
    }
}
