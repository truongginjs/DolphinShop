using System;
using WebApi.Helpers.Extensions;
using Xunit;

namespace WebApi.Tests
{
    public class TestStringExtension
    {
        [Fact]
        public void UppercaseFirstLetterTest()
        {
            string name = "tien";
            string result = "Tien";
            string name2 = "    ";
            string name3 = null;
            Assert.Equal(name.ToUppercaseFirstLettter(), result);
            Assert.Equal(name2.ToUppercaseFirstLettter(), name2);
            Assert.NotEqual(name3.ToUppercaseFirstLettter(), result);
        }

        [Fact]
        public void UppercaseFirstLetterTest2()
        {
            string name = "truong";

            Assert.NotEmpty(name.ToUppercaseFirstLettter());
        }
    }
}
