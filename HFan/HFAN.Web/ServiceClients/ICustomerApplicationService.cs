using HFAN.Web.Models;

namespace HFAN.Web.ServiceClients
{
    public interface ICustomerApplicationService
    {
        CustomerApplicationModel Get();
        CustomerApplicationModel Get(string customerId);
    }
}
