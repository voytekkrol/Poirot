using Poirot.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Poirot.Viewmodel.Commands
{
    class SelectedPrintShopCommand : ICommand
    {
        public ServicesVM VM { get; set; }
        public UpdatePrintShopVM UpdatePrintShopVM { get; set; }
        public PrintShop SelectedPrintShop { get; set; }

        public event EventHandler CanExecuteChanged;

        public SelectedPrintShopCommand(ServicesVM vm)
        {
            this.VM = vm;
            
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            PrintShop tempPrintShop = parameter as PrintShop;
            UpdatePrintShopVM = new UpdatePrintShopVM(tempPrintShop);
            VM.UpdateSelectedPrintShop();
            
        }
    }
}
