using Autopark.ViewModels.Base;
using System;

namespace Autopark.ViewModels.Entities
{
    class TrackSheetViewModel : BaseViewModel
    {
        #region Путевой лист 

        private DateTime _ReportDate;

        public DateTime ReportDate { get => _ReportDate; set => Set(ref _ReportDate, value); }

        private TimeSpan _StartTime;

        public TimeSpan StartTime { get => _StartTime; set => Set(ref _StartTime, value); }

        private TimeSpan _ReturnTime;

        public TimeSpan ReturnTime { get => _ReturnTime; set => Set(ref _ReturnTime, value); }

        #endregion
    }
}
