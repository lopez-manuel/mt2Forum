using Mt2Forum.Api.Contracts;
using Mt2Forum.Api.Service.Interfaces;

namespace Mt2Forum.Api.Service;

public class ServiceManager : IServiceManager
{
    private readonly Lazy<IPostService> _postService;
    private readonly Lazy<ICommentService> _commentService;

    public ServiceManager(IRepositoryManager repositoryManager)
    {
        _postService = new Lazy<IPostService>(() => new PostService(repositoryManager));
        _commentService = new Lazy<ICommentService>(() => new CommentService(repositoryManager));
    }
    
    public IPostService PostService => _postService.Value;
    public ICommentService CommentService => _commentService.Value;
}