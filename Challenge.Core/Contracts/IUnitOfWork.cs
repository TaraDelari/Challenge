namespace Challenge.Core.Contracts
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        void SaveChanges();
    }
}