using _2_Persistent;
using _3_Infrastructure.Dtos;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _5_WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherStationsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public WeatherStationsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var stations = await _dbContext.WeatherStations.ToListAsync();

            var returnedData = stations.Select(station => new WeatherStationDto(station)).ToList();

            return Ok(returnedData);
        }
    }
}