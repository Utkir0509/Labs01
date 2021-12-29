using System;

namespace tema6z2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A=1, B=3, C=5, X;
            Console.WriteLine($"Значения переменных изначально: {A}, {B}, {C}");
            X = B;
            B = A;
            A = C;
            C = X;
            Console.WriteLine($"Новые значения переменных: A: {A}, B: {B}, C: {C}");
        }
    }
}
