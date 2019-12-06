using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebDriverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://google.com";

            var query = driver.FindElement(By.Name("q"));
            query.SendKeys("trello");
            query.Submit();

            var mylink = driver.FindElement(By.LinkText("Увійти в Trello"));
            mylink.Click();

            var email = driver.FindElement(By.XPath("/html/body/div[1]/section/div/div/div[3]/form/div/div/div[1]/input"));
            email.SendKeys("Bohdan0708");

            var userPassword = driver.FindElement(By.XPath("/html/body/div[1]/section/div/div/div[3]/form/div/div/div[1]/div/input"));
            userPassword.SendKeys("7142128%");

            var loginButton = driver.FindElement(By.XPath("/html/body/div[1]/section/div/div/div[3]/form/div/div/input"));
            loginButton.Click();


            WebDriverWait waitForElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(text(),'171')]")));

            var userBoard = driver.FindElement(By.XPath("//div[contains(text(),'171')]"));
            userBoard.Click();

            var userCard = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div[4]/div/div[2]/div/div/div/div/div[2]/div/div/div[1]/ul/li[1]/a/span[1]"));
            userCard.Click();

            var userCardName = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[3]/div/div/div/div[3]/div[1]/textarea"));
            userCardName.Click();
            userCardName.Clear();
            userCardName.SendKeys("Change name test");

            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            //WebDriverWait waitForElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //waitForElement.Until(ExpectedConditions.ElementIsVisible(By.Id("header")));


            var menubutton = driver.FindElement(By.XPath("//*[@id=\"header\"]/div[2]/button[3]"));
            menubutton.Click();


        }
    }
}
