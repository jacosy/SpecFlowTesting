using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BillToIDsMaintenance.Models;
using FvTech.Data;
using C1.Win.C1FlexGrid;

namespace BillToIDsMaintenance
{
    public partial class BillToIDsMaintenance : Form, IBMViewer
    {        
        BMViewModel vm;
        BMPresenter presenter;

        public BillToIDsMaintenance(SqlDatabaseConnection databaseConnection, string databaseName, string userName)
        {
            InitializeComponent();
            databaseLabel.Text = "Database: " + databaseName;
            presenter = new BMPresenter(databaseConnection, userName, this);
            presenter.Initialize();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            vm.InputBillToID = BillToIDsTxt.Text.Trim();
            DataTable dt = presenter.Search(vm.InputBillToID);
            billToIdFlexGrid.DataSource = dt;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            vm.InputBillToID = BillToIDsTxt.Text.Trim();
            string msg = BMPresenter.ValidateBillToId(vm.InputBillToID);
            if (string.IsNullOrEmpty(msg))
            {
                if (DialogResult.Yes == MessageBox.Show(string.Format("Are you sure you want to create new BillToID: {0} ?", vm.InputBillToID)
                                        , "Create BillToID"
                                        , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
                {
                    msg = presenter.Create(vm.InputBillToID);
                    DataTable dt = presenter.Search();
                    billToIdFlexGrid.DataSource = dt;
                    BillToIDsTxt.Text = string.Empty;
                    MessageBox.Show(msg);
                }
            }
            else
            {                
                MessageBox.Show(msg);
            }
        }

        public void Show(BMViewModel viewModel)
        {
            vm = viewModel;
            billToIdFlexGrid.DataSource = vm.BillToIdDt;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (billToIdFlexGrid.RowSel >= billToIdFlexGrid.Rows.Count || billToIdFlexGrid.RowSel < 1)
            {
                return;
            }

            Row row = billToIdFlexGrid.Rows[billToIdFlexGrid.RowSel];
            string billToId = row["BillToID"].ToString();

            if (MessageBox.Show("Are you sure you want to delete BillToID: " + billToId + "?", "Delete BillToID", MessageBoxButtons.YesNo, (System.Windows.Forms.MessageBoxIcon)32) == DialogResult.Yes)
            {
                string msg = presenter.Delete(billToId);
                billToIdFlexGrid.Rows.Remove(billToIdFlexGrid.RowSel);
                MessageBox.Show(msg);
            }
        }
    }
}
