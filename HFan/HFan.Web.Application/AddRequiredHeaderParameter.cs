using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HFan.Web.Application
{
    public class AddRequiredHeaderParameter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.Parameters == null)
                operation.Parameters = new List<OpenApiParameter>();

            operation.Parameters.Add(new OpenApiParameter()
            {
                Name = "X-User-Token",
                In = ParameterLocation.Header,
                Required = true
            });
            operation.Parameters.Add(new OpenApiParameter()
            {
                Name = "client-corrid",
                In = ParameterLocation.Header,
                Required = true
            });
            operation.Parameters.Add(new OpenApiParameter()
            {
                Name = "client-channel",
                In = ParameterLocation.Header,
                Required = false
            });
        }
    }
}
