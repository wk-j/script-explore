#! "netcoreapp2.0"
#r "nuget:NetStandard.Library,2.0.0"
#r "nuget: Newtonsoft.Json, 10.0.3"

using Newtonsoft.Json;
using System.Linq;

class User
{
    public string Email { set; get; }
    public string Name { set; get; }
}

var rawJson = "[{\"email\": \"wk@gmail.com\"}]";
var users = JsonConvert.DeserializeObject<User[]>(rawJson);

foreach (var user in users)
{
    Console.WriteLine($"Found: {user.Name} - {user.Email}.");
}