using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaApp.Models
{
    internal class Pago
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string MetodoPago { get; set; } // Tarjeta de débito o crédito
        public string NumeroFactura { get; set; }
    }
}
