var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var env = builder.Environment; //Uygulaman�n �al��ma ortam�n� (Development, Production, vb.) al�r.

builder.Configuration.SetBasePath(env.ContentRootPath) //Yap�land�rma dosyalar�n�n k�k dizinini ayarlar (genellikle proje dizini).Sunucuya at�nca da oran�n adresini almay� sa�lar.
.AddJsonFile("appsettings.json", optional: false) //Temel yap�land�rma dosyas�n� ("appsettings.json") zorunlu olarak ekler.
.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true); //�al��ma ortam�na �zel yap�land�rma dosyas�n� ("appsettings.Development.json" gibi) ekler. Bu dosya opsiyoneldir.

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
