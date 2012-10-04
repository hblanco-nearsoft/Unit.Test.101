using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit.Testing._101
{
    

    class Program
    {
        static void Main(string[] args)
        {
            var client = new NumbersClient();
            var content = client.GetRandomFact();

            Console.WriteLine(content);
            Console.ReadKey();
        }
    }

    
}
