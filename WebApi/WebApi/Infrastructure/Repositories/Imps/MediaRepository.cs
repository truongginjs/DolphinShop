using LapTrinhDotNet.EFCore.Initialize;
using WebApi.Models;

namespace WebApi.Infrastructure.Repositories.Imps
{
    public class MediaRepository : MyGenericRepository<Media>, IMediaRepository
    {
        public MediaRepository(DBContext context) : base(context)
        {
        }
    }
}