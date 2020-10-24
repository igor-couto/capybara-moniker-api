using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace capybara_moniker_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CapybaraController : ControllerBase
    {
        private static readonly string[] MaleNickNames = new[]
        {
            "Zé do Sofá", "Arnaldo", "Cuco", "Pato", "Louro", "Bilóia", "Leleco", "Jiló", "Dedeco", "Dez Conto", "Mandioca", "Baleio"
        };

        private static readonly string[] FemaleNickNames = new[]
        {
            "Leida","Leninha", "Lili", "Marcha Lenta", "Monalisa", "Cleide", "Bochechas", "Melindrosa", "Samambaia", "Moranguinho", "Ritinha", "Nazaré"
        };

        private readonly ILogger<CapybaraController> _logger;

        public CapybaraController(ILogger<CapybaraController> logger)
            => _logger = logger;

        [HttpGet]
        public string Get()
        {
            var rng = new Random();
            return MaleNickNames[rng.Next(MaleNickNames.Length)];
        }
    }
}
