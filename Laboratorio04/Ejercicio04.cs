using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices; 
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    public class Ejercicio04
    {
        public int[] CalcularBilletes(int cantidad[0, 0, 0, 0, 0],  int billetes[100, 50, 20, 5, 1])
        {

            Console.WriteLine("Ingrese cantidad");
            cantidad = Convert.ToInt32(Console.ReadLine());
            if (cantidad>=100)
            {
                int div = cantidad % 100;
                int almacenado = cantidad - div;
                cantidad = cantidad - almacenado;


            }
            if (cantidad >= 50)
            {
                int div = cantidad % 50;
                int almacenado = cantidad - div;
                cantidad = cantidad - almacenado;


            }
            if (cantidad >= 20)
            {
                int div = cantidad % 20;
                int almacenado = cantidad - div;
                cantidad = cantidad - almacenado;


            }
            if (cantidad >= 5)
            {
                int div = cantidad % 5;
                int almacenado = cantidad - div;
                cantidad = cantidad - almacenado;


            }
            if (cantidad >= 1)
            {
                int div = cantidad % 1;
                int almacenado = cantidad - div;
                cantidad = cantidad - almacenado;


            }
           
            return new int [0, 0, 0, 0, 0, 0] {};
        }
    }
}
