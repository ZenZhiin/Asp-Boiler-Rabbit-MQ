using System.Collections.Generic;
using Ocean.Labs.Roles.Dto;

namespace Ocean.Labs.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}