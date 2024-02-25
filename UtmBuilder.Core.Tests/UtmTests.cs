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
    private Url url = new Url("https://example.io");
    private Campaign campaign = new Campaign("src", "med", "nme", "id", "trm", "cnt");

    [TestMethod]
    public void Should_return_URL_from_utm()
    {
        var utm = new Utm(url, campaign);
        var result = "https://example.io" +
            "?utm_source=src" +
            "&utm_medium=med" +
            "&utm_campaign=nme" +
            "&utm_id=id" +
            "&utm_term=trm" +
            "&utm_content=cnt";

        Assert.AreEqual(result, utm.ToString());
    }
}
