using System;
using TechTalk.SpecFlow;

namespace LifeRayTestProject1.TestSteps
{
    [Binding]
    class CommonSteps
    {
        [Given(@"I Open a Chrome Browser")]
        public void GivenIOpenAChromeBrowser()
        {
            Browsers.Init();
        }
    }
}
