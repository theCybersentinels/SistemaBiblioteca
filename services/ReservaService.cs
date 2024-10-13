using SistemaBiblioteca.Models;
using System.Collections.Generic;

namespace SistemaBiblioteca.Services
{
    public class ReservaService
    {
        private List<Reserva> reservas;

        public ReservaService()
        {
            reservas = new List<Reserva>();
        }

        public void AgregarReserva(Reserva reserva)
        {
            reservas.Add(reserva);
        }
    }
}
