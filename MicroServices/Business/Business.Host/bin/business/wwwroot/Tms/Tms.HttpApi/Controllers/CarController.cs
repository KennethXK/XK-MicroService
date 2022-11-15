using Tms.CarManagement;
using Tms.CarManagement.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace Tms.Controllers
{
    [RemoteService]
    [Area("Tms")]
    [Route("api/app/Car")]
    public class CarController : AbpController
    {
        private readonly ICarAppService _CarAppService;

        public CarController(ICarAppService CarAppService)
        {
            _CarAppService = CarAppService;
        }

        [HttpPost]
        [Route("data-post")]
        public Task<CarDto> DataPost(CreateOrUpdateCarDto input)
        {
            return _CarAppService.DataPost(input);
        }

        [HttpPost]
        [Route("delete")]
        public Task Delete(List<Guid> ids)
        {
            return _CarAppService.Delete(ids);
        }

        [HttpGet]
        [Route("{id}")]
        public Task<CarDto> Get(Guid id)
        {
            return _CarAppService.Get(id);
        }

        [HttpGet]
        public Task<PagedResultDto<CarDto>> GetAll(GetCarInputDto input)
        {
            return _CarAppService.GetAll(input);
        }
    }
}
