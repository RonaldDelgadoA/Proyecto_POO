using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppdeBicicletas
{
    public class AgregadoDecorator : Bicicletas
    {
        protected Bicicletas orden;
        public AgregadoDecorator(Bicicletas orden)
        {
            this.orden = orden;
        }
        public override string Adicion()
        {
            return orden.Adicion();
        }
    }
}
