using System.ComponentModel.DataAnnotations;

namespace ArduinoIntegrationApi.DataModels
{
    public class CurtainReading
    {
        [Key] public int Cur_Id { get; set; }
        [MaxLength(10)]
        [Required] public string Cur_Value { get; set; }
    }
}