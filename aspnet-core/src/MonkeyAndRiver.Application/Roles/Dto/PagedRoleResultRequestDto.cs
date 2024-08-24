using Abp.Application.Services.Dto;

namespace MonkeyAndRiver.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

