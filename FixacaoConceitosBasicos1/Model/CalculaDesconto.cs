using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    internal class CalculaDesconto
    {

        public static double Calcular(double valor, double desconto)
        {

            double novoValor = valor - (valor * (desconto / 100));

            return novoValor;
        }
    }
}
