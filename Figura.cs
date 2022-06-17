using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AportePOO
{
    class Figura
    {
        private string color;
        private string nombres;

        public void Imprimir() {
            Console.WriteLine("*************************");
            Console.WriteLine("Nombre:"+nombres+
                               "\nColor:"+ color );
            
        }


        public string Color { get => color; set => color = value; }
        public string Nombres { get => nombres; set => nombres = value; }
    }
}
