using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{
    
    [Test]
    public async Task Test1()
    {
        await Page.GotoAsync("https://playwright.dev");

        // Expect a title "to contain" a substring.
        await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));

        // create a locator
        var getStarted = Page.GetByRole(AriaRole.Link, new() { Name = "Get started" });

        // Expect an attribute "to be strictly equal" to the value.
        await Expect(getStarted).ToHaveAttributeAsync("href", "/docs/intro");

        // Click the get started link.
        await getStarted.ClickAsync();

        // Expects the URL to contain intro.
        await Expect(Page).ToHaveURLAsync(new Regex(".*intro"));
        await Page.Locator("//*[@class='navbar__link']").ClickAsync();
        Thread.Sleep(1000);
        await Page.Locator("//*[@class='dropdown__menu']//li").Nth(1).HighlightAsync();
        Thread.Sleep(2000);
        await Page.Locator("//*[@class='dropdown__menu']//li").Nth(1).ClickAsync();
        Thread.Sleep(2000);
      
    }
      
    [Test]
     public async Task Test2()
    {
        await Page.GotoAsync("https://playwright.dev");

        // Expect a title "to contain" a substring.
        await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));

        // create a locator
        var getStarted = Page.GetByRole(AriaRole.Link, new() { Name = "Get started" });

        // Expect an attribute "to be strictly equal" to the value.
        await Expect(getStarted).ToHaveAttributeAsync("href", "/docs/intro");

        // Click the get started link.
        await getStarted.ClickAsync();

        // Expects the URL to contain intro.
        await Expect(Page).ToHaveURLAsync(new Regex(".*intro"));
        await Page.Locator("//*[@class='navbar__link']").ClickAsync();
         await Page.Locator("//*[@class='dropdown__menu']//li").Nth(2).HighlightAsync();
        Thread.Sleep(2000);
        await Page.Locator("//*[@class='dropdown__menu']//li").Nth(2).ClickAsync();
        Thread.Sleep(2000);
      
    }
   
   
    
}