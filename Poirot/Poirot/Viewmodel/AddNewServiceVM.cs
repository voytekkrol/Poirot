using Poirot.Model;
using Poirot.View;
using Poirot.Viewmodel.Commands;
using SQLite;
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
    class AddNewServiceVM : INotifyPropertyChanged
    {
        public AddNewServiceCommand AddNewServiceCommand { get; set; }
        public ObservableCollection<string> ListOfServicemen { get; set; }
        public ObservableCollection<string> ListOfPrintShopsNames { get; set; }
        public ObservableCollection<string> ListOfMachinesNames { get; set; }

        public List<PrintShop> ListOfPrintShops { get; set; }
        public List<Machine> ListOfMachines { get; set; }

        private string selectedPrintShopName;

        public string SelectedPrintShopName
        {
            get { return selectedPrintShopName; }
            set 
            { 
                selectedPrintShopName = value;
                OnPropertyChanged("SelectedPrintShopName");
                ListOfMachinesNames.Clear();
                PopulateListOfMachinesNames();
            }
        }

        private PrintShop selectedPrintShop;

        public PrintShop SelectedPrintShop
        {
            get { return selectedPrintShop; }
            set { selectedPrintShop = value; }
        }


        private string selectedMachineName;

        public string SelectedMachineName
        {
            get { return selectedMachineName; }
            set 
            { 
                selectedMachineName = value;
                OnPropertyChanged("SelectedMachineName");
                SelectMachineFromList();
            }
        }

        private Machine selectedMachine;

        public Machine SelectedMachine
        {
            get { return selectedMachine; }
            set { selectedMachine = value; }
        }

        private string selectedServiceman1;

        public string SelectedServiceman1
        {
            get { return selectedServiceman1; }
            set 
            { 
                selectedServiceman1 = value;
                OnPropertyChanged("SelectedServiceman1");
            }
        }

        private string selectedServiceman2;

        public string SelectedServiceman2
        {
            get { return selectedServiceman2; }
            set
            {
                selectedServiceman2 = value;
                OnPropertyChanged("SelectedServiceman2");
            }
        }

        private Service newService;

        public Service NewService
        {
            get { return newService; }
            set 
            { 
                newService = value;
                OnPropertyChanged("NewService");
            }
        }

        public AddNewServiceVM()
        {
            NewService = new Service();

            AddNewServiceCommand = new AddNewServiceCommand(this);

            ListOfPrintShops = new List<PrintShop>();
            ListOfMachines = new List<Machine>();

            ListOfPrintShopsNames = new ObservableCollection<string>();
            ListOfMachinesNames = new ObservableCollection<string>();
            ListOfServicemen = new ObservableCollection<string>()
            {
                "Piotrek",
                "Roland",
                "Staszek",
                "Tadek",
                "Wojtek"
            };

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(DatabaseHelper.dbFile))
            {
                var listOfPrintShopsNames = (conn.Table<PrintShop>().Select(p => p.Name)).ToList();
                ListOfPrintShopsNames.Clear();

                foreach (var printShopName in listOfPrintShopsNames)
                {
                    ListOfPrintShopsNames.Add(printShopName);
                }

                var listOfPrintShops = conn.Table<PrintShop>().ToList();

                foreach (var printShop in listOfPrintShops)
                {
                    ListOfPrintShops.Add(printShop);
                }

                PopulateListOfMachinesNames();
            }
        }

        public void PopulateListOfMachinesNames()
        {
            SelectedPrintShop = ListOfPrintShops.Where(p => p.Name == SelectedPrintShopName).FirstOrDefault();

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(DatabaseHelper.dbFile)) 
            {
                if (SelectedPrintShopName == null)
                {
                    var listOfMachinesNames = (conn.Table<Machine>().Select(p => p.Type)).ToList();
                    var listOfMachinesNumber = (conn.Table<Machine>().Select(p => p.SerialNumber)).ToList();

                    ListOfMachinesNames.Clear();
                    foreach (var machineName in listOfMachinesNames)
                    {
                        ListOfMachinesNames.Add("Type: " + machineName + " number: " + (listOfMachinesNumber[listOfMachinesNames.IndexOf(machineName)]));
                    }
                    
                    PopulateListOfMachines(conn, listOfMachinesNumber);


                }
                else if (SelectedPrintShopName != null)
                {
                    var listOfMachinesName = conn.Table<Machine>().Where(p => p.PrintShopId == SelectedPrintShop.Id)
                                                                   .Select(p => p.Type).ToList();
                    var listOfMachinesNumber = conn.Table<Machine>().Where(p => p.PrintShopId == SelectedPrintShop.Id)
                                                                     .Select(p => p.SerialNumber).ToList();

                    ListOfMachinesNames.Clear();

                    foreach (var machineName in listOfMachinesName)
                    {
                        ListOfMachinesNames.Add("Type: " + machineName + " number: " + (listOfMachinesNumber[listOfMachinesName.IndexOf(machineName)]));
                    }

                    PopulateListOfMachines(conn, listOfMachinesNumber);
                }
            }
        }

        public void AddNewService()
        {
            NewService.Serviceman1 = SelectedServiceman1;
            NewService.Serviceman2 = SelectedServiceman2;
            NewService.PrintShopId = SelectedPrintShop.Id;
            NewService.MachineId = SelectedMachine.Id;
            NewService.CreatedTime = DateTime.Now;
            NewService.UpdatedTime = DateTime.Now;
            

            DatabaseHelper.Insert<Service>(NewService);

            MessageBox.Show("New service added to list");
        }

        public void PopulateListOfMachines(SQLiteConnection conn, List<string> listOfMachinesNumbers)
        {
            var listOfMachines = conn.Table<Machine>().ToList();

            ListOfMachines.Clear();

            foreach (var machine in listOfMachines)
            {
                ListOfMachines.Add(machine);
            }
        }

        public void SelectMachineFromList()
        {

            string[] tempMachineName = SelectedMachineName.Split(' ');

            string tempMachineNumber = tempMachineName[tempMachineName.Length - 1];
            SelectedMachine = ListOfMachines.Where(m => m.SerialNumber == tempMachineNumber).FirstOrDefault();
            
            //TODO Problem with selection list of printshops when machine selected before. Exception occure.

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
