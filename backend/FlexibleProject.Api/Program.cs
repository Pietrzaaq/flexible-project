using FlexibleProject.Api;

var allowOrigins = "AllowOrigins";

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddCors(options =>
    {
        options.AddPolicy(name: allowOrigins,
            policy  =>
            {
                policy.WithOrigins()
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowAnyOrigin();
            });
    });
    builder.Services.AddPresentation();
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    
    app.UseRouting();
    app.UseCors(allowOrigins);
    app.MapControllers();
    app.Run();
}


