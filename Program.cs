using System;
using System.Collections.Generic;

class Program
{
    static bool EstaBalanceado(string expresion)
    {
        Stack<char> pila = new Stack<char>();
        foreach (char c in expresion)
        {
            if (c == '(' || c == '{' || c == '[')
                pila.Push(c);
            else if (c == ')' || c == '}' || c == ']')
            {
                if (pila.Count == 0) return false;
                char tope = pila.Pop();
                if (!EsPar(tope, c)) return false;
            }
        }
        return pila.Count == 0;
    }

    static bool EsPar(char apertura, char cierre)
    {
        return (apertura == '(' && cierre == ')') ||
               (apertura == '{' && cierre == '}') ||
               (apertura == '[' && cierre == ']');
    }

    static void Main()
    {
        Console.WriteLine("Ingrese la expresión:");
        string expresion = Console.ReadLine();

        if (EstaBalanceado(expresion))
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula no balanceada.");
    }
}
