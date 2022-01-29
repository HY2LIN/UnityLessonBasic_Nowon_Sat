using System;

namespace UnityLesson_Csharp_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 14;
            int b = 5;
            int c = 0;

            c = OperatorMehods.Sum(a, b); // c = a + b;
            c = a - b;
            c = a / b;
            c = a % b;
            c = a * b;

            c++; // c = c + 1;
            c--; // c = c - 1;

            bool result;
            result = a == b;
            result = a != b;

            bool A = true;
            bool B = false;

            result = A | B;
            result = A & B;
            result = A ^ B;
            result = !A;

            result = A || B;
            result = A && B;

            int x = 1;

            c = a | b;
            c = a & b;
            c = a ^ b;
            c = ~a;
            c = a << x;
            c = a >> x;


        }
    }
}
