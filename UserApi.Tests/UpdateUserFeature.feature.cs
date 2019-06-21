// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UserApi.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("UpdateUserFeature", Description="\tIn order update a user by Id\r\n\tAs a API consumer\r\n\tI want to be to update a user" +
        "\'s information through the API", SourceFile="UpdateUserFeature.feature", SourceLine=0)]
    public partial class UpdateUserFeatureFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UpdateUserFeature.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "UpdateUserFeature", "\tIn order update a user by Id\r\n\tAs a API consumer\r\n\tI want to be to update a user" +
                    "\'s information through the API", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        public virtual void ScenarioTearDown()
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
        
        [TechTalk.SpecRun.ScenarioAttribute("Updating a user with valid data", SourceLine=5)]
        public virtual void UpdatingAUserWithValidData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Updating a user with valid data", null, ((string[])(null)));
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 testRunner.Given("that a user exists in the system", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Surname",
                        "Email"});
            table1.AddRow(new string[] {
                        "TestName",
                        "TestSurname",
                        "TestEmail"});
#line 8
 testRunner.When("I request to update the user by Id with details", ((string)(null)), table1, "When ");
#line 11
 testRunner.Then("the user should be updated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.And("the response status code is \'200 OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Updating a non-existing user", SourceLine=13)]
        public virtual void UpdatingANon_ExistingUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Updating a non-existing user", null, ((string[])(null)));
#line 14
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 15
 testRunner.Given("that a user does not exist in the system", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
 testRunner.When("I request to update the user by Id with details Name: \'TestName\' Surname: \'TestSu" +
                    "rname\' and Email: \'TestEmail\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.Then("the response status code is \'404 Not Found\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void UpdatingAUserWithInvalidData(string name, string surname, string email, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Updating a user with invalid data", null, exampleTags);
#line 19
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 20
 testRunner.Given("that a user exists in the system", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
 testRunner.When(string.Format("I request to update the user by Id with details Name: \'{0}\' Surname: \'{1}\' and Em" +
                        "ail: \'{2}\'", name, surname, email), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("the response status code is \'400 Bad Request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Updating a user with invalid data, Variant 0", SourceLine=24)]
        public virtual void UpdatingAUserWithInvalidData_Variant0()
        {
#line 19
this.UpdatingAUserWithInvalidData("TestName", "TestSurname", "", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Updating a user with invalid data, Variant 1", SourceLine=24)]
        public virtual void UpdatingAUserWithInvalidData_Variant1()
        {
#line 19
this.UpdatingAUserWithInvalidData("TestName", "", "TestEmail", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Updating a user with invalid data, Variant 2", SourceLine=24)]
        public virtual void UpdatingAUserWithInvalidData_Variant2()
        {
#line 19
this.UpdatingAUserWithInvalidData("", "TestSurname", "TestEmail", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Updating a user with invalid data, Variant 3", SourceLine=24)]
        public virtual void UpdatingAUserWithInvalidData_Variant3()
        {
#line 19
this.UpdatingAUserWithInvalidData("", "", "TestEmail", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Updating a user with invalid data, Variant 4", SourceLine=24)]
        public virtual void UpdatingAUserWithInvalidData_Variant4()
        {
#line 19
this.UpdatingAUserWithInvalidData("", "", "", ((string[])(null)));
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
