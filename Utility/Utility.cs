using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ClassLibrary2.Utilities
{
    public static class Utility
    {
        private static string ScreenShotPath = @"C:\Users\monij\OneDrive\Desktop\Sugar_Automation\ClassLibrary2\Screenshots\";
        public static void Screenshot(IWebDriver _driver, string screenName)
        {
            if (!Directory.Exists(ScreenShotPath))
                Directory.CreateDirectory(ScreenShotPath);
            ScreenShotPath = ScreenShotPath + screenName + ".Png";
            ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(ScreenShotPath, ScreenshotImageFormat.Png);
        }
    }
}
