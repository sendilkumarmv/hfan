using HFan.Web.Application;
using HFan.Web.Application.Handlers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // opt => opt.OperationFilter<AddRequiredHeaderParameter>());
builder.Services.AddSingleton<IPublishApplication, PublishApplication>();
builder.Services.AddScoped<ICustomerApplicationHandler, CustomerApplicationHandler>();

var app = builder.Build();


// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

//docker run -d --hostname my-rabbit --name ecom-rabbit -p 15672:15672 -p 5672:5672 rabbitmq:3-management