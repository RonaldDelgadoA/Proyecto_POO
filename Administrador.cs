using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppdeBicicletas
{
    class Administrador : Cuenta, ICuenta
    {
        public string ES_ADMIN { get; set; }
        public string Fecha_Nom_Admin { get; set; }
        public string Domi_Admin { get; set; }
        public string Expe_Admin { get; set; }
        public string Estudios_Admin { get; set; }
        public string Profe_Admin { get; set; }
        public string Licencia_Admin { get; set; }
        public string Tiempo_Licencia_Admin { get; set; }

        public Administrador(int ID_Cuenta, int Cedula, string Nombre, string Apellido, int Celular, string Correo, string Usuario, string Password, string Fecha_Nom_Admin, string Domi_Admin, string Expe_Admin, string Estudios_Admin, string Profe_Admin, string Licencia_Admin, string Tiempo_Licencia_Admin, string ES_ADMIN) : base(ID_Cuenta, Cedula, Nombre, Apellido, Celular, Correo, Usuario, Password)
        {
            this.Fecha_Nom_Admin = Fecha_Nom_Admin;
            this.Domi_Admin = Expe_Admin;
            this.Expe_Admin = Expe_Admin;
            this.Estudios_Admin = Estudios_Admin;
            this.Profe_Admin = Profe_Admin;
            this.Licencia_Admin = Licencia_Admin;
            this.Tiempo_Licencia_Admin = Tiempo_Licencia_Admin;
            this.ES_ADMIN = ES_ADMIN;
        }

        public void Reguistro()
        {
            
        }

        public void Login()
        {
            
        }

        public void Vender()
        {
            
        }

        public void Pago()
        {
            
        }

        public void Alquilar()
        {
            
        }

        public void Mostrar()
        {
            int time = 5000;
            if (ES_ADMIN == "SI" || ES_ADMIN == "Si" || ES_ADMIN == "sI" || ES_ADMIN == "si")
            {
                Console.WriteLine("************Informacion del Administrador************");
                Console.WriteLine("Tu ID: " + ID_Cuenta);
                Console.WriteLine("Tu Cédula: " + Cedula);
                Console.WriteLine("Tu Nombre: " + Nombre);
                Console.WriteLine("Tu Apellido: " + Apellido);
                Console.WriteLine("Tu Celular: " + Cedula);
                Console.WriteLine("Tu Correo: " + Correo);
                Console.WriteLine("Tu Usuario: " + Usuario);
                //Console.WriteLine("Tu Contraceña: " + Password);
                Console.WriteLine("Tu Fecha de Nacimiento: " + Fecha_Nom_Admin);
                Console.WriteLine("Tu Domicilio: " + Domi_Admin);
                Console.WriteLine("Tu Experiencia: " + Expe_Admin);
                Console.WriteLine("Tus Estudios: " + Estudios_Admin);
                Console.WriteLine("Tu Profesion: " + Profe_Admin);
                Console.WriteLine("Tu licencia: " + Licencia_Admin);
                Console.WriteLine("Tu tiempo de licencia es: " + Tiempo_Licencia_Admin + " dias");
                Console.WriteLine("------------------------------------------------------");
                Console.ReadKey();
                Console.Clear();
            }else{
                Console.Clear();
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("***** Lo siento no tienes licencia para ver tu informacion *****");
                Console.WriteLine("------------------------------------------------------");
                Thread.Sleep(time);
                Console.Clear();
            }
        }

        public void Comprar()
        {
            
        }
    }
}

