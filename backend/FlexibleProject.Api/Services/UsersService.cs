using FlexibleProject.Api.Abstractions;
using FlexibleProject.Api.DTO;
using FlexibleProject.Api.Entities;
using MapsterMapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FlexibleProject.Api.Services;

public class UsersService : IUsersService
{
    private static HttpClient _client = new();
    private readonly IMapper _mapper;

    public UsersService(IMapper mapper)
    {
        _mapper = mapper;
    }
    
    public async Task<List<UserDto>> GetUsers(int numberOfUsers)
    {
        var maxNumberOfUsers = 10;
        var users = new List<User>();
        
        if (numberOfUsers == 0 || numberOfUsers > 9)
        {
            numberOfUsers = maxNumberOfUsers;
        }

        var response = await _client.GetAsync($"https://randomuser.me/api/?results={numberOfUsers}");

        if (!response.IsSuccessStatusCode)
        {
            return null;
        }

        var jsonString = await response.Content.ReadAsStringAsync();
        var jsonObject = JObject.Parse(jsonString);
        var jsonUsers = jsonObject["results"]?.Children().ToList();

        if (jsonUsers is null)
        {
            return null;
        }
        
        foreach (var jsonUser in jsonUsers)
        {
            User user = jsonUser.ToObject<User>();
            users.Add(user);
        }
        
        // var result = new List<User> {new("jhondoe@wp.pl")};

        return users.Select(x => _mapper.Map<UserDto>(x)).ToList();
    }
}