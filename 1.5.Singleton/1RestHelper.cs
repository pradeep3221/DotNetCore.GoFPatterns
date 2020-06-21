using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _1._5.Singleton
{
    public sealed class RestHelper
    {
        private static readonly RestHelper instance = new RestHelper();
        static RestHelper()
        {
        }
        private RestHelper()
        {
        }
        public static RestHelper Instance
        {
            get
            {
                return instance;
            }
        }
        public async Task<string> Restclient(String url)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
    }

    enum HTTPVerb
    {
        Get,
        Post,
        PUT,
        Delete
    }
}
