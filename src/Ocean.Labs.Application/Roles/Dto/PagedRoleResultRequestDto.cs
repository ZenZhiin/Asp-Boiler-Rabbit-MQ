using Abp.Application.Services.Dto;

namespace Ocean.Labs.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

