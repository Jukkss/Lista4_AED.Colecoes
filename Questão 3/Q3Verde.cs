using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string sequencia = Console.ReadLine();
        Stack<char> pilha = new Stack<char>();

        foreach (char c in sequencia)
        {
            if (c == '(' || c == '[')
            {
                pilha.Push(c);
            }
            else if (c == ')' || c == ']')
            {
                if (pilha.Count == 0 || (c == ')' && pilha.Peek() != '(') || (c == ']' && pilha.Peek() != '['))
                {
                    Console.WriteLine("errada");
                    return;
                }
                pilha.Pop();
            }
        }

        Console.WriteLine(pilha.Count == 0 ? "correta" : "errada");
    }
}

