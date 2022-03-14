using DistanceApi.Interfaces;
using DistanceApi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DistanceApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DistanceController : ControllerBase
    {
        private readonly IDistanceService _distanceService;

        public DistanceController(IDistanceService distanceService)
        {
            _distanceService = distanceService;
        }

        [HttpPost]
        public ActionResult<double> Calculate(CoordinateViewModel model)
        {
            var distance = _distanceService.GetDistance(model);
            return Ok(distance);
        }
    }
}
