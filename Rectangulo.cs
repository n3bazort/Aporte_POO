using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AportePOO
{
    internal class Rectangulo:Figura,IFigura
    {
        public int color { set; get; }
        public int nombres { set; get; }
        public int labase { set; get; }
        public int altura { set; get; }

        public Rectangulo(string nombres, string color, int labase, int altura)
        {
            this.Color = color;
            this.Nombres = nombres;
            this.labase = labase;
            this.altura = altura;
        }

       

        void IFigura.CalcularArea()
        {
            int area = labase*altura;
            Console.WriteLine("El area del Rectangulo es: " + area + "cm");
        }
    }
}
