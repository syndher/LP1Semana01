﻿using System ;
using System.Security.Cryptography.X509Certificates;

namespace MeuPrograma
    {
        /// <summary>
        /// Chooses the class
        /// </summary>
        class Program
        {
            /// <summary>
            /// Starts the script to add two numbers given by the user
            /// </summary>
            /// <param name="args"></param>
        static void Main (string[] args)
            {
                Console.WriteLine("Enter an integer:");
                string x = Console.ReadLine();
                int y = int.Parse(x);
                Console.WriteLine("Enter real number:");
                string real = Console.ReadLine();
                float freal = float.Parse(real);
                float sum = y + freal;
                Console.WriteLine($"The sum of {y} and {freal} is {sum}");





            }
        }
    }
