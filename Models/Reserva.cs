using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Models
{
    public class Reserva
    {
        public int IDReserva { get; set; }
        public int IDUsuario { get; set; }
        public int IDLibro { get; set; }
        public string FechaReserva { get; set; }
        public string FechaRetorno { get; set; }
    }
}

