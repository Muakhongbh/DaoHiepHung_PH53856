using System.ComponentModel.DataAnnotations;

namespace API_Thi.Data
{
	public class NhanVien
	{
		[Required (ErrorMessage = "ID is required")]
		public int Id { get; set; }
		[Required (ErrorMessage = "Name is required")]
		public string HoTen { get; set; }
		[Required (ErrorMessage = "ChucVu is required")]
		public string ChucVu { get; set; }
		[Required (ErrorMessage = "GioiTinh is required")]
		public DateTime NgaySinh { get; set; }
		[Required (ErrorMessage = "Luong is required")]
		public float Luong { get; set; }
		[Required (ErrorMessage = "CreateStast is required")]
		public DateTime CreateStast { get; set; } 
	}
}
