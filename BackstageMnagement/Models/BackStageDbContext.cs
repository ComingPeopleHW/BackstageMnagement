namespace BackstageMnagement.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BackStageDbContext : DbContext
    {
        public BackStageDbContext()
            : base("name=BackStageDbContext")
        {
        }

        public virtual DbSet<AccountInfo> AccountInfo { get; set; }
        public virtual DbSet<ArticleInfo> ArticleInfo { get; set; }
        public virtual DbSet<Draft> Draft { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountInfo>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<AccountInfo>()
                .Property(e => e.PassWord)
                .IsUnicode(false);

            modelBuilder.Entity<AccountInfo>()
                .Property(e => e.Permissions)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleInfo>()
                .Property(e => e.User)
                .IsUnicode(false);

            modelBuilder.Entity<Draft>()
                .Property(e => e.User)
                .IsUnicode(false);
        }
    }
}
