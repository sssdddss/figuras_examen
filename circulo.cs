using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leccion
{
    public class circulo:figura,ifigura
    {
        public double Pi;
        public double R2 { get; set; }
        
        public circulo( string nombre, string color, double R2):base (nombre, color)
        {
            this.Pi = 3.1416;
            this.R2 = R2;
            
        }

        public void calculodearea()
        {
            double area = 0;
            area = Pi * (R2 * R2);
            Console.WriteLine("El area del circulo es: " + area);

        }
        
    }
}
