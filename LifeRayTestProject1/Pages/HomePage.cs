using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace LifeRayTestProject1
{
    public class HomePage
    {
        /*private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }*/

        [FindsBy(How = How.ClassName, Using = "PageTitle")]
        private IWebElement PageTitle;

        [FindsBy(How = How.Id, Using = "ParkingLot")]
        private IWebElement ParkingLotSelector;

        [FindsBy(How = How.Id, Using = "StartingDate")]
        private IWebElement StartingDate;

        [FindsBy(How = How.Id, Using = "StartingTime")]
        private IWebElement StartingTime;

        [FindsBy(How = How.XPath, Using = "//input[@name='StartingTimeAMPM'][@value='AM']")]
        private IWebElement StartingTimeAM;

        [FindsBy(How = How.XPath, Using = "//input[@name='StartingTimeAMPM'][@value='PM']")]
        private IWebElement StartingTimePM;

        [FindsBy(How = How.Id, Using = "LeavingDate")]
        private IWebElement LeavingDate;

        [FindsBy(How = How.Id, Using = "LeavingTime")]
        private IWebElement LeavingTime;

        [FindsBy(How = How.XPath, Using = "//input[@name='LeavingTimeAMPM'][@value='AM']")]
        private IWebElement LeavingTimeAM;

        [FindsBy(How = How.XPath, Using = "//input[@name='LeavingTimeAMPM'][@value='PM']")]
        private IWebElement LeavingTimePM;

        [FindsBy(How = How.Name, Using = "Submit")]
        private IWebElement CalculateButton;

        /*[FindsBy(How = How.XPath, Using = "//span[@class='SubHead']/b/text()")]
        private IWebElement ParkingPrice;*/

        /*[FindsBy(How = How.XPath, Using = "//span[@class='BodyCopy']/b/text()")]
        public IWebElement ParkingTime;*/

        public bool CheckIfPageTitleExists()
        {
            if (PageTitle.Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ChooseParkingLot(string parkingLotType)
        {
            SelectElement pt = new SelectElement(ParkingLotSelector);
            pt.SelectByText(parkingLotType);
        }

        public void ClearTimes()
        {
            StartingDate.Clear();
            StartingTime.Clear();
            LeavingDate.Clear();
            LeavingTime.Clear();
        }

        public void SetEntryDateTime(DateTime dt)
        {
            
            StartingDate.SendKeys(dt.ToString("MM/dd/yyyy"));
            StartingTime.SendKeys(dt.ToString("HH:mm"));

            //AM/PM
            switch (dt.ToString("tt"))
            {
                case "AM":
                    StartingTimeAM.Click();
                    break;
                case "PM":
                    StartingTimePM.Click();
                    break;
                default:
                    break;
            }
        }

        public void SetLeaveDateTime(DateTime dt)
        {
            // Clear



            LeavingDate.SendKeys(dt.ToString("MM/dd/yyyy"));
            LeavingTime.SendKeys(dt.ToString("HH:mm"));

            //AM/PM
            switch (dt.ToString("tt"))
            {
                case "AM":
                    LeavingTimeAM.Click();
                    break;
                case "PM":
                    LeavingTimePM.Click();
                    break;
                default:
                    break;
            }
        }

        public void ClickCalculate()
        {
            CalculateButton.Click();
        }

        /// <summary>
        /// Price, Days, Hours, Minutes
        /// </summary>
        /*public struct ParkingResults
        {
            public int price, days, hours, minutes;
            public ParkingResults(int p1,int p2, int p3, int p4)
            {
                price = p1;
                days = p2;
                hours = p3;
                minutes = p4;
            }
        }*/

        public ParkingResults returnResults()
        {
            ParkingResults pr = new ParkingResults();

            // Fill with results
            IWebElement ParkingPrice = Browsers.getDriver.FindElement(By.XPath("//span[@class='SubHead']/b"));
            pr.price = Int32.Parse(ParkingPrice.Text.Remove(0,2).Replace(".00",""));

            // Parking time slicing [(](.*) Days, (.*) Hours, (.*) Minutes
            //Regex rx = new Regex(@"[(](.*) Days, (.*) Hours, (.*) Minutes");
            IWebElement ParkingTime = Browsers.getDriver.FindElement(By.XPath("//span[@class='BodyCopy']/b"));
            MatchCollection mc = Regex.Matches(ParkingTime.Text, @"\d+");

            pr.days = Int32.Parse(mc[0].ToString());
            pr.hours = Int32.Parse(mc[1].ToString());
            pr.minutes = Int32.Parse(mc[2].ToString());

            return pr;
        }
    }
}
