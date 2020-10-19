using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Projeto_13._10._2020
{
    
    class Calculadora
    {
        
        private static void fprg_soma (double p_valor1, double p_valor2)
        {
            double vloc_soma;

            vloc_soma = p_valor1 + p_valor2;

            Console.WriteLine("Soma " + p_valor1 + " + " + p_valor2 + " = " + vloc_soma);
        }
        private static void fprg_subtrai (double p_valor1, double p_valor2)
        {
            double vloc_subtrai;

            vloc_subtrai = p_valor1 - p_valor2;

            Console.WriteLine("Soma " + p_valor1 + " - " + p_valor2 + " = " + vloc_subtrai);
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
        private static void pprg_menu()
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
                pprg_menu();

                Console.WriteLine("Escolha uma opção: ");

                int vprg_opcao = Convert.ToInt32(Console.ReadLine());
                double vprg_valor2 = 0;
                double vprg_valor1 = 0;

                if (vprg_opcao >= 1 && vprg_opcao < 5)
                {
                Console.WriteLine("Escolha o Valor 1: ");

                vprg_valor1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Escolha o Valor 2: ");

                vprg_valor2 = Convert.ToDouble(Console.ReadLine());

                }
                if (vprg_opcao == 1)
                {
                    fprg_soma(vprg_valor1, vprg_valor2);

                } else if (vprg_opcao == 2)
                {
                    fprg_subtrai(vprg_valor1,vprg_valor2);
                
                } else if (vprg_opcao == 3)
                {
                    fprg_multiplica(vprg_valor1,vprg_valor2);

                } else if (vprg_opcao == 4)
                {
                    fprg_divide(vprg_valor1,vprg_valor2);
                
                } else if (vprg_opcao == 5)
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
