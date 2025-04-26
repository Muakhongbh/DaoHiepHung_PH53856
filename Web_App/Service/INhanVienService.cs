using API_Thi.Data;

namespace Web_App.Service
{
	public interface INhanVienService
	{
		Task<List<NhanVien>> GetAllNhanVien();
		Task<NhanVien> GetNhanVienById(int id);
		Task CreateNhanVien(NhanVien nhanVien);
		Task UpdateNhanVien(NhanVien nhanVien);
		Task DeleteNhanVien(int id);
	}
}
