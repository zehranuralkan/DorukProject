using DorukProject.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IReportService, ReportService>();
builder.Services.AddScoped<ITimeSpanConverter, TimeSpanConverterService>();
builder.Services.AddScoped<IDayMinutesCalculator, DayMinutesCalculator>();
builder.Services.AddScoped<IHourMinutesCalculator, HourMinutesCalculator>();
builder.Services.AddScoped<IWorkOrder, WorkOrderService>(); 
builder.Services.AddScoped<IPostureList, PostureListService>(); 
builder.Services.AddScoped<ITableColumnsService, TableColumnsService>(); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
