namespace Mt2Forum.Api.Contracts;

public interface IRepositoryManager
{
    IPostRepository PostRepository { get; }
    ICommentRepository CommentRepository { get; }
    Task<int> SaveAsync();
}