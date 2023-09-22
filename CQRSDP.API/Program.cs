using CQRSDP.Business.Abstract;
using CQRSDP.Business.Concrete;
using CQRSDP.Business.Mapping;
using CQRSDP.DataAccess.Abstract;
using CQRSDP.DataAccess.Concrete;
using CQRSDP.Handler.Handlers.CommandHandler;
using CQRSDP.Handler.Handlers.QueryHandler;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(ProductMapping));
builder.Services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());

//builder.Services.AddScoped<CreateProductCommandHandler>();
builder.Services.AddScoped<GetAllProductQueryHandler>();
builder.Services.AddScoped<IProductReadDal,ProductReadDal>();
builder.Services.AddScoped<IProductWriteDal,ProductWriteDal>();
builder.Services.AddScoped<IProductService,ProductManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
