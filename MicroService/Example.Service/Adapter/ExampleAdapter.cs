using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Service.Common.Models;

namespace Example.Service.Adapter
{
    public class ExampleAdapter : IExampleAdapter
    {
        private readonly IHttpClientFactory _clientFactory;
        public ExampleAdapter(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public SampleModel getSampleModel()
        {
            return new SampleModel
            {
                Id = 1,
                Name = "Sample Object"
            };
        }

        public async Task<SampleModel> HTTPClientExample()
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
           "https://api.binance.com/api/v1/ticker/24hr?symbol=");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var results = await response.Content
                    .ReadAsStringAsync();
                return JsonConvert.DeserializeObject<SampleModel>(results);
            }
            else
            {
                throw new Exception("faild to retrive data from external point");
            }
        }
    }
}
