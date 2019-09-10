using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcRESTClient
{
    class Program
    {
        static void Main(string[] args)
        {
            RestClient client = new RestClient("http://localhost:51272/");
            RestRequest request = new RestRequest("api/calc?x=14&y=15", Method.GET);
            var response = client.Execute(request);
            Console.WriteLine();
        }
    }
}
