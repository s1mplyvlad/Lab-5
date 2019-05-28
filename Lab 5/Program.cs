using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage database = new Storage();

            string action;

            string model;

            double cost;

            string kindProduct;

            do
            {

                Console.WriteLine("Введите одну з команд для работы з базой данных(Addproduct,OutputDataBase,SortDataBase,SearchFromDataBase,Exit).");

                action = Console.ReadLine();

                if (action == "AddProduct")
                {

                    database.AddProductToDataBase();

                }
                else if (action == "OutputDataBase")
                {

                    database.OutputDataBase();

                }
                else if (action == "SortDataBase")
                {
                    database.SortDataBase();
                }
                else if (action == "SearchFromDataBase")
                {

                    try
                    {

                        Console.WriteLine("Введите желаемую марку продукта,цену и вид продукции : ");

                        model = Console.ReadLine();

                        cost = Convert.ToDouble(Console.ReadLine());

                        kindProduct = Console.ReadLine();

                        database.SearchFromDataBase(model, cost, kindProduct);

                    }
                    catch (FormatException ex)
                    {

                        string message = ex.Message;

                        Console.WriteLine(message);

                        Console.WriteLine();

                    }
                }
                else
                {

                    Console.WriteLine("Даной команды не существует!");

                    Console.WriteLine();

                }

            } while (action != "Exit");

        }

    }
}

