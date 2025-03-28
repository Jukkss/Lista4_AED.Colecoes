/* Lista4_AED - Questão4 - João Victor Soares Souza */
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão4
{
    internal class Q4
    {
        static void Main(string[] args)
        {
            Queue<string> Pista = new Queue<string>();
            Console.WriteLine("Selecione uma opção de 1 a 6: ");
            int op = int.Parse(Console.ReadLine());

            do
            {
                switch (op)
                {
                    case 1:
                        Console.WriteLine($"Há {Pista.Count} aviões na fila.");
                        break;

                    case 2:
                        string aviaoSaiu = Pista.Peek();
                        Pista.Dequeue();
                        Console.WriteLine($"Avião {aviaoSaiu} decolou.");
                        break;

                    case 3:
                        Console.WriteLine("Adicionar avião:");
                        string aviaoEntrando = Console.ReadLine();
                        Pista.Enqueue( aviaoEntrando );
                        Console.WriteLine($"Avião {aviaoEntrando} adicionado.");
                        break;

                    case 4:
                        foreach (string avioes in Pista)
                        {
                            Console.WriteLine(avioes);
                        }
                        break;

                    case 5:
                        string primeiroAviao = Pista.Peek();
                        Console.WriteLine(primeiroAviao);
                        break;

                    case 6:
                        return;
                    
                    default:
                        Console.WriteLine("selecione uma opção válida");
                        break;
                }
                Console.WriteLine("Selecione uma opção: ");
                op = int.Parse(Console.ReadLine());
            } while (op != 6);
        }
    }
}
