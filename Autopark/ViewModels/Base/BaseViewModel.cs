using Autopark.Models;
using Autopark.Models.Entities;
using MathCore.ViewModels;
using Microsoft.EntityFrameworkCore;
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

        private ObservableCollection<Task> _Tasks;

        public ObservableCollection<Task> Tasks { get => _Tasks; set => Set(ref _Tasks, value); }

        private ObservableCollection<TrackSheet> _TrackSheets;

        public ObservableCollection<TrackSheet> TrackSheets { get => _TrackSheets; set => Set(ref _TrackSheets, value); }

        private ObservableCollection<Department> _Departments;

        public ObservableCollection<Department> Departments { get => _Departments; set => Set(ref _Departments, value); }

        private ObservableCollection<Position> _Positions;

        public ObservableCollection<Position> Positions { get => _Positions; set => Set(ref _Positions, value); }

        private ObservableCollection<Employee> _Employees;

        public ObservableCollection<Employee> Employees { get => _Employees; set => Set(ref _Employees, value); }

        private ObservableCollection<Account> _Accounts;

        public ObservableCollection<Account> Accounts { get => _Accounts; set => Set(ref _Accounts, value); }

        private ObservableCollection<Car> _Cars;

        public ObservableCollection<Car> Cars { get => _Cars; set => Set(ref _Cars, value); }


        #endregion

        public BaseViewModel()
        {
            using (AutoparkContext db = new AutoparkContext())
            {
                Tasks = db.Tasks
                    .Include(t => t.Customer)
                    .Include(t => t.Route)
                    .ToObservableCollection();

                TrackSheets = db.TrackSheets
                    .Include(ts => ts.Driver)
                    .Include(ts => ts.Checker)
                    .Include(ts => ts.Authorized)
                    .Include(ts => ts.Car)
                    .Include(ts => ts.Status)
                    .ToObservableCollection();

                Departments = db.Departments
                    .ToObservableCollection();

                Positions = db.Positions
                    .Include(p => p.Department)
                    .ToObservableCollection();

                Employees = db.Employees
                    .Include(e => e.Position)
                    .ThenInclude(p => p.Department)
                    .ToObservableCollection();

                Accounts = db.Accounts
                    .Include(a => a.Employee)
                    .Include(a => a.Role)
                    .ToObservableCollection();

                Cars = db.Cars
                    .Include(c => c.Brand)
                    .Include(c => c.Fuel)
                    .ToObservableCollection();
            }
        }

    }
}
