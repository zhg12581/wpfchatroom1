using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfchatroom1.Model;

namespace wpfchatroom1.DAL
{
    public class AccountContext : DbContext
    {
        public AccountContext()
            : base("AccountContext")
        {

        }

        public DbSet<Data> Datas { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
            */
            //modelBuilder.Entity<Data>().ToTable("Data").HasKey(p => p.ID);
            Database.SetInitializer(new SqliteCreateDatabaseIfNotExists<AccountContext>(modelBuilder));

        }
    }
}
