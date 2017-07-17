using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using iProof.EntityFrameworkCore.Seed;

namespace iProof.EntityFrameworkCore
{
    [DependsOn(
        typeof(iProofCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class iProofEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }


        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<iProofDbContext>(configuration =>
                {
                    iProofDbContextConfigurer.Configure(configuration.DbContextOptions, configuration.ConnectionString);
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(iProofEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}