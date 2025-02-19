using System ;
using System.Text;


    namespace MeuPrograma
    {
        /// <summary>
        /// Chooses the class
        /// </summary>
        class Program
        {
            /// <summary>
            /// Starts the script to write "Hello World!" and
            /// "Bye World!" on the console
            /// </summary>
            /// <param name="args"></param>
        static void Main (string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                string introducao = "Bom dia \u263C";
                string fim = "Acabou a a"+'\u00E7'+'\u00E3'+"o";
                Console.WriteLine(introducao);
                Console.WriteLine(fim);
            }
        }
    }
