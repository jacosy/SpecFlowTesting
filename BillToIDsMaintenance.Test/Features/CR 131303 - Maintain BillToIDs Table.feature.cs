﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BillToIDsMaintenance.Test.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CR 131303 - Maintain BillToIDs Table")]
    [NUnit.Framework.CategoryAttribute("CR")]
    [NUnit.Framework.CategoryAttribute("131303")]
    [NUnit.Framework.CategoryAttribute("BillToID")]
    [NUnit.Framework.CategoryAttribute("IBM")]
    [NUnit.Framework.CategoryAttribute("MSC")]
    [NUnit.Framework.CategoryAttribute("Outbound")]
    [NUnit.Framework.CategoryAttribute("Routing")]
    public partial class CR131303_MaintainBillToIDsTableFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CR 131303 - Maintain BillToIDs Table.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CR 131303 - Maintain BillToIDs Table", @"	IBM MSC Outbound Routing - create tool in Strategic EDI tool so that we can modify the table for CR 131302 at any time by adding and removing bill to IDs
	In order to maintain BillToIDs table in UnitedStationers DB
	As an operator
	I want to have a functionality to add or delete BillToID in BillToIDs table", ProgrammingLanguage.CSharp, new string[] {
                        "CR",
                        "131303",
                        "BillToID",
                        "IBM",
                        "MSC",
                        "Outbound",
                        "Routing"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get BillToIDs")]
        public virtual void GetBillToIDs()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get BillToIDs", null, ((string[])(null)));
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 10
 testRunner.When("User does not provide any Keyword to search BillToID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("It should return all the BillToIDs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search BillToIDs")]
        [NUnit.Framework.TestCaseAttribute("ABC", "3", null)]
        [NUnit.Framework.TestCaseAttribute("987", "1", null)]
        [NUnit.Framework.TestCaseAttribute("****", "0", null)]
        public virtual void SearchBillToIDs(string keyword, string expectedRecords, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search BillToIDs", null, exampleTags);
#line 13
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 14
 testRunner.Given("There are the following records in BillToIDs table: ABC123, ABC456, ABC987 & Test" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
 testRunner.When(string.Format("User use {0} to search BillToID", keyword), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then(string.Format("It should return the {0} records containing the keyword", expectedRecords), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Creat a New BillToID")]
        [NUnit.Framework.TestCaseAttribute("987654", null)]
        [NUnit.Framework.TestCaseAttribute("NewID", null)]
        public virtual void CreatANewBillToID(string billToID, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Creat a New BillToID", null, exampleTags);
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 25
 testRunner.When(string.Format("User tries to create a {0}", billToID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
  testRunner.And(string.Format("There is no matched {0} in DB", billToID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.Then(string.Format("The {0} should be created and stored in BillToIDs table", billToID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Try to Create an existing BillToID")]
        [NUnit.Framework.TestCaseAttribute("123456", null)]
        [NUnit.Framework.TestCaseAttribute("ABCEDF", null)]
        public virtual void TryToCreateAnExistingBillToID(string billToID, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Try to Create an existing BillToID", null, exampleTags);
#line 34
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 35
 testRunner.When(string.Format("User tries to create a {0}", billToID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
  testRunner.And(string.Format("There is a matched {0} in DB", billToID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.Then(string.Format("The {0} should not be created and stored in BillToIDs table", billToID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Delete an existing BillToID")]
        [NUnit.Framework.TestCaseAttribute("123456", null)]
        [NUnit.Framework.TestCaseAttribute("ABCEDF", null)]
        public virtual void DeleteAnExistingBillToID(string billToID, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete an existing BillToID", null, exampleTags);
#line 44
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 45
 testRunner.Given(string.Format("There is an existing {0} in BillToID table", billToID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 46
 testRunner.When(string.Format("User tries to delete {0}", billToID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
 testRunner.Then(string.Format("{0} should be deleted from BillToID table", billToID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
