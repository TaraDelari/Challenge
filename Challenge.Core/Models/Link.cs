using Challenge.Core.Utils;
using System.Collections.Generic;
using System.Linq;

namespace Challenge.Core.Models
{
    public class Link
    {
        public string UserId { get; private set; }
        public User User { get; internal set; }
        public string WebPageUrl { get; internal set; }
        public WebPage WebPage { get; private set; }
        public ICollection<Tag> Tags { get; private set; }

        private Link() { }

        public Link(WebPage webPage, User user)
        {
            WebPage = webPage;
            User = user;
            Tags = new List<Tag>();
        }

        public void AddTags(IEnumerable<Tag> tags)
        {
            IEnumerable<Tag> distinctNewTags = tags.RemoveDuplicates();
            IEnumerable<Tag> newTags = distinctNewTags.Where(x => !Tags.Any(y => y.Content == x.Content));

            foreach (Tag tag in newTags)
                Tags.Add(tag);
        }

        public override bool Equals(object obj)
        {
            var other = obj as Link;

            if (ReferenceEquals(other, null))
                return false;

            if (ReferenceEquals(this, other))
                return true;

            if (other.GetType() != typeof(Link))
                return false;

            if (WebPageUrl == null || other.WebPageUrl == null || UserId == null || other.UserId == null)
                return false;

            return WebPageUrl == other.WebPageUrl && UserId == other.UserId;
        }

        public static bool operator ==(Link a, Link b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Link a, Link b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return $"{typeof(Link)}{WebPageUrl}{UserId}".GetHashCode();
        }
    }
}