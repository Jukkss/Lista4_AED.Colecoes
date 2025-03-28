using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> tempos = new List<double>();
        int opcao;

        do
        {
            Console.Write("Op:\n");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    double tempoInicio = double.Parse(Console.ReadLine());
                    tempos.Insert(0, tempoInicio);
                    break;
                case 2:
                    double tempoFim = double.Parse(Console.ReadLine());
                    tempos.Add(tempoFim);
                    break;
                case 3:
                    double tempoPos = double.Parse(Console.ReadLine());
                    int posicao = int.Parse(Console.ReadLine());
                    if (posicao >= 0 && posicao <= tempos.Count)
                        tempos.Insert(posicao, tempoPos);
                    break;
                case 4:
                    if (tempos.Count > 0)
                    {
                        Console.WriteLine(tempos[0]);
                        tempos.RemoveAt(0);
                    }
                    break;
                case 5:
                    if (tempos.Count > 0)
                    {
                        Console.WriteLine(tempos[tempos.Count - 1]);
                        tempos.RemoveAt(tempos.Count - 1);
                    }
                    break;
                case 6:
                    int posRemover = int.Parse(Console.ReadLine());
                    if (posRemover >= 0 && posRemover < tempos.Count)
                    {
                        Console.WriteLine(tempos[posRemover]);
                        tempos.RemoveAt(posRemover);
                    }
                    break;
                case 7:
                    double tempoRemover = double.Parse(Console.ReadLine());
                    if (tempos.Contains(tempoRemover))
                    {
                        tempos.Remove(tempoRemover);
                    }
                    break;
                case 8:
                    double tempoBuscar = double.Parse(Console.ReadLine());
                    Console.WriteLine(tempos.Count(t => t == tempoBuscar));
                    break;
                case 9:
                    Console.WriteLine(string.Join(" ", tempos));
                    break;
                case 10:
                    tempos.Sort();
                    Console.WriteLine(string.Join(" ", tempos));
                    break;
                case 11:
                    tempos.Sort();
                    tempos.Reverse();
                    Console.WriteLine(string.Join(" ", tempos));
                    break;
                case 12:
                    return;
                default:
                    break;
            }
        } while (true);
    }
}

