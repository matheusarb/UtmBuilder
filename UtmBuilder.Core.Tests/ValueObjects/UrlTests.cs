
using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects;

[TestClass]
public class UrlTests
{
    private const string InvalidUrl = "urlInvalida";
    private const string ValidUrl = "https://example.io";

    [TestMethod]
    [TestCategory("URL Tests")]
        public void Should_return_an_exception_when_URL_is_invalid()
        {
            try
            {
                new Url(InvalidUrl);
                Assert.Fail();
            }
            catch (InvalidUrlException)
            {
                Assert.IsTrue(true);
            }
        }
    
    [TestMethod]
    [TestCategory("URL Tests")]
    [ExpectedException(typeof(InvalidUrlException))]
        public void Should_return_an_exception_when_URL_is_invalid2()
        {
            new Url(InvalidUrl);
        }

    [TestMethod]
    [TestCategory("URL Tests")]
        public void Should_not_return_an_exception_when_URL_is_valid()
        {
            try
            {
                new Url(ValidUrl);
                Assert.IsTrue(true);
            }
            catch (InvalidUrlException)
            {
                Assert.Fail();
            }
        }
}