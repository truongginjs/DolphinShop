using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LapTrinhDotNet.EFCore.Initialize;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Infrastructure.Repositories
{
    public abstract class MyGenericRepository<T> : GenericRepository<T> where T : BaseModel
    {
        private readonly DbSet<T> _table;
        private readonly DbContext _context;

        protected MyGenericRepository(DbContext context) : base(context)
        {
            _context = context;
            _table = context.Set<T>();
        }

        public override T Delete(object Id)
        {
            var data = _table.Find(Id);
            data.IsDeleted = true;
            _context.SaveChanges();
            return data;
        }
        public override async Task<T> DeleteAsync(object Id)
        {
            var data = await _table.FindAsync(Id);
            data.IsDeleted = true;
            await _context.SaveChangesAsync();
            return data;
        }

        public override Task<T> GetAsync(object Id) => NotDelete().FirstOrDefaultAsync(x => Id.Equals(x.Id));

        public override T Get(object Id) => NotDelete().FirstOrDefault(x => Id.Equals(x.Id));

        public override async Task<IEnumerable<T>> GetsAsync() => await NotDelete().ToListAsync();

        public override IEnumerable<T> Gets() => NotDelete().ToList();
        private IQueryable<T> NotDelete() => _table.Where(x => x.IsDeleted == false);
    }
}