using System;

namespace Mhd.Framework.EfCore
{
    public interface ITraceable : IInterceptor
    {
        Guid AuditCreateBy { get; set; }
        Guid AuditModifiedBy { get; set; }
    }
}
