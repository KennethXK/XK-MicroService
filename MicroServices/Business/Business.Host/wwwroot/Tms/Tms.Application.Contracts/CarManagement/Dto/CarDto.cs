using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;
using System.ComponentModel.DataAnnotations;

namespace Tms.CarManagement.Dto
{
    public class CarDto : EntityDto<Guid?>
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