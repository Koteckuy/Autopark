using Autopark.Infrastructure.Commands;
using Autopark.ViewModels.Base;
using System.Windows;
using System.Windows.Input;

namespace Autopark.ViewModels
{
    class MainWindowViewModel : BaseViewModel
    {
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
            Application.Current.MainWindow.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;

        #endregion

        #region CloseAppCommand

        public ICommand CloseAppCommand { get; }

        private bool CanCloseAppCommandExecute(object o) => true;

        private void OnCloseAppCommandExecuted(object o) => Application.Current.Shutdown();

        #endregion

        #endregion

        public MainWindowViewModel()
        {
            #region Комманды

            MinimizeAppCommand = new ActionCommand(OnMinimizeAppCommandExecuted, CanMinimizeAppCommandExecute);
            MaximizeAppCommand = new ActionCommand(OnMaximizeAppCommandExecuted, CanMaximizeAppCommandExecute);
            CloseAppCommand = new ActionCommand(OnCloseAppCommandExecuted, CanCloseAppCommandExecute);

            #endregion
        }
    }
}
