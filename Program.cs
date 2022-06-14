using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppdeBicicletas
{
    class Program
    {
        public static void Main(string[] args)
        {
            string Opciones;

            Usuario U1 = new Usuario(1,1234567890,"Ronald","Delgado",09335543,"totoor","1-ap-","facci","R","123");

            Vendedor V1 = new Vendedor(1,1234567890,"Ronald","Delgado",09335543,"qwert","R","123","qwert","qwert","qwert","qwert");

            Alquiler BICI1 = new Alquiler(0, 1, "SI", "Blanco", "MX-20", "_","No disponible",0,5,"NO",300,"NO");
            Alquiler BICI2 = new Alquiler(0, 2, "NO", "Blanco", "MX-100", "_","No disponible", 0, 10, "NO", 500, "NO");
            Alquiler BICI3 = new Alquiler(0, 3, "SI", "ROJO", "MX-300", "_","No disponible", 0, 7, "NO", 400, "NO");
            Alquiler BICI4 = new Alquiler(0, 4, "SI", "NEGRO", "MX-500", "_","No disponible", 0, 10, "NO", 300, "NO");

            Administrador A1 = new Administrador(1, 123456789, "Ronald", "Delgado", 09335543, "totootr", "R", "123", "17-05-2000","My Casa","Mucha Esxperiencia","Estudios en FACCI","Ingeniero en Tecnologuia","SI","365","NO");
            
            int BAN = 0;

            do
            {
                Console.WriteLine("********************************");
                Console.WriteLine("Bienvenido a la APP Tu Bici :) ");
                Console.WriteLine("Opciones de Navegación:");
                Console.WriteLine("Login - Diguite: 1");
                Console.WriteLine("Reguistro - Diguite: 2");
                Console.WriteLine("Ver Informacion de Administrador (Solo Personal Autorizado) - Diguite: 3");
                Console.WriteLine("Deseas Vender tu Bicicleta - Diguite: 4");
                Console.WriteLine("Deseas Alquilar una Bicicleta - Diguite: 5");
                Console.WriteLine("Salir del Programa - Diguite: 6");
                Console.Write("---> ");
                Opciones = Console.ReadLine();
                Console.WriteLine("-----------------------------------------------");
                Console.Clear();


                string C;


                do
                {
                    switch (Opciones)
                    {
                        case "1":
                            U1.Login();
                            if (BAN == 0)
                            {BAN = 1;}
                            break;
                        case "2":
                            U1.Reguistro();
                            break;
                        case "3":
                            if (BAN == 0)
                            {
                                Console.WriteLine("---------------------------------------");
                                Console.WriteLine("Lo sentimo debe primero Iniciar Seccion");
                                Console.WriteLine("---------------------------------------");
                                int time = 5000;
                                Thread.Sleep(time);
                                Console.Clear();
                            }
                            else { A1.Mostrar(); }
                            break;
                        case "4":
                            if (BAN == 0)
                            {Console.WriteLine("---------------------------------------");
                             Console.WriteLine("Lo sentimo debe primero Iniciar Seccion");
                             Console.WriteLine("---------------------------------------");
                             int time = 5000;
                             Thread.Sleep(time);
                             Console.Clear();
                            }
                            else{V1.Vender();}
                            break;
                        case "5":
                            if (BAN == 0)
                            {
                                Console.WriteLine("---------------------------------------");
                                Console.WriteLine("Lo sentimo debe primero Iniciar Seccion");
                                Console.WriteLine("---------------------------------------");
                                int time = 5000;
                                Thread.Sleep(time);
                                Console.Clear();
                            }else{
                                List<Alquiler> Lista_de_Bici = new List<Alquiler>();
                                Lista_de_Bici.Add(BICI1);
                                Lista_de_Bici.Add(BICI2);
                                Lista_de_Bici.Add(BICI3);
                                Lista_de_Bici.Add(BICI4);

                                foreach (Alquiler ABC in Lista_de_Bici)
                                {
                                    ABC.Mostrar();
                                }
                            }
                            break;
                        case "6":
                            Console.WriteLine("............Saliendo..........");
                            break;
                    }

                    if (Opciones == "1" || Opciones == "2" || Opciones == "3" || Opciones == "4" || Opciones == "5" || Opciones == "6")
                    { C = "1"; }
                    else { C = "0"; }

                    if (C != "1")
                    { Console.WriteLine("Error......Vuelva a Diguitar un Número "); }

                } while (Opciones == "1" && Opciones == "2" && Opciones == "3" && Opciones == "4" && Opciones == "5" && Opciones == "6");

                if (Opciones == "6")
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Gracias por usar la Aplicacion :) ");
                    Console.WriteLine("----------Vuelve Pronto :) -------"); 
                    Console.WriteLine("Presiona Enter para Finalizar");
                    Console.WriteLine("--------------------------------");
                }

            } while (Opciones != "6");
        }
    }
}
