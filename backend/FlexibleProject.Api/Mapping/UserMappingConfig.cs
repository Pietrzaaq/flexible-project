using FlexibleProject.Api.DTO;
using FlexibleProject.Api.Entities;
using Mapster;

namespace FlexibleProject.Api.Mapping;

public class UserMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<User, UserDto>()
            .Map(dest => dest.Picture, src => src.Picture.Medium)
            .Map(dest => dest.First, src => src.Name.First)
            .Map(dest => dest.Last, src => src.Name.Last)
            .Map(dest => dest.Email, src => src.Email);
    }
}