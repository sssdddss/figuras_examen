using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leccion
{
    public class Program
    {
        static void Main(string[] args)
        {
            cuadrado cuadrado1 = new cuadrado("Cuadrado", "Rojo", 3, 1, 6, 9);
            cuadrado1.mostrardatos();
            rectangulo rectangulo1 = new rectangulo(5,2,"rectangulo","amarillo");
            rectangulo1.mostrardatos();
            circulo circulo1 = new circulo("Circulo", "negro", 2.6);
            circulo1.mostrardatos();
            List<ifigura> formasgeometricas = new List<ifigura>();
            formasgeometricas.Add(cuadrado1);
            formasgeometricas.Add(rectangulo1);
            formasgeometricas.Add(circulo1);
            foreach (ifigura figura in formasgeometricas)
            {
                figura.calculodearea();

            }
    }
}
