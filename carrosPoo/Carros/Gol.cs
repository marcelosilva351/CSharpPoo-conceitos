using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrosPoo.Carros
{
    public class Gol : Carro
    {
        public Gol() : base("Gol", 180)
        {

        }

        public override void Acelerar()
        {
            VelAtual += 10;
            Console.WriteLine(VelAtual);
        }
    }
}
