var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var env = builder.Environment; //Uygulamanýn çalýþma ortamýný (Development, Production, vb.) alýr.

builder.Configuration.SetBasePath(env.ContentRootPath) //Yapýlandýrma dosyalarýnýn kök dizinini ayarlar (genellikle proje dizini).Sunucuya atýnca da oranýn adresini almayý saðlar.
.AddJsonFile("appsettings.json", optional: false) //Temel yapýlandýrma dosyasýný ("appsettings.json") zorunlu olarak ekler.
.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true); //Çalýþma ortamýna özel yapýlandýrma dosyasýný ("appsettings.Development.json" gibi) ekler. Bu dosya opsiyoneldir.

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
