using Soccer.Server.Models;

namespace Soccer.Server.Services
{
    public interface IPositionsService
    {
        Task<IEnumerable<Position>> GetPositionsList();
    }
}
