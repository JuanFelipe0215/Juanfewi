using Juanfewi.Models;
using Microsoft.EntityFrameworkCore;
namespace Juanfewi.Data;

public class DataContext: DbContext
{
    public DbSet<Event> Events { get; set; }
    
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    
}