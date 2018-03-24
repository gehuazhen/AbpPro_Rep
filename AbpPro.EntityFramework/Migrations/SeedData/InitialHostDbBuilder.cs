using AbpPro.EntityFramework;
using EntityFramework.DynamicFilters;

namespace AbpPro.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly AbpProDbContext _context;

        public InitialHostDbBuilder(AbpProDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
            new DefaultTasksCreator(_context).Create();
        }
    }
}
