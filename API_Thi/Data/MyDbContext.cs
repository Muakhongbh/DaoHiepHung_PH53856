using Microsoft.EntityFrameworkCore;

namespace API_Thi.Data
{
	public class MyDbContext : DbContext
	{
		public MyDbContext()
		{
		}
		public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
		{
		}

		public DbSet<NhanVien> NhanViens { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
