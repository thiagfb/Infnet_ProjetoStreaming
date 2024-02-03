using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpotifyLike.Domain.Streaming.Aggregates;
using SpotifyLike.Repository;

namespace SpotifyLike.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BandaController : ControllerBase
    {
        private SpotifyLikeContext Context { get; set; }

        public BandaController(SpotifyLikeContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult GetBandas()
        {
            var resul = this.Context.Bandas.ToList();

            return Ok(resul);
        }

        [HttpGet("id")]
        public IActionResult GetBandas(Guid id)
        {
            //var resul = this.Context.Bandas.Where(x => x.Id == id).FirstOrDefault();
            var resul = this.Context.Bandas.Where(x => x.Id == id).FirstOrDefault(x => x.Id == id);

            if (resul == null)
            {
                return NotFound();
            }

            return Ok(resul);
        }

        [HttpPost]
        public IActionResult SaveBandas([FromBody] Banda banda)
        {
            this.Context.Bandas.Add(banda);
            this.Context.SaveChanges();

            return Created($"/banda/{banda.Id}", banda);
        }
    }
}
