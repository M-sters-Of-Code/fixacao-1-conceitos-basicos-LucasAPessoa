using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    internal class CalculaAumento
    {

        public static double Calcular(double salario, double aumento) {

            double novoSalario = salario + (salario * (aumento / 100));

            return novoSalario;
        }
    }
}
