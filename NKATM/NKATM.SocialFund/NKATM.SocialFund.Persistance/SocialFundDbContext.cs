using Microsoft.EntityFrameworkCore;
using NKATM.SocialFund.Domain;
using NKATM.SocialFund.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NKATM.SocialFund.Persistance
{
    public class SocialFundDbContext : DbContext
    {
        public SocialFundDbContext(DbContextOptions<SocialFundDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SocialFundDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var item in ChangeTracker.Entries<BaseEntity>())
            {
                item.Entity.ModificationDate = DateTime.Now;

                if(item.State == EntityState.Added)
                {
                    item.Entity.DateCreated = DateTime.Now;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<SocialType> SocialTypes { get; set; }
        public DbSet<SocialRequest> SocialRequests { get; set; }
        public DbSet<SocialResult> SocialResults { get; set; }
    }
}
