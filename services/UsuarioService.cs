using SistemaBiblioteca.Models;
using System.Collections.Generic;

namespace SistemaBiblioteca.Services
{
    public class UsuarioService
    {
        private List<Usuario> usuarios;

        public UsuarioService()
        {
            usuarios = new List<Usuario>();
        }

        public void AgregarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }
    }
}
