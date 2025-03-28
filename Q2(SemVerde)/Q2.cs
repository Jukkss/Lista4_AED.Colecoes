/* Lista4_AED - Questão2 - João Victor Soares Souza */
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_SemVerde_
{
    internal class Q2
    {
        static void Main(string[] args)
        {
            Stack<double> PolonesaInv = new Stack<double>();
            Console.WriteLine("Informe a operação Polonesa inversa: ");
            string elementos = Console.ReadLine();
            double num;
            foreach (char element in elementos)
            {
                if (element != '-' &&  element !=  '+' && element != '*' && element != '/')
                {
                    num = char.GetNumericValue(element);
                    PolonesaInv.Push(num);
                }
                else
                {
                    if (element == '-')
                    {
                        double num1 = PolonesaInv.Pop();
                        double num2 = PolonesaInv.Pop();
                        PolonesaInv.Push(num2-num1);
                    }
                    else if (element == '+')
                    {
                        double num1 = PolonesaInv.Pop();
                        double num2 = PolonesaInv.Pop();
                        PolonesaInv.Push(num2 + num1);
                    }
                    else if (element == '*')
                    {
                        double num1 = PolonesaInv.Pop();
                        double num2 = PolonesaInv.Pop();
                        PolonesaInv.Push(num2 * num1);
                    }
                    else if (element == '/')
                    {
                        double num1 = PolonesaInv.Pop();
                        double num2 = PolonesaInv.Pop();
                        PolonesaInv.Push(num2 / num1);
                    }
                }
            }
            double result = PolonesaInv.Peek();
            Console.WriteLine();
        }
    }
}
