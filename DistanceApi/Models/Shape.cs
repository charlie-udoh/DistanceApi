namespace DistanceApi.Models
{
    public abstract class Shape
    {
        public abstract double CalculateDistance();

        public double ToRadians(double value)
        {
            return (Math.PI / 180) * value;
        }
    }
}
