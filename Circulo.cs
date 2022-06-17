using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AportePOO
{
    class Circulo : Figura,IFigura
    {
        public int color { set; get; }
        public int nombres { set; get; }
        public int radio { set; get; }

        public Circulo(string nombres, string color,int radio)
        {
            this.Color = color;
            this.Nombres = nombres;
            this.radio = radio;
        }


            void  IFigura.CalcularArea()
        {
            double pi=Math.PI;
            double r1=Math.Pow(radio,2);
            int area = (int)(r1 * pi);
            Console.WriteLine("El area del Círculo es: " + area+" cm");
        }
    }

}
