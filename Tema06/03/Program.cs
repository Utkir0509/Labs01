using System;

namespace tema6z3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 1, B = 3, C = 5, X;
            Console.WriteLine($"Значения переменных изначально: {A}, {B}, {C}");
            X = C;
            C = A;
            A = B;
            B = X;  
            Console.WriteLine($"Новые значения переменных: A: {A}, B: {B}, C: {C}");
        }
    }
}