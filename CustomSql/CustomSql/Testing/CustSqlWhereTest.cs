using System;
using NUnit.Framework;
using NUnit.Extensions.Forms;
using Moq;
using CustomSQL;
using System.Data;

namespace Tests
{
    [TestFixture]
    public class CustSqlWhereTest
    {
        /// <summary>
        /// Tests that the query is correct and that the correct value is returned.
        /// </summary>
        [Test]
        public void getColsOfTypeTest()
        {
            var dataMock = new Mock<DataHelper>();
            string[] columnsList = new string[] { "1st", "2nd" };
            DataTable outTable = new DataTable();
            outTable.Columns.Add("COLUMN_NAME");
            foreach (string col in columnsList)
            {
                outTable.Rows.Add(new string[] { col });
            }
            string queryToMock = "SELECT COLUMN_NAME FROM [ClientCardFB3].information_schema.columns WHERE TABLE_NAME = 'HouseholdMembers' AND (DATA_TYPE IN ('int')) AND (COLUMN_NAME = '1st' OR COLUMN_NAME = '2nd')";
            dataMock.Setup(_ => _.sqlSelectQuery(It.IsAny<string>(), queryToMock)).Returns(outTable);

            CustSqlWhere sqlWhere = new CustSqlWhere(dataMock.Object, "", new string[]{"1st", "2nd"}, "ClientCardFB3", "HouseholdMembers");
            string[] columnAct = sqlWhere.getColsOfType("(DATA_TYPE IN ('int'))");

            Assert.AreEqual(columnsList, columnAct);
        }

        /// <summary>
        /// Tests that the query is correct and that the correct value is returned.
        /// </summary>
        [Test]
        public void getDistinctValsInColTest()
        {
            var dataMock = new Mock<DataHelper>();
            DataTable outTable = new DataTable();
            string[] namesList = new string[] { "Bob", "Joe" };
            outTable.Columns.Add("LastName");
            foreach (string name in namesList)
            {
                outTable.Rows.Add(new string[] { name });
            }
            string queryToMock = "SELECT DISTINCT LastName FROM [ClientCardFB3].[dbo].[HouseholdMembers]";
            dataMock.Setup(_ => _.sqlSelectQuery(It.IsAny<string>(), queryToMock)).Returns(outTable);

            CustSqlWhere sqlWhere = new CustSqlWhere(dataMock.Object, "", new string[] { "1st", "2nd" }, "ClientCardFB3", "HouseholdMembers");
            string[] columnAct = sqlWhere.getDistinctValsInCol("LastName");

            Assert.AreEqual(namesList, columnAct);
        }

        /// <summary>
        /// Make sure the controls are added and the sqlWhereProperties gets populated correctly
        /// </summary>
        [Test]
        [STAThread]
        public void setupStringSelectTest()
        {
            // Setup mock data to return first names or last names
            var dataMock = new Mock<DataHelper>();
            dataMock.Setup(_ => _.sqlSelectQuery(It.IsAny<string>(), It.IsAny<string>())).Returns(new DataTable());
            DataTable firstNameTable = new DataTable();
            firstNameTable.Columns.Add("FirstName");
            string[] firstNames = new string[] { "Billy", "John"};
            foreach (string name in firstNames)
            {
                firstNameTable.Rows.Add(new string[] { name });
            }
            dataMock.Setup(_ => _.sqlSelectQuery(It.IsAny<string>(), It.Is<string>(s => s.Contains("FirstName")))).Returns(firstNameTable);
            DataTable lastNameTable = new DataTable();
            lastNameTable.Columns.Add("LastName");
            string[] lastNames = new string[] { "Joe", "Doe"};
            foreach (string name in lastNames)
            {
                lastNameTable.Rows.Add(new string[] { name });
            }
            dataMock.Setup(_ => _.sqlSelectQuery(It.IsAny<string>(), It.Is<string>(s => s.Contains("LastName")))).Returns(lastNameTable);

            // init and show the form
            CustSqlWhere sqlWhere = new CustSqlWhere(dataMock.Object, "", new string[0], "ClientCardFB3", "HouseholdMembers");
            sqlWhere.Show();

            // Cal funct to test
            string[] colNames = new string[]{ "FirstName", "LastName" };
            sqlWhere.setupStringSelect(colNames);

            // Check the sqlProperties have the correct values
            SqlSelectProperty[] selectProps = (SqlSelectProperty[])sqlWhere.SqlSelectProperties;
            Assert.AreEqual(2, selectProps.Length);
            Assert.AreEqual("FirstName", (string)selectProps[0]);
            Assert.AreEqual("LastName", (string)selectProps[1]);

            SqlStringWhereProperty[] stringWhereProps = (SqlStringWhereProperty[])sqlWhere.SqlStringWhereProperties;
            Assert.AreEqual(2, stringWhereProps.Length);
            Assert.AreEqual("FirstName", stringWhereProps[0].columnName);
            Assert.AreEqual("LastName", stringWhereProps[1].columnName);
            Assert.AreEqual(firstNames, stringWhereProps[0].AllItems);
            Assert.AreEqual(lastNames, stringWhereProps[1].AllItems);

            // Check the correct controls were put on the form
            LabelTester colLabel0Tester = new LabelTester("flpStringSelect.flpSelection0.colLabel");
            Assert.AreEqual("FirstName", colLabel0Tester.Text);
            LabelTester colLabel1Tester = new LabelTester("flpStringSelect.flpSelection1.colLabel");
            Assert.AreEqual("LastName", colLabel1Tester.Text);

            string[][] allNames = new string[][]{firstNames, lastNames};
            for (int columnNum = 0; columnNum < colNames.Length; columnNum++)
            {
                string panelNameCol = "flpStringSelect.flpSelection"+columnNum;
                CheckBoxTester chkDisplayTester = new CheckBoxTester(panelNameCol + ".chkDisplay");
                Assert.NotNull(chkDisplayTester.Text);

                ListBoxTester lstSelectionsTester = new ListBoxTester(panelNameCol + ".lstSelections");
                Assert.AreEqual(allNames[columnNum], lstSelectionsTester.Properties.DataSource);

                CheckBoxTester chkEnabledTester = new CheckBoxTester(panelNameCol + ".chkEnabled");
                Assert.NotNull(chkEnabledTester.Text);
            }

            // Manipulate the controls
            string panelName = "flpStringSelect.flpSelection";
            CheckBoxTester chkDisplayTester0 = new CheckBoxTester(panelName + "0.chkDisplay");
            chkDisplayTester0.Check();

            CheckBoxTester chkEnabledTester1 = new CheckBoxTester(panelName + "1.chkEnabled");
            chkEnabledTester1.Check();
            ListBoxTester lstSelectionsTester0 = new ListBoxTester(panelName + "0.lstSelections");
            lstSelectionsTester0.SetSelected(0, false);
            lstSelectionsTester0.SetSelected(1, true);
            ListBoxTester lstSelectionsTester1 = new ListBoxTester(panelName + "1.lstSelections");
            lstSelectionsTester1.SetSelected(0, true);
            lstSelectionsTester1.SetSelected(1, true);

            // Check the sql properties are affected properly
            selectProps = (SqlSelectProperty[])sqlWhere.SqlSelectProperties;
            Assert.True(selectProps[0].IsEnabled);
            Assert.False(selectProps[1].IsEnabled);

            stringWhereProps = (SqlStringWhereProperty[])sqlWhere.SqlStringWhereProperties;
            Assert.AreEqual("(FirstName IN ('John'))", (string)stringWhereProps[0]);
            Assert.AreEqual("(LastName IN ('Joe', 'Doe'))", (string)stringWhereProps[1]);
        }

        /// <summary>
        /// Make sure the controls are added and the sqlWhereProperties gets populated correctly
        /// </summary>
        [Test]
        [STAThread]
        public void setupRangeSelectTest()
        {
            // Setup mock data to return first names or last names
            var dataMock = new Mock<DataHelper>();
            dataMock.Setup(_ => _.sqlSelectQuery(It.IsAny<string>(), It.IsAny<string>())).Returns(new DataTable());
            DataTable idTable = new DataTable();
            idTable.Columns.Add("ID");
            int[] ids = new int[] { 0, 5 };
            foreach (int id in ids)
            {
                idTable.Rows.Add(new int[] { id });
            }
            dataMock.Setup(_ => _.sqlSelectQuery(It.IsAny<string>(), It.Is<string>(s => s.Contains("ID")))).Returns(idTable);
            DataTable birthTable = new DataTable();
            birthTable.Columns.Add("Birth");
            DateTime[] birthDays = new DateTime[] { new DateTime(1900, 1, 1), new DateTime(2000, 1, 1) };
            foreach (DateTime birthDay in birthDays)
            {
                birthTable.Rows.Add(new DateTime[] { birthDay });
            }
            dataMock.Setup(_ => _.sqlSelectQuery(It.IsAny<string>(), It.Is<string>(s => s.Contains("Birth")))).Returns(birthTable);

            // init and show the form
            CustSqlWhere sqlWhere = new CustSqlWhere(dataMock.Object, "", new string[0], "ClientCardFB3", "HouseholdMembers");
            sqlWhere.Show();

            // Cal funct to test
            string[] colNames = new string[] { "ID", "Birth" };
            string[] numCols = new string[] { "ID" };
            sqlWhere.setupRangeSelect(colNames, numCols);

            // Check the sqlProperties have the correct values
            SqlSelectProperty[] selectProps = (SqlSelectProperty[])sqlWhere.SqlSelectProperties;
            Assert.AreEqual(2, selectProps.Length);
            Assert.AreEqual("ID", (string)selectProps[0]);
            Assert.AreEqual("Birth", (string)selectProps[1]);

            SqlRangeWhereProperty[] stringWhereProps = sqlWhere.SqlRangeWhereProperties;
            Assert.AreEqual(2, stringWhereProps.Length);
            Assert.AreEqual("ID", stringWhereProps[0].columnName);
            Assert.AreEqual("Birth", stringWhereProps[1].columnName);

            // TODO: add this part
            /*
            // Check the correct controls were put on the form
            LabelTester colLabel0Tester = new LabelTester("flpStringSelect.flpSelection0.colLabel");
            Assert.AreEqual("FirstName", colLabel0Tester.Text);
            LabelTester colLabel1Tester = new LabelTester("flpStringSelect.flpSelection1.colLabel");
            Assert.AreEqual("LastName", colLabel1Tester.Text);

            string[][] allNames = new string[][]{firstNames, lastNames};
            for (int columnNum = 0; columnNum < colNames.Length; columnNum++)
            {
                string panelNameCol = "flpStringSelect.flpSelection"+columnNum;
                CheckBoxTester chkDisplayTester = new CheckBoxTester(panelNameCol + ".chkDisplay");
                Assert.NotNull(chkDisplayTester.Text);

                ListBoxTester lstSelectionsTester = new ListBoxTester(panelNameCol + ".lstSelections");
                Assert.AreEqual(allNames[columnNum], lstSelectionsTester.Properties.DataSource);

                CheckBoxTester chkEnabledTester = new CheckBoxTester(panelNameCol + ".chkEnabled");
                Assert.NotNull(chkEnabledTester.Text);
            }*/
        }
    }
}