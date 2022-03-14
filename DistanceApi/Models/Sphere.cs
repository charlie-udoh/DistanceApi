namespace DistanceApi.Models
{
    public class Sphere : Shape
    {
        private double latitude1;
        private double longitude1;
        private double latitude2;
        private double longitude2;
        private string Unit;

        public Sphere(Coordinates p1, Coordinates p2, string? unit)
        {
            latitude1 = p1.Latitude;
            longitude1 = p1.Longitude;
            latitude2 = p2.Latitude;
            longitude2 = p2.Longitude;
            Unit = unit;
        }

        public override double CalculateDistance()
        {
            double dLat = ToRadians(latitude2 - latitude1);
            double dLon = ToRadians(longitude2 - longitude1);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                Math.Cos(ToRadians(latitude1)) * Math.Cos(ToRadians(latitude2)) *
                Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Asin(Math.Min(1, Math.Sqrt(a)));
            var r = Constants.EarthRadiusUnitOfLength.ContainsKey(Unit) ? Constants.EarthRadiusUnitOfLength[Unit] : Constants.EarthRadiusUnitOfLength["Kilometers"];
            return Math.Round(c * r, 2);
        }
    }
}
