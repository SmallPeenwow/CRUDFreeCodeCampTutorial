using CRUDFreeCodeCampTutorial.Model;
using Microsoft.EntityFrameworkCore;

namespace CRUDFreeCodeCampTutorial.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Category { get; set; }
    }
}
