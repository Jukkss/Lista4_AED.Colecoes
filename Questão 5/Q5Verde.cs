using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string frase = Console.ReadLine().ToLower();
        string[] palavras = frase.Split(' ');
        Dictionary<string, int> contagem = new Dictionary<string, int>();

        foreach (var palavra in palavras)
        {
            if (contagem.ContainsKey(palavra))
            {
                contagem[palavra]++;
            }
            else
            {
                contagem[palavra] = 1;
            }
        }

        foreach (var item in contagem)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }
    }
}

