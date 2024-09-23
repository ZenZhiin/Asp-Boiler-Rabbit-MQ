using System.Collections.Generic;
using Ocean.Labs.Roles.Dto;

namespace Ocean.Labs.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
