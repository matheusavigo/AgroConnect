using AgroConnect.Models;
using System.Data.Entity;

namespace AgroConnect.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=BD_AgroConnectEntities")
        {
        }
        public DbSet<Cadastro> Cadastroes { get; set; }

    }
}
