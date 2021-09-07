using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArduinoIntegrationApi.DataModels
{
    public class Room
    {
        [Key] [MaxLength(50)] public string RoomName { get; set; }

    }
}
