using DistanceApi.Interfaces;
using DistanceApi.Models;
using DistanceApi.ViewModels;

namespace DistanceApi.Services
{
    public class DistanceService : IDistanceService
    {
        public double GetDistance(CoordinateViewModel model)
        {
            var fromCoordinates = new Coordinates(model.Latitude1, model.Longitude1);
            var toCoordinates = new Coordinates(model.Latitude2, model.Longitude2);
            double distance;
            switch (model.Shape)
            {
                case "Flat":
                    var plane = new Plane(fromCoordinates, toCoordinates, model.UnitOfLength);
                    distance = plane.CalculateDistance();
                    return distance;
                case "Ellipsoid":
                    var ellipsoid = new Ellipsoid(fromCoordinates, toCoordinates, model.UnitOfLength);
                    distance = ellipsoid.CalculateDistance();
                    return distance;
                default:
                    var sphere = new Sphere(fromCoordinates, toCoordinates, model.UnitOfLength);
                    distance = sphere.CalculateDistance();
                    return distance;
            }
        }
    }
}
