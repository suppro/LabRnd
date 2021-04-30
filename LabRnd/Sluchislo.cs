using System;
using System.Linq;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace LabRnd
{
    class Sluchislo : Random
    {
        public override void getRndValue(ComboBox cbResource, Label resultRnd, int valMin, int valMax)
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
            //chromeOptions.AddArguments("headless");
            ChromeDriverService driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            ChromeDriver browser = new ChromeDriver(driverService, chromeOptions);
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(5));
            browser.Navigate().GoToUrl(url);
            IWebElement buttonRnd = wait.Until(e => e.FindElement(By.CssSelector(".js-generate")));
            IWebElement imputMin = wait.Until(e => e.FindElement(By.CssSelector("#min")));
            imputMin.Click();
            imputMin.Clear();
            imputMin.SendKeys(valMin.ToString());
            IWebElement imputMax = wait.Until(e => e.FindElement(By.CssSelector("#max")));
            imputMax.Click();
            imputMax.Clear();
            imputMax.SendKeys(valMax.ToString());
            buttonRnd.Click();
            IWebElement resultRandom = wait.Until(e => e.FindElement(By.CssSelector(".big")));
            resultRnd.Text = resultRandom.GetAttribute("innerText");
            //browser.Close();
        }
    }
}