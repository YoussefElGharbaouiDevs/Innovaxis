using AutoMapper;
using Innovaxis.Api.Dtos;
using Innovaxis.Domain.Models;

namespace Innovaxis.Api.Configurations;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        #region Category

        CreateMap<CategoryEntity, CategoryDto>();
        CreateMap<CategoryDto, CategoryEntity>();

        #endregion

        #region User

        CreateMap<UserEntity, UserDto>();
        CreateMap<UserDto, UserEntity>();

        #endregion

        #region Category

        CreateMap<TaskEntity, TaskDto>();
        CreateMap<TaskDto, TaskEntity>();

        #endregion
    }
}