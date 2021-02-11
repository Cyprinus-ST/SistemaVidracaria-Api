using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {   //Conexão Caios
           // var connectionString = "Password=x;Persist Security Info=True;User ID=sa;Initial Catalog=db_vidracaria;Data Source=DESKTOP-TI83OVD\\SQLEXPRESS";
            //Conexão Vilas
            var connectionString = "Server=127.0.0.1;Database=db_vidracaria;User Id=sa;Password=123456;";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new MyContext(optionsBuilder.Options);

        }
    }
}


