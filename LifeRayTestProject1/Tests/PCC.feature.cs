// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace LifeRayTestProject1.Tests
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("PCC", Description="\tTest", SourceFile="Tests\\PCC.feature", SourceLine=0)]
    public partial class PCCFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "PCC.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PCC", "\tTest", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
#line hidden
#line 5
 testRunner.Given("I Open a Chrome Browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
 testRunner.And("I navigate to http://www.shino.de/parkcalc/index.php", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Open and check home page", SourceLine=7)]
        public virtual void OpenAndCheckHomePage()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Open and check home page", null, ((string[])(null)));
#line 8
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 9
 testRunner.Then("the correct page appears", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        public virtual void ValetParking(string pType, string pEntry, string pLeave, string rPrice, string rDays, string rHours, string rMinutes, string comment, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Valet Parking", null, exampleTags);
#line 11
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 12
 testRunner.When(string.Format("I select {0}", pType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.And(string.Format("I set entry datetime {0}", pEntry), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And(string.Format("I set leave datetime {0}", pLeave), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And("I press Caluclate", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.Then(string.Format("I got the following price and metrics: {0} dollar {1} days {2} hours {3} minutes", rPrice, rDays, rHours, rMinutes), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Valet Parking, Variant 0", SourceLine=19)]
        public virtual void ValetParking_Variant0()
        {
#line 11
this.ValetParking("Valet Parking", "12/1/2019 01:00 AM", "12/1/2019 02:00 AM", "12", "0", "1", "0", "", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Valet Parking, Variant 1", SourceLine=19)]
        public virtual void ValetParking_Variant1()
        {
#line 11
this.ValetParking("Valet Parking", "12/1/2019 01:00 AM", "12/1/2019 05:00 AM", "12", "0", "4", "0", "", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Valet Parking, Variant 2", SourceLine=19)]
        public virtual void ValetParking_Variant2()
        {
#line 11
this.ValetParking("Valet Parking", "12/1/2019 01:00 AM", "12/2/2019 02:00 AM", "36", "1", "1", "0", "", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Valet Parking, Variant 3", SourceLine=19)]
        public virtual void ValetParking_Variant3()
        {
#line 11
this.ValetParking("Short-Term Parking", "12/1/2019 01:00 AM", "12/1/2019 02:00 AM", "2", "0", "1", "0", "", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Valet Parking, Variant 4", SourceLine=19)]
        public virtual void ValetParking_Variant4()
        {
#line 11
this.ValetParking("Short-Term Parking", "12/1/2019 01:00 AM", "12/2/2019 02:00 AM", "26", "1", "1", "0", "", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Valet Parking, Variant 5", SourceLine=19)]
        public virtual void ValetParking_Variant5()
        {
#line 11
this.ValetParking("Valet Parking", "12/1/2019 01:00 AM", "12/2/2019 01:00 AM", "18", "1", "0", "0", "", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Valet Parking, Variant 6", SourceLine=19)]
        public virtual void ValetParking_Variant6()
        {
#line 11
this.ValetParking("Short-Term Parking", "12/1/2019 01:00 AM", "12/2/2019 01:00 AM", "24", "1", "0", "0", "", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Valet Parking, Variant 7", SourceLine=19)]
        public virtual void ValetParking_Variant7()
        {
#line 11
this.ValetParking("Short-Term Parking", "12/1/2019 01:00 AM", "12/1/2019 11:59 PM", "24", "0", "22", "59", "47 dollar, but with daily limit it should be 24", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
