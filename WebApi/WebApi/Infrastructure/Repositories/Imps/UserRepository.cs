using LapTrinhDotNet.EFCore.Initialize;
using WebApi.Models;

namespace WebApi.Infrastructure.Repositories.Imps
{
    public class UserRepository : MyGenericRepository<User>, IUserRepository
    {
        public UserRepository(DBContext context) : base(context)
        {
        }
    }
}