using DA.Accounting;
using DA.PayJom;
using DA.Payout;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextFactory<AccountingDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AccountingConnection"),
        sqlOptions => sqlOptions.EnableRetryOnFailure()
    ).EnableServiceProviderCaching(true);
});

builder.Services.AddDbContextFactory<PayoutDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("PayoutConnection"),
        sqlOptions => sqlOptions.EnableRetryOnFailure()
    ).EnableServiceProviderCaching(true);
});

builder.Services.AddDbContextFactory<PayJomDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("PayJomConnection"),
        sqlOptions => sqlOptions.EnableRetryOnFailure()
    ).EnableServiceProviderCaching(true);
});


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
