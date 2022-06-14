using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppdeBicicletas
{
    class Cuenta
    {
        public int ID_Cuenta { get; set; }
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Celular { get; set; }
        public string Correo { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }

        public Cuenta(int ID_Cuenta, int Cedula, string Nombre, string Apellido, int Celular, string Correo, string Usuario, string Password)
        {
            this.ID_Cuenta = ID_Cuenta;
            this.Cedula = Cedula;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Correo = Correo;
            this.Usuario = Usuario;
            this.Password = Password;
        }
    }
}
