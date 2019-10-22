using Challenge.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Challenge.Core.UnitTests.Models
{
    public class Link_AddTags
    {
        //TODO: Other test cases
        [Fact]
        public void NewTagsContainDuplicates_DuplicatesIgnored()
        {
            //arrange
            WebPage webPage = new WebPage("http://example.com");
            Link link = new Link(webPage, User.CreateNew("testuser@example.com", "testUser", "abc"));
            Tag[] newTags = new Tag[] { new Tag("tag1"), new Tag("tag2"), new Tag("tag1"), new Tag("tag3"), new Tag("tag4"), new Tag("tag4"), new Tag("tag1") };
            Tag[] expectedTags = new Tag[] { new Tag("tag1"), new Tag("tag2"), new Tag("tag3"), new Tag("tag4") };

            //act
            link.AddTags(newTags);

            //assert
            Assert.Equal(expectedTags.Length, link.Tags.Count);
            foreach (Tag tag in link.Tags)
                Assert.True(expectedTags.Any(x => x.Content == tag.Content));
        }


        [Fact]
        public void TagsAlreadyExist_ExistingTagsIgnored()
        {
            //arrange
            WebPage webPage = new WebPage("http://example.com");
            Link link = new Link(webPage, User.CreateNew("testuser@example.com", "testUser", "abc"));
            Tag[] existingTags = new Tag[] { new Tag("tag1"), new Tag("tag2"), new Tag("tag3") };
            Tag[] newTags = new Tag[] { new Tag("tag4"), new Tag("tag2"), new Tag("tag5"), new Tag("tag6") };
            Tag[] expectedTags = new Tag[] { new Tag("tag1"), new Tag("tag2"), new Tag("tag3"), new Tag("tag4"), new Tag("tag5"), new Tag("tag6") };
            link.AddTags(existingTags);

            //act
            link.AddTags(newTags);

            //assert
            Assert.Equal(expectedTags.Length, link.Tags.Count);
            foreach (Tag tag in link.Tags)
                Assert.True(expectedTags.Any(x => x.Content == tag.Content));
        }
    }
}
