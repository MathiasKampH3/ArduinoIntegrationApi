using System;
using System.ComponentModel.DataAnnotations;


namespace ArduinoIntegrationApi.DataModels
{
    public class LightReading
    {
        [Key] public int Ls_Id { get; set; }
        [MaxLength(10)]
        [Required] public string Ls_Value { get; set; }
    }
}