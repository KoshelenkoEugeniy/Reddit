namespace Reddit.Core.Services.Interfaces
{
    public interface IApiService
    {
        IRedditApi Client { get; }
    }
}
