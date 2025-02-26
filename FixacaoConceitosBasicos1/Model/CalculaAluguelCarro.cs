using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    internal class CalculaAluguelCarro
    {

        public static double Calcular(int dias, double quilometragemInicial,double quilometragemFinal)
        {
            int diaria = dias * 95;
            double quilometrosRodados = (quilometragemFinal - quilometragemInicial) * 0.35;

            double total = (double)diaria + quilometrosRodados;

            return total;
        }
    }
}
