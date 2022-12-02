using System;

namespace Laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            double rightBorder = 1;
            double leftBorder = 0.2;
            double accuracy = 0.0001;
            int value = 10;

            double argument;
            double step;
            double function;
            double sumV = 0;
            double element = 1;
            double sumE = 0;
            int i;

            step = (rightBorder - leftBorder) / 10;

            for (argument = leftBorder; argument < rightBorder; argument += step)
            {
                function = 0.5 * Math.Log(argument);

                for(i = 0; i <= value; i++)
                {
                    for (int j = 0; j < 2 * i + 1; j++)
                        element *= ((argument - 1) / (argument + 1));
                  //  element = (1.0 / (2 * i + 1)) * Math.Pow(((argument - 1) / (argument + 1)), (2 * i + 1));
                    element *=(1.0 / (2 * i + 1));
                    sumV += element;
                    element = 1;
                }

               // element = 1;
                i = 0;

                do
                {
                    element = (1.0 / (2 * i + 1)) * Math.Pow(((argument - 1) / (argument + 1)), (2 * i + 1));
                    sumE += element;
                    i++;
                } while (Math.Abs(element) >= accuracy);

                if (Math.Abs(element) < accuracy)
                    sumE -= element;

                sumV =  Math.Round(sumV, 4);
                sumE = Math.Round(sumE, 4);
                function = Math.Round(function, 4);
                element = 1;

                Console.WriteLine($"X = {argument}    SN = {sumV}    SE = {sumE}   Y = {function}");

               

                sumE = 0;
                sumV = 0;
            }
        }
    }
}
