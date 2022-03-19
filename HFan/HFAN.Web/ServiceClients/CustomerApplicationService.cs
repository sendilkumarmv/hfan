using HFAN.Web.Models;
using Microsoft.Extensions.Options;
using System.Text.Json;

namespace HFAN.Web.ServiceClients
{
    public class CustomerApplicationService : ICustomerApplicationService
    {
        private HttpClient client;
        private string apiBaseUrl;
        public CustomerApplicationService(HttpClient httpClient, IOptions<Settings> settings)
        {
            client = httpClient;
            apiBaseUrl = settings.Value.EndPoints.ApplicationApiBaseUri;
        }
        public async Task<List<CustomerApplicationModel>> Get()
        {
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, $"{apiBaseUrl}/CustomerApplication");
            var responseMessage = await client.SendAsync(requestMessage);
            if(responseMessage.IsSuccessStatusCode)
            {
                var response = await responseMessage.Content.ReadAsStringAsync();
                var application = JsonSerializer.Deserialize<List<CustomerApplicationModel>>(response, new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                return application;
            }
            return null;
        }

        public CustomerApplicationModel Get(string customerId)
        {
            return new CustomerApplicationModel();
        }
    }
}
