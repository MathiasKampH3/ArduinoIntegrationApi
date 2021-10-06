using System;
using System.ComponentModel.DataAnnotations;


namespace ArduinoIntegrationApi.DataModels
{
    public class TemperatureReading
    {
        [Key] public int Ts_Id { get; set; }
        [Required] public float Ts_Value { get; set; }
    }
}