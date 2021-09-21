using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters.ViewModels
{
    class MainWindowViewModel : BaseViewModel
    {
        #region properties
        private BaseViewModel currentContent;
        public BaseViewModel CurrentContent
        {
            get => currentContent;
            set
            {
                currentContent = value;
                OnPropertyChanged(nameof(CurrentContent));
            }
        }
        #endregion

        #region constructor
        public MainWindowViewModel()
        {
            Task.Run(() => currentContent = new LetterViewModel());
        }
        #endregion

        #region methods

        #endregion
    }
}
