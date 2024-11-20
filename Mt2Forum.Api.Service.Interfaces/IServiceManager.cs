namespace Mt2Forum.Api.Service.Interfaces;

public interface IServiceManager
{
    public IPostService PostService { get; }
    public ICommentService CommentService { get; }
}