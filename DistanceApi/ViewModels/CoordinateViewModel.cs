using DistanceApi.Validations;
using System.ComponentModel.DataAnnotations;

namespace DistanceApi.ViewModels
{
    public class CoordinateViewModel
    {
        [Required]
        public double Latitude1 { get; set; }
        [Required]
        public double Longitude1 { get; set; }
        [Required]
        public double Latitude2 { get; set; }
        [Required]
        public double Longitude2 { get; set; }
        [ValidShape]
        public string? Shape { get; set; }
        [ValidUnitOfLength]
        public string? UnitOfLength { get; set; }
    }
}
