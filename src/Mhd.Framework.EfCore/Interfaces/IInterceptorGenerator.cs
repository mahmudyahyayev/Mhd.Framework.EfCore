using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;

namespace Mhd.Framework.EfCore
{
    public interface IInterceptorGenerator
    {
        void OnBefore(EntityEntry item, DbContext objectContext);
        void OnAfter();
        void OnError(Exception exception);
    }
}
