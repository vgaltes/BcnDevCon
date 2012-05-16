using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using test2.CreateTicketUIMapClasses;
using test2.TicketDetailUIMapClasses;
using test2.TicketsUIMapClasses;
using test2.DeleteUIMapClasses;
using test2.DashboardClasses;


namespace test2
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        [TestMethod]
        [DeploymentItem("C:\\Users\\Administrator\\documents\\visual studio 2012\\Projects\\Test2\\Test2\\DataSources\\datasource.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\datasource.csv", "datasource#CSV", DataAccessMethod.Sequential)]
        public void CreateNewTicket()
        {
            Dashboard dashboardPage = new Dashboard();
            CreateTicketUIMap createTicketPage = new CreateTicketUIMap();
            TicketDetailUIMap ticketDetailPage = new TicketDetailUIMap();
            TicketsUIMap ticketsListPage = new TicketsUIMap();
            DeleteUIMap deletePage = new DeleteUIMap();
            string newId = string.Empty;

            dashboardPage.LaunchBrowserAndNavToFabrikamDashboard();
            dashboardPage.CreaeNewTicket();

            createTicketPage.CreateSampleTicketParams.UITitleEditText =
                TestContext.DataRow["Title"].ToString();
            createTicketPage.CreateSampleTicket();

            // Extract the ticketID
            newId = ticketDetailPage.CurrentId;

            ticketDetailPage.AssertTicketTitleExpectedValues.UIItemCustomInnerText =
                            TestContext.DataRow["ExpectedTitle"].ToString();

            ticketDetailPage.AssertTicketTitle();
            ticketDetailPage.AssertDescription();
            ticketDetailPage.ReturnToList();
            ticketsListPage.OpenTicket(newId);
            ticketsListPage.NavigateToDeletePage(newId);
            deletePage.DeleteTicket();
            dashboardPage.CloseBrowser();
        }

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

    }
}
