
namespace SumarB.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class SumaController : ControllerBase
    {
        [HttpGet]
        [Route("Add")]
        public int Add(int a, int b){
            return a+b;       
        }
        [HttpGet]
        [Route("Multiply")]
        public int Mul(int a, int b)
        {   
            return a * b;
        }
        [HttpPost]
        [Route("Add")]
        public int Add2([FromHeader]int a, [FromHeader] int b)
        {
            return a + b;
        }
        [HttpPost]
        [Route("Multiply")]
        public int Mul2([FromHeader] int a, [FromHeader] int b) {
            return a * b;
        }
    }
}
