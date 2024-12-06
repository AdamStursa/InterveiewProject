

using InterviewProject.Models;
using Microsoft.EntityFrameworkCore;

namespace InterviewProject.Data;

public sealed class AppDbContext(DbContextOptions<AppDbContext> options): DbContext(options)
{
	public DbSet<Package> Packages { get; set; } = default!;
	
	public DbSet<Plane> Planes { get; set; } = default!;
	
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		// add unique to identification number
		modelBuilder.Entity<Plane>()
			.HasIndex(p => p.IdentificationNumber)
			.IsUnique();

		// specific for sqlite db
		modelBuilder.Entity<Package>()
			.Property(e => e.Weight)
			.HasConversion<double>();
	}
		
}