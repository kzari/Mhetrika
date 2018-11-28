using Microsoft.EntityFrameworkCore;

namespace mhetrika.Infrastructure.Data
{
    public class MhetrikaContext : DbContext
    {
        public MhetrikaContext(DbContextOptions<MhetrikaContext> options) : base(options)
        {

        }
    }
}
