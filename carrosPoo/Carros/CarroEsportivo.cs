using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrosPoo.Carros
{
    public abstract class CarroEsportivo : Carro, IEsportivo
    {
        public CarroEsportivo(string modelo, int velMax) : base(modelo, velMax)
        {

        }

        public void Turbo()
        {
            base.VelAtual *= 2;

        }
    }
}
