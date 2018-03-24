using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using AbpPro.EntityFramework;

namespace AbpPro.Migrator
{
    [DependsOn(typeof(AbpProDataModule))]
    public class AbpProMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<AbpProDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}