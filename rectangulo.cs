using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leccion
{
    public class rectangulo:figura, ifigura
    {
        public int Base { get; set; }
        public int altura { get; set; }

        public rectangulo(int Base, int altura,string nombre,string color) : base(nombre, color)
        {
            this.Base = Base;
            this.altura = altura;
        }
        public void calculodearea()
        {
            int Area = 0;
            Area = Base * altura;
            Console.WriteLine("El area del rectangulo es " + Area);
        }
        
    }
}
