/* Lista4_AED - Questão5 - João Victor Soares Souza */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_SemVerde_
{
    internal class Q5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma frase:");
            string frase = Console.ReadLine();
            frase = frase.ToLower();
            string[] palavras = frase.Split(' ');
            Dictionary<string, int> Classificacao = new Dictionary<string, int>();

            foreach (string s in palavras)
            {
                if (Classificacao.ContainsKey(s))
                {
                    Classificacao[s]++;
                }
                else
                {
                    Classificacao.Add(s, 1);
                }
            }
            foreach(KeyValuePair<string, int> pair in Classificacao)
            {
                Console.WriteLine(pair);
            }
        }
    }
}
