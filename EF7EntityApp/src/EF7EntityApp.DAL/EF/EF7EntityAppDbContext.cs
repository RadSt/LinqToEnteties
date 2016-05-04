using System.Threading;
using System.Threading.Tasks;
using EF7EntityApp.DAL.Models;
using Microsoft.Data.Entity;

namespace EF7EntityApp.DAL.EF
{
    /// <summary>
    /// Класс для подключения к БД.
    /// </summary>
    public class Ef7EntityAppDbContext : DbContext, IEf7EntityAppDbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=NancyDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }
    }

    public interface IEf7EntityAppDbContext
    {
        DbSet<Customer> Customers { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}