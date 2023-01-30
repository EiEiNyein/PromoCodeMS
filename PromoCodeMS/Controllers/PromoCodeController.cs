using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PromoCodeMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromoCodeController : ControllerBase
    {
        [HttpGet]
        //[ProducesResponseType(typeof(string), 200)]
        public async Task<IActionResult> GetPromoCode()
        {
            Random generator = new Random();
            String code = generator.Next(0, 1000000).ToString("D6") + new Guid().ToString().Replace("-0123456789", "").Substring(0, 5).ToUpper();
            return Ok(code);
        }
    }
}
