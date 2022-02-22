using HFan.Web.Application.Model;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using RabbitMQ.Client;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Text;

namespace HFan.Web.Application.Handlers
{
    public class PublishApplication : IPublishApplication
    {
        public PublishApplication()
        {

        }
        public void Publish(CustomerApplication application)
        {
            var factory = new ConnectionFactory()
            {
                Uri = new Uri("amqp://guest:guest@localhost:5672")
            };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            channel.QueueDeclare("demo-queue",
                durable: true,
                exclusive: false,
                autoDelete: false,
                arguments: null);
            var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(application));
            channel.BasicPublish("", "demo-queue", null, body);
        }
    }

   

    
}
