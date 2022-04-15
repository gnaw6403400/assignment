using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Core.Entity;
namespace MovieStoreApp.Infrastructure.Repository
{
    public class CastRepositoryAsync : BaseRepositoryAsync<Cast>
    {
        public CastRepositoryAsync(MovieContext _db) : base(_db)
        {
        }
    }
}
