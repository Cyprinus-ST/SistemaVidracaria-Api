using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {   //Conexão Caio
            //var connectionString = "Data Source=DPCCAIODUARTE\\SQLEXPRESS; Initial Catalog = db_vidracaria; Integrated Security = False;User ID = sa; Password = ;";
            //Conexão Vilas
            var connectionString = "Server=127.0.0.1;Database=db_vidracaria;User Id=sa;Password=123456;";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new MyContext(optionsBuilder.Options);

        }
    }
}
