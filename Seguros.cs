using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppdeBicicletas
{
    public class Seguros : AgregadoDecorator
    {
      public Seguros(Bicicletas orden) : base(orden) { }
      public override string Adicion()
      {
       var segurito = "Conta perdidas o algun robo de la bicicleta";
       return segurito;
      }
    }
}
