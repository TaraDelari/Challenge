namespace Challenge.Core.Contracts
{
    public interface IHasher
    {
        string Hash(string input);
        bool Verify(string submittedPassword, string hashedPassword);
    }
}