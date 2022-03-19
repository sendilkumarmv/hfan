using HFAN.Web.Models;

namespace HFAN.Web.ServiceClients
{
    public interface ICustomerApplicationService
    {
        Task<List<CustomerApplicationModel>> Get();
        CustomerApplicationModel Get(string customerId);
    }
}
