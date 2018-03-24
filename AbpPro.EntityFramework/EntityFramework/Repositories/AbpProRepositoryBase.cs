using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace AbpPro.EntityFramework.Repositories
{
    public abstract class AbpProRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AbpProDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AbpProRepositoryBase(IDbContextProvider<AbpProDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AbpProRepositoryBase<TEntity> : AbpProRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AbpProRepositoryBase(IDbContextProvider<AbpProDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
