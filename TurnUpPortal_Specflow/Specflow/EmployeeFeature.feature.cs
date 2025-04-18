﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:2.0.0.0
//      Reqnroll Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TurnUpPortal_Specflow.Specflow
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("EmployeeFeature")]
    [NUnit.Framework.FixtureLifeCycleAttribute(NUnit.Framework.LifeCycle.InstancePerTestCase)]
    public partial class EmployeeFeatureFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private static global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Specflow", "EmployeeFeature", "As an admin user for TurnUp Portal I would like to \r\ncreate , update and delete e" +
                "mployee records \r\nso I can manage employee records successfully ", global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
        
#line 1 "EmployeeFeature.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public static async System.Threading.Tasks.Task FeatureSetupAsync()
        {
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public static async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(featureHint: featureInfo);
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Equals(featureInfo) == false)))
            {
                await testRunner.OnFeatureEndAsync();
            }
            if ((testRunner.FeatureContext == null))
            {
                await testRunner.OnFeatureStartAsync(featureInfo);
            }
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
            global::Reqnroll.TestRunnerManager.ReleaseTestRunner(testRunner);
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("create new employee record")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        [NUnit.Framework.TestCaseAttribute("Peanut", null)]
        [NUnit.Framework.TestCaseAttribute("Charito", null)]
        public async System.Threading.Tasks.Task CreateNewEmployeeRecord(string name, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Regression"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Name", name);
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("create new employee record", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 8
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 9
 await testRunner.GivenAsync("I logged into TurnUp portal successfully", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 10
 await testRunner.WhenAsync("I navigate to employee page", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 11
 await testRunner.WhenAsync(string.Format("I create new employee \'{0}\' record", name), ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 12
 await testRunner.ThenAsync(string.Format("new employee \'{0}\' record should be saved successfully", name), ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("update employee record")]
        [NUnit.Framework.TestCaseAttribute("Peanut1", "Peanut1", "12345677", "P@ssw0rd2", "P@ssw0rd2", "True", "Bike", null)]
        public async System.Threading.Tasks.Task UpdateEmployeeRecord(string name, string username, string contact, string password, string retypepassword, string isadmin, string vehicle, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Name", name);
            argumentsOfScenario.Add("Username", username);
            argumentsOfScenario.Add("Contact", contact);
            argumentsOfScenario.Add("Password", password);
            argumentsOfScenario.Add("Retypepassword", retypepassword);
            argumentsOfScenario.Add("Isadmin", isadmin);
            argumentsOfScenario.Add("Vehicle", vehicle);
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("update employee record", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 20
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 21
await testRunner.GivenAsync("I logged into TurnUp portal successfully", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 22
await testRunner.WhenAsync("I navigate to employee page", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 23
await testRunner.WhenAsync(string.Format("I edit \'{0}\',\'{1}\',\'{2}\',\'{3}\',\'{4}\',\'{5}\'and \'{6}\' of employee record", name, username, contact, password, retypepassword, isadmin, vehicle), ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 24
await testRunner.ThenAsync(string.Format("the \'{0}\',\'{1}\',\'{2}\',\'{3}\',\'{4}\',\'{5}\'and \'{6}\' of employee record should be upd" +
                            "ated successfully", name, username, contact, password, retypepassword, isadmin, vehicle), ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("delete employee record")]
        [NUnit.Framework.TestCaseAttribute("Peanut1", "Peanut1", null)]
        public async System.Threading.Tasks.Task DeleteEmployeeRecord(string name, string username, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Name", name);
            argumentsOfScenario.Add("Username", username);
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("delete employee record", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 32
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 33
await testRunner.GivenAsync("I logged into TurnUp portal successfully", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 34
await testRunner.WhenAsync("I navigate to employee page", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 35
await testRunner.WhenAsync(string.Format("I delete the \'{0}\' and \'{1}\' employee record", name, username), ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 36
await testRunner.ThenAsync(string.Format("\'{0}\' and \'{1}\' employee record should be deleted successfully", name, username), ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
