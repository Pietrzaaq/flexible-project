using FlexibleProject.Api.DTO;
using FlexibleProject.Api.Entities;
using Mapster;

namespace FlexibleProject.Api.Mapping;

public class UserMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<User, UserDto>();
    }
}