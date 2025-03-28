using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> musicas = new List<string>();
        int opcao;
        do
        {
            Console.Write("Op:\n");
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                continue;
            }

            switch (opcao)
            {
                case 1:
                    musicas.Add(Console.ReadLine());
                    break;
                case 2:
                    musicas.Insert(0, Console.ReadLine());
                    break;
                case 3:
                    string novaMusica = Console.ReadLine();
                    string musicaReferencia = Console.ReadLine();
                    int pos = musicas.IndexOf(musicaReferencia);
                    if (pos != -1)
                    {
                        musicas.Insert(pos + 1, novaMusica);
                    }
                    break;
                case 4:
                    if (musicas.Count > 0)
                    {
                        musicas.RemoveAt(0);
                    }
                    break;
                case 5:
                    if (musicas.Count > 0)
                    {
                        musicas.RemoveAt(musicas.Count - 1);
                    }
                    break;
                case 6:
                    string musicaRemover = Console.ReadLine();
                    musicas.Remove(musicaRemover);
                    break;
                case 7:
                    Console.WriteLine(string.Join("\n", musicas));
                    break;
                case 8:
                    string musicaPesquisa = Console.ReadLine();
                    if (musicas.Contains(musicaPesquisa))
                    {
                        Console.WriteLine("sim");
                    }
                    else
                    {
                        Console.WriteLine("não");
                    }
                    break;
                case 9:
                    return;
            }
        } while (true);
    }
}