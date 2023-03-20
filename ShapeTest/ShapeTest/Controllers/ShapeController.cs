using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShapeTest.Model;
using ShapeTest.Service;

namespace ShapeTest.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ShapeController : ControllerBase
    {
        private readonly ShapeService _shapeService;
        public ShapeController()
        {
            _shapeService = new ShapeService(); 
        }
        [HttpPost]
        public async Task<ActionResult> GetCirculeArea(long radius)
        {
            return Ok(await _shapeService.GetCirculeArea(radius));
        }
        [HttpPost]
        public async Task<ActionResult> GetTriangleArea(shapeModels model)
        {
            return Ok(await _shapeService.GetTriangleArea(model));
        }
    }

}


