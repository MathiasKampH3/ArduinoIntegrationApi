using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArduinoIntegrationApi.Context;
using ArduinoIntegrationApi.DataModels;

namespace ArduinoIntegrationApi.Controllers
{
    [ApiController]
    [Route("api/Rooms")]
    public class RoomController : Controller
    {
        private static ArduinoApiContext Ctx { get; set; } = new();

        [HttpPut]
        [Route("CreateRoom")]
        public Room CreateNewRoom(string roomName)
        {
            Room newRoom = ContextManager.CreateNewRoom(roomName);
            return newRoom;
        }

        [HttpGet]
        [Route("CheckRoomExists")]
        public bool CheckRoomExists(string roomName)
        {
            if (ContextManager.RoomExists(roomName))
            {
                return true;
            }

            return false;
        }
    }
}
