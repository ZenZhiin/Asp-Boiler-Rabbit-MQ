using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Ocean.Labs.MultiTenancy;

namespace Ocean.Labs.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
