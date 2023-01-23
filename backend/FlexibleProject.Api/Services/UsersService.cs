using FlexibleProject.Api.Abstractions;
using FlexibleProject.Api.DTO;
using FlexibleProject.Api.Entities;
using MapsterMapper;
using Newtonsoft.Json;

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
        
        if (numberOfUsers == 0 || numberOfUsers > 9)
        {
            numberOfUsers = maxNumberOfUsers;
        }

        var response = await _client.GetAsync($"https://randomuser.me/api/?results={numberOfUsers}");

        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();

            var users = JsonConvert.DeserializeObject<List<User>>(json);
        }

        var result = new List<User> {new("jhondoe@wp.pl")};

        return result.Select(x => _mapper.Map<UserDto>(x)).ToList();
    }
}