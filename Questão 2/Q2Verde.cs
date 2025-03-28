using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Expressão (RPN): ");
        string expressao = Console.ReadLine();
        double resultado = AvaliarRPN(expressao);
        Console.WriteLine(resultado.ToString("F2", CultureInfo.InvariantCulture));
    }

    static double AvaliarRPN(string expressao)
    {
        Stack<double> pilha = new Stack<double>();

        foreach (char c in expressao)
        {
            if (char.IsDigit(c))
            {
                pilha.Push((double)char.GetNumericValue(c));
            }
            else if (c == '+' || c == '-' || c == '*' || c == '/')
            {
                if (pilha.Count < 2)
                {
                    throw new InvalidOperationException("Expressão inválida");
                }

                double b = pilha.Pop();
                double a = pilha.Pop();

                switch (c)
                {
                    case '+': pilha.Push(a + b); break;
                    case '-': pilha.Push(a - b); break;
                    case '*': pilha.Push(a * b); break;
                    case '/': pilha.Push(a / b); break;
                }
            }
        }

        if (pilha.Count != 1)
        {
            throw new InvalidOperationException("Expressão inválida");
        }

        return pilha.Pop();
    }
}
