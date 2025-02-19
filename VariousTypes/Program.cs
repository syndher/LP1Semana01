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
                uint b = 0x0F;
                Console.WriteLine(a);
                Console.WriteLine(b);

                char star = '\u2606';
                char arrow = '\u27B3';
                char checkmark = '\u2713';
                Console.WriteLine(star);
                Console.WriteLine(arrow);
                Console.WriteLine(checkmark);
            }
        }
    }
