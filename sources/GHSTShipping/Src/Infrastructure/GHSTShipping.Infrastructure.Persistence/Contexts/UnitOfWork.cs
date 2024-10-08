using GHSTShipping.Application.Interfaces;
using GHSTShipping.Application.Interfaces.Repositories;
using GHSTShipping.Domain.Entities;
using GHSTShipping.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore.Storage;
using System.Threading;
using System.Threading.Tasks;

namespace GHSTShipping.Infrastructure.Persistence.Contexts
{
    public class UnitOfWork(ApplicationDbContext dbContext) : IUnitOfWork
    {
        private IGenericRepository<Shop> _shop;
        private IGenericRepository<ShopPricePlan> _shopPricePlan;
        private IGenericRepository<Order> _order;

        public IGenericRepository<Shop> Shops => _shop ??= new GenericRepository<Shop>(dbContext);
        public IGenericRepository<ShopPricePlan> ShopPricePlanes => _shopPricePlan ??= new GenericRepository<ShopPricePlan>(dbContext);
        public IGenericRepository<Order> Orders => _order ??= new GenericRepository<Order>(dbContext);

        public async Task<bool> SaveChangesAsync(CancellationToken cancellation = default)
        {
            return await dbContext.SaveChangesAsync() > 0;
        }

        public bool SaveChanges()
        {
            return dbContext.SaveChanges() > 0;
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default)
        {
            return await dbContext.Database.BeginTransactionAsync(cancellationToken);
        }
    }
}
