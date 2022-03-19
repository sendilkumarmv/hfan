using HFan.Web.Application.Model;

namespace HFan.Web.Application.Handlers
{
    public class CustomerApplicationHandler : ICustomerApplicationHandler
    {
        public IEnumerable<CustomerApplication> GetCustomerApplications()
        {
            return new List<CustomerApplication>
            {
                new CustomerApplication()
                {
                    ApplicationId = "HFA000011",
                    CustomerId ="CIF0045673"
                },
                new CustomerApplication()
                {
                    ApplicationId = "HFA000012",
                    CustomerId ="CIF0045890"
                }
            };
        }
    }
}
