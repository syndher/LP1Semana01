using System ;
using System.Security.Cryptography.X509Certificates;
using System.Text;


    namespace MeuPrograma
    {
        /// <summary>
        /// Chooses the class
        /// </summary>
        class Program
        {
            /// <summary>
            /// Starts the script to write multiple types of strings
            /// </summary>
            /// <param name="args"></param>
        static void Main (string[] args)
            {
                double xx = 1.23456;
                int ii = 19;
                Console.OutputEncoding = Encoding.UTF8;
                string introducao = "Bom dia \u263C";
                string fim = "Acabou a a"+'\u00E7'+'\u00E3'+"o";
                Console.WriteLine(introducao);
                Console.WriteLine(fim);

                int x = 10;
                int y = 3;
                string conc1 = "abc" + 123;
                string conc2 = "def" + x;
                string valuex = $"the value of x is {x}";
                string valuexy = $"the value of {x} + {y} is {x + y}";

                Console.WriteLine(conc1);
                Console.WriteLine(conc2);
                Console.WriteLine(valuex);
                Console.WriteLine(valuexy);

                string s1 = $"{xx:f2}";
                string s2 =$"{xx:p1}";

                Console.WriteLine(s1);
                Console.WriteLine(s2);

                string s3 = $"{ii:c}";
                string s4 = $"{ii:x}";

                Console.WriteLine(s4);
                Console.WriteLine(s3);


            }
        }
    }
