using Microsoft.EntityFrameworkCore;
using TraversalApiProject.DAL.Entities;

namespace TraversalApiProject.DAL.Context
{
    public class VisitorContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-MJ87N70\\SQLEXPRESS;Database=ReservationDBApi; integrated security=true; TrustServerCertificate=True");
        }
        public DbSet<Visitor> Visitors { get; set; }
    }
}
