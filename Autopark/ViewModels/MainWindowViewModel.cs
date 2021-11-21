using Autopark.Infrastructure.Commands;
using Autopark.ViewModels.Base;
using System.Windows;
using System.Windows.Input;

namespace Autopark.ViewModels
{
    class MainWindowViewModel : BaseViewModel
    {
        #region Команды

        #region CloseAppCommand

        public ICommand CloseAppCommand { get; }

        private bool CanCloseAppCommandExecute(object o) => true;

        private void OnCloseAppCommandExecuted(object o)
        {
            Application.Current.Shutdown();
        }

        #endregion

        #endregion

        public MainWindowViewModel()
        {
            #region Комманды

            CloseAppCommand = new ActionCommand(OnCloseAppCommandExecuted, CanCloseAppCommandExecute);

            #endregion

        }
    }
}
