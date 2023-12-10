using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Windows;

namespace PhotoCollageMaker
{
    public class PhotoCollageTests
    {

        private const string appiumServer = "http://127.0.0.1:4723/wd/hub";
        private const string appIdentifier = "34317GoodJobApps.PhotoCollageMaker-PhotoGridPhotoE_rxkvjcfxv2hyw!App";
        private WindowsDriver<WindowsElement> driver;
        private AppiumOptions options;



        [SetUp]
        public void Setup()
        {
            this.options = new AppiumOptions();
            options.AddAdditionalCapability("app", appIdentifier);
            this.driver = new WindowsDriver<WindowsElement>(new Uri(appiumServer), options);


        }

        [TearDown]  

        public void Teardown() 
        
        { 
            
            driver.Quit();
        
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}