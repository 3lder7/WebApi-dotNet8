using Microsoft.EntityFrameworkCore;

namespace WebApi_dotNet8.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)//opções de conexão
        {
            
        }
    }
}
