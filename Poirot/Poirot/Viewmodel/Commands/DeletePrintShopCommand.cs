
using Poirot.Model;
using System;
using System.Windows.Input;

namespace Poirot.Viewmodel.Commands
{
    class DeletePrintShopCommand : ICommand
    {
        public ServicesVM VM { get; set; }

        public event EventHandler CanExecuteChanged;
        //TODO canExecuteChanged implement

        public DeletePrintShopCommand(ServicesVM vm)
        {
            this.VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            PrintShop selectedPrintShop = parameter as PrintShop;
            if(selectedPrintShop != null)
                return true;

            return false;
        }

        public void Execute(object parameter)
        {
            VM.DeletePrintShop();
        }
    }
}
