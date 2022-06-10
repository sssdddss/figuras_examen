using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leccion
{
    public class figura
    {
        public string nombre { get; set; }
        public string color { get; set; }

        public figura (string nombre, string color)
        {
            this.nombre= nombre;
            this.color= color;
        }
        public void mostrardatos()
        {
            Console.WriteLine("El nombre: " + nombre);
            Console.WriteLine("El color: " + color);
        }
    }
}
