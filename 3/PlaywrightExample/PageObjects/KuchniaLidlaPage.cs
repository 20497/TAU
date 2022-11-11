using System.Threading.Tasks;
using Microsoft.Playwright;

namespace PlaywrightExample.PageObjects
{
    public class KuchniaLidlaPage
    {
        private IPage _page;
        private ILocator _searchInput => _page.Locator("#search_form_top > input");
        private ILocator _searchButton => _page.Locator("#search_form_top > button");
        private ILocator _recipeHeader => _page.Locator("#details > div.lead > h1");

        private ILocator _acceptCookiesButton => _page.Locator(
            "#CybotCookiebotDialog > div > div.cookie-alert-extended-controls > button.cookie-alert-extended-button");

        private ILocator _recipeDuckDumplings =>
            _page.Locator("#products > div:nth-child(1) > div.recipe_box.product_1 > a.description");
        
        public KuchniaLidlaPage(IPage page) => _page = page;

        public async Task SearchForRecipe(string productName)
        {
            await _searchInput.FillAsync(productName);
            await _searchButton.ClickAsync();
        }

        public async Task ClickAcceptCookies() => await _acceptCookiesButton.ClickAsync();
        public async Task ClickDuckDumplingsRecipe() => await _recipeDuckDumplings.ClickAsync();
        public async Task RecipeHeaderIsVisible() => await Assertions.Expect(_recipeHeader).ToBeVisibleAsync();
    }
}