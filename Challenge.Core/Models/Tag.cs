namespace Challenge.Core.Models
{
    public class Tag
    {
        public string Content { get; private set; }
        public string Url { get; private set; }
        public string LinkUserId { get; private set; }
        public Link Link { get; internal set; }

        private Tag() { }

        internal Tag(string content)
        {
            Content = content;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Tag;

            if (ReferenceEquals(other, null))
                return false;

            if (ReferenceEquals(this, other))
                return true;

            if (other.GetType() != typeof(Tag))
                return false;

            if (Url == null || other.Url == null || LinkUserId == null || other.LinkUserId == null)
                return false;

            return Url == other.Url && LinkUserId == other.LinkUserId;
        }

        public static bool operator ==(Tag a, Tag b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Tag a, Tag b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return $"{typeof(Tag)}{Url}{LinkUserId}".GetHashCode();
        }
    }
}
