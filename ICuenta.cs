using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppdeBicicletas
{
    interface ICuenta
    {
        void Reguistro();

        void Login();

        void Vender();

        void Pago();

        void Alquilar();

        void Mostrar();

        void Comprar();
    }
}
