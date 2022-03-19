using HFAN.Web.Models;
using Microsoft.Extensions.Options;

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
        public CustomerApplicationModel Get()
        {
            return new CustomerApplicationModel();
        }

        public CustomerApplicationModel Get(string customerId)
        {
            return new CustomerApplicationModel();
        }
    }
}
