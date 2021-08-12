using System;

namespace Algoritmos
{
    class Basicos
    {
        static void Main(string[] args)
        {


            //bubbleSortArray();
            selectionSortArray();

            Console.Read();
        }

        private static void selectionSortArray()
        {
            int[] array = { 5, 6, 4, 1, 2, 0, -3, 7 };
            int aux;
            int posMin;

            for (int a = 0; a < array.Length; a++)
                Console.Write(array[a] + " ");


            for(int a = 0; a < array.Length; a++)
            {
                posMin = a;

                for(int p = a + 1; p < array.Length; p++)
                {
                    if(array[posMin] > array[p])
                    {
                        posMin = p;
                    }
                }

                aux = array[a];
                array[a] = array[posMin];
                array[posMin] = aux;
            }

            Console.Write("\n");

            for (int a = 0; a < array.Length; a++)
                Console.Write(array[a] + " ");
        }

        private static void bubbleSortArray()
        {

            int[] array = { 5, 6, 4, 1, 2, 0, -3, 7 };
            int iterations = 0;
            int aux;
            bool ordenado = false;

            for (int a = 0; a < array.Length; a++)
                Console.Write(array[a] + " ");

            while (!ordenado)
            {
                ordenado = true;

                for (int p = 0; p < array.Length - 1 - iterations; p++)
                {
                    if (array[p] > array[p + 1])
                    {
                        aux = array[p + 1];
                        array[p + 1] = array[p];
                        array[p] = aux;

                        ordenado = false;
                    }
                }
                iterations++;
            }


            Console.Write(" \n");
            for (int a = 0; a < array.Length; a++)
                Console.Write(array[a] + " ");

        }

        private static void isPrime(int number) {

            bool isp = true;

            if (number <= 1)
            {
                Console.WriteLine("no prime");
                isp = false;

            }else
            {
                for (int x = 2; x <= number /2; x++)
                {
                    if (number % x == 0)
                    {
                        isp = false;
                        Console.WriteLine("No prime"); break;
                    }
                        
                }

                if(isp)
                    Console.WriteLine($"prime {number}");
            }

        }

        private static int mutiplicar(int a, int b)
        {
            int result = 0;

            for(int x = 0; x < b; x++)
            {
                result += a;
            }
            
            return result;
        }

        private static int restar(int a, int b)
        {
            int max = (a < b) ? b : a;
            int min = (a < b) ? a : b;
            int result = 0;

            do
            {
                min++;
                result++;

            } while (min < max);

            return result;
        }
    }
}
