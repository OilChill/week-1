﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        static void Main(string[] args)
        {

            input();
            Console.ReadKey();

        }

        public static void input()
        {

            int x;
            Console.WriteLine("Enter Sizeeeeee = ");
            x = Convert.ToInt32(Console.ReadLine());
            int[] y = new int[x];
            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine("Enter numberrrrrr = ");
                y[i] = Convert.ToInt32(Console.ReadLine());

            }
            process(y);

        }
        public static void process(int[] x)
        {

            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i != x.Length - 1; i++)
                {
                    if (x[i] > x[i + 1])
                    {
                        int temp = x[i];
                        x[i] = x[i + 1];
                        x[i + 1] = temp;
                        flag = true;
                    }
                }
            }
            output(x);
        }
        public static void output(int[] x)
        {
            Console.WriteLine("Sort ::::: ");
            for (int i = 0; i != x.Length; i++)
            {
                Console.Write(x[i]);
                Console.Write(" ");
            }

        }
       

    }
}
