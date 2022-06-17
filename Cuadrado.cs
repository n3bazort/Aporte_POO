using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AportePOO
{
    internal class Cuadrado:Figura,IFigura
    {
        public int labase { set; get; }
        public int altura { set; get; }
        public int lados { set; get; }

        public Cuadrado(string nombres, string color, int lados)
        {
            this.Color = color;
            this.Nombres = nombres;
            this.lados = lados;
          
        }

       

        void IFigura.CalcularArea()
        {
            int area = lados*lados;
            Console.WriteLine("El area del Cuadrado es: "+area+"cm");
        }
    }
}
