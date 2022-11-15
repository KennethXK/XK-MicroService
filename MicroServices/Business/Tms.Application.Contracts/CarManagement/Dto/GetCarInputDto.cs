using System;
using Volo.Abp.Application.Dtos;

namespace Tms.CarManagement.Dto
{
    public class GetCarInputDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}