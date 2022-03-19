using HFan.Web.Application.Model;

namespace HFan.Web.Application.Handlers
{
    public interface ICustomerApplicationHandler
    {
        IEnumerable<CustomerApplication> GetCustomerApplications();
    }
}
