using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    internal class CalculaIMC
    {

        public static string Calcular(double altura, double peso, string genero)
        {
            double imc = peso / (altura * altura);


            if (imc < 18.5)
            {
                return "abaixo do peso";
            } else if( imc >= 18.5 && imc < 25){
                return "peso ideal(parabéns)";
            }
            else if (imc >= 25 && imc < 30)
            {
                return "levemente acima do peso";
            }
            else if (imc >= 30 && imc < 35)
            {
                return "obesidade grau I";
            }
            else if (imc >= 35 && imc < 40)
            {
                return "obesidade grau II (severa)";
            }else
            {
                return "obesidade grau III(mórbida)";
            };

        }

    }
}
