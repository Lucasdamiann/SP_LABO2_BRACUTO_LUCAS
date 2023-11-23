using Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Usuario
    {
        private string tipoUsuario;
        private string nombreUsuario;
        private string claveUsuario;

        public Usuario(string usuario, string clave)
        {
            this.nombreUsuario = ValidarCredencialUsuario(usuario);
            this.claveUsuario = ValidarCredencialUsuario(clave);
        }

        private string ValidarCredencialUsuario(string credencial)
        {
            if (credencial is not null && credencial.Length > 4 && credencial.Length < 10)
            {
                return credencial;
            }
            else
            {
                throw new CantidadCaracteresInvalidaException("Cantidad de caracteres invalida");
            }
        }
    }
}
