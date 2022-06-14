using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppdeBicicletas
{
    class Vendedor : Cuenta, ICuenta
    {
        public string NOM_APP { get; set; }
        public string DES_SER { get; set; }
        public string Requi_Legal { get; set; }
        public string Carac_SER { get; set; }

        public Vendedor(int ID_Cuenta, int Cedula, string Nombre, string Apellido, int Celular, string Correo, string Usuario, string Password, string NOM_APP, string DES_SER, string Requi_Legal, string Carac_SER) : base(ID_Cuenta, Cedula, Nombre, Apellido, Celular, Correo, Usuario, Password)
        {
            this.NOM_APP = NOM_APP;
            this.DES_SER = DES_SER;
            this.Requi_Legal = Requi_Legal;
            this.Carac_SER = Carac_SER;
        }

        public int Ingreso()
        {
            int Enviar = 0;
            Enviar = int.Parse(Console.ReadLine());
            return Enviar;
        }
        public string IngresoS()
        {
            string EnviarS = "";
            EnviarS = Console.ReadLine();
            return EnviarS;
        }

        public void Reguistro()
        {

        }

        public void Login()
        {
            
        }

        private static int P = 1;

        public void Vender()
        {
            ID_Cuenta = P;
            Console.WriteLine("************Reguistro para la Venta de tu BiciCleta************");
            Console.WriteLine("Id: " + ID_Cuenta);
            Console.WriteLine("Su Cédula: "+ Cedula);
            //Cedula = Ingreso();
            Console.WriteLine("Su Nombre: "+ Nombre);
            //Nombre = IngresoS();
            Console.WriteLine("Su Apellido: "+ Apellido);
            //Apellido = IngresoS();
            Console.WriteLine("Su Número Celular: "+ Celular);
            //Celular = Ingreso();
            Console.WriteLine("Su Correo: "+ Correo);
            //Correo = IngresoS();

            Console.WriteLine("Nombre de la App : My Bici :) ");

            Console.Write("Describa el servicio: ");
            DES_SER = IngresoS();
            Console.Write("Descriva como consiguio la bicicleta: ");
            Requi_Legal = IngresoS();
            Console.Write("Escriba una carateristica del servicio: ");
            Carac_SER = IngresoS();

            Console.WriteLine("Su Usuario: " + Usuario);
            Console.Write("Ingrese su Contraceña: ");
            string PasswordR="";
            PasswordR = IngresoS();
            Console.WriteLine("--------------------------------");

            int time = 5000;
            String Opciones;
            Console.WriteLine("Opciones:");
            Console.WriteLine("Realizar Venta: 1");
            Console.WriteLine("Cancelar: 2");
            Console.Write("---> ");
            Opciones = Console.ReadLine();
            Console.WriteLine("--------------------------------");

            string C;

            do
            {
                if (PasswordR == Password)
                {
                    switch (Opciones)
                    {
                        case "1":
                            Console.WriteLine(".....Venta Realizada Correcto......");
                            Thread.Sleep(time);
                            Console.Clear();
                            P = P + 1;
                            break;
                        case "2":
                            Console.WriteLine(".....Venta Cancelado.....");
                            Thread.Sleep(time);
                            Console.Clear();
                            break;
                    }
                }else{
                    Console.WriteLine("Error ........ Contraseña Mal Diguitada");
                }
            

                if (Opciones == null || Opciones == "1" || Opciones == "2")
                { C = "1"; }
                else { C = "0";}

                if (C != "1")
                {
                    Console.WriteLine("Error......Vuelva a Diguitar un Número ");
                    Thread.Sleep(time);
                    Console.Clear();
                }

            }while (Opciones == null && Opciones == "1" && Opciones == "2");
        }

        public void Pago()
        {
            
        }
        public void Mostrar()
        {

        }

        public void Alquilar()
        {
            
        }

        public void Comprar()
        {
            
        }
    }
}
