using Challenge.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge.Core.Utils
{
    static class TagsDuplicateRemover
    {
        private static IEqualityComparer<Tag> comparer = new DistinctTagContentComparer();

        internal static IEnumerable<Tag> RemoveDuplicates(this IEnumerable<Tag> tags)
        {
            return tags.Distinct(comparer);
        }
    }

    class DistinctTagContentComparer : IEqualityComparer<Tag>
    {
        public bool Equals(Tag x, Tag y)
        {
            if (x.Content == null || y.Content == null)
                return false;
            return x.Content == y.Content;
        }

        public int GetHashCode(Tag obj)
        {
            return obj.GetHashCode();
        }
    }
}
