using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Tms.CarManagement.Dto
{
    public class CreateOrUpdateCarDto: EntityDto<Guid?>
    {
        
        /// <summary>
        /// 编码
        /// </summary>
        [Required]
        public string Code { get; set; }
        
        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        public string Name { get; set; }
        
    }
}