using Consultorio.AccesoDatos;
using Consultorio.Entidades;
using System;

namespace Consultorio.LogicaNegocio
{
    public class PersonalAdminBLL
    {
        private PersonalAdminDAL adminDAL = new PersonalAdminDAL();

        public PersonalAdmin IniciarSesion(string usuario, string contrasena)
        {
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                throw new Exception("Usuario y contraseña no pueden estar vacíos.");
            }

            // Aquí iría la lógica de HASHING en un sistema real

            return adminDAL.ValidarLogin(usuario, contrasena);
        }
    }
}