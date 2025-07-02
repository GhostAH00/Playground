using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class Calculadora
    {
        public int Adicao(int numA, int numB)
        {

            return numA + numB;

        }

        public int Divisao(int numA, int numB)
        {
            if (numB  == 0)
            {
                return 0;
            }

            return numA / numB;
        }

    }
}
