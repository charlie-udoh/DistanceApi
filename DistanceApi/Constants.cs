namespace DistanceApi
{
    public class Constants
    {
        public static Dictionary<string, double> EarthRadiusUnitOfLength = new Dictionary<string, double>()
        {
            {"Kilometers", 6371.0},
            {"Miles", 3958.8}
        };

        public static string[] Shapes = new string[] { "Flat", "Spherical", "Ellipsoid" };
    }
}
