using System.Collections.Generic;
using System.Threading.Tasks;
using HogwartsPotions.Models;
using HogwartsPotions.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HogwartsPotions.Controllers
{
    [Route("/potions")]
    [ApiController]
    public class PotionController : ControllerBase
    {
        private readonly HogwartsContext _context;

        public PotionController(HogwartsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<Potion>> GetAllPotions()
        {
            return await _context.GetAllPotions();
        }

        [HttpPost]
        public async Task<IActionResult> BrewPotion([FromQuery] long studentId, [FromBody] Potion newPotion)
        {
            Potion brewedPotion = await _context.BrewPotion(studentId, newPotion);
            return Ok(brewedPotion);
        }

        [HttpGet("/{student-id}")]
        public async Task<List<Potion>> GetPotionsOfStudent([FromRoute] long studentId)
        {
            return await _context.GetAllPotionsOfStudent(studentId);
        }

        [HttpPost("/brew")]
        public async Task<Potion> StartBrewPotion([FromBody] long studentId)
        {
            return await _context.StartBrewPotion(studentId);
        }

        [HttpPut("/potions/{potionId:long}/add")]
        public async Task<Potion> AddIngredientToPotion([FromRoute] long potionId, [FromBody] Ingredient ingredient)
        {
            return await _context.AddIngredientToPotion(potionId, ingredient);
        }
    }
}
