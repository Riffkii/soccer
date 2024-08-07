using Soccer.Server.Data;
using Soccer.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace Soccer.Server.Services
{
    public class PositionsService : IPositionsService
    {
        private readonly SoccerDbContext _context;

        public PositionsService(SoccerDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Position>> GetPositionsList()
        {
            return await _context.Positions
                .OrderBy(x => x.DisplayOrder)
                .ToListAsync();
        }
    }
}
