using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    internal class MetrosMilimetros
    {
        public static double Converter(double num)
        {

            double milimetro = num * 1000;
            return milimetro;
        }

    }
}
