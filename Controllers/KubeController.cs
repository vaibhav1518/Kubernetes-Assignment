using Microsoft.AspNetCore.Mvc;

namespace KubernetesAssignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KubeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from Kubernetes");
        }
    }
}
