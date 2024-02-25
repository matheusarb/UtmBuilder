using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core.Tests;

[TestClass]
public class UtmTests
{
    private Url link = new Url("https://example.io");
    private Campaign campaign = new Campaign("source", "medium", "name");

    [TestMethod]
    public void Should_return_URL_from_utm()
    {
        var utm = new Utm(link, campaign);
        utm.ToString();
        Assert.IsTrue(true);
    }
}
