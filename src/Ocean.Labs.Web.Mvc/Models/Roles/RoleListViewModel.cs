using System.Collections.Generic;
using Ocean.Labs.Roles.Dto;

namespace Ocean.Labs.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
