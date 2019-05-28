using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    struct Product : IComparable
    {

        public string model;

        public double cost;

        public string kindProduct;

        public int CompareTo(object o)
        {

            Product one = (Product)o;

            return cost.CompareTo(one.cost);

        }

    }

    class Storage
    {

        public Storage()
        {

            N = 0;

            database = new Product[N];

        }

        public void AddProductToDataBase()
        {

            try
            {
                N++;
                Array.Resize(ref database, N);

                Console.Write("Введите марку продукта : ");

                database[N - 1].model = Console.ReadLine();

                Console.Write("Введите цену продукта(грн) : ");

                database[N - 1].cost = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите вид продукции : ");

                database[N - 1].kindProduct = Console.ReadLine();

                Console.WriteLine();
            }
            catch (FormatException ex)
            {

                N--;
                Array.Resize(ref database, N);

                string message = ex.Message;

                Console.WriteLine(message);

                Console.WriteLine();
            }

        }

        public void OutputDataBase()
        {

            if (N == 0)
            {

                Console.WriteLine("База данных пустая!");

                Console.WriteLine();

            }
            else
            {
                foreach (Product one in database)
                {

                    Console.WriteLine("Марка продукта : {0}", one.model);

                    Console.WriteLine("Цена продукта : {0}", one.cost);

                    Console.WriteLine("Вид продукции : {0}", one.kindProduct);

                    Console.WriteLine();
                }
            }

        }

        public void SortDataBase()
        {

            if (N == 0)
            {

                Console.WriteLine("База данных пустая, добавьте продукцию для сортировки!");

                Console.WriteLine();

            }
            else
            {
                Array.Sort(database);

                Console.WriteLine("Отсортированная база даных по стоимости!");

                OutputDataBase();
            }

        }

        public void SearchFromDataBase(string modelSearch, double costSearch, string kindProductSearch)
        {

            if (N == 0)
            {

                Console.WriteLine("База данных пустая, добавьте продукцию для поиска!");

                Console.WriteLine();

            }
            else
            {
                foreach (Product one in database)
                {

                    if (one.model == modelSearch && one.cost <= costSearch && one.kindProduct == kindProductSearch)
                    {

                        Console.WriteLine("Марка продукта : {0}", one.model);

                        Console.WriteLine("Цена продукта : {0}", one.cost);

                        Console.WriteLine("Вид продукции : {0}", one.kindProduct);

                        Console.WriteLine();

                    }

                }
            }

        }

        private int N;
        Product[] database;
    }

}
