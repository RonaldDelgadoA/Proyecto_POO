using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppdeBicicletas
{
    class Alquiler : Pago, ICuenta
    {
        public int N_Alquiler_B { get; set; }
        public int N_BICI { get; set; }
        public string B_Alquiler_S_N { get; set; }
        public string Color_B { get; set; }
        public string Modelo_B { get; set; }
        public string Tiempo_B { get; set; }
        public string Imagen { get; set; }

        public Alquiler(int N_Alquiler_B, int N_BICI, string B_Alquiler_S_N, string Color_B, string Modelo_B, string Tiempo_B, string Imagen, int ID_Pago, int Efectivo, string Paypal, int Monto, string Traferencia) : base (ID_Pago, Efectivo, Paypal, Monto,Traferencia)
        {
            this.N_Alquiler_B = N_Alquiler_B;
            this.N_BICI = N_BICI;
            this.B_Alquiler_S_N = B_Alquiler_S_N;
            this.Color_B = Color_B;
            this.Modelo_B = Modelo_B;
            this.Tiempo_B = Tiempo_B;
            this.Imagen = Imagen;
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

        private static int PA = 1;

        public void Pago()
        {
            switch (Opciones)
            {
                case "1":
                    N_BICI = A1;
                    B_Alquiler_S_N = A2;
                    Color_B = A3;
                    Modelo_B = A4;
                    Imagen = A5;
                    Efectivo = A6;
                    break;
                case "2":
                    N_BICI = B1;
                    B_Alquiler_S_N = B2;
                    Color_B = B3;
                    Modelo_B = B4;
                    Imagen = B5;
                    Efectivo = B6;
                    break;
                case "3":
                    N_BICI = C1;
                    B_Alquiler_S_N = C2;
                    Color_B = C3;
                    Modelo_B = C4;
                    Imagen = C5;
                    Efectivo = C6;
                    break;
                case "4":
                    N_BICI = D1;
                    B_Alquiler_S_N = D2;
                    Color_B = D3;
                    Modelo_B = D4;
                    Imagen = D5;
                    Efectivo = D6;
                    break;
            }

            Console.WriteLine("******Informe de Pago de Bicicletas******");
            ID_Pago = PA;
            Console.WriteLine("Numero de Orden : " + ID_Pago);

            Console.WriteLine("Numero de Bicicleta : " + N_BICI);
            Console.WriteLine("Modelo: " + Modelo_B);
            Console.WriteLine("Color de Bicicleta: " + Color_B);
            Console.WriteLine("Imagen de la Bicicleta: " + Imagen);
            Console.WriteLine("Tiempo de alquiler: " + Tiempo_A+" hora");
            Console.WriteLine("Valor: $" + Efectivo);
            Console.WriteLine(" ");

            Console.WriteLine("--------------------------------");

            int time = 5000;
            String Opci;
            Console.WriteLine("Opciones:");
            Console.WriteLine("Confirmar: 1");
            Console.WriteLine("Cancelar: 2");
            Console.Write("---> ");
            Opci = Console.ReadLine();
            Console.WriteLine("--------------------------------");

            string C;

            string OPI = "";

            //do{
            Console.WriteLine("Deceas agregar algun seguro a la Bicicleta: (Si o No)");
            Console.Write("---> ");
            OPI = Console.ReadLine();
            Console.WriteLine("--------------------------------");

            if (OPI == "SI" || OPI == "Si" || OPI == "si" || OPI == "sI")
            {
                var Segurity = new BicicletaBasica();
                Console.Write(Segurity.Adicion());
                var Segurity1 = new Seguros(Segurity);
                Console.Write(Segurity1.Adicion());
                Console.WriteLine("");
            }
            else{
            Console.WriteLine("Seguro no agregado :) ");
            }

            //} while (OPI == "SI" || OPI == "Si");
            

            do
            {
                switch (Opci)
                {
                    case "1":
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("........Has Alquilado una Bicicleta........");
                        Console.WriteLine("-------------------------------------------");
                        
                        switch (Opciones)
                        {
                            case "1":
                                A2 = "NO";
                                B_Alquiler_S_N = "NO";
                                break;
                            case "2":
                                B2 = "NO";
                                B_Alquiler_S_N = "NO";
                                break;
                            case "3":
                                C2 = "NO";
                                B_Alquiler_S_N = "NO";
                                break;
                            case "4":
                                D2 = "NO";
                                B_Alquiler_S_N = "NO";
                                break;
                        }

                        Thread.Sleep(time);
                        Console.Clear();
                        PA = PA + 1;
                        break;
                    case "2":
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("............Se cancelo la orden............");
                        Console.WriteLine("-------------------------------------------");
                        Thread.Sleep(time);
                        Console.Clear();
                        break;
                }

                if (Opci == null || Opci == "1" || Opci == "2")
                { C = "1"; }
                else { C = "0"; }

                if (C != "1")
                {
                    Console.WriteLine("Error......Vuelva a Diguitar un Número ");
                    Thread.Sleep(time);
                    Console.Clear();
                }

            } while (Opci == null && Opci == "1" && Opci == "2");

        }

        private static int B = 1;

        private string Tiempo_A = "";

        private static int A1 = 0;
        private static String A2 = "";
        private static String A3 = "";
        private static String A4 = "";
        private static String A5 = "";
        private static int A6 = 0;

        private static int B1 = 0;
        private static String B2 = "";
        private static String B3 = "";
        private static String B4 = "";
        private static String B5 = "";
        private static int B6 = 0;

        private static int C1 = 0;
        private static String C2 = "";
        private static String C3 = "";
        private static String C4 = "";
        private static String C5 = "";
        private static int C6 = 0;

        private static int D1 = 0;
        private static String D2 = "";
        private static String D3 = "";
        private static String D4 = "";
        private static String D5 = "";
        private static int D6 = 0;

        

        private String Opciones = "";

        public void Mostrar()
        {
            Console.WriteLine("************Bici "+ B +"************");
            Console.WriteLine("Numero de Bicicleta : " + N_BICI);
            Console.WriteLine("Para Alquilar: "+ B_Alquiler_S_N);
            Console.WriteLine("Color de Bicicleta: "+ Color_B);
            Console.WriteLine("Modelo: " + Modelo_B);
            Console.WriteLine("Imagen: " + Imagen);
            Console.WriteLine("Valor: $" + Efectivo);
                                  
            if (B == 1)
            {
                A1 = N_BICI;
                A2 = B_Alquiler_S_N;
                A3 = Color_B;
                A4 = Modelo_B;
                A5 = Imagen;
                A6 = Efectivo;
            }
            else{
                if (B == 2)
                {
                    B1 = N_BICI;
                    B2 = B_Alquiler_S_N;
                    B3 = Color_B;
                    B4 = Modelo_B;
                    B5 = Imagen;
                    B6 = Efectivo;
                    ALTO = "NO";
                }
                else{
                    if (B == 3)
                    {
                        C1 = N_BICI;
                        C2 = B_Alquiler_S_N;
                        C3 = Color_B;
                        C4 = Modelo_B;
                        C5 = Imagen;
                        C6 = Efectivo;
                    }
                    else
                    {
                        if (B == 4)
                        {
                            D1 = N_BICI;
                            D2 = B_Alquiler_S_N;
                            D3 = Color_B;
                            D4 = Modelo_B;
                            D5 = Imagen;
                            D6 = Efectivo;
                        }
                    }
                }
            }

            B = B + 1;

            if (B == 5)
            {
                Console.WriteLine("---------------------------------");
                Alquilar();
                B = 1;
            }
        }

        private String ALTO = "";

        public string Seguro = "";

        public void Alquilar()
        {
            
            int time = 5000;
            do
            {
                Console.WriteLine("Ingresa el Numero de la Bicicleta que deceas:");
                Console.Write("---> ");
                Opciones = Console.ReadLine();
                Console.WriteLine("--------------------------------");

                if (ALTO == null ||ALTO == "NO" || ALTO == "no" || ALTO == "nO" || ALTO == "No")
                {
                    Console.WriteLine("*** Lo siento pero esa Bicicleta ya esta ocupada ***");
                    Console.WriteLine("----------------------------------------------------");
                }

            } while (ALTO == null || ALTO == "NO" || ALTO == "no" || ALTO == "nO" || ALTO == "No");

            string C;

            do
            {       
                    switch (Opciones)
                    {  
                    case "1":
                        Console.Write("Ingresa el Tiempo de Alquiler (hora): ");
                        Tiempo_A = Console.ReadLine();
                        Console.Clear();
                        Pago();
                        break;
                    case "2":
                        Console.Write("Ingresa el Tiempo de Alquiler (hora): ");
                        Tiempo_A = Console.ReadLine();
                        Console.Clear();
                        Pago();
                        break;
                    case "3":
                        Console.Write("Ingresa el Tiempo de Alquiler (hora): ");
                        Tiempo_A = Console.ReadLine();
                        Console.Clear();
                        Pago();
                        break;
                    case "4":
                        Console.Write("Ingresa el Tiempo de Alquiler (hora): ");
                        Tiempo_A = Console.ReadLine();
                        Console.Clear();
                        Pago();
                        break;
                    }

                if (Opciones == null || Opciones == "1" || Opciones == "2" || Opciones == "3" || Opciones == "4")
                { C = "1"; }
                else { C = "0"; }

                if (C != "1")
                {
                    Console.WriteLine("Error......Vuelva a Diguitar un Número ");
                    Thread.Sleep(time);
                    Console.Clear();
                }

            } while (Opciones == null && Opciones == "1" && Opciones == "2" && Opciones == "3" && Opciones == "4");
        }

        public void Comprar()
        {
            
        }
    }
}
