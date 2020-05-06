using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Poirot.Viewmodel.Commands
{
    class NewServiceCommand : ICommand
    {
        public ServicesVM VM { get; set; }

        public event EventHandler CanExecuteChanged;

        public NewServiceCommand(ServicesVM vm)
        {
            this.VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            VM.CreateNewService();
        }
    }
}
