using WebApi.Models;

namespace WebApi.Infrastructure.Repositories.Imps
{
    public class CommentRepository : MyGenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(DBContext context) : base(context)
        {
        }
    }
}