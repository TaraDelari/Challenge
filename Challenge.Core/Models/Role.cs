using System;

namespace Challenge.Core.Models
{
    public class Role
    {
        public string Name { get; private set; }
        public string DisplayName { get; private set; }

        public Role(string name, string displayName = null)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));

            Name = name;
            DisplayName = displayName ?? name;
        }
    }
}