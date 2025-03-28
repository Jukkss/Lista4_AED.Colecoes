/* Lista4_AED - Questão2 - João Victor Soares Souza */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_SemVerde_
{
    internal class Q3
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            Console.WriteLine("Informe a sequencia: ");
            string sequencia = Console.ReadLine();

            foreach (char c in sequencia)
            {
                if (c == '(' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']') 
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("Sequencia correta");
            }
            else
            {
                Console.WriteLine("Sequencia incorreta");
            }
        }
    }
}
