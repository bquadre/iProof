using Abp.Zero.EntityFrameworkCore;
using iProof.Authorization.Roles;
using iProof.Authorization.Users;
using iProof.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace iProof.EntityFrameworkCore
{
    public class iProofDbContext : AbpZeroDbContext<Tenant, Role, User, iProofDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public iProofDbContext(DbContextOptions<iProofDbContext> options)
            : base(options)
        {

        }
    }
}
