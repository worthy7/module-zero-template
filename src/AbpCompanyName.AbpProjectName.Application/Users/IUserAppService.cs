using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AbpCompanyName.AbpProjectName.Roles.Dto;
using AbpCompanyName.AbpProjectName.Users.Dto;

namespace AbpCompanyName.AbpProjectName.Users
{
    /// <summary>
    /// Manage Users
    /// </summary>
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        /// <summary>
        /// Get the roles
        /// </summary>
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}