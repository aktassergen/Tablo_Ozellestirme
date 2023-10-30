using Sergen_Aktas_Odev5.Class;

namespace Sergen_Aktas_Odev6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey yesNo = ConsoleKey.E;
            while (yesNo == ConsoleKey.E)
            {
                Console.Write("Satır(Row) ve sütun(Column) değeri giriniz (Örn: 2x4): ");
                string[] input = Console.ReadLine().Split('x');
                try
                {
                    int rows = Convert.ToInt32(input[0]);
                    int columns = Convert.ToInt32(input[1]);
                    if (rows <= 27 && columns <= 70 && rows >= 0 && columns >= 0)
                    {
                        if (rows == 0 || columns == 0)
                        {                
                            yesNo = ReadYesNoKey();
                        }
                        else
                        {
                            Console.Write("Satır sutun genişliği(Width) ve Yükseliği(Height) değeri giriniz (Örn: 2x4): ");
                            string[] sizeInput = Console.ReadLine().Split('x');
                            int width = Convert.ToInt32(sizeInput[0]);
                            int height = Convert.ToInt32(sizeInput[1]);

                            if (width <= 209/columns && height <= 53/rows && rows >= 0 && columns >= 0)
                            {
                                TableCreator tableCreator = new TableCreator(width, height, rows, columns);
                                yesNo = ReadYesNoKey();
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();
                    }
                    Console.Clear();
                }
                catch (Exception ex){}

                Console.Clear();
            }
        }
        private static ConsoleKey ReadYesNoKey()
        {
            Console.Write("devam etmek için 'E', çıkış için 'H' tuşuna basın.");
            ConsoleKey check = Console.ReadKey(true).Key;
            while (check != ConsoleKey.E && check != ConsoleKey.H)
            {
                check = Console.ReadKey(true).Key;
            }
            return check;
        }
    }
}