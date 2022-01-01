using LapTrinhDotNet.EFCore.Initialize;
using WebApi.Models;

namespace WebApi.Infrastructure.Repositories.Imps
{
    public class RoleRepository : MyGenericRepository<Role>, IRoleRepository
    {
        public RoleRepository(DBContext context) : base(context)
        {
        }
    }
}