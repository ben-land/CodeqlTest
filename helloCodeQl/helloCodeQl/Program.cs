using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace helloCodeQl
{
    public class Program
    {
        private static readonly HttpClient client = new HttpClient();

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //uri from para should picked up 
        public async Task<HttpResponseMessage> GetRespondAsync(Uri uri)
        {
            client.BaseAddress = uri;
            var res = await client.GetAsync(uri);
            return res;
        }
    }
}
