using Autopark.ViewModels.Base;

namespace Autopark.ViewModels.Entities
{
    class AuthorizationViewModel : BaseViewModel
    {
        #region Авторизация

        private string _Login;

        public string Login { get => _Login; set => Set(ref _Login, value); }

        private string _Password;

        public string Password { get => _Password; set => Set(ref _Password, value); }

        #endregion

        #region Регистрация

        private string _RegistrationLogin;

        public string RegistrationLogin { get => _RegistrationLogin; set => Set(ref _RegistrationLogin, value); }

        private string _RegistrationPassword;

        public string RegistrationPassword { get => _RegistrationPassword; set => Set(ref _RegistrationPassword, value); }

        #endregion
    }
}
