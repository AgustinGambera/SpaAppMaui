using SpaApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaApp.ViewModels
{
    internal class ClienteViewModel : BaseViewModel
    {
        private ObservableCollection<Cliente> _clientes;
        public ObservableCollection<Cliente> Clientes
        {
            get => _clientes;
            set
            {
                _clientes = value;
                OnPropertyChanged(nameof(Clientes));
            }
        }

        public ClienteViewModel()
        {
            Clientes = new ObservableCollection<Cliente>();
        }
    }
}
