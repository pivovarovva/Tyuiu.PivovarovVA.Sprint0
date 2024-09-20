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

            // Ожидание, что заголовок содержит "Playwright"
            await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));

            // Создание локатора для ссылки "Get Started"
            var getStarted = Page.Locator("text=Get Started");

            // Ожидание, что атрибут "href" равен "/docs/intro"
            await Expect(getStarted).ToHaveAttributeAsync("href", "/docs/intro");

            // Клик по ссылке "Get Started"
            await getStarted.ClickAsync();

            // Ожидание, что URL содержит "intro"
            await Expect(Page).ToHaveURLAsync(new Regex(".*intro"));
        }
    }
}