using BillToIDsMaintenance.Models;
using BillToIDsMaintenance.Repositories;
using FvTech.Data;
using Moq;
using NUnit.Framework;
using System;
using System.Data;

namespace BillToIDsMaintenance.Test
{
    [TestFixture]
    public class BMPresenterShould
    {
        IBMViewer viewer;
        SqlDatabaseConnection databaseConnection;
        string userName;

        [OneTimeSetUp]
        public void SetUp()
        {
            databaseConnection = new SqlDatabaseConnection(@"Initial Catalog=UnitedStationers;Data Source=(localdb)\ProjectsV13;Integrated Security=true;");
            userName = "Longoria";
            var moqViewer = new Mock<IBMViewer>();
            moqViewer.Setup(view => view.Show(new BMViewModel()));
            viewer = moqViewer.Object;
        }

        [Test]
        public void Initialize_WhenThereIsNoBillToIDInDB_ReturnEmptyBillToIDList()
        {
            var sut = new BMPresenter(databaseConnection, userName, viewer);
            BMViewModel vm = sut.Initialize();
            Assert.That(vm.BillToIdDt.Rows.Count == 0);
        }

        [Test]
        public void Initialize_WhenThereAreSomeBillToIDsInDB_ReturnNotEmptyBillToIDList()
        {
            var repository = new BillToIDsRepository(databaseConnection);
            var sut = new BMPresenter(databaseConnection, userName, viewer);

            repository.CreateBillToID("123456", userName, DateTime.Now);
            BMViewModel vm = sut.Initialize();
            Assert.That(vm.BillToIdDt.Rows, Has.Count.GreaterThan(0));
            Assert.That(vm.BillToIdDt.Rows, Has.Count.EqualTo(1));

            databaseConnection.RunSqlCommand("truncate table BillToIDs");
        }

        [Test]
        public void CreateBillToID_WhenBillToIDDoesNotExist_ItShouldBeCreated()
        {
            var sut = new BMPresenter(databaseConnection, userName, viewer);
            string billToId = "123456";
            string msg = sut.Create(billToId);
            DataTable billToIdDt = sut.Search();

            Assert.That(msg, Is.EqualTo(string.Format("BillToID: {0} is created successfully!", billToId)));
            Assert.That(billToIdDt.Rows, Has.Count.EqualTo(1));
            databaseConnection.RunSqlCommand("truncate table BillToIDs");
        }

        [Test]
        public void CreateBillToID_WhenBillToIDtExists_ItShouldNotBeCreated()
        {
            var repository = new BillToIDsRepository(databaseConnection);
            var sut = new BMPresenter(databaseConnection, userName, viewer);
            string billToId = "123456";
            sut.Create(billToId);
            string msg = sut.Create(billToId);

            Assert.That(msg, Is.EqualTo(string.Format("BillToID: {0} is already existed in DB.{1}Can't create duplicate BillToID!", billToId, Environment.NewLine)));

            databaseConnection.RunSqlCommand("truncate table BillToIDs");
        }

        [Test]
        public void Search_WhenBillToIDIsNotProvided_ReturnAllRecords()
        {
            var sut = new BMPresenter(databaseConnection, userName, viewer);
            CreateTestData();

            DataTable dt = sut.Search();

            Assert.That(dt.Rows, Has.Count.EqualTo(4));

            databaseConnection.RunSqlCommand("truncate table BillToIDs");
        }

        [TestCase("ABC", 1)]
        [TestCase("A", 3)]
        public void Search_WhenBillToIDIsProvided_ReturnOnlyTheMatchedRecords(string billToId, int expectedRecords)
        {
            var sut = new BMPresenter(databaseConnection, userName, viewer);
            CreateTestData();

            DataTable dt = sut.Search(billToId);

            Assert.That(dt.Rows, Has.Count.EqualTo(expectedRecords));

            databaseConnection.RunSqlCommand("truncate table BillToIDs");
        }

        [Test]
        public void Delete_WhenBillToIDIsMatechedInDB_DeleteTheMatchedRecord()
        {
            var sut = new BMPresenter(databaseConnection, userName, viewer);
            CreateTestData();
            string billToId = "123456";

            string msg = sut.Delete("123456");
            DataTable dt = sut.Search();

            Assert.That(msg, Is.EqualTo(string.Format("BillToID: {0} is deleted successfully!", billToId)));
            Assert.That(dt.Rows, Has.Count.EqualTo(3));

            databaseConnection.RunSqlCommand("truncate table BillToIDs");
        }

        [TestCase("EDF")]
        [TestCase("A")]
        public void Delete_WhenBillToIDIsNotMatechedInDB_NoRecordIsDeleted(string billToId)
        {
            var sut = new BMPresenter(databaseConnection, userName, viewer);
            CreateTestData();

            string msg = sut.Delete(billToId);
            DataTable dt = sut.Search();

            Assert.That(dt.Rows, Has.Count.EqualTo(4));

            databaseConnection.RunSqlCommand("truncate table BillToIDs");
        }

        [TestCase("")]
        [TestCase("   ")]
        [TestCase(null)]
        public void ValidateBillToId_WhenBillToIdIsEmptyOrNull_ReturnBillToIdEmptyMsg(string billToId)
        {
            string msg = BMPresenter.ValidateBillToId(billToId);

            Assert.That(msg, Is.EqualTo("BillToID can't be empty!"));
        }

        [Test]
        public void ValidateBillToId_WhenBillToIdIsOver100Characters_ReturnBillToIdExceedsMaximumLengthMsg()
        {
            string billToId = new string('A', 101);
            string msg = BMPresenter.ValidateBillToId(billToId);

            Assert.That(msg, Is.EqualTo("The length of BillToID can't be over 100 characters!"));
        }

        [Test]
        public void ValidateBillToId_WhenBillToIdIsValidated_ReturnEmptythMsg()
        {
            string billToId = new string('A', 99);
            string msg = BMPresenter.ValidateBillToId(billToId);

            Assert.That(msg, Is.EqualTo(string.Empty));
        }

        private void CreateTestData()
        {
            var repository = new BillToIDsRepository(databaseConnection);
            repository.CreateBillToID("ABC", userName, DateTime.Now);
            repository.CreateBillToID("EADF", userName, DateTime.Now);
            repository.CreateBillToID("XYZA", userName, DateTime.Now);
            repository.CreateBillToID("123456", userName, DateTime.Now);
        }
    }
}
