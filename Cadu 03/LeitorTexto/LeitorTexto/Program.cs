using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LeitorTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // o arquivo que vou abrir
            string arquivo = args[0];
            string line = "";

            try
            {
                StreamReader sr = new StreamReader(arquivo);
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
