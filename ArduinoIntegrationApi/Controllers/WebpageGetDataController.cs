using System.Collections.Generic;
using ArduinoIntegrationApi.Context;
using Microsoft.AspNetCore.Mvc;
using ArduinoIntegrationApi.DataModels;

namespace ArduinoIntegrationApi.Controllers
{
    [ApiController]
    [Route("api/WebpageGetData")]
    public class WebpageGetDataController : Controller
    {
        [HttpGet]
        [Route("GetLatestTemperature")]
        public TemperatureSensor GetLatestTemperature(string roomName)
        {
            return ContextManager.GetLatestTemperature(roomName);
        }

        [HttpGet]
        [Route("GetLatestLightSensorState")]
        public LightSensor GetLatestLightSensorState(string roomName)
        {
            return ContextManager.GetLatestLightSensorState(roomName);
        }

        [HttpGet]
        [Route("GetLatestWindowState")]
        public WindowLock GetLatestWindowLockState(string roomName)
        {
            return ContextManager.GetLatestWindowLockState(roomName);
        }

        [HttpGet]
        [Route("GetAllRooms")]
        public List<Room> GetAllRooms()
        {
            return ContextManager.GetAllRooms();
        }
    }
}
