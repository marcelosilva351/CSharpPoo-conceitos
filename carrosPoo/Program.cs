using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using carrosPoo.Carros;

namespace carrosPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro gol = new Gol();
            Console.WriteLine("Modelo: " + gol.Modelo);
            Console.WriteLine("Velocidade atual: " +  gol.VelAtual);
            Console.WriteLine("Acelerando... Vel atual: ");
            gol.Acelerar();
            gol.Acelerar();
            gol.Acelerar();
            gol.Acelerar();
            Console.WriteLine("Desacelerando... ");
            gol.Desacelerar();
            gol.Desacelerar();
            gol.Desacelerar();

            CarroEsportivo ferrari = new Ferrari();
            Console.WriteLine("Modelo: " + ferrari.Modelo);
            Console.WriteLine("Velocidade atual: " + ferrari.VelAtual);
            Console.WriteLine("Acelerando... Vel atual: ");
            ferrari.Acelerar();
            ferrari.Acelerar();
            ferrari.Acelerar();
            ferrari.Acelerar();
            ferrari.Turbo();
            Console.WriteLine("Turbo ferrari, velocidade atual: " + ferrari.VelAtual);
            Console.WriteLine("Desacelerando... ");
            ferrari.Desacelerar();
            ferrari.Desacelerar();
            ferrari.Desacelerar();
            gol.VelAtual = -300;
            Console.WriteLine("Vel gol:" + gol.VelAtual);
            gol.VelAtual = 500;
            Console.WriteLine("Vel gol: " + gol.VelAtual);
            
          
            
            

            Console.WriteLine("Total carros criados: " + Carro.TotalCarro);
            Console.ReadLine();


        }
    }
}
