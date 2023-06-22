using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ativiade07
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcao;
            
            double receber;


            Console.WriteLine(" Escolha a opção de café: \n");
            Console.WriteLine(" 1- Café expresso R$ 3.00 \n 2- Capuccino R$ 4.50 \n 3- Mocaccino R$ 6.00 \n 4- Água quente R$ 1.00");
            
            Console.WriteLine(" Ok, agora digite o valor válido");
            receber = Double.Parse(Console.ReadLine());

            opcao = Int32.Parse(Console.ReadLine());
            if (opcao == 1 && receber >= 3.00)
            {
                Console.WriteLine(" Você digitou o valor válido, Retirei seu café ");
            }
            else
            {
                Console.WriteLine(" Esse valor não é válido!");
            }

              
            if (opcao == 2)
            {
                
                if (receber >= 4.50)
                {
                    Console.WriteLine(" Você digitou o valor válido, Retirei seu Capuccino ");
                   


                }
                else
                {
                    Console.WriteLine(" Esse valor não é válido!");
                    return;
                }
            }

            if (opcao == 3)
            {
               
                if (receber >= 6.00)
                {
                    Console.WriteLine(" Você digitou o valor válido, Retirei seu Capuccino ");

                    

                }
                else
                {
                    Console.WriteLine(" Esse valor não é válido!");
                    return;
                }
            }

            if (opcao == 4)
            {
               
                if (receber >= 1.00)
                {
                    Console.WriteLine(" Você digitou o valor válido, Retirei seu Capuccino ");

                    
                }
                else
                {
                    Console.WriteLine(" Esse valor não é válido!");
                    return;
                }
            }


            Console.ReadKey();
        }
    }
}
