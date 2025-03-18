using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Data
{
    public class BlazorCrudContext : DbContext
    {
        public BlazorCrudContext(DbContextOptions<BlazorCrudContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorCrud.Domain.Users.User> Users { get; set; } = default!;
    }
}
