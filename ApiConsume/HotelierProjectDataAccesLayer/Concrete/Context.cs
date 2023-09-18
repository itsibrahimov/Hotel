using HotelierProjectEntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HotelierProjectDataAccesLayer.Concrete;

public class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server = RIRI;" +
            " initial catalog = Hotelier;" +
            " integrated security = true");
    }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Staff> Staffs { get; set; }
    public DbSet<Subscribe> Subscribes { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
}