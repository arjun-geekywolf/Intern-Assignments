using Hotel_Booking_System.Interfaces;
using Hotel_Booking_System.Models;
using Hotel_Booking_System.Services;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<HotelDbContext>(options =>
    options.UseSqlServer(@"Data Source=localhost,1433;Initial Catalog=Hotel;User ID=sa;Password=arjun@123;Trust Server Certificate=True"));

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        options.JsonSerializerOptions.MaxDepth = 64;
    });

builder.Services.AddScoped<IHotelService, HotelService>();
builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddScoped<IRoomTypeService, RoomTypeService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IBookingService, BookingService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IReviewService, ReviewService>();

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
app.MapControllers();

app.Run();