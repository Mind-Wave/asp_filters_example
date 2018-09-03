namespace AnipchenkoASPNETFilters.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class User : DbContext
    {
        public User()
            : base("name=User")
        {
        }

        public virtual DbSet<users> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<users>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.pass)
                .IsUnicode(false);
        }
    }
}
