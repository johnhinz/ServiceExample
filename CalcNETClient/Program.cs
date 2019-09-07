using CalcNETClient.CalcService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcNETClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateClient client = new CalculateClient();
            int result = client.Add(13, 67);
            Console.WriteLine(result);
        }
    }
}
