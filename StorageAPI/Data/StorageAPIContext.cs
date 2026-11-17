using Microsoft.EntityFrameworkCore;

public class StorageAPIContext(DbContextOptions<StorageAPIContext> options) : DbContext(options)
{
    public DbSet<StorageAPI.Models.Product> Product { get; set; } = default!;
}
