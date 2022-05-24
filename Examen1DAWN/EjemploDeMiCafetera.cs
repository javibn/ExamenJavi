using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1DAWN
{
    /// <summary>
    /// Creación de un nuevo fichero para la segunda clase
    /// </summary>
    class EjemploDeMiCafetera
    {
        static void main()
        {
            Cafetera mi_cafetera_ejemplo = new Cafetera("EspressoBarista", "Procoffee", 0.6, 7);

            Console.WriteLine(mi_cafetera_ejemplo.Volumen);
            Console.WriteLine(mi_cafetera_ejemplo.consumocapsulas(5));
            Console.WriteLine(mi_cafetera_ejemplo.TotalDeCapsulas);
            Console.WriteLine(mi_cafetera_ejemplo.consumoagua(5));
            Console.WriteLine(mi_cafetera_ejemplo.Volumen);
            mi_cafetera_ejemplo.llenardep(0.5);
            Console.WriteLine(mi_cafetera_ejemplo.Volumen);
            mi_cafetera_ejemplo.reponercapsulas(3);
            Console.WriteLine(mi_cafetera_ejemplo.TotalDeCapsulas);
        }
    }
}