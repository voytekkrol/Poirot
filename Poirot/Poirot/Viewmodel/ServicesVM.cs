using GalaSoft.MvvmLight.Command;
using Poirot.Model;
using Poirot.View;
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
    class ServicesVM : INotifyPropertyChanged
    { 

        private PrintShop selectedPrintShop;
        private Machine selectedMachine;
        private Service selectedService;
        public ObservableCollection<PrintShop> PrintShops { get; set; }
        public ObservableCollection<Machine> Machines { get; set; }
        public ObservableCollection<Service> Services { get; set; }

        public NewPrintShopCommand NewPrintShopCommand { get; set; }
        public NewMachineCommand NewMachineCommand { get; set; }
        public NewServiceCommand NewServiceCommand { get; set; }
        public DeletePrintShopCommand DeletePrintShopCommand { get; set; }
        public DeleteMachineCommand DeleteMachineCommand { get; set; }
        public DeleteServiceCommand DeleteServiceCommand { get; set; }
        public SelectedPrintShopCommand SelectedPrintShopCommand { get; set; }
        public ExitCommand ExitCommand { get; set; }

        public NewServiceWindow newServiceWindow { get; set; }


        public PrintShop SelectedPrintShop
        {
            get { return selectedPrintShop; }
            set 
            { 

                selectedPrintShop = value;
                OnPropertyChanged("SelectedPrintShop");
                ReadMachines();
                ReadServices();
            }
        }

        public Machine SelectedMachine
        {
            get { return selectedMachine; }
            set 
            { 
                selectedMachine = value;
                OnPropertyChanged("SelectedMachine");
                ReadServices();
            }
        }

        public Service SelectedService
        {
            get { return selectedService; }
            set 
            { 
                selectedService = value;
                OnPropertyChanged("SelectedService");
            }
        }

        public ServicesVM()
        {

            NewPrintShopCommand = new NewPrintShopCommand(this);
            NewMachineCommand = new NewMachineCommand(this);
            NewServiceCommand = new NewServiceCommand(this);
            DeletePrintShopCommand = new DeletePrintShopCommand(this);
            DeleteMachineCommand = new DeleteMachineCommand(this);
            DeleteServiceCommand = new DeleteServiceCommand(this);
            SelectedPrintShopCommand = new SelectedPrintShopCommand(this);
            ExitCommand = new ExitCommand(this);

            PrintShops = new ObservableCollection<PrintShop>();
            Services = new ObservableCollection<Service>();
            Machines = new ObservableCollection<Machine>();

            ReadPrintShops();
            ReadMachines();
            ReadServices();
        }

        public void CreateNewPrintShop()
        {
            NewPrintShopWindow newPrintShopWindow = new NewPrintShopWindow();
            newPrintShopWindow.ShowDialog();

            ReadPrintShops();

           
        }

        public void CreateNewMachine()
        {
            NewMachineWindow newMachineWindow = new NewMachineWindow();
            newMachineWindow.ShowDialog();

            ReadMachines();
        }

        public void CreateNewService()
        {
            newServiceWindow = new NewServiceWindow();
            newServiceWindow.ShowDialog();

            ReadServices();
        }

        public void UpdateSelectedPrintShop()
        {
            UpdatePrintShopWindow updatePrintShopWindow = new UpdatePrintShopWindow();
            updatePrintShopWindow.ShowDialog();
        }

        public void ReadPrintShops()
        {
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(DatabaseHelper.dbFile))
            {
                
                var printShops = conn.Table<PrintShop>().ToList();

                PrintShops.Clear();
                foreach (var printShop in printShops)
                {
                    PrintShops.Add(printShop);
                }
            }
        }

        public void ReadMachines()
        {
            if (SelectedPrintShop != null)
            {
                using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(DatabaseHelper.dbFile))
                {
                    var machines = conn.Table<Machine>().Where(m => m.PrintShopId == SelectedPrintShop.Id).ToList();

                    Machines.Clear();
                    foreach (var machine in machines)
                    {
                        Machines.Add(machine);
                    }
                }
            }
        }

        public void ReadServices()
        {
            if(SelectedMachine != null)
            {
                using(SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(DatabaseHelper.dbFile))
                {
                    var services = conn.Table<Service>().Where(m => m.MachineId == SelectedMachine.Id).ToList();

                    Services.Clear();
                    foreach (var service in services)
                    {
                        Services.Add(service);
                    }
                }
            }

            if(SelectedPrintShop != null && SelectedMachine == null)
            {
                using(SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(DatabaseHelper.dbFile)) 
                {
                    var services = conn.Table<Service>().Where(m => m.PrintShopId == SelectedPrintShop.Id).ToList();

                    Services.Clear();
                    foreach (var service in services)
                    {
                        Services.Add(service);
                    }
                }
            }
        }

        public void DeletePrintShop()
        {
            if(SelectedPrintShop != null)
            {
                DeleteAllMachineOfPrintShop();
                DatabaseHelper.Delete<PrintShop>(SelectedPrintShop);
                this.ReadPrintShops();
                this.ReadMachines();
                this.ReadServices();
            }
        }

        public void DeleteMachine()
        {
            if(SelectedMachine != null)
            {
                DeleteAllServicesOfMachine(SelectedMachine);

                DatabaseHelper.Delete<Machine>(SelectedMachine);

                this.ReadMachines();
                this.ReadServices();
            }
        }

        public void DeleteAllMachineOfPrintShop()
        {
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(DatabaseHelper.dbFile))
            {
                var machines = conn.Table<Machine>().Where(m => m.PrintShopId == SelectedPrintShop.Id).ToList();

                foreach (var machine in machines)
                {
                    DeleteAllServicesOfMachine(machine);
                    DatabaseHelper.Delete<Machine>(machine);
                }
            }
        }

        public void DeleteService()
        {
            if(SelectedService != null)
            {
                DatabaseHelper.Delete<Service>(SelectedService);
                this.ReadServices();
            }
        }

        public void DeleteAllServicesOfMachine(Machine machine)
        {
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(DatabaseHelper.dbFile))
            {
                var services = conn.Table<Service>().Where(s => s.MachineId == machine.Id).ToList();

                foreach (var service in services)
                {
                    DatabaseHelper.Delete<Service>(service);
                }
            }
        }

        public void ExitApp()
        {
            Application.Current.Shutdown();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



    }
}
