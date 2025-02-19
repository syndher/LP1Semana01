using System ;

    namespace MeuPrograma
    {
        /// <summary>
        /// Chooses the class
        /// </summary>
        class Program
        {
            /// <summary>
            /// Starts the script to write various numbers and values on the console
            /// </summary>
            /// <param name="args"></param>
        static void Main (string[] args)
            {
                int a = 1;
                uint b = 0x0FU;
                Console.WriteLine(a);
                Console.WriteLine(b);

                char star = '\u2606';
                char arrow = '\u27B3';
                char checkmark = '\u2713';

                Console.WriteLine(star);
                Console.WriteLine(arrow);
                Console.WriteLine(checkmark);

                double real1 = 23;
                float real2 = 12.512f;
                Console.WriteLine(real1);
                Console.WriteLine(real2);

                bool booleanTrue = true;
                bool booleanFalse = false;
                Console.WriteLine(booleanTrue);
                Console.WriteLine(booleanFalse);
                
            }
        }
    }
