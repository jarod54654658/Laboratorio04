using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    public class Ejercicio05
    {
        public int[] CalcularBilletes(int monto, int[,] billetes)
        {
            int[] total = new int[billetes.GetLength(0)];

            for (int i = 0; i < total.Length; i++)
            {
                int billetesdeno = billetes[i, 0];
                int numerobillete = billetes[i, 1];

                int billetealeatorio = monto / billetesdeno;

                if (numerobillete < 0 || billetealeatorio <= numerobillete)
                {
                    total[i] = billetealeatorio;
                }
                else
                {
                    total[i] = numerobillete;
                }

                monto =   monto - (total[i] * billetesdeno);
            }


            Console.ReadKey();
            return total;
            
        }
    }
}
