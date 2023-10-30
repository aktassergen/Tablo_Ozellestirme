using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sergen_Aktas_Odev5.Class
{
    public class TableCreator
    {
        public TableCreator(int width, int height, int rows, int columns)
        {
            CreateAndDisplayTable(width, height, rows, columns);
        }

        private static void CreateAndDisplayTable(int width, int height, int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                Console.Write("+");
                for (int j = 0; j < columns; j++)
                {
                   
                    for (int k = 0; k < width; k++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("+");
                }
                Console.WriteLine();
                for (int m = 0; m < height; m++)
                {
                    Console.Write("|");
                    for (int l = 0; l < columns; l++)
                    {
                        for (int n = 0; n < width; n++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("|");
                    }
                    Console.WriteLine();
                }
            }

            Console.Write("+");
            for (int j = 0; j < columns; j++)
            {

                for (int k = 0; k < width; k++)
                {
                    Console.Write("-");
                }
                Console.Write("+");
            }
            Console.WriteLine();
        }
    }
}
        

