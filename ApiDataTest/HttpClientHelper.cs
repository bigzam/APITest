using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace Microsoft.MetaAnalytics.RestClient
{

    public class HttpClientHelper
    {
        public const int DefaultTimeoutSeconds = 100;

        private readonly HttpClient _client;

        public HttpClientHelper()
        {
            _client = new HttpClient();
            TimeoutSeconds = DefaultTimeoutSeconds;
        }

        public int TimeoutSeconds { get; set; }

        public TResponse Get<TResponse>(Uri uri)
        {
            string responseContent = string.Empty;
            using (HttpResponseMessage response = _client.GetAsync(uri).Result)
            {
                response.EnsureSuccessStatusCode();
                responseContent = response.Content.ReadAsStringAsync().Result;
                
                return JsonConvert.DeserializeObject<TResponse>(responseContent);
            }
        }
    }
}
