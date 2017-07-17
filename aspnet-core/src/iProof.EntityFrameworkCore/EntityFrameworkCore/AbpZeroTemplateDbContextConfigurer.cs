using Microsoft.EntityFrameworkCore;

namespace iProof.EntityFrameworkCore
{
    public static class iProofDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<iProofDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }
    }
}