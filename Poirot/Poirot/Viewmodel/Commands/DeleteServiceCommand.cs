using Poirot.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Poirot.Viewmodel.Commands
{
    class DeleteServiceCommand : ICommand
    {
        public ServicesVM VM { get; set; }

        public event EventHandler CanExecuteChanged;
        //TODO canExecuteChanged implement

        public DeleteServiceCommand(ServicesVM vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            Service selectedService = parameter as Service;
            if(selectedService != null)
                return true;

            return false;
        }

        public void Execute(object parameter)
        {
            VM.DeleteService();
        }
    }
}
