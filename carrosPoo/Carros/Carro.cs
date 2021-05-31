using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrosPoo.Carros
{
    public abstract class Carro
    {   


        public string Modelo { get; private set; }


        public int  VelMax  { get; private set; }

        public static int TotalCarro { get; private set; }

        protected int _velAtual;

        public int VelAtual { get { return _velAtual; }  set 
            { if (value < 0 || value > VelMax) 
                {
                    return;
                }
                _velAtual = value; 
            }

        }
        public Carro(string modelo, int velMax)
        {
            TotalCarro++;
            VelAtual = 0;
            VelMax = velMax;
            Modelo = modelo;
        }

        public abstract void Acelerar();

        public void Desacelerar()
        {
            this._velAtual -= 5;
            Console.WriteLine(VelAtual);
        }

    }
}
