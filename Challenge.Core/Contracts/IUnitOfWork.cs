namespace Challenge.Core.Contracts
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IRoleRepository RoleRepository { get; }
        ILinkRepository LinkRepository { get; }
        void SaveChanges();
    }
}