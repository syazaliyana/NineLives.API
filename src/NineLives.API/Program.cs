//program starts
//builder is an object that helps configuring everything bfr application starts. 
var builder = WebApplication.CreateBuilder(args);

//create builder and registering the services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//build application
var app = builder.Build();

//configure pipeline. asking if im running in development mode
if (app.Environment.IsDevelopment())
{
    //after registered it above, now use/exposes it.
    app.UseSwagger();
    app.UseSwaggerUI();
}

//this is middleware
app.UseHttpsRedirection();

//this is a route. use what been registered
app.MapControllers();

app.Run();
