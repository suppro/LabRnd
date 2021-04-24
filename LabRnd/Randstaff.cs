using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace LabRnd
{
    class Randstaff : Random
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
            MessageBox.Show(resourceName);
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");
            ChromeDriverService driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            ChromeDriver browser = new ChromeDriver(driverService, chromeOptions);
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            browser.Navigate().GoToUrl(url);
            IWebElement button = browser.FindElement(By.CssSelector("#button"));
            button = browser.FindElement(By.CssSelector("#button"));
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(5));
  
            button.Click();
            IWebElement getValue = wait.Until(e => e.FindElement(By.CssSelector(".cur")));
            getValue = wait.Until(e => e.FindElement(By.CssSelector(".cur")));
            MessageBox.Show(getValue.Text);
            resultRnd.Text = getValue.Text;
        }
    }
}
