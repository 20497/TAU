using System.Threading.Tasks;
using Microsoft.Playwright;
using NUnit.Framework;
using PlaywrightExample.PageObjects;

namespace PlaywrightExample
{
    public class KuchniaLidlaPageGoogleChromeTests
    {
        private IPlaywright _playwright;
        private IBrowser _browser;
        
        [SetUp]
        public async Task SetupGoogleChromeBrowser()
        {
            _playwright = await Playwright.CreateAsync();
            _browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Channel = "chrome",
                Headless   = false,
                SlowMo = 2000
            });
        }

        [TearDown]
        public async Task DisposeBrowser() => await _browser.DisposeAsync();

        [Test]
        public async Task FilteringRecipes_IsSuggesting_CorrectRecipes()
        {
            var page = await _browser.NewPageAsync();
            var kuchniaLidlaPage = new KuchniaLidlaPage(page);
            
            await page.GotoAsync("https://kuchnialidla.pl/");

            await kuchniaLidlaPage.ClickAcceptCookies();
            await kuchniaLidlaPage.SearchForRecipe("pierogi z kaczka");
            await kuchniaLidlaPage.ClickDuckDumplingsRecipe();
            await kuchniaLidlaPage.RecipeHeaderIsVisible();
        }
    }
}