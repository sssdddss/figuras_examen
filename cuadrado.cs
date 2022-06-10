using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leccion
{
    public class cuadrado : figura, ifigura
    {
        public int Lado1 { get; set; }
        public int Lado2 { get; set; }
        public int Lado3 { get; set; }
        public int Lado4 { get; set; }
        public cuadrado(string nombre, string color, int Lado1, int Lado2, int Lado3, int Lado4) : base(nombre, color)
        {
            this.Lado1 = Lado1;
            this.Lado2 = Lado2;
            this.Lado3 = Lado3;
            this.Lado4 = Lado4;
        }
        public void calculodearea()
        {
            int Area = 0;
            Area = Lado1 + Lado2 + Lado3 + Lado4;
            Console.WriteLine("El area del cuadrado es " + Area);
        }

    }
}
