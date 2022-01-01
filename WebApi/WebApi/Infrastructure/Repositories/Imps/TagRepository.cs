using LapTrinhDotNet.EFCore.Initialize;
using WebApi.Models;

namespace WebApi.Infrastructure.Repositories.Imps
{
    public class TagRepository : MyGenericRepository<Tag>, ITagRepository
    {
        public TagRepository(DBContext context) : base(context)
        {
        }
    }
}