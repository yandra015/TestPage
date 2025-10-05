using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;

namespace CodeSolvers.Interview.Tests;

public class Test
{
    IWebDriver driver;

    [SetUp]
       public void SetUp()
{
        driver = new ChromeDriver();
}

    [Test]
    public void Test1()
    {
        driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        driver.Manage().Window.Maximize();
        
        Assert.That(driver.Title,Is.EqualTo("Swag Labs"));
    }
}