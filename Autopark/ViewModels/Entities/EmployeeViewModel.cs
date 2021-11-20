using Autopark.ViewModels.Base;

namespace Autopark.ViewModels.Entities
{
    class EmployeeViewModel : BaseViewModel
    {
        #region Сотрудник

        private string _FirstName;

        public string FirstName { get => _FirstName; set => Set(ref _FirstName, value); }

        private string _SecondName;

        public string SecondName { get => _SecondName; set => Set(ref _SecondName, value); }

        private string _ThirdName;

        public string ThirdName { get => _ThirdName; set => Set(ref _ThirdName, value); }

        private string _Phone;

        public string Phone { get => _Phone; set => Set(ref _Phone, value); }

        private string _Address;

        public string Address { get => _Address; set => Set(ref _Address, value); }

        #endregion
    }
}
