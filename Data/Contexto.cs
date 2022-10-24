using Microsoft.EntityFrameworkCore;

namespace pdf_final.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options): base(options)
        {

        }
    }
}
