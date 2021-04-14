using System.Threading.Tasks;
using AspNet.Api.Websocket.WebApp.Middlewares;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.Api.Websocket.WebApp.Controllers
{
  [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly NotificationsMessageHandler _wsNotificationsMessageHandler;
        public WeatherForecastController(NotificationsMessageHandler notificationHandler)
        {
            _wsNotificationsMessageHandler = notificationHandler;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await _wsNotificationsMessageHandler.SendMessageToAllAsync("message");
            return Ok();
        }
    }
}
