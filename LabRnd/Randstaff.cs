using System;
using System.Linq;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace LabRnd
{
    class Randstaff : Random
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
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
            browser.Navigate().GoToUrl(url);
            IWebElement button = wait.Until(e => e.FindElement(By.CssSelector("#button")));
            button = browser.FindElement(By.CssSelector("#button"));
            IWebElement imputMin = wait.Until(e => e.FindElement(By.CssSelector("#number-start")));
            imputMin.Click();
            imputMin.Clear();
            imputMin.SendKeys(valMin.ToString());
            IWebElement imputMax = wait.Until(e => e.FindElement(By.CssSelector("#number-end")));
            imputMax.Click();
            imputMax.Clear();
            imputMax.SendKeys(valMax.ToString());
            button.Click();
            IWebElement getValue = wait.Until(e => e.FindElement(By.CssSelector(".new")));
            resultRnd.Text = getValue.GetAttribute("innerText");
            browser.Close();
        }
    }
}
