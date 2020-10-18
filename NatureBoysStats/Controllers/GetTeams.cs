using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace NatureBoysStats.Controllers
{
    public class GetTeams
    {
        public static HttpClient GetHttpClient()
        {
            var client = new HttpClient();
           // httpClient.BaseAddress = new Uri("https://www.themealdb.com");
            client.BaseAddress = new Uri("https://www.thesportsdb.com");
            return client;
        }
    }
}
