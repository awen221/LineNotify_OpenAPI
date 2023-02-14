using Microsoft.AspNetCore.Mvc;

namespace LineNotify_OpenAPI.Controllers
{
    using LineNotify.Interface.Func;

    /// <summary>
    /// 
    /// </summary>
    [Route("[controller]/[action]")]
    [ApiController]
    public class api : ControllerBase
        ,Iapi<IActionResult>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult notify(string token, string message)
        {
            var result = new LineNotify.api().notify(token, message);
            return Ok(result);
        }
    }
}
