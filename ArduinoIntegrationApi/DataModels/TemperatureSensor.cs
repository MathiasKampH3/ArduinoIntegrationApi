using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ArduinoIntegrationApi.Enums;

namespace ArduinoIntegrationApi.DataModels
{
    public class TemperatureSensor
    {
        [Key] public int T_Id { get; set; }
        [Required] public float T_Value { get; set; }
        [Required] public DateTime T_Cts { get; set; }
        [Required] public ComponentType ComponentType { get; set; }

        [ForeignKey("Room")] [Required] public string RoomName { get; set; }

        //public virtual Room Room { get; set; }
    }
}