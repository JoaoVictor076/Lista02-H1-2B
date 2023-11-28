
using H1Store.Catalogo.Data.Providers.MongoDb.Interfaces;

using Microsoft.Extensions.Options;

using ListaH1.Domain.Interfaces;
using ListaH1.Application.AutoMapper;
using ListaH1.Data.AutoMapper;
using ListaH1.Data.Repository;
using ListaH1.Application.Services;
using ListaH1.Application.Interfaces;
using ListaH1.Data.Providers.MongoDb.Configuration;
using ListaH1.Data.Providers.MongoDb;
using ListaH1.Infra.EmailService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(DomainToApplication), typeof(ApplicationToDomain));

builder.Services.AddAutoMapper(typeof(DomainToCollection), typeof(CollectionToDomain));

builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();

builder.Services.AddScoped<IFornecedorRepository, FornecedorRepository>();
builder.Services.AddScoped<IFornecedorService, FornecedorService>();

builder.Services.Configure<MongoDbSettings>(
    builder.Configuration.GetSection("MongoDbSettings"));

builder.Services.AddSingleton<IMongoDbSettings>(serviceProvider =>
       serviceProvider.GetRequiredService<IOptions<MongoDbSettings>>().Value);

builder.Services.AddScoped(typeof(IMongoRepository<>), typeof(MongoRepository<>));


builder.Services.Configure<EmailConfig>(
    builder.Configuration.GetSection("EmailConfig"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
