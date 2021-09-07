using Microsoft.AspNetCore.Mvc;
using ArduinoIntegrationApi.Context;


namespace ArduinoIntegrationApi.Controllers
{
    [ApiController]
    [Route("api/PostData")]
    public class ArduinoPostDataController : Controller
    {
        [HttpPut]
        [Route("PostTemperature")]
        public StatusCodeResult PostTemperature(string roomName, float temperatureReading)
        {
            if (ContextManager.AddNewTemperature(roomName, temperatureReading))
            {
                return new StatusCodeResult(200);
            }
            else
            {
                return new StatusCodeResult(400);
            }
        }


        [HttpPut]
        [Route("PostLightSensorState")]
        public StatusCodeResult PostLightSensorState(string roomName, bool lightSensorState)
        {
            if (ContextManager.AddNewLightSensorSate(roomName, lightSensorState))
            {
                return new StatusCodeResult(200);
            }

            return new StatusCodeResult(400);
        }

        [HttpPut]
        [Route("PostWindowLockState")]
        public StatusCodeResult PostWindowLockState(string roomName, bool windowLockState)
        {
            if (ContextManager.AddNewWindowLockState(roomName, windowLockState))
            {
                return new StatusCodeResult(200);
            }

            return new StatusCodeResult(400);
        }
    }
}