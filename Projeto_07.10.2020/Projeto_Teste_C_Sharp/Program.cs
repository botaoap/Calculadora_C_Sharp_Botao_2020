using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace Projeto_Teste_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularListaString();
        }

        private static void CalcularListaString()
        {
            List<string> listaString;

            listaString = new List<string>();

            string _string;

            _string = "João";

            listaString.Add(_string);

            _string = "Maria";

            listaString.Add(_string);

            _string = "Roberto";

            listaString.Add(_string);


           
            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine(listaString[i]);
            }
              

            int n = 0;
            
            while (n <3)
            {
                Console.WriteLine(listaString[n]);

                n++;
            }
        }
        private static void CalcularLisraInt()
        {

        }
    }
}
