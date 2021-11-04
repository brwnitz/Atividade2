using System;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma das opções abaixo para começar");
            Console.WriteLine("Opção 1 - Raiz quadrada");
            Console.WriteLine("Opção 2- Área de uma circunferência");
            
            int type = Int32.Parse(Console.ReadLine());

            if (type == 1)
            {
                Console.WriteLine("Digite o valor que deseja tirar a raíz");
                Console.WriteLine("Raíz de: ");
                double radicando = double.Parse(Console.ReadLine());
                if (radicando >= 0)
                {
                    double raiz = Math.Pow(radicando, 0.5);
                    Console.WriteLine("A raíz quadrada de " + radicando + " é: " + raiz);
                }
                else
                {
                    Console.WriteLine("Insira um valor positivo.");
                }

            }
            if (type == 2)
            {
                double raio = 0;
                double area = 0;
                Console.WriteLine("Digite o valor do raio da circunferência");
                Console.WriteLine("Raio: ");                                               
                    raio = Convert.ToDouble(Console.ReadLine());
                    area = Math.PI * Math.Pow(raio, 2);
                    Console.WriteLine("A área da circunferência de " + raio.ToString() + " é:" + area);   
                if (raio < 0)
                {
                    Console.WriteLine("Insira um valor positivo.");
                }

            }
            if (type > 2)
            {
                Console.WriteLine("Insira um valor compatível.");
            }
            if (type < 0)
            {
                Console.WriteLine("Insira um valor compatível.");
            }
        }
    }
}
