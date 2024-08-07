using Microsoft.AspNetCore.Mvc;
using Soccer.Server.Models;
using Soccer.Server.Services;

namespace Soccer.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PositionsController : ControllerBase
    {
        private readonly IPositionsService _positionService;

        public PositionsController(IPositionsService positionService)
        {
            _positionService = positionService;
        }

        // GET: api/Positions
        [HttpGet]
        public async Task<IEnumerable<Position>> Get()
        {
            return await _positionService.GetPositionsList();
        }
    }
}
