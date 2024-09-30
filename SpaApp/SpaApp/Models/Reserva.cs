using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaApp.Models
{
    internal class Reserva
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Servicio Servicio { get; set; }
        public DateTime FechaReserva { get; set; }
        public Profesional Profesional { get; set; }

        //Responsabilidad: Representar la reserva de un cliente para un servicio con un profesional en una fecha específica.
    }
}
