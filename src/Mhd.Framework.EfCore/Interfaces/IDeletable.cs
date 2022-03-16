namespace Mhd.Framework.EfCore
{
    public interface IDeletable : IInterceptor
    {
        bool AuditIsDeleted { get; set; }
    }
}
