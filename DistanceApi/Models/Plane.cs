namespace DistanceApi.Models
{
    public class Plane : Shape
    {
        private double latitude1;
        private double longitude1;
        private double latitude2;
        private double longitude2;
        private string Unit;

        public Plane(Coordinates p1, Coordinates p2, string? unit)
        {
            latitude1 = p1.Latitude;
            longitude1 = p1.Longitude;
            latitude2 = p2.Latitude;
            longitude2 = p2.Longitude;
            Unit = unit;
        }

        public override double CalculateDistance()
        {
            var distance = Math.Round(Math.Sqrt(Math.Pow(latitude2 - latitude1, 2) + Math.Pow(longitude2 - longitude1, 2)), 2);
            return distance;
        }
    }
}
