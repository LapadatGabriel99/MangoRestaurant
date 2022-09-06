namespace Mango.Services.Identity.Services.Contracts
{
    public interface IDbInitializerService : IDisposable
    {
        Task Initialize();
    }
}
