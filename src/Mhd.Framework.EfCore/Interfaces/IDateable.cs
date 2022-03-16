using System;

namespace Mhd.Framework.EfCore
{
    public interface IDateable : IInterceptor
    {
        DateTime AuditCreateDate { get; set; }
        DateTime AuditModifiedDate { get; set; }
    }

}
