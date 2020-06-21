using System;
using System.Threading.Tasks;

namespace _1._5.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            Task.WhenAll(RESTCalls1(), RESTCalls2());
            Console.ReadKey();
        }

        static async Task RESTCalls1()
        {
            try
            {
                var respose1 = RestHelper.Instance.Restclient("https://jsonplaceholder.typicode.com/todos/1");
                var respose2 = RestHelper.Instance.Restclient("https://jsonplaceholder.typicode.com/todos/2");
                await Task.WhenAll(respose1, respose2);

                Console.WriteLine("RESTCalls1 respose1: {0}", respose1.Result);
                Console.WriteLine("RESTCalls1 respose2: {0}", respose2.Result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        static async Task RESTCalls2()
        {
            try
            {
                var respose3 = RestHelper.Instance.Restclient("https://jsonplaceholder.typicode.com/todos/3");
                var respose4 = RestHelper.Instance.Restclient("https://jsonplaceholder.typicode.com/todos/4");
                await Task.WhenAll(respose3, respose4);

                Console.WriteLine("RESTCalls1 respose3: {0}", respose3.Result);
                Console.WriteLine("RESTCalls1 respose4: {0}", respose4.Result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
