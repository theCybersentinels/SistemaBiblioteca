using SistemaBiblioteca.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaBiblioteca.Services
{
    public class LibroService
    {
        private List<Libro> libros;

        public LibroService()
        {
            // Inicializando la lista de libros con algunos libros de ejemplo
            libros = new List<Libro>
            {
                new Libro { ISBN = "978-3-16-148410-0", Titulo = "Cien años de soledad", Autor = "Gabriel García Márquez", Editorial = "Editorial Sudamericana", AnoPublicacion = 1967, Genero = "Ficción", NumCopias = 5 },
                new Libro { ISBN = "978-0-06-112008-4", Titulo = "To Kill a Mockingbird", Autor = "Harper Lee", Editorial = "J.B. Lippincott & Co.", AnoPublicacion = 1960, Genero = "Ficción", NumCopias = 3 }
            };
        }

        // Método para obtener la lista de libros
        public List<Libro> ObtenerLibros()
        {
            return libros;
        }

        // Método para agregar un nuevo libro
        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
        }

        // Método para editar un libro existente
        public void EditarLibro(string isbn, Libro libroActualizado)
        {
            var libro = libros.FirstOrDefault(l => l.ISBN == isbn);
            if (libro != null)
            {
                libro.Titulo = libroActualizado.Titulo;
                libro.Autor = libroActualizado.Autor;
                libro.Editorial = libroActualizado.Editorial;
                libro.AnoPublicacion = libroActualizado.AnoPublicacion;
                libro.Genero = libroActualizado.Genero;
                libro.NumCopias = libroActualizado.NumCopias;
            }
        }

        // Método para eliminar un libro
        public void EliminarLibro(Libro libro)
        {
            libros.Remove(libro);
        }
    }
}
