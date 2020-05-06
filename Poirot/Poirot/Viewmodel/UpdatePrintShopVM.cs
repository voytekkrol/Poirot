using Poirot.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poirot.Viewmodel
{
    class UpdatePrintShopVM : INotifyPropertyChanged
    {

        private PrintShop selectedPrintShop;

        public PrintShop SelectedPrintShop
        {
            get { return selectedPrintShop; }
            set
            {
                selectedPrintShop = value;
                OnPropertyChanged("SelectedPrintShop");
            }
        }
        public UpdatePrintShopVM()
        {
          
        }

        public UpdatePrintShopVM(PrintShop selectedPrintShop)
        {
            SelectedPrintShop = selectedPrintShop;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
