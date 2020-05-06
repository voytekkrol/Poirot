using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Poirot.Viewmodel.Commands
{
    class AddNewPrintShopCommand : ICommand
    {
        public AddNewPrintShopVM VM { get; set; }

        public event EventHandler CanExecuteChanged;

        public AddNewPrintShopCommand(AddNewPrintShopVM vm)
        {
            this.VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            VM.AddNewPrintShop();
        }
    }
}
