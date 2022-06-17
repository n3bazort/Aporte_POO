using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AportePOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo Circulo1 = new Circulo("Circulo","Azul",10);
            Rectangulo Rectangulo1 = new Rectangulo("Rectangulo","Amarillo",4,6);
            Cuadrado Cuadrado1 = new Cuadrado("Cuadrado","Verde",8);


            List<Figura> Lalista = new List<Figura>
            {
                Circulo1,
                Rectangulo1,
                Cuadrado1
            };

            foreach (Figura b in Lalista)
            {
                Console.WriteLine("");
                b.Imprimir();
            }

            foreach (IFigura metodos in Lalista)
            {
               
                metodos.CalcularArea();
               
            }
            Console.ReadLine();
        }

    }
}
