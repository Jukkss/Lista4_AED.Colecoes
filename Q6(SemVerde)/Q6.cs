/* Lista4_AED - Questão6 - João Victor Soares Souza */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6_SemVerde_
{
    internal class Q6
    {
        static void Main(string[] args)
        {
            LinkedList<string> Playlist = new LinkedList<string>();

            Console.WriteLine("Escolha uma opção: ");
            int op = int.Parse(Console.ReadLine());

            do
            {
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Musica no final: ");
                        string musicaFinal = Console.ReadLine();
                        Playlist.AddLast(musicaFinal);
                        break;

                    case 2:
                        Console.WriteLine("Musica no começo: ");
                        string musicaCemeco = Console.ReadLine();
                        Playlist.AddFirst(musicaCemeco);
                        break;

                    case 3:
                        Console.WriteLine("Musica a ser procurada: ");  
                        string musicaPesq = Console.ReadLine();
                        LinkedListNode<string> noPesq;
                        noPesq = Playlist.Find(musicaPesq);
                        Console.WriteLine("Musica a ser adicionada: ");
                        string musicaAdicionar = Console.ReadLine();
                        Playlist.AddAfter(noPesq, musicaAdicionar);
                        break;

                    case 5:
                        Console.WriteLine("Musica remover final:");
                        string musicaRemoverF = Console.ReadLine();
                        LinkedListNode<string> noRemoverF;
                        noRemoverF = Playlist.Find(musicaRemoverF);
                        Playlist.Remove(noRemoverF);
                        break;

                    case 4:
                        Console.WriteLine("Musica remover final:");
                        string musicaRemoverC = Console.ReadLine();
                        LinkedListNode<string> noRemoverC;
                        noRemoverC = Playlist.Find(musicaRemoverC);
                        Playlist.Remove(noRemoverC);
                        break;

                    case 6:
                        Console.WriteLine("Musica remover: ");
                        string musicaRemover = Console.ReadLine();
                        Playlist.Remove(musicaRemover);
                        break;

                    case 7:
                        foreach (string s in Playlist)
                        {
                            Console.WriteLine(s);
                        }
                        break;

                    case 8:
                        Console.WriteLine("Musica a ser pesquisada: ");
                        musicaPesq = Console.ReadLine();
                        if (Playlist.Contains(musicaPesq))
                        {
                            Console.WriteLine("Musica conta na lista");
                        }
                        else
                        {
                            Console.WriteLine("Musica nao consta na lista");
                        }
                        break;
                    case 9:
                        return;
                    default:
                        Console.WriteLine("opção invalida");
                        break;
                }

                Console.WriteLine("Escolha uma opção: ");
                op = int.Parse(Console.ReadLine());
            } while (op != 9);
        }
    }
}
