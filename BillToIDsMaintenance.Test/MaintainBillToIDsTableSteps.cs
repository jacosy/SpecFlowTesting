using BillToIDsMaintenance.Models;
using FvTech.Data;
using Moq;
using NUnit.Framework;
using System.Data;
using TechTalk.SpecFlow;

namespace BillToIDsMaintenance.Test
{
    [Binding]
    public class MaintainBillToIDsTableSteps
    {
        BMPresenter sut;
        IBMViewer viewer;
        SqlDatabaseConnection databaseConnection;
        string userName;

        public MaintainBillToIDsTableSteps()
        {
            databaseConnection = new SqlDatabaseConnection(@"Initial Catalog=UnitedStationers;Data Source=(localdb)\ProjectsV13;Integrated Security=true;");
            userName = "Longoria";
            var moqViewer = new Mock<IBMViewer>();
            moqViewer.Setup(view => view.Show(new BMViewModel()));
            viewer = moqViewer.Object;
            sut = new BMPresenter(databaseConnection, userName, viewer);
        }

        #region Scenario: Get BillToIDs
        [When(@"User does not provide any Keyword to search BillToID")]
        public void WhenUserDoesNotProvideAnyKeywordToSearchBillToID()
        {
            sut.Create("123456");
            sut.Create("ABCEDF");
            sut.Create("poiuy");
        }

        [Then(@"It should return all the BillToIDs")]
        public void ThenItShouldReturnAllTheBillToIDs()
        {
            DataTable dt = sut.Search();
            Assert.That(dt.Rows, Has.Count.EqualTo(3));
            databaseConnection.RunSqlCommand("truncate table BillToIDs");
        }
        #endregion

        #region Scenario Outline: Delete an existing BillToID
        [Given(@"There is an existing (.*) in BillToID table")]
        public void GivenThereIsAnExistingInBillToIDTable(string billToID)
        {
            string msg = sut.Create(billToID);
        }

        [When(@"User tries to delete (.*)")]
        public void WhenUserTriesToDelete(string billToID)
        {
            sut.Delete(billToID);
        }

        [Then(@"(.*) should be deleted from BillToID table")]
        public void ThenShouldBeDeletedFromBillToIDTable(string billToID)
        {
            DataTable dt = sut.Search(billToID);
            Assert.That(dt.Rows, Has.Count.EqualTo(0));
            databaseConnection.RunSqlCommand("truncate table BillToIDs");
        }
        #endregion                               

        #region Scenario Outlines: 1. Creat a New BillToID; 2. Try to Create an existing BillToID
        [When(@"User tries to create a (.*)")]
        public void WhenUserTriesToCreateBillToID(string billToID)
        {
            sut.Create(billToID);
        }

        [When(@"There is no matched (.*) in DB")]
        public void WhenThereIsNoMatchedInDB(string billToID)
        {
        }

        [Then(@"The (.*) should be created and stored in BillToIDs table")]
        public void BillToIdShouldBeCreatedAndStoredInBillToIDsTable(string billToID)
        {
            DataTable dt = sut.Search(billToID);
            Assert.That(dt.Rows, Has.Count.EqualTo(1));
            databaseConnection.RunSqlCommand("truncate table BillToIDs");
        }

        [When(@"There is a matched (.*) in DB")]
        public void WhenThereIsAMatchedInDB(string billToID)
        {
            sut.Create(billToID);
        }

        [Then(@"The (.*) should not be created and stored in BillToIDs table")]
        public void BillToIdShouldNotBeCreatedAndStoredInBillToIDsTable(string billToID)
        {
            DataTable dt = sut.Search(billToID);
            Assert.That(dt.Rows, Has.Count.EqualTo(1));
            databaseConnection.RunSqlCommand("truncate table BillToIDs");
        }
        #endregion

        #region Scenario Outline: Search BillToIDs      
        [Given(@"There are the following records in BillToIDs table: ABC123, ABC456, ABC987 & Test")]
        public void GivenThereAreTheFollowingRecordsInBillToIDsTableABCABCABCTest()
        {
            sut.Create("ABC123");
            sut.Create("ABC456");
            sut.Create("ABC987");
            sut.Create("Test");
        }

        [When(@"User use (.*) to search BillToID")]
        public void WhenUserUseABCToSearchBillToID(string keyword)
        {
            DataTable dt = sut.Search(keyword);
            ScenarioContext.Current.Add("Result", dt.Rows.Count);
        }

        [Then(@"It should return the (.*) records containing the keyword")]
        public void ThenItShouldReturnTheRecordsContainingTheKeyword(int expectedRecords)
        {
            Assert.That(int.Parse(ScenarioContext.Current["Result"].ToString()) == expectedRecords);
            databaseConnection.RunSqlCommand("truncate table BillToIDs");
        }
        #endregion
    }
}
