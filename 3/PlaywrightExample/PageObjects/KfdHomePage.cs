using Microsoft.Playwright;

using System.Threading.Tasks;

namespace PlaywrightExample.PageObjects
{
    public class KfdHomePage
    {
        private IPage _page;
        private ILocator _shoppingCart => _page.Locator("id=_desktop_cart");
        private ILocator _searchInput => _page.Locator("id=topsearchelastic_input");
        private ILocator _searchButton => _page.Locator("#topsearchelastic_widget > form > button");

        private ILocator _premiumWheyProduct =>
            _page.Locator("#js-product-list > div.products.row > div:nth-child(1) > article > div");
        
        private ILocator _premiumWheyProductInShoppingCart =>
            _page.Locator("#main > div > div.cart-grid-body.col-xs-12.col-lg-8 > div > div.cart-overview.js-cart > ul > li > div > div.product-line-grid-left.col-md-3.col-xs-4 > span > img");


        private ILocator _addProductToShoppingCartButton => _page.Locator(
            "#add-to-cart-or-refresh > div.product-add-to-cart.js-product-add-to-cart > div > div.add > button");

        private ILocator _goToShoppingCartFromProductPopup =>
            _page.Locator("#blockcart-modal > div > div > div.modal-body > div > div.col-md-7 > div > div > a");

        public KfdHomePage(IPage page) => _page = page;

        public async Task SearchForProduct(string productName)
        {
            await _searchInput.FillAsync(productName);
            await _searchButton.ClickAsync();
        }

        public async Task AddPremiumWheyProductToShoppingCart()
        {
            await _premiumWheyProduct.ClickAsync();
            await _addProductToShoppingCartButton.ClickAsync();
            await _goToShoppingCartFromProductPopup.ClickAsync();
        }

        public async Task IsPremiumWheyProductVisibleInShoppingCart() =>
            await Assertions.Expect(_premiumWheyProductInShoppingCart).ToBeVisibleAsync();
        
        public async Task IsShoppingCartEnabled() => await Assertions.Expect(_shoppingCart).ToBeEnabledAsync();
    }
}