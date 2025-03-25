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

            Console.WriteLine("Op:");
            int op = int.Parse(Console.ReadLine());
            do
            {
                switch (op)
                {
                    case 1:
                        double resTem = double.Parse(Console.ReadLine());
                        tempo.Insert(0, resTem);
                        Console.WriteLine($"{op}\n{resTem}");
                        op = int.Parse(Console.ReadLine());
                        break;

                    case 2:
                        resTem = double.Parse (Console.ReadLine());
                        tempo.Add(resTem);
                        Console.WriteLine($"{op}\n{resTem}");
                        op = int.Parse(Console.ReadLine());
                        break;

                    case 3:
                        resTem = double.Parse (Console.ReadLine());
                        int resPos = int.Parse(Console.ReadLine());
                        tempo.Insert(resPos, resTem );
                        Console.WriteLine($"{op}\n{resTem}\n{resPos}");
                        op = int.Parse(Console.ReadLine());
                        break;

                    case 4:
                        double tempPos = tempo[0];
                        tempo.Remove(tempo[0]);
                        Console.WriteLine($"{op}\n{tempPos}");
                        op = int.Parse(Console.ReadLine());
                        break;

                    case 5:
                        tempPos = tempo[tempo.Count-1];
                        tempo.Remove (tempo[tempo.Count-1]);
                        Console.WriteLine($"{op}\n{tempPos}");
                        op = int.Parse(Console.ReadLine());
                        break;

                    case 6:
                        resPos = int.Parse(Console.ReadLine()); 
                        tempPos = tempo[resPos];
                        tempo.Remove(tempPos);
                        Console.WriteLine($"{op}\n{resPos}\n{tempPos}");
                        op = int.Parse(Console.ReadLine());
                        break;

                    case 7:
                        double temRmv = double.Parse (Console.ReadLine());
                        tempo.Remove(tempo.IndexOf(temRmv));
                        Console.WriteLine($"{op}\n{temRmv}");
                        op = int.Parse(Console.ReadLine());
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
                        Console.WriteLine($"{op}\n{tempPesq}\n{rept}");
                        op = int.Parse(Console.ReadLine());
                        break;

                    case 9:
                        Console.WriteLine($"{op}");
                        foreach(double temps in tempo)
                        {
                            Console.WriteLine(temps);
                        }
                        op = int.Parse(Console.ReadLine());
                        break;

                    case 10:
                        tempo.Sort();
                        Console.WriteLine($"{op}");
                        foreach (double temps in tempo)
                        {
                            Console.WriteLine(temps);
                        }
                        op = int.Parse(Console.ReadLine());
                        break;

                    case 11:
                        tempo.Sort();
                        tempo.Reverse();
                        Console.WriteLine($"{op}");
                        foreach (double temps in tempo)
                        {
                            Console.WriteLine(temps);
                        }
                        op = int.Parse(Console.ReadLine());
                        break;

                    case 12:
                        break;
                }
            } while (op != 0 && op <= 12);
        }
    }
}
