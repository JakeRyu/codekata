using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Extension.Tests
{
    [TestFixture]
    class StringExtensionsTests
    {
        private string _str;

        [SetUp]
        public void SetUp()
        {
            _str = "This long blog post summary needs to be shorent to be shown in the list.";
        }

        [Test]
        [TestCase(20, "This long blog post summary needs to be shorent to be shown in the list.")]
        [TestCase(3, "This long blog")]
        [TestCase(0, "")]
        public void Shorten_DependingOnNoOfWords_ReturnTheStringAccordingly(int noOfWords, string expected)
        {
            // assign

            // act
            var result = _str.Shorten(noOfWords);

            // assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Shorten_EmptyString_ReturnArgumentNullException()
        {
            string sud = string.Empty;

            Assert.That(() => sud.Shorten(3), Throws.ArgumentNullException);
        }
    }
}
