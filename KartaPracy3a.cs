using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            /*1. (easy) Napisz progrm z wykorzystaniem techniki iteracyjnej wyświetlający na ekranie poniższy ciąg znaków.
            Wejście: n
            Wyjście: ∗ − | ∗ − | ∗− | ∗− | ∗− | ∗− | ∗− | ...*/
            /*
            for (int i = 0; i < n; i++)
            {
                Console.Write("*-|");
            }
            */

            /*2. (easy) Napisz progrm z wykorzystaniem techniki iteracyjnej wyświetlający na ekranie poniższy ciąg znaków.
            Wejście: n
            Wyjście: ∗|| ∗ ∗ − − ∗ ∗ ∗ || ∗ ∗ ∗ ∗ − −....*/
            /*
            for (int i = 0; i < n; i++)
            {
                Console.Write("∗|| ∗ ∗ − − ∗ ∗ ∗ || ∗ ∗ ∗ ∗ − −");
            }
            */
            /*
            for (int i = 1; i < n+1; i++)
            {
                for (int j = 1; j < n+1; j++)
                {
                    if (n-i < j) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            */

            /*7. (medium) Napisz program z wykorzystaniem techniki iteracyjnej wyświetlający na ekranie poniższe ilustracje.
                Wejście: n
                Wyjście:*/
            /*
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    //if (i == 1 | j == 1 | i == n) Console.Write("* ");
                    //if (i == 2 & j == 1 | i == 2 & j == n) Console.Write("* ");
                    if (i == 1 | j == 1 | i == n | j == n | (i == n / 2 + 1 & j == n / 2 + 1));
                    //else Console.WriteLine(" ");
                }
                Console.WriteLine();
            }
            */

            //zad 6
            /*
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == n - j + 1) Console.Write("?");
                    else if (i == j) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            */

            //zad 7
            /*
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j == n / 2 + 1) Console.Write("*");
                    else if (i == n / 2 + 1) Console.Write("-");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            */

            //zad 4
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j == n / 2 + 1 & i == 1 | i == n & j == n / 2 + 1 | i == 2 & j == 2 | i == 2 & j == n-1 | i == 3 & j == 1 | i == 3 & j == n | i == 4 & j == n-1 | i == 4 & j == 2) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
