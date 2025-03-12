
/*
 * As classes a serem dsenvolvidas devem atender aos seguintes requisitos:
 * - Devem estar na pasta Model
 * - Para a classe SomaDoisNumeros, deve-se criar um método estático chamado Somar que recebe dois inteiros e retorna a soma deles
 * - Para a classe MetrosMilimetros, deve-se criar um método estático chamado Converter que recebe um double e retorna o valor em milímetros
 * - A  classe CalculaAumento deve ter um método estático chamado Calcular que recebe um double salario e um double aumento e retorna o valor do salário com o aumento aplicado
 * A classe CalculaDesconto deve ter um método estático chamado Calcular que recebe um double valor e um double desconto e retorna o valor com o desconto aplicado
 * - A classe CalculaAluguelCarro deve ter um método estático chamado Calcular que recebe um int dias, um int quilometragemInicial, um int quilometragemFinal e retorna o valor total do aluguel
 */

using System;
using FixacaoConceitosBasicos1.Model;

bool saida = true;

while (saida)
{


    try
    {
        Console.WriteLine("""
        Menu

        [0] - Sair
        [1] - Soma de dois números
        [2] - Conversão de metros para milímetros
        [3] - Cálculo de IMC 
        
        """);

        Console.WriteLine("Escolha uma opção:");
        int opcao = int.Parse(Console.ReadLine());


        switch (opcao)
        {
            case 0:
            Console.WriteLine("Saindo...");
                saida = false;
                break;
        case 1:
            SomaDoisNumeros somador = new SomaDoisNumeros();
            Console.WriteLine("Primeiro valor");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(somador.Somar(num1, num2));
            break;
        case 2:
            Console.WriteLine("Metroxmilimetro");
                Console.WriteLine("Insira os metros");
                int metros = int.Parse(Console.ReadLine());
                Console.WriteLine("O valor em milimetros é " + MetrosMilimetros.Converter(metros));
            break;
        case 3:
            Console.WriteLine("Digite sua altura");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu peso");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu gênero");
            string genero = Console.ReadLine();
            Console.WriteLine(CalculaIMC.Calcular(altura, peso, genero));
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Insira um valor válido. Erro: " + e);
    };

    //try
    //{
    //    SomaDoisNumeros somador = new SomaDoisNumeros();

    //    Console.WriteLine("Primeiro valor");
    //    int num1 = int.Parse(Console.ReadLine());
    //    Console.WriteLine("Segundo valor");
    //    int num2 = int.Parse(Console.ReadLine());

    //    Console.WriteLine(somador.Somar(num1, num2));

    //    Console.WriteLine("Metroxmilimetro");
    //    Console.WriteLine(MetrosMilimetros.Converter(22));

    //    break;
    //}
    //catch (Exception e)
    //{
    //    Console.WriteLine("Insira um valor válido. Erro: " + e);
    //}

}

