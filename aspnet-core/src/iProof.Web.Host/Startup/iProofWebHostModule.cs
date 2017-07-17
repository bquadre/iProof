using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using iProof.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace iProof.Web.Host.Startup
{
    [DependsOn(
       typeof(iProofWebCoreModule))]
    public class iProofWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public iProofWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(iProofWebHostModule).GetAssembly());
        }
    }
}
