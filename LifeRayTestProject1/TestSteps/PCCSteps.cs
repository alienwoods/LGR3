using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace LifeRayTestProject1
{
    [Binding]
    public class PCCSteps
    {
        
        [Given(@"I navigate to (.*)")]
        public void GivenINavigateTo(string _targetAddress)
        {
            Browsers.Goto(_targetAddress);
        }
        
        [Then(@"the correct page appears")]
        public void ThenTheCorrectPageAppears()
        {
            Assert.IsTrue(Pages.home.CheckIfPageTitleExists());
        }

        [AfterScenario]
        public void CloseBrowser()
        {
            Browsers.Close();
        }

        [When(@"I select (.*)")]
        public void WhenISelectParkingType(string parkingType)
        {
            Pages.home.ChooseParkingLot(parkingType);
        }

        [When(@"I set entry datetime (.*)")]
        public void WhenISetEntryDate(DateTime entry_dt)
        {
            Pages.home.ClearTimes();
            Pages.home.SetEntryDateTime(entry_dt);
        }

        [When(@"I set leave datetime (.*)")]
        public void WhenISetLeaveDate(DateTime leave_dt )
        {
            Pages.home.SetLeaveDateTime(leave_dt);
        }

        [When(@"I press Caluclate")]
        public void WhenIPressCaluclate()
        {
            //ScenarioContext.Current.Pending();
            Pages.home.ClickCalculate();
            WebDriverWait wait = new WebDriverWait(Browsers.getDriver, new TimeSpan(0,0,5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[@class='BodyCopy']/b")));
        }

        [Then(@"I got the following price and metrics: (.*) dollar (.*) days (.*) hours (.*) minutes")]
        public void ThenIGotTheFollowingPriceAndMetrics(int money, int days, int hours, int minutes)
        {
            ParkingResults expResults = new ParkingResults(money,days,hours,minutes);
            Assert.AreEqual(expResults.ToString(), Pages.home.returnResults().ToString());
        }

    }
}
