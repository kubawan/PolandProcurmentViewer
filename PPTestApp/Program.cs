using PP.Connection;
using PP.Connection.JsonDataClasses;
using System;
using System.Threading.Tasks;

namespace PPTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {
            try
            {
                var ppConnection = new PPConnection();
                var tenders = await ppConnection.Get<Tenders>("");

                Console.WriteLine($"Total procurments number: {tenders.Total}");

                int num = 1;
                foreach (var tender in tenders.Tender)
                {
                    Console.WriteLine($"{num}. {tender.Title} | {tender.Date}");
                    num++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
