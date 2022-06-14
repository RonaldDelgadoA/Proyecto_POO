using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppdeBicicletas
{
    class Usuario : Cuenta, ICuenta
    {
        public string F_Naci { get; set; }
        public string Domi { get; set; }

        public Usuario(int ID_Cuenta, int Cedula, string Nombre, string Apellido, int Celular, string Correo, string F_Naci, string Domi, string Usuario, string Password) : base(ID_Cuenta, Cedula, Nombre, Apellido, Celular, Correo, Usuario, Password)
        {
            this.F_Naci = F_Naci;
            this.Domi = Domi;
        }

        public void Login()
        {
            string UsuarioI;
            string PasswordI;
            Console.WriteLine("************Inicio de Seccion************");
            Console.Write("Usuario: ");
            UsuarioI = IngresoS();
            Console.Write("Contraceña: ");
            PasswordI = IngresoS();
            //Operaciones(UsuarioI, PasswordI);

            int time = 5000;
            String Opciones;
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Opciones:");
            Console.WriteLine("Iniciar seccion : 1");
            Console.WriteLine("Cancelar: 2");
            Console.Write("---> ");
            Opciones = Console.ReadLine();
            Console.WriteLine("--------------------------------");
            string C;
            do
            {
                switch (Opciones)
                {
                    case "1":
                        if (UsuarioI == Usuario && PasswordI == Password)
                        {
                            Console.WriteLine(".....Iniciando Seccion......");
                            Thread.Sleep(time);
                            Console.Clear();
                        }
                        else
                        {

                            Console.WriteLine(".....Usuario y Contraseña Incorrecta......");
                            Console.WriteLine(".....Vuelva a Ingresarlo......");
                            Thread.Sleep(time);
                            Console.Clear();
                        }
                        break;
                    case "2":
                        Console.WriteLine(".....Seccion Cancelado.....");
                        Thread.Sleep(time);
                        Console.Clear();
                        break;
                }

                if (Opciones == null || Opciones == "1" || Opciones == "2")
                { C = "1"; }
                else { C = "0"; }

                if (C != "1")
                {Console.WriteLine("Error......Vuelva a Diguitar un Número ");
                 Thread.Sleep(time);
                 Console.Clear();}

            } while (Opciones == null && Opciones == "1" && Opciones == "2");

        }

        private static int P = 1;

        public void Reguistro()
        {          
                ID_Cuenta = P;
                Console.WriteLine("************Reguistro************");
                Console.WriteLine("Id: " + ID_Cuenta);
                Console.Write("Ingrese su Cédula: ");
                Cedula=Ingreso();
                Console.Write("Ingrese su Nombre: ");
                Nombre= IngresoS();
                Console.Write("Ingrese su Apellido: ");
                Apellido = IngresoS();
                Console.Write("Ingrese su Número Celular: ");
                Celular = Ingreso();
                Console.Write("Ingrese su Correo: ");
                Correo = IngresoS();
                Console.Write("Ingrese su Fecha de Nacimiento (31-12-2022): ");
                F_Naci = IngresoS();
                Console.Write("Ingrese su Domicilio: ");
                Domi = IngresoS();
                Console.Write("Ingrese su Usuario: ");
                Usuario = IngresoS();
                Console.Write("Ingrese su Contraceña: ");
                Password = IngresoS();
                Console.WriteLine("--------------------------------");
                //Opciones();

                int time = 5000;
                String Opciones;
                Console.WriteLine("Opciones:");
                Console.WriteLine("Finalizar Reguistro: 1");
                Console.WriteLine("Cancelar: 2");
                Console.Write("---> ");
                Opciones = Console.ReadLine();
                Console.WriteLine("--------------------------------");

                string C;

                do
                {
                    switch (Opciones)
                    {
                        case "1":
                            Console.WriteLine(".....Reguistro Correcto......");
                            Thread.Sleep(time);
                            Console.Clear();
                            P = P + 1;
                        break;
                        case "2":
                            Console.WriteLine(".....Reguistro Cancelado.....");
                            Thread.Sleep(time);
                            Console.Clear();
                            break;
                    }

                    if (Opciones == null || Opciones == "1" || Opciones == "2")
                    { C = "1"; }
                    else { C = "0"; }

                    if (C != "1")
                    {
                        Console.WriteLine("Error......Vuelva a Diguitar un Número ");
                        Thread.Sleep(time);
                        Console.Clear();
                    }

                } while (Opciones == null && Opciones == "1" && Opciones == "2");
        }
        public int Ingreso()
        {
            int Enviar=0;
            Enviar = int.Parse(Console.ReadLine());
            return Enviar;
        }
        public string IngresoS()
        {
            string EnviarS="";
            EnviarS = Console.ReadLine();
            return EnviarS;
        }

        public void Opciones()
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

        }

        public void Comprar()
        {
            
        }
    }
}
