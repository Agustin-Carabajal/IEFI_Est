using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEFI_Est
{
    internal class Conteo
    {
        public int Factorial(int numero)
        {
            if (numero < 0)
            {
                throw new ArgumentException("El número debe ser no negativo.");
            }
            if (numero == 0 || numero == 1)
            {
                return 1;
            }
            int resultado = 1;
            for (int i = 2; i <= numero; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        public int Combinacion(int n, int k)
        {
            if (k < 0 || n < 0 || k > n)
            {
                throw new ArgumentException("Los valores de n y k deben ser no negativos y k no debe ser mayor que n.");
            }
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }

        public int Permutacion(int n, int k)
        {
            if (k < 0 || n < 0 || k > n)
            {
                throw new ArgumentException("Los valores de n y k deben ser no negativos y k no debe ser mayor que n.");
            }
            return Factorial(n) / Factorial(n - k);
        }
    }
}
