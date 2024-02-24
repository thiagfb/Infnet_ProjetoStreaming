using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Spotify.Application.Conta;
using Spotify.Application.Conta.Request;

namespace SpotifyLike.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UsuarioService _usuarioService;

        public UserController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public IActionResult Criar(UsuarioDto dto)
        {
            if (ModelState is { IsValid: false })
                return BadRequest();

            var result = this._usuarioService.Criar(dto);

            return Ok();

        }
    }
}
