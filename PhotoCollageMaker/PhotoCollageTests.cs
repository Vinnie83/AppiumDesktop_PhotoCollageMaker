using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Windows;
using System.Drawing;

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

       

        [Test]
        public void Test_MakeCollage()
        {
            var noThanksButton = driver.FindElementByName("No Thanks !");
            noThanksButton.Click();

            Thread.Sleep(3000);

            var collageButton = driver.FindElementByAccessibilityId("BtnCollage");
            collageButton.Click();

            Thread.Sleep(3000);

            var allLocations = driver.FindElementByName("All locations");
            allLocations.Click();

            Thread.Sleep(1000);

            var inputField = driver.FindElementByName("Address");
            inputField.Clear();
            Thread.Sleep(2000);
            inputField.SendKeys("D:\\Documents\\Pictures\\Collage Editor");
            inputField.SendKeys(Keys.Enter);

            var itemsView = driver.FindElementByName("Items View");
            itemsView.SendKeys(Keys.Control + "a");


            var openButton = driver.FindElementByClassName("Button");
            openButton.Click();

            Thread.Sleep(6000);

            var buttonSticker = driver.FindElementByAccessibilityId("BtnSticker");
            buttonSticker.Click();

            var stickerConfirm = driver.FindElementByAccessibilityId("BtnStickerOk");
            stickerConfirm.Click();

            var saveButton = driver.FindElementByName("Save");
            saveButton.Click();

            var yesButton = driver.FindElementByName("Yes");
            yesButton.Click();

            string directoryPath = "D:\\Documents\\Pictures\\Photo Collage Maker & Montage Creator";

            string filePattern = "mycreation*";

            bool fileExists = Directory.GetFiles(directoryPath, filePattern).Any();

            Assert.That(fileExists,Is.True );

        }
    }
}