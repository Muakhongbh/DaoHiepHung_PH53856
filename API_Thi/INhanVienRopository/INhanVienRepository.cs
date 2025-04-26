using API_Thi.Data;

namespace API_Thi.INhanVienRopository
{
	public interface INhanVienRepository
	{
		Task<List<NhanVien>> GetAllNhanVien();
		Task<NhanVien> GetNhanVienById(int id);
		Task CreateNhanVien(NhanVien nhanVien);
		Task UpdateNhanVien(NhanVien nhanVien);
		Task DeleteNhanVien(int id);
	}
}
