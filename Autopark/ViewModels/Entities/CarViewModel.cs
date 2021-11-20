using Autopark.ViewModels.Base;

namespace Autopark.ViewModels.Entities
{
    class CarViewModel : BaseViewModel
    {
        #region Автомобиль

        private string _Model;

        public string Model { get => _Model; set => Set(ref _Model, value); }

        public string _LicensePlate;

        public string LicensePlate { get => _LicensePlate; set => Set(ref _LicensePlate, value); }

        public int _Mileage;

        public int Mileage { get => _Mileage; set => Set(ref _Mileage, value); }

        public float _FuelRemaining;

        public float FuelRemaining { get => _FuelRemaining; set => Set(ref _FuelRemaining, value); }

        #endregion
    }
}
