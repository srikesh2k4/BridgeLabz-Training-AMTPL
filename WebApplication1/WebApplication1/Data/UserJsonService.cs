using System.Text.Json;

namespace WebApplication1.Data;

public class UserJsonService
{
    private readonly string _path;

    public UserJsonService(IWebHostEnvironment env)
    {
        _path = Path.Combine(env.ContentRootPath, "Data", "data.json");
    }

    public List<UserInfo> GetUsers()
    {
        if (!File.Exists(_path))
            return new List<UserInfo>();

        var json = File.ReadAllText(_path);

        return JsonSerializer.Deserialize<List<UserInfo>>(
            json,
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }
        ) ?? new List<UserInfo>();
    }
}