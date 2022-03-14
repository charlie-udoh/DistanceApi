namespace DistanceApi.Models
{
    public class Ellipsoid : Shape
    {
        private double latitude1;
        private double longitude1;
        private double latitude2;
        private double longitude2;
        private string Unit;

        public Ellipsoid(Coordinates p1, Coordinates p2, string? unit)
        {
            latitude1 = p1.Latitude;
            longitude1 = p1.Longitude;
            latitude2 = p2.Latitude;
            longitude2 = p2.Longitude;
            Unit = unit;
        }

        public override double CalculateDistance()
        {
            throw new NotImplementedException();
        }
    }
}
