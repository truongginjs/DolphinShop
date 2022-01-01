using LapTrinhDotNet.EFCore.Initialize;
using WebApi.Models;

namespace WebApi.Infrastructure.Repositories.Imps
{
    public class PostRepository : MyGenericRepository<Post>, IPostRepository
    {
        public PostRepository(DBContext context) : base(context)
        {
        }
    }
}