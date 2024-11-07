using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace BestStoreMVC.Services
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
