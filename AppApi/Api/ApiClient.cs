using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppApi.Api
{
    public static class ApiClient
    {
        public static HttpClient Instance { get; }
        static ApiClient()
        {
            Instance = new HttpClient()
            {
                BaseAddress = new Uri("http://127.0.0.1:7061/")
            };
            var byteArray = System.Text.Encoding.ASCII.GetBytes("staff:BCLyon2024");
            Instance.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(
                "Basic", Convert.ToBase64String(byteArray));
        }
    }
}
