using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.XPath;
using System.Web;
using System.Xml.Xsl;
using System.Collections.Generic;

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
            var numberOfOrders = 10;
            var res = await client.GetAsync(uri);
            return res;
        }
    }

    class Composers
    {
        IList<string> names, genres;

        public Composers()
        {
            names = new List<string> { "Bach", "Beethoven", "Chopin" };
            genres = new List<string> { "Classical", "Romantic", "Jazz" };
        }

        public IList<string> Names
        {
            get { return genres; }
        }

        public IList<string> Genres
        {
            get { return genres; }
        }
    }
}
