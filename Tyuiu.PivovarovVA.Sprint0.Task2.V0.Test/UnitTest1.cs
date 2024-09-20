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

            // ��������, ��� ��������� �������� "Playwright"
            await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));

            // �������� �������� ��� ������ "Get Started"
            var getStarted = Page.Locator("text=Get Started");

            // ��������, ��� ������� "href" ����� "/docs/intro"
            await Expect(getStarted).ToHaveAttributeAsync("href", "/docs/intro");

            // ���� �� ������ "Get Started"
            await getStarted.ClickAsync();

            // ��������, ��� URL �������� "intro"
            await Expect(Page).ToHaveURLAsync(new Regex(".*intro"));
        }
    }
}

