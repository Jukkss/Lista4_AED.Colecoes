using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> filaDecolagem = new Queue<string>();
        int opcao;

        do
        {
            Console.Write("Op:\n");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine(filaDecolagem.Count);
                    break;
                case 2:
                    if (filaDecolagem.Count > 0)
                    {
                        Console.WriteLine(filaDecolagem.Dequeue());
                    }
                    break;
                case 3:
                    string identificador = Console.ReadLine();
                    filaDecolagem.Enqueue(identificador);
                    break;
                case 4:
                    foreach (var aviao in filaDecolagem)
                    {
                        Console.WriteLine(aviao);
                    }
                    break;
                case 5:
                    if (filaDecolagem.Count > 0)
                    {
                        Console.WriteLine(filaDecolagem.Peek());
                    }
                    break;
                case 6:
                    return;
                default:
                    break;
            }
        } while (true);
    }
}
