using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppdeBicicletas
{
    public class BicicletaBasica : Bicicletas
    {
        public override string Adicion(){
        var segurito = "Has agregado el seguro adicional";
        return segurito;
        }
    }
}
