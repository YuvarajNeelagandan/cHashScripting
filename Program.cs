// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestEmisoft
{
    class Program
    {
        static void Main(string[] args)
        {
            String HOMEPAGE = "https://www.emsisoft.com/en/anti-malware-home/";
            String ALTERNATIVE_INSTALATION_OPTIONS_XPATH = "//*[@id=\"post-162\"]/section[1]/div[2]/div[1]/div/div[1]/p/a";
            String WEB_INSTALLER_XPATH = "//*[@id=\"post-1597\"]/main/ul/li[1]/a";

            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("download.default_directory", "C:\\Users\\eleve\\Downloads");
            options.AddUserProfilePreference("download.prompt_for_download", false);
            options.AddUserProfilePreference("download.extensions_to_open", "application/xml");
            options.AddUserProfilePreference("safebrowsing.enabled", true);
            options.AddArguments("headless");
            options.AddArguments("safebrowsing-disable-download-protection");
            options.AddArguments("safebrowsing-disable-extension-blacklist");

            System.Console.WriteLine("Started -- ");
            IWebDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl(HOMEPAGE);
            driver.FindElement(By.XPath(ALTERNATIVE_INSTALATION_OPTIONS_XPATH)).Click();
            driver.FindElement(By.XPath(WEB_INSTALLER_XPATH)).Click();
            System.Console.WriteLine("Download Completed!");
        }
    }
}