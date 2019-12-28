using System;

namespace Consulta_CEP {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Bem vindo ao sistema de consulta de valores das entregas \n");

            string continuar = "";
            
            Console.Clear();
            Console.WriteLine ("Digite o numero do CEP que deseja verificar:");
            int cep = int.Parse(Console.ReadLine ());
            int validacacaoCEP = Convert.ToInt32(cep.ToString().PadLeft(1,'1'));
            int opcao = Convert.ToInt32(cep.ToString().Substring(0,4) );
            Console.WriteLine(opcao);
           do{

            switch (opcao) {
                case 8070:
                    {
                        Console.WriteLine ("\n O valor da taxa de entrega ficará ---> R$20,00");
                        Console.WriteLine ("\n Deseja continuar utilizando o sistema?");
                        continuar = Console.ReadLine();
                        break;
                    }
                case 8071:
                    {
                        Console.WriteLine ("\n O valor da taxa de entrega ficará ---> R$25,00");
                        Console.WriteLine ("\n Deseja continuar utilizando o sistema?");
                        continuar = Console.ReadLine();
                        break;
                    }
                default:
                    {
                        Console.WriteLine ("\n Não atendemos a esse CEP");
                        Console.WriteLine ("\n Deseja continuar utilizando o sistema?");
                        continuar = Console.ReadLine();
                        break;
                    }
                
            }
           }while(continuar == "sim");

           Console.WriteLine("\n Obrigado por Utilizar o sistema");
        }
    }
}