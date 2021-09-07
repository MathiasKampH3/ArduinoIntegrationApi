using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ArduinoIntegrationApi.Enums;

namespace ArduinoIntegrationApi.DataModels
{
    public class LightSensor
    {
        [Key] public int L_Id { get; set; }
        [Required]
        public bool L_Value { get; set; }
        [Required]
        public DateTime L_Cts { get; set; }
        [Required]
        public ComponentType ComponentType { get; set; }
        [ForeignKey("Room")] [Required] public string RoomName { get; set; }

       //public virtual Room Room { get; set; }
    }
}