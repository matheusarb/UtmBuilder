
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
            try
            {
                var url = new Url("urlInvalida");
                Assert.Fail();
            }
            catch (InvalidUrlException e)
            {                
                Assert.IsTrue(true);
            }

        }
    
    [TestMethod]
    [TestCategory("URL Tests")]
    [ExpectedException(typeof(InvalidUrlException))]
        public void Should_return_an_exception_when_URL_is_invalid2()
        {
            new Url("invalidUrl");
        }

    [TestMethod]
    [TestCategory("URL Tests")]
        public void Should_not_return_an_exception_when_URL_is_valid()
        {
            try
            {
                var url = new Url("https://matheus.io");
                Assert.IsTrue(true);
            }
            catch (InvalidUrlException e)
            {
                Assert.Fail();
            }
        }
}