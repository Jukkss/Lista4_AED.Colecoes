/* Lista4_AED - Questão1 - João Victor Soares Souza */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_SemVerde_
{
    internal class Q1
    {
        static void Main(string[] args)
        {
            List <double> tempos = new List<double>();
            Console.WriteLine("Escolha uma opção de 1 a 12");
            int op = int.Parse(Console.ReadLine());
            do
            {
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Tempo no início: ");
                        double tempoInicio = double.Parse(Console.ReadLine());
                        tempos.Insert(0, tempoInicio);
                        break;
                    case 2:
                        Console.WriteLine("Tempo no final: ");
                        double tempoFinal = double.Parse(Console.ReadLine());
                        tempos.Add(tempoFinal);
                        break;
                    case 3:
                        Console.WriteLine("Tempo: ");
                        double tempoPos = double.Parse(Console.ReadLine());
                        Console.WriteLine("Posição: ");
                        int pos = int.Parse(Console.ReadLine());
                        tempos.Insert(pos, tempoPos);
                        break;
                    case 4:
                        if (tempos.Count > 1)
                        { 
                            double tempoInicioRemovido = tempos[0];
                            tempos.RemoveAt(0);
                            Console.WriteLine($"Tempo removido: {tempoInicioRemovido}");
                        }
                        else { Console.WriteLine("Sem elementos para a remoção"); }
                        break;
                    case 5:
                        if (tempos.Count > 1)
                        {
                            double tempoFinalRemovido = tempos[tempos.Count - 1];
                            tempos.RemoveAt(tempos.Count - 1);
                            Console.WriteLine($"Tempo removido: {tempoFinalRemovido}");
                        }
                        else { Console.WriteLine("Sem elementos para a remoção"); }
                        break;
                    case 6:
                        Console.WriteLine("Posição a ser removida: ");
                        pos = int.Parse(Console.ReadLine());
                        if (tempos.Count >= pos)
                        {
                            double tempoRemovido = tempos[pos];
                            tempos.RemoveAt(pos);
                            Console.WriteLine($"Tempo removido: {tempoRemovido}");
                        }
                        else { Console.WriteLine("Sem elementos nessa posição"); }
                        break;
                    case 7:
                        Console.WriteLine("Tempo a ser removido: ");
                        double tempoRemovidoPesq = double.Parse(Console.ReadLine());
                        tempos.Remove(tempoRemovidoPesq);
                        break;
                    case 8:
                        Console.WriteLine("Tempo a ser pesquisado: ");
                        double tempoPesq = double.Parse(Console.ReadLine());
                        int cont = 0;
                        foreach (double tempo in tempos)
                        {
                            if (tempoPesq == tempo)
                            {
                                cont++;
                            }
                        }
                        Console.WriteLine($"Tempo repete {cont} vezes");
                        break; 
                    case 9:
                        foreach (double tempo in tempos)
                        {
                            Console.WriteLine(tempo);
                        }
                        break;
                    case 10:
                        tempos.Sort();
                        foreach (double tempo in tempos)
                        {
                            Console.WriteLine(tempo);
                        }
                        break;
                    case 11:
                        tempos.Sort();
                        tempos.Reverse();
                        foreach (double tempo in tempos)
                        {
                            Console.WriteLine(tempo);
                        }
                        break;
                    case 12:
                        return;
                    default:
                        Console.WriteLine("Informe uma opção válida");
                        break;
                }
                Console.WriteLine("Informe uma opção: ");
                op = int.Parse(Console.ReadLine());

            } while (op != 12);
        }
    }
}
