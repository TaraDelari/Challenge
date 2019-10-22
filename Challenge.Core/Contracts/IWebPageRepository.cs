using Challenge.Core.Models;

namespace Challenge.Core.Contracts
{
    public interface IWebPageRepository
    {
        WebPage Get(string url);
        void Insert(WebPage webPage);
    }
}
