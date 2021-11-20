using MathCore.ViewModels;

namespace Autopark.ViewModels
{
    class ToastViewModel : ViewModel
    {
        #region Содержание

        private string _Content;

        public string Content { get => _Content; set => Set(ref _Content, value); }

        #endregion
    }
}
