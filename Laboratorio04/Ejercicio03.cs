using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    public class Ejercicio03
    {
        public string Sumar(string num1, string num2)
        {
            decimal suma = 0;
            if (Convert.ToDecimal(num1) >= 0 && Convert.ToDecimal(num2) >= 0)
            
                {
                    suma = Convert.ToDecimal(num1) + Convert.ToDecimal(num2);
                }
                return Convert.ToString(suma);
            
        }
    }
} 
