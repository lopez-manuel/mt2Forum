using Entities.Models;
using Mt2Forum.Api.Contracts;

namespace Repository.EntitiesImplementation;

public class CommentRepositoryRepository : RepositoryBase<Comment> , ICommentRepository
{
    public CommentRepositoryRepository(RepositoryContext repositoryContext) : base(repositoryContext) {}
    
}