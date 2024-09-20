using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NUnit.Framework;
using Microsoft.Playwright;

namespace Tyuiu.PivovarovVA.Sprint0.Task2.V0.Test
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class Tests : PageTest
    {
        [Test]
        public async Task HomepageHasPlaywrightInTitleAndGetStartedLinkLinkingtoTheIntroPage()
        {
            await Page.GotoAsync("https://playwright.dev");

            // ќжидание, что заголовок содержит "Playwright"
            await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));

            // —оздание локатора дл€ ссылки "Get Started"
            var getStarted = Page.Locator("text=Get Started");

            // ќжидание, что атрибут "href" равен "/docs/intro"
            await Expect(getStarted).ToHaveAttributeAsync("href", "/docs/intro");

            //  лик по ссылке "Get Started"
            await getStarted.ClickAsync();

            // ќжидание, что URL содержит "intro"
            await Expect(Page).ToHaveURLAsync(new Regex(".*intro"));
        }
    }
}

