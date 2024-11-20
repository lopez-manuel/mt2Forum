using Mt2Forum.Api.Contracts;
using Mt2Forum.Api.Service.Interfaces;

namespace Mt2Forum.Api.Service;

internal sealed class CommentService : ICommentService
{
    private readonly IRepositoryManager _repositoryManager;

    public CommentService(IRepositoryManager repositoryManager)
    {
        _repositoryManager = repositoryManager;
    }
}