using Microsoft.EntityFrameworkCore;

namespace Models
{
    public class NetCoreApiContext : DbContext
    {
        public NetCoreApiContext(DbContextOptions<NetCoreApiContext> options) : base(options)
        {
        }

        //Provide a DbSet for each entity in the model
    }
}