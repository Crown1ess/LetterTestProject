using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Letters.ViewModels
{
    public class BaseViewModel
    {
        #region INPC
        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged([CallerMemberName]string property = null)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        #endregion
    }
}
