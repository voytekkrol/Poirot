using Poirot.Model;
using Poirot.Viewmodel.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Poirot.Viewmodel
{
    class AddNewPrintShopVM : INotifyPropertyChanged
    {
        public AddNewPrintShopCommand AddNewPrintShopCommand { get; set; }

        private PrintShop newPrintShop;

        public PrintShop NewPrintShop
        {
            get { return newPrintShop; }
            set 
            { 
                newPrintShop = value;
                OnPropertyChanged("NewPrintShop");
            }
        }

        public AddNewPrintShopVM()
        {
            AddNewPrintShopCommand = new AddNewPrintShopCommand(this);

            NewPrintShop = new PrintShop();
        }

        public void AddNewPrintShop()
        {
            MessageBox.Show("New printshop added to list");
            if(NewPrintShop != null) 
            { 
                DatabaseHelper.Insert<PrintShop>(NewPrintShop);
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
