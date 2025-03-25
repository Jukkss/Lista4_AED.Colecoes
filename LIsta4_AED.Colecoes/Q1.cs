/* Lista4_AED.Coleções - Questão1 - João Victor Soares Souza */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIsta4_AED.Colecoes
{
    internal class Q1
    {
        static void Main(string[] args)
        {
            List <double> tempo = new List<double> ();

            int op = int.Parse(Console.ReadLine());
            do
            {
                switch (op)
                {
                    case 1:
                        double resTem = double.Parse(Console.ReadLine());
                        tempo.Insert(1, resTem);
                        Console.WriteLine($"Op:\n{op}\n{resTem}");
                    break;

                    case 2:
                        resTem = double.Parse (Console.ReadLine());
                        tempo.Insert(tempo.Count-1, resTem);
                        Console.WriteLine($"Op:\n{op}\n{resTem}");
                    break;

                    case 3:
                        resTem = double.Parse (Console.ReadLine());
                        int resPos = int.Parse(Console.ReadLine());
                        tempo.Insert(resPos, resTem );
                        Console.WriteLine($"Op:\n{op}\n{resTem}\n{resPos}");
                    break;

                    case 4:
                        double tempPos = tempo[0];
                        tempo.Remove(tempo[0]);
                        Console.WriteLine($"Op:\n{op}\n{tempPos}");
                    break;

                    case 5:
                        tempPos = tempo[tempo.Count-1];
                        tempo.Remove (tempo[tempo.Count-1]);
                        Console.WriteLine($"Op:\n{op}\n{tempPos}");
                    break;

                    case 6:
                        resPos = int.Parse(Console.ReadLine()); 
                        tempPos = tempo[resPos];
                        tempo.Remove(tempPos);
                        Console.WriteLine($"Op:\n{op}\n{resPos}\n{tempPos}");
                    break;

                    case 7:
                        double temRmv = double.Parse (Console.ReadLine());
                        tempo.Remove(tempo.IndexOf(temRmv));
                        Console.WriteLine($"Op:\n{op}\n{temRmv}");
                    break;

                    case 8:
                        double tempPesq = double.Parse (Console.ReadLine());
                        int rept = 0;
                        foreach(double temps in tempo)
                        {
                            if (temps == tempPesq)
                            {
                                rept++;
                            }
                        }
                        Console.WriteLine($"Op:\n{op}\n{tempPesq}\n{rept}");
                    break;

                    case 9:
                        Console.WriteLine($"Op:\n{op}");
                        foreach(double temps in tempo)
                        {
                            Console.WriteLine(temps);
                        }
                    break;

                    case 10:
                        tempo.Sort();
                        Console.WriteLine($"Op:\n{op}");
                        foreach (double temps in tempo)
                        {
                            Console.WriteLine(temps);
                        }
                    break;

                    case 11:
                        tempo.Sort();
                        tempo.Reverse();
                        Console.WriteLine($"Op:\n{op}");
                        foreach (double temps in tempo)
                        {
                            Console.WriteLine(temps);
                        }
                    break;

                    case 12:
                        break;
                }
            } while (op != 0 && op <= 12);
        }
    }
}
