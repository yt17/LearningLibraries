using _FluentValidationApp.Validator;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddControllersWithViews();
//There are 3 ways to implement Fluent Validation in Net Core 6

builder.Services.AddControllersWithViews().AddFluentValidation(options =>
{
    //Way1
    //options.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());

    //Way2
    options.RegisterValidatorsFromAssemblyContaining<UserInfoValidator>();
});

//Way3
//builder.Services.AddControllersWithViews().AddFluentValidation();
//builder.Services.AddTransient<IValidator<Customer>, CustomerValidator>();

builder.Services.Configure<ApiBehaviorOptions>(opt =>
{
    opt.SuppressModelStateInvalidFilter = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
