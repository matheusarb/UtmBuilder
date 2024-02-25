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
    private readonly Url _url = new Url("https://example.io");
    private readonly Campaign _campaign = new Campaign("src", "med", "nme", "id", "trm", "cnt");
    private readonly string fullCampaignUrl = "https://example.io" +
            "?utm_source=src" +
            "&utm_medium=med" +
            "&utm_campaign=nme" +
            "&utm_id=id" +
            "&utm_term=trm" +
            "&utm_content=cnt";

    [TestMethod]
    public void Should_return_URL_from_utm()
    {
        var utm = new Utm(_url, _campaign);
        
        Assert.AreEqual(fullCampaignUrl, utm.ToString());
    }

    [TestMethod]
    public void Should_implicitly_convert_utm_URL_to_string()
    {
        var utm = new Utm(_url, _campaign);
        Assert.AreEqual(fullCampaignUrl, (string)utm);
    }
}
