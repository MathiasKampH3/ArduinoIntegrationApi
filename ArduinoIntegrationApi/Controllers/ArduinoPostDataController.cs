using Microsoft.AspNetCore.Mvc;
using ArduinoIntegrationApi.Context;


namespace ArduinoIntegrationApi.Controllers
{
    [ApiController]
    [Route("api/PostData")]
    public class ArduinoPostDataController : Controller
    {
        [HttpGet]
        [Route("PostRoomData")]
        public StatusCodeResult PostRoomData(string roomName, float tempHead, float humHead, float tempFeet,string soundStatus, string curtainStatus , string lightStatus)
        {
            if (ContextManager.PostRoomData(roomName, tempHead, humHead, tempFeet, soundStatus, curtainStatus, lightStatus))
            {
                return new StatusCodeResult(200);
            }

            return new StatusCodeResult(400);
        }
    }
}