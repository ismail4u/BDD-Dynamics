using Microsoft.Dynamics365.UIAutomation.Api;
using System;
using TechTalk.SpecFlow;

namespace Dynamics_CRM_BDD
{
    [Binding]
    public class AccCreationStepdef 
    {

        private readonly TestBase browserInstance;

        public AccCreationStepdef(TestBase browserInstance)
        {
            this.browserInstance = browserInstance;
        }

        Browser xrmBrowser;

        [Then(@"Enter account details and save")]
        public void ThenEnterAccountDetailsAndSave()
        {
            xrmBrowser = browserInstance.xrmBrowser;
            xrmBrowser.ThinkTime(5000);
            xrmBrowser.Entity.SetValue("name", "Automated Test Demo - 29 Jan");
            xrmBrowser.Entity.SetValue("telephone1", "555-555-5555");
            xrmBrowser.Entity.SetValue("websiteurl", "https://easyrepro.crm.dynamics.com");

            xrmBrowser.CommandBar.ClickCommand("Save & Close");
            xrmBrowser.ThinkTime(2000);
        }
    }
}
