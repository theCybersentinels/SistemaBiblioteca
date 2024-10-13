using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Models
{
    public class Libro
    {
        public int IDLibro { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int AnoPublicacion { get; set; }
        public string Genero { get; set; }
        public int NumCopias { get; set; }
    }
}
