
namespace SumarB.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class SumaController : ControllerBase
    {
        [HttpGet]
        [Route("Add")]
        public float Add(float a, float b){
            return a + b;       
        }
        [HttpGet]
        [Route("Multiply")]
        public float Mul(float a, float b)
        {   
            return a * b;
        }
        [HttpGet]
        [Route("Division")]
        public float Div(float a, float b) {
            return a / b;
        }
        [HttpGet]
        [Route("Substraction")]
        public float Sub(float a, float b) {
            return a - b;
        }
        [HttpPost]
        [Route("Add")]
        public float Add2([FromHeader] float a, [FromHeader] float b)
        {
            return a + b;
        }
        [HttpPost]
        [Route("Multiply")]
        public float Mul2([FromHeader] float a, [FromHeader] float b) {
            return a * b;
        }
        [HttpPost]
        [Route("Division")]
        public float Div2([FromHeader] float a, [FromHeader] float b)
        {
            return a / b;
        }
        [HttpPost]
        [Route("Substraction")]
        public float Sub2([FromHeader] float a, [FromHeader] float b)
        {
            return a - b;
        }
    }
}
