using Poirot.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Poirot.Viewmodel.Commands
{
    class DeleteMachineCommand : ICommand
    {
        public ServicesVM VM { get; set; }

        public event EventHandler CanExecuteChanged;
        //TODO canExecuteChanged implement
        public DeleteMachineCommand(ServicesVM vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            Machine selectedMachine = parameter as Machine;
            if(selectedMachine != null)
                return true;

            return false;
        }

        public void Execute(object parameter)
        {
            VM.DeleteMachine();
        }
    }
}
