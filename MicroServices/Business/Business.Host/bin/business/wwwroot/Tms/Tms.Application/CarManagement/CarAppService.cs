using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Tms.CarManagement.Dto;
using Tms.Models;
using Microsoft.AspNetCore.Authorization;
using Tms.Permissions;

namespace Tms.CarManagement
{
    [Authorize(TmsPermissions.Car.Default)]
    public class CarAppService : ApplicationService,ICarAppService
    {
        private const string FormName = "Car";
        private IRepository<Car, Guid> _repository;

        public CarAppService(
            IRepository<Car, Guid> repository
            )
        {
            _repository = repository;
        }
        #region 增删改查基础方法

        public async Task<CarDto> Get(Guid id)
        {
            var data = await _repository.GetAsync(id);
            var dto = ObjectMapper.Map<Car, CarDto>(data);
            return dto;
        }

        public async Task<PagedResultDto<CarDto>> GetAll(GetCarInputDto input)
        {
            var query = (await _repository.GetQueryableAsync()).WhereIf(!string.IsNullOrWhiteSpace(input.Filter), a => a.Name.Contains(input.Filter));

            var totalCount = await query.CountAsync();
            var items = await query.OrderBy(input.Sorting ?? "Id")
                       .Skip(input.SkipCount)
                       .Take(input.MaxResultCount)
                       .ToListAsync();

            var dto = ObjectMapper.Map<List<Car>, List<CarDto>>(items);
            return new PagedResultDto<CarDto>(totalCount, dto);
        }

        public async Task<CarDto> DataPost(CreateOrUpdateCarDto input)
        {
            Car result = null;
            if (!input.Id.HasValue)
            {
                input.Id = GuidGenerator.Create();
                result = await _repository.InsertAsync(ObjectMapper.Map<CreateOrUpdateCarDto, Car>(input));
            }
            else
            {
                var data = await _repository.GetAsync(input.Id.Value);
                result = await _repository.UpdateAsync(ObjectMapper.Map(input, data));
            }
            return ObjectMapper.Map<Car, CarDto>(result);
        }

        public async Task Delete(List<Guid> ids)
        {
            foreach (var item in ids)
            {
                await _repository.DeleteAsync(item);
            }

        }

     
        #endregion

    }
}