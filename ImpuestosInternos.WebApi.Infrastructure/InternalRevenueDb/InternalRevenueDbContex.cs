using ImpuestosInternos.WebApi.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ImpuestosInternos.WebApi.Infrastructure.InternalRevenueDb;

public class InternalRevenueDbContex: DbContext
{
    public DbSet<Contributor> Contributors { get; set; }
    public DbSet<FiscalReceipt> FiscalReceipts { get; set; }
    public DbSet<TypeContributor> TypeContributors { get; set; }


    public InternalRevenueDbContex(DbContextOptions<InternalRevenueDbContex> dbContextOptions): base(dbContextOptions)
    {
        
        
    }
    
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contributor>()
            .HasOne(c => c.TypeContributor)
            .WithMany(c => c.Contributors)
            .HasForeignKey(c => c.TypeId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<FiscalReceipt>()
            .HasOne(c => c.Contributor)
            .WithMany(x => x.FiscalReceiptsCollection)
            .HasForeignKey(c => c.ContributorId);

        // modelBuilder.Entity<TypeContributor>()
        //     .HasOne(t => t.Contributors);

    }
}