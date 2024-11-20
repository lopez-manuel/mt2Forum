using Mt2Forum.Api.Contracts;

namespace Repository.EntitiesImplementation;

public class PostRepositoryRepository : RepositoryBase<PostRepositoryRepository>, IPostRepository
{
    public PostRepositoryRepository(RepositoryContext repositoryContext) : base(repositoryContext) {}
    
}