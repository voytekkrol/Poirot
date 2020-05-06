using Poirot.Model;
using Poirot.Viewmodel.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Poirot.Viewmodel
{
    class AddNewMachineVM : INotifyPropertyChanged
    {
        public AddNewMachineCommand AddNewMachineCommand { get; set; }

        public ObservableCollection<string> ListOfPrintShopsNames { get; set; }
        public ObservableCollection<PrintShop> ListOfPrintShops { get; set; }

        private Machine newMachine;

        public Machine NewMachine
        {
            get { return newMachine; }
            set 
            { 
                newMachine = value;
                OnPropertyChanged("NewMachine");
            }
        }

        private string selectedPrintShopName;

        public string SelectedPrintShopName
        {
            get { return selectedPrintShopName; }
            set 
            { 
                selectedPrintShopName = value;
                OnPropertyChanged("SelectedPrintShopName");
            }
        }


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


        public AddNewMachineVM()
        {
            AddNewMachineCommand = new AddNewMachineCommand(this);

            ListOfPrintShopsNames = new ObservableCollection<string>();
            ListOfPrintShops = new ObservableCollection<PrintShop>();

            NewMachine = new Machine();

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(DatabaseHelper.dbFile)) 
            {
                var listOfPrintShopsNames = (conn.Table<PrintShop>().Select(p => p.Name)).ToList();
                var listOfPrintShops = conn.Table<PrintShop>().ToList();

                ListOfPrintShopsNames.Clear();
                foreach (var printShop in listOfPrintShopsNames)
                {
                    ListOfPrintShopsNames.Add(printShop);
                }

                ListOfPrintShops.Clear();
                foreach (var printShop in listOfPrintShops)
                {
                    ListOfPrintShops.Add(printShop);
                }
            }
        }

        public void AddNewMachine()
        {
            
            if(SelectedPrintShopName != null)
            {
                SelectedPrintShop = ListOfPrintShops.Where(p => (p.Name == SelectedPrintShopName)).FirstOrDefault() as PrintShop;
                NewMachine.PrintShopId = SelectedPrintShop.Id;
                if (NewMachine != null)
                {
                    MessageBox.Show("New machine added to list");
                    DatabaseHelper.Insert<Machine>(NewMachine);
                }
            }

        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
