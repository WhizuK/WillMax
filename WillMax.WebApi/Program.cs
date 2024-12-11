using WillMax.Infra.Data.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddWebApiConfiguration(builder.Configuration);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

//Filter chain interceptor
app.Use(async (ctx, next) =>
{
    Console.WriteLine(ctx.Request.Query);
    await next.Invoke(ctx);
});

app.MapControllers();

app.Run();
