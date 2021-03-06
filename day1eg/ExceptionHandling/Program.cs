﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            acceptname an = new acceptname();
            try
            {
                an.inputName();

            }
            catch(UpperNameException ex)
            {
                Console.WriteLine(ex.Message);

            }
            try
            {
                int a, b, c;
                a = 100;
                b = 0;
                c = 0;
                c = a / b;
                Console.WriteLine("div:" + c);
                int[] arr = new int[3];
                arr[7] = 49;
                File.Open("c:\\test.txt", FileMode.Open);
            }
            catch(DivideByZeroException de)
            {
                Console.WriteLine(de.Message);

            }
            catch(FileNotFoundException fe)
            {
                Console.WriteLine(fe.Message);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally block...");
                GC.Collect();

            }
        }
    }
}
