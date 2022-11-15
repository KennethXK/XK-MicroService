using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Tms.CarManagement.Dto;

namespace Tms.CarManagement
{
    public interface ICarAppService : IApplicationService
    {
        Task<CarDto> Get(Guid id);

        Task<PagedResultDto<CarDto>> GetAll(GetCarInputDto input);

        Task<CarDto> DataPost(CreateOrUpdateCarDto input);

        Task Delete(List<Guid> ids);
    }
}
