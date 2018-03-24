using System.Collections.Generic;
using AbpPro.Roles.Dto;
using AbpPro.Users.Dto;

namespace AbpPro.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}