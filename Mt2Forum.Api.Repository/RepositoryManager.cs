using Mt2Forum.Api.Contracts;
using Repository.EntitiesImplementation;

namespace Repository;

public class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryContext _repositoryContext;
    private readonly Lazy<IPostRepository> _postRepository;
    private readonly Lazy<ICommentRepository> _commentRepository;


    public RepositoryManager( RepositoryContext repositoryContext )
    {
        _repositoryContext = repositoryContext;
        _postRepository = new Lazy<IPostRepository>( () => new PostRepositoryRepository( repositoryContext ) );
        _commentRepository = new Lazy<ICommentRepository>( () => new CommentRepositoryRepository( repositoryContext ) );
    }

    public IPostRepository PostRepository => _postRepository.Value;
    public ICommentRepository CommentRepository => _commentRepository.Value;

    public async Task<int> SaveAsync()
    {
        return await _repositoryContext.SaveChangesAsync();
    }
    
}