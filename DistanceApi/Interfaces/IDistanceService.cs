using DistanceApi.ViewModels;

namespace DistanceApi.Interfaces
{
    public interface IDistanceService
    {
        double GetDistance(CoordinateViewModel model);
    }
}
