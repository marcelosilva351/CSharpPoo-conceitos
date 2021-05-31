using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrosPoo.Carros
{
    public class Ferrari : CarroEsportivo
    {
        public Ferrari() : base ("Ferrari", 350)
        {

        }
        public override void Acelerar()
        {
            VelAtual += 40;
            Console.WriteLine(VelAtual);
        }
     

    }
}
