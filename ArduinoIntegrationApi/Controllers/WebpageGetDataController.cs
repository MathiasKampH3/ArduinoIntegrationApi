using ArduinoIntegrationApi.Context;
using Microsoft.AspNetCore.Mvc;
using ArduinoIntegrationApi.DataModels;
using Newtonsoft.Json;


namespace ArduinoIntegrationApi.Controllers
{
    [ApiController]
    [Route("api/WebpageGetData")]
    public class WebpageGetDataController : Controller
    {
        [HttpGet]
        [Route("GetLatestRoomData")]
        public string GetLatestRoomData(string roomName)
        {
            RoomReading latestRoomData = ContextManager.GetLatestRoomData(roomName);

            return JsonConvert.SerializeObject(latestRoomData);
        }
    }
}