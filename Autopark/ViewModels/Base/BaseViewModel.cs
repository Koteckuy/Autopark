using Autopark.Models.Entities;
using MathCore.ViewModels;
using System.Collections.ObjectModel;

namespace Autopark.ViewModels.Base
{
    internal class BaseViewModel : ViewModel
    {
        #region Заголовок окна

        private string _Title;

        public string Title { get => _Title; set => Set(ref _Title, value); }

        #endregion

        #region Таблицы

        private ObservableCollection<Employee> _Employees;

        public ObservableCollection<Employee> Employees { get => _Employees; set => Set(ref _Employees, value); }

        private ObservableCollection<Account> _Accounts;

        public ObservableCollection<Account> Accounts { get => _Accounts; set => Set(ref _Accounts, value); }

        private ObservableCollection<Car> _Cars;

        public ObservableCollection<Car> Cars { get => _Cars; set => Set(ref _Cars, value); }

        private ObservableCollection<Task> _Task;

        public ObservableCollection<Task> Task { get => _Task; set => Set(ref _Task, value); }

        private ObservableCollection<TrackSheet> _TrackSheet;

        public ObservableCollection<TrackSheet> TrackSheet { get => _TrackSheet; set => Set(ref _TrackSheet, value); }

        #endregion
    }
}
