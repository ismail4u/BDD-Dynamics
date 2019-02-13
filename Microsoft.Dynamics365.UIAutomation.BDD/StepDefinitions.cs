using Microsoft.Dynamics365.UIAutomation.Browser;
using Microsoft.Dynamics365.UIAutomation.Api;
using System;
using System.Security;
using TechTalk.SpecFlow;

namespace Dynamics_CRM_BDD
{
    [Binding]
    public class StepDefinitions 
    {
        private readonly SecureString _username = System.Configuration.ConfigurationManager.AppSettings["OnlineUsername"].ToSecureString();
        private readonly SecureString _password = System.Configuration.ConfigurationManager.AppSettings["OnlinePassword"].ToSecureString();
        private readonly Uri _xrmUri = new Uri(System.Configuration.ConfigurationManager.AppSettings["OnlineCrmUrl"].ToString());
        Browser xrmBrowser;
        //public static Browser xrmBrowser = null;
        private readonly TestBase browserInstance;

        public StepDefinitions(TestBase browserInstance)
        {
            this.browserInstance = browserInstance;
        }


        [Given(@"I login to CRM")]
        public void GivenILoginToCRM()
        {
            browserInstance.xrmBrowser = new Browser(TestSettings.Options);
            xrmBrowser = browserInstance.xrmBrowser;
            xrmBrowser.LoginPage.Login(_xrmUri, _username, _password);
            xrmBrowser.GuidedHelp.CloseGuidedHelp();
        }
           
    
        
        [When(@"I navigate to Sales and select Accounts")]
        public void WhenINavigateToSalesAndSelectAccounts()
        {
            xrmBrowser.ThinkTime(500);
            xrmBrowser.Navigation.OpenSubArea("Sales", "Companies");
        }
        
        [Then(@"I click on New command")]
        public void ThenIClickOnNewCommand()
        {
            xrmBrowser.ThinkTime(2000);
            xrmBrowser.Grid.SwitchView("Active Accounts");

            xrmBrowser.ThinkTime(1000);
            xrmBrowser.CommandBar.ClickCommand("New");
        }
        
        [Then(@"I set value of name to RandomString of (.*)")]
        public void ThenISetValueOfNameToRandomStringOf(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I set value of telephone(.*) to '(.*)'")]
        public void ThenISetValueOfTelephoneTo(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I set value of websiteurl to '(.*)'")]
        public void ThenISetValueOfWebsiteurlTo(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I click on Save command")]
        public void ThenIClickOnSaveCommand()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Activity timeline count should be equal to (.*)")]
        public void ThenActivityTimelineCountShouldBeEqualTo(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
