using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hp_api.Model;
using Microsoft.EntityFrameworkCore;
using hp_api.Controllers;

namespace hp_api.Controllers.Data
{
  public class HpContext : DbContext
  {
    protected readonly IConfiguration Configuration;
    public HpContext(IConfiguration configuration) { Configuration = configuration; }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
      // connect to sql server with connection string from app settings 
      options.UseSqlServer(Configuration.GetConnectionString("StringConexaoSQLServer"));
    }
    public DbSet<Hp_Personagens> Hp_Personagens { get; set; }
  }
}