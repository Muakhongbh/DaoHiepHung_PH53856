using API_Thi.Data;
using Microsoft.EntityFrameworkCore;

namespace API_Thi.INhanVienRopository.NhanVienRepository
{
	public class NhanVienRepository : INhanVienRepository
	{
		private readonly MyDbContext _context;
		public NhanVienRepository(MyDbContext context)
		{
			_context = context;
		}

		public async Task CreateNhanVien(NhanVien nhanVien)
		{
			try
			{
				_context.NhanViens.Add(nhanVien);
				await _context.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw new Exception("Error creating NhanVien", ex);
			}
		}

		public async Task DeleteNhanVien(int id)
		{
			try
			{
				var nhanVien = await GetNhanVienById(id);
				if (nhanVien == null)
				{
					throw new Exception("NhanVien not found");
				}
				_context.NhanViens.Remove(nhanVien);
				await _context.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw new Exception("Error deleting NhanVien", ex);
			}
		}

		public async Task<List<NhanVien>> GetAllNhanVien()
		{
			return await _context.NhanViens.ToListAsync();
		}

		public async Task<NhanVien> GetNhanVienById(int id)
		{
			return await _context.NhanViens.FindAsync(id);
		}

		public async Task UpdateNhanVien(NhanVien nhanVien)
		{
			try
			{
				if(nhanVien.Id <= 0)
				{
					throw new Exception("Invalid NhanVien ID");
				}
				_context.NhanViens.Update(nhanVien);
				await _context.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw new Exception("Error updating NhanVien", ex);
			}
		}
	}
}
