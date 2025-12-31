using System.Text.Json;

namespace WebApplication1.Data;

public class UserInfo
{
    public string name { get; set; }
    public string language { get; set; }
    public string id { get; set; }
    public string bio { get; set; }
    public decimal bioversion { get; set; }
}