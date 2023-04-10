using AlphabiApi.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VitrineCarrosApi.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }
        //public DbSet<VtexOrderModel> Order { get; set; }
    }

}
