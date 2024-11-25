using System;
using System.ServiceModel;

class Program
{
    static void Main()
    {
        using (var host = new ServiceHost(typeof(BookSoap)))
        {
            host.Open();
            Console.WriteLine("Book API is running...");
            Console.WriteLine("Press 'Enter' to end service");
            Console.ReadLine();
        }
    }
}