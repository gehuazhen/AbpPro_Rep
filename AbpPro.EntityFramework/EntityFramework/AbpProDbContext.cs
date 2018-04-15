using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using AbpPro.Authorization.Roles;
using AbpPro.Authorization.Users;
using AbpPro.MultiTenancy;

using AbpPro.Tasks;
using AbpPro.Products;
using AbpPro.CaseGroup;

namespace AbpPro.EntityFramework
{
    public class AbpProDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
        public  IDbSet<Task> Tasks { get; set; }
        public IDbSet<Product> Products { get; set; }
        public IDbSet<M_AJMB> Ajmb { get; set; }
        public IDbSet<M_ZDYSB> zdysb { get; set; }
        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public AbpProDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in AbpProDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of AbpProDbContext since ABP automatically handles it.
         */
        public AbpProDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public AbpProDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public AbpProDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
