using FlexibleProject.Api.DTO;

namespace FlexibleProject.Api.Abstractions;

public interface IUsersService
{
    Task<List<UserDto>> GetUsers(int numberOfUsers);
}