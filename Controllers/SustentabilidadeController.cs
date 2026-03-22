using Microsoft.AspNetCore.Mvc;

namespace EcoTrackApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SustentabilidadeController : ControllerBase
    {
        private static readonly string[] Dicas = new[]
        {
            "Use transporte público sempre que possível.",
            "Reduza o consumo de plástico.",
            "Economize energia desligando aparelhos.",
            "Prefira produtos sustentáveis.",
            "Evite desperdício de água."
        };

        [HttpGet]
        public string Get()
        {
            Random random = new Random();
            int index = random.Next(Dicas.Length);

            return Dicas[index];
        }
    }
}