using iProof.Configuration;
using iProof.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace iProof.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class iProofDbContextFactory : IDbContextFactory<iProofDbContext>
    {
        public iProofDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<iProofDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            iProofDbContextConfigurer.Configure(builder, configuration.GetConnectionString(iProofConsts.ConnectionStringName));
            
            return new iProofDbContext(builder.Options);
        }
    }
}