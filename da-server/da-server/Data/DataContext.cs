using da_server.Entities;
using Microsoft.EntityFrameworkCore;

namespace da_server.Data;

public class DataContext : DbContext
{
  public DataContext(DbContextOptions<DataContext> options) : base(options) { }

  public DbSet<User> Users { get; set; }
  public DbSet<Profile> Profiles { get; set; }
  public DbSet<Match> Matches { get; set; }

}
