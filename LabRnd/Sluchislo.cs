using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace LabRnd
{
    class Sluchislo : Random
    {
        public override void getRndValue(ComboBox cbResource, Label resultRnd)
        {
            string resourceName = cbResource.Text;
            string url;

            using (RNDDBEntities db = new RNDDBEntities())
            {
                Resource model = (from u in db.Resource
                                  where u.name == resourceName
                                  select u).FirstOrDefault();
                url = model.url;

            }

            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");
            ChromeDriverService driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            ChromeDriver browser = new ChromeDriver(driverService, chromeOptions);
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(5));
            browser.Navigate().GoToUrl(url);
            IWebElement buttonRnd = wait.Until(e => e.FindElement(By.CssSelector("#random-button")));
            buttonRnd.Click();
            IWebElement resultRandom = wait.Until(e => e.FindElement(By.CssSelector(".number2")));

            string[] searchValue = resultRandom.Text.Split(' ', '\t', '\n');
            for (int i = 0; i < searchValue.Length; ++i)
                if (i == searchValue.Length - 1)
                    resultRnd.Text = searchValue[i];
            browser.Close();
        }
    }
}