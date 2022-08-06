using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.    Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы.
//Проверить, корректно ли в ней расставлены скобки. Например, в строке ([]{})[] скобки расставлены корректно,
//а в строке ([]] — нет. Указание: задача решается однократным проходом по символам заданной строки слева
//направо; для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая, каждая
//закрывающая скобка в строке должна соответствовать скобке из вершины стека (при этом скобка с вершины
//стека снимается); в конце прохода стек должен быть пуст.   ([]{})[]
namespace Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите иследуемую строку");
            string element_Str = Console.ReadLine();
            Stack<char> stack_Str = new Stack<char>();
            bool proverka = true;
            foreach (char letter_C in element_Str)
            {
                //string letter_Str == letter_C;
                if (letter_C == '(')
                {
                    stack_Str.Push(')');
                }
                if (letter_C == '[')
                {
                    stack_Str.Push(']');
                }
                if (letter_C == '{')
                {
                    stack_Str.Push('}');
                }

                if ((letter_C == ')') || (letter_C == ']') || (letter_C == '}'))
                {
                    if (stack_Str.Count == 0 || stack_Str.Pop() != letter_C)
                    {
                        proverka = false;
                    }
                }
            }
            if (stack_Str.Count != 0)
            {
                proverka = false;
            }
            if (proverka == false)
                Console.WriteLine("Не верная строка");
            else
                Console.WriteLine("Верная строка");
            Console.ReadKey();
        }
    }
}
