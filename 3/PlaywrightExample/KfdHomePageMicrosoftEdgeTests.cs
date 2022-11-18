using System.Threading.Tasks;
using Microsoft.Playwright;
using NUnit.Framework;
using PlaywrightExample.PageObjects;

namespace PlaywrightExample
{
    [TestFixture]
    public class KfdHomePageMicrosoftEdgeTests
    {
        private IPlaywright _playwright;
        private IBrowser _browser;
        
        [SetUp]
        public async Task SetupGoogleChromeBrowser()
        {
            _playwright = await Playwright.CreateAsync();
            _browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Channel = "msedge",
                Headless   = false,
                SlowMo = 2000
            });
        }

        [TearDown]
        public async Task DisposeBrowser() => await _browser.DisposeAsync();
        
        [Test]
        public async Task AddedProduct_IsShown_InShoppingCart()
        {
            var page = await _browser.NewPageAsync();
            var kfdHomePage = new KfdHomePage(page);
            
            await page.GotoAsync("https://sklep.kfd.pl/");
            
            await kfdHomePage.IsShoppingCartEnabled();
            await kfdHomePage.SearchForProduct("whey gold");
            await kfdHomePage.AddPremiumWheyProductToShoppingCart();
            await kfdHomePage.IsPremiumWheyProductVisibleInShoppingCart();
        }
    }
}