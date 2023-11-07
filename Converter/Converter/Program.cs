using Newtonsoft.Json;
using System.ComponentModel;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Введите путь до файла");
                string path = Console.ReadLine();
                var hr = new reading(path);
                Console.WriteLine("--------------------------------- \n");
                Console.WriteLine("тыкните F1");

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.F1)
                {
                    Console.WriteLine("--------------------------------- \n");
                    Console.WriteLine("Как куда и зачем менять будем?");
                    path = Console.ReadLine();
                    hr.wrtiting(path);

                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Пока :(");
                    break;
                }



            }
         
        }
        public static void boba()
        {
            Console.Clear();
            Console.WriteLine("Конвертирую..");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Конвертирую...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Конвертирую.");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Конвертирую..");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Конвертирую...");
            Console.WriteLine("вроде наконвертировал чёто, чекайте");
        }
    }
}