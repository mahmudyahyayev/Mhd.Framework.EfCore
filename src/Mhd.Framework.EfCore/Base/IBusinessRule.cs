namespace Mhd.Framework.EfCore
{
    public interface IBusinessRule
    {
        bool IsBroken();
        string Message { get; }
    }
}
