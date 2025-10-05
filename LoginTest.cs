using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;

namespace CodeSolvers.Interview.Tests;

public class Logintest
{
 IWebDriver driver;

    [SetUp]
 public void SetUp()
{
    driver = new ChromeDriver();
}

 [Test]
public void login()
{
 
    driver.Navigate().GoToUrl("https://www.saucedemo.com/");
    driver.Manage().Window.Maximize();
    driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
    driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
    driver.FindElement(By.Id("login-button")).Click();

    Assert.IsTrue(driver.Url.Contains("inventory"), "Expected to be redirected to the inventory page.");
}    

}

