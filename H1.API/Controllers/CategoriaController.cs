
using ListaH1.Application.Interfaces;
using ListaH1.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ListaH1.H1.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CategoriaController : ControllerBase
	{
		private readonly ICategoriaService _categoriaService;
		public CategoriaController(ICategoriaService categoriaService)
		{
			_categoriaService = categoriaService;
		}

		[HttpPost]
		[Route("Adicionar")]
		public async Task<IActionResult> Post(NovaCategoriaViewModel categoriaViewModel)
		{
			await _categoriaService.Adicionar(categoriaViewModel);

			return Ok();
		}

	

		[HttpGet]
		[Route("ObterTodas")]
		public IActionResult Get()
		{
			return Ok(_categoriaService.ObterTodas());
		}
	}
}

