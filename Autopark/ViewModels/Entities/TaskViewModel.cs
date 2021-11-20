using Autopark.ViewModels.Base;

namespace Autopark.ViewModels.Entities
{
    class TaskViewModel : BaseViewModel
    {
        #region Задача 

        private int _Mileage;

        public int Mileage { get => _Mileage; set => Set(ref _Mileage, value); }
        
        private string _Details;

        public string Details { get => _Details; set => Set(ref _Details, value); }

        #endregion
    }
}
