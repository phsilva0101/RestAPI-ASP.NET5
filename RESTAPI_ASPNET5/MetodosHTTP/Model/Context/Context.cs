using Microsoft.EntityFrameworkCore;

namespace MetodosHTTP.Model.Context
{
    public class Context : DbContext
    {
        public Context()
        {

        }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Person> Persons {  get; set;}
    }
}
