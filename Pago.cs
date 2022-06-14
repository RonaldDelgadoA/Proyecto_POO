using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppdeBicicletas
{
    class Pago
    {
        public int ID_Pago { get; set; }
        public int Efectivo { get; set; }
        public string Paypal { get; set; }
        public int Monto { get; set; }
        public string Traferencia { get; set; }

        public Pago(int ID_Pago,int Efectivo, string Paypal, int Monto, string Traferencia)
        {
            this.ID_Pago = ID_Pago;
            this.Efectivo = Efectivo;
            this.Paypal = Paypal;
            this.Monto = Monto;
            this.Traferencia = Traferencia;
        }



    }
}
