using API_Thi.Data;

namespace Web_App.Service
{
	public class NhanVienService : INhanVienService
	{
		private readonly HttpClient _httpClient;
		public NhanVienService(IHttpClientFactory httpClient)
		{
			_httpClient = httpClient.CreateClient("nhanvien");
		}
		public async Task CreateNhanVien(NhanVien nhanVien)
		{
			var response = await _httpClient.PostAsJsonAsync("nhanvien", nhanVien);
			response.EnsureSuccessStatusCode();
		}

		public async Task DeleteNhanVien(int id)
		{
			var response = await _httpClient.DeleteAsync($"nhanvien/{id}");
			response.EnsureSuccessStatusCode();
		}

		public async Task<List<NhanVien>> GetAllNhanVien()
		{
			return await _httpClient.GetFromJsonAsync<List<NhanVien>>("nhanvien");
		}

		public async Task<NhanVien> GetNhanVienById(int id)
		{
			return await _httpClient.GetFromJsonAsync<NhanVien>($"nhanvien/{id}");
		}

		public async Task UpdateNhanVien(NhanVien nhanVien)
		{
			var response = await _httpClient.PutAsJsonAsync($"nhanvien/{nhanVien.Id}", nhanVien);
			response.EnsureSuccessStatusCode();
		}
	}
}
