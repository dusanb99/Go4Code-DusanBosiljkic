using Microsoft.EntityFrameworkCore;
using ProjektniZadatak;
using ProjektniZadatak.Mapping;
using ProjektniZadatak.Repository;
using ProjektniZadatak.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.OpenApi.Models;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


builder.Services.AddDbContext<DrustvenaMrezaDbContext>(options =>
{
    options.UseSqlServer("Server=localhost;Database=DrustvenaMrezaDb;Trusted_Connection=True;TrustServerCertificate=True");
});






// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "JWTToken_Auth_API",
        Version = "v1"
    });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 1safsfsdfdfd\"",
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement {
        {
            new OpenApiSecurityScheme {
                Reference = new OpenApiReference {
                    Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});

// Identity
//builder.Services.AddIdentity<IdentityUser, IdentityRole>()
//    .AddEntityFrameworkStores<DrustvenaMrezaDbContext>()
//    .AddDefaultTokenProviders();



builder.Services.AddScoped<IKorisnikRepository, KorisnikRepository>();
builder.Services.AddScoped<IKorisnikService, KorisnikService>();

builder.Services.AddScoped<IObjavaRepository, ObjavaRepository>();
builder.Services.AddScoped<IObjavaService, ObjavaService>();

builder.Services.AddScoped<ILajkRepository, LajkRepository>();
builder.Services.AddScoped<ILajkService, LajkService>();

builder.Services.AddScoped<IPratilacRepository, PratilacRepository>();
builder.Services.AddScoped<IPratilacService, PratilacService>();

builder.Services.AddScoped<IObavestenjeRepository, ObavestenjeRepository>();
builder.Services.AddScoped<IObavestenjeService, ObavestenjeService>();

builder.Services.AddScoped<IKomentarRepository, KomentarRepository>(); // ovde puca .build
builder.Services.AddScoped<IKomentarService, KomentarService>();



builder.Services.AddAutoMapper(typeof(MapperConfig));

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
