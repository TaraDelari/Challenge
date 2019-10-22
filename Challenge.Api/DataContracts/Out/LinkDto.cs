using System.Collections.Generic;

namespace Challenge.Api.DataContracts.Out
{
    public class LinkDto
    {
        public string Link { get; set; }
        public List<string> Tags { get; set; }

        public LinkDto()
        {
            Tags = new List<string>();
        }
    }
}
