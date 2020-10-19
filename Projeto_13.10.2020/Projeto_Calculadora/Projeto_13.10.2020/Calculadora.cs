using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Projeto_13._10._2020
{
    
    class Calculadora
    {

        private static void CalcularSoma (double primeiroValor, double segundoValor)
        {
            double vloc_soma;

            vloc_soma = primeiroValor + segundoValor;

            Console.WriteLine("Soma " + primeiroValor + " + " + segundoValor + " = " + vloc_soma);
        }
        private static void CalcularSubtracao (double primeiroValor, double segundoValor)
        {
            double vloc_subtrai;

            vloc_subtrai = primeiroValor - segundoValor;

            Console.WriteLine("Soma " + primeiroValor + " - " + segundoValor + " = " + vloc_subtrai);
        }

        private static void fprg_multiplica (double p_valor1, double p_valor2)
        {
            double vloc_multiplica;

            vloc_multiplica = p_valor1 * p_valor2;

            Console.WriteLine("Soma " + p_valor1 + " * " + p_valor2 + " = " + vloc_multiplica);
        }
        private static void fprg_divide(double p_valor1, double p_valor2)
        {
            double vloc_divide;

            if (p_valor2 == 0)
            {
                Console.WriteLine("Divisão por zero não existe!");
            }
            else
            {
                vloc_divide = p_valor1 / p_valor2;
                Console.WriteLine("Soma " + p_valor1 + " / " + p_valor2 + " = " + vloc_divide);
            }
        }
        private static void MenuDeOperacoes()
        {
            Console.WriteLine(" ---------------------------- ");
            Console.WriteLine(" --- 1 - Soma             --- ");
            Console.WriteLine(" --- 2 - Suntração        --- ");
            Console.WriteLine(" --- 3 - Multipilicalção  --- ");
            Console.WriteLine(" --- 4 - Divisão          --- ");
            Console.WriteLine(" --- 5 - Sair             --- ");
            Console.WriteLine(" ---------------------------- ");
        }

        //public async void pprg_timer()
        //{
        //    await Task.Delay(1000);
        //}
        
        static void Main(string[] args)
        {


            while (true)
            {
                MenuDeOperacoes();

                Console.WriteLine("Escolha uma opção: ");

                int operacaoDesejada = Convert.ToInt32(Console.ReadLine());
                double SegundoValor = 0;
                double primeiroValor = 0;

                if (operacaoDesejada >= 1 && operacaoDesejada < 5)
                {
                Console.WriteLine("Escolha o Valor 1: ");

                primeiroValor = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Escolha o Valor 2: ");

                SegundoValor = Convert.ToDouble(Console.ReadLine());

                }
                if (operacaoDesejada == 1)
                {
                    CalcularSoma(primeiroValor, SegundoValor);

                } else if (operacaoDesejada == 2)
                {
                    CalcularSubtracao(primeiroValor,SegundoValor);
                
                } else if (operacaoDesejada == 3)
                {
                    fprg_multiplica(primeiroValor,SegundoValor);

                } else if (operacaoDesejada == 4)
                {
                    fprg_divide(primeiroValor,SegundoValor);
                
                } else if (operacaoDesejada == 5)
                {
                    Console.WriteLine("Obrigado por usar nosso programa!");
                    break;

                } else 
                {
                    Console.WriteLine("Opção Inválida!");
                                    
                }

                System.Threading.Thread.Sleep(2000);
                //pprg_timer();
                Console.Clear();
                
            }
                        
    
         }
    }
}
