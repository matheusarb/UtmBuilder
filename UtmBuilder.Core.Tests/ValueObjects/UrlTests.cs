
using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects;

[TestClass]
public class UrlTests
{
    [TestMethod]
    [TestCategory("URL Tests")]
        public void Should_return_an_exception_when_URL_is_invalid()
        {
            var link = ""; 
            var url = new Url(link);
            
            Assert.AreEqual(url, new InvalidUrlException());
        }

    [TestMethod]
    [TestCategory("URL Tests")]
        public void Should_not_return_an_exception_when_URL_is_valid()
        {
            Assert.Fail();
        }
}