using System.Threading.Tasks;

namespace SimpleCms.Infrastructure.UseCase
{
    public interface IAsyncUseCaseRequestHandler<in TRequest, TResponse> 
        where TRequest : IRequest<TResponse>
    {
        Task<TResponse> ProcessAsync(TRequest request);
    }
}
