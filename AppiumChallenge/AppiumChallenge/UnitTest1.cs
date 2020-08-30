using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;

namespace AppiumChallenge
{
    public class Tests
    {
        private AppiumDriver<AndroidElement> _driver;

        [SetUp]
        public void Setup()
        {
            var appPath = "C:/Users/Usuario/Downloads/MercadoLibre.apk";
            var capabilities = new AppiumOptions();
            
            capabilities.AddAdditionalCapability("app", appPath);
            capabilities.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            capabilities.AddAdditionalCapability(MobileCapabilityType.App, appPath);
            capabilities.AddAdditionalCapability(MobileCapabilityType.DeviceName, "RFXNW19116012168");

            _driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), capabilities);
        }

        [Test]
        public void Test1()
        {
            AndroidElement registerButton =_driver.FindElementById("home_onboarding_email_register_button");
            registerButton.Click();
            Assert.Pass();
        }
    }
}