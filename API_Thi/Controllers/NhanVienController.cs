using API_Thi.Data;
using API_Thi.INhanVienRopository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Thi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class NhanVienController : ControllerBase
	{
		private readonly INhanVienRepository _nhanVienRepository;
		public NhanVienController(INhanVienRepository nhanVienRepository)
		{
			_nhanVienRepository = nhanVienRepository;
		}
		[HttpGet]
		public async Task<IActionResult> GetAllNhanVien()
		{
			var nhanViens = await _nhanVienRepository.GetAllNhanVien();
			return Ok(nhanViens);
		}
		[HttpGet("{id:int}")]
		public async Task<IActionResult> GetNhanVienById(int id)
		{
			var nhanVien = await _nhanVienRepository.GetNhanVienById(id);
			if (nhanVien == null)
			{
				return NotFound();
			}
			return Ok(nhanVien);
		}
		[HttpPost]
		public async Task<IActionResult> CreateNhanVien([FromBody] NhanVien nhanVien)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			await _nhanVienRepository.CreateNhanVien(nhanVien);
			return CreatedAtAction(nameof(GetNhanVienById), new { id = nhanVien.Id }, nhanVien);
		}
		[HttpPut("{id:int}")]
		public async Task<IActionResult> UpdateNhanVien(int id, [FromBody] NhanVien nhanVien)
		{
			if (id != nhanVien.Id)
			{
				return BadRequest();
			}
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			await _nhanVienRepository.UpdateNhanVien(nhanVien);
			return NoContent();
		}
		[HttpDelete("{id:int}")]
		public async Task<IActionResult> DeleteNhanVien(int id)
		{
			await _nhanVienRepository.DeleteNhanVien(id);
			return NoContent();
		}
	}
}
