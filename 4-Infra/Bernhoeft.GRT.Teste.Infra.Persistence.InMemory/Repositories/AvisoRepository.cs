using Bernhoeft.GRT.ContractWeb.Domain.SqlServer.ContractStore.Entities;
using Bernhoeft.GRT.ContractWeb.Domain.SqlServer.ContractStore.Interfaces.Repositories;
using Bernhoeft.GRT.Core.Attributes;
using Bernhoeft.GRT.Core.EntityFramework.Infra;
using Bernhoeft.GRT.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Bernhoeft.GRT.ContractWeb.Infra.Persistence.SqlServer.ContractStore.Repositories
{
    [InjectService(Interface: typeof(IAvisoRepository))]
    public class AvisoRepository : Repository<AvisoEntity>, IAvisoRepository
    {
        private readonly DbContext _context;

        public AvisoRepository(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _context = serviceProvider.GetRequiredService<DbContext>();
        }

        public async Task AddAsync(AvisoEntity entity)
        {
            await Set.AddAsync(entity);
        }

        public async Task DeleteAsync(AvisoEntity entity)
        {
            Set.Remove(entity);
            await Task.CompletedTask;
        }

        public Task<AvisoEntity> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<AvisoEntity>> ObterTodosAvisosAsync(TrackingBehavior tracking = TrackingBehavior.Default, CancellationToken cancellationToken = default)
        {
            var query = tracking is TrackingBehavior.NoTracking ? Set.AsNoTrackingWithIdentityResolution() : Set;
            return query.ToListAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(AvisoEntity entity)
        {
            Set.Update(entity);
            await Task.CompletedTask;
        }
    }
}