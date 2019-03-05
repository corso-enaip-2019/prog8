using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ok = CheckBrackets(@"
                namespace Brackets
                {
                    class Program
                    {
                        static void Main(string[] args)
                        {
                            bool ok = CheckBrackets("")

                            Console.ReadLine();
                        }
                        static bool CheckBrackets(string text)
                        {

                        }
                    }
                }");
            

            string strOk = ok ? "match" : "don't match"; //if booleano
            Console.WriteLine($"Brackets { strOk }");

            Console.ReadLine();
        }
        /// <summary>
        /// Verifica se il test passato ottiene un numero coererente di parentesi
        /// di apertura e chiusura "(", "[", "{"
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static bool CheckBrackets(string text)
        {
            char[] chars = text.ToCharArray();
            Stack<char> validChar = new Stack<char>();
            for (int i = 0; i < chars.Length; i++)
            {
                char currentChar = text[i];
                if (currentChar == '(' || currentChar == '[' || currentChar == '{')
                {
                    validChar.Push(currentChar);
                }
                else if (currentChar == ')')
                {
                    if (validChar.Count() == 0)
                        return false;
                    char lastChar = validChar.Peek();
                    if (lastChar == '(')
                    validChar.Pop();
                    else
                        return false;
                }
                else if (currentChar == ']')
                {
                    if (validChar.Count() == 0)
                        return false;
                    char lastChar = validChar.Peek();
                    if (lastChar == '[')
                        validChar.Pop();
                    else
                        return false;
                }
                else if (currentChar == '}')
                {
                    if (validChar.Count() == 0)
                        return false;
                    char lastChar = validChar.Peek();
                    if (lastChar == '{')
                        validChar.Pop();
                    else
                        return false;
                }
            }
            if (validChar.Count() == 0)
                return true;
            return false;
        }
    }
}