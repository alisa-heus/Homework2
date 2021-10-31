using System;

namespace Task1Library
{
    public class Homework2
    {
       public static double Task1(int inputA, int inputB)
        {
            var result = (inputA * 5 + Math.Pow(inputB, 2)) / (inputB - inputA);
            return result;
        }

        public static void Task2(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        public static (int divided, int remainder) Task3(int numberA, int numberB)
        {
            int divided = numberA / numberB;
            int remainder = numberA % numberB;
            return (divided, remainder);
        }

        public static float Task4(float inputa, float inputb, float inputc)
        {
            float numberX = (inputc - inputb) / inputa;
            return numberX;
        }

        public static (float a, float b) Task5(float numberX1, float numberY1, float numberX2, float numberY2)
        {
            float a = (numberY2 - numberY1) / (numberX2 - numberX1);
            float b = numberY1 - a * numberX1;
            return (a, b);
        }
    }
}
