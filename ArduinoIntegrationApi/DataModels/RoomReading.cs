using System;
using System.ComponentModel.DataAnnotations;

namespace ArduinoIntegrationApi.DataModels
{
    public class RoomReading
    {
        [Key] public string Rd_RoomName { get; set; }
        [Required]
        public DateTime Rd_Cts { get; set; }
        [Required]
        public virtual LightReading LightReading { get; set; }
        [Required]
        public virtual TemperatureReading HeadTemperatureReading { get; set; }
        [Required]
        public virtual TemperatureReading FeetTemperatureReading { get; set; }
        [Required]
        public virtual HumidityReading HumidityReading { get; set; }
        [Required]
        public virtual CurtainReading CurtainReading { get; set; }
        [Required]
        public virtual SoundReading SoundReading { get; set; }
    }
}