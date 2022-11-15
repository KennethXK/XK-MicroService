using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;
using System.ComponentModel.DataAnnotations;

namespace Tms.Models
{
    /// <summary>
    /// 表单
    /// </summary>
    public class Car: AuditedAggregateRoot<Guid>, ISoftDelete, IMultiTenant
    {
        public Guid? TenantId { get; set; }
        
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
        
		
		public bool IsDeleted { get; set; }
    }
}