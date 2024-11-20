using Mt2Forum.Api.Contracts;
using Mt2Forum.Api.Service.Interfaces;

namespace Mt2Forum.Api.Service;

internal sealed class PostService : IPostService
{
    private readonly IRepositoryManager _repositoryManager;
    
    public PostService(IRepositoryManager repositoryManager)
    {
        _repositoryManager = repositoryManager;
    }
}