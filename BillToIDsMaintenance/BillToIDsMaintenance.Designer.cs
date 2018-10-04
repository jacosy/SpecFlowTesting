namespace BillToIDsMaintenance
{
    partial class BillToIDsMaintenance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillToIDsMaintenance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.BillToIDsTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.billToIdFlexGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billToIdFlexGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.CreateBtn);
            this.panel1.Controls.Add(this.BillToIDsTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 56);
            this.panel1.TabIndex = 0;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(250, 16);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(341, 16);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateBtn.TabIndex = 2;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // BillToIDsTxt
            // 
            this.BillToIDsTxt.Location = new System.Drawing.Point(78, 18);
            this.BillToIDsTxt.Name = "BillToIDsTxt";
            this.BillToIDsTxt.Size = new System.Drawing.Size(146, 20);
            this.BillToIDsTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BillToIDs";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(332, 451);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.databaseLabel);
            this.panel2.Controls.Add(this.billToIdFlexGrid);
            this.panel2.Location = new System.Drawing.Point(3, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(669, 477);
            this.panel2.TabIndex = 1;
            // 
            // databaseLabel
            // 
            this.databaseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Location = new System.Drawing.Point(10, 456);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(56, 13);
            this.databaseLabel.TabIndex = 20;
            this.databaseLabel.Text = "Database:";
            // 
            // billToIdFlexGrid
            // 
            this.billToIdFlexGrid.AllowDelete = true;
            this.billToIdFlexGrid.AllowEditing = false;
            this.billToIdFlexGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.billToIdFlexGrid.AutoClipboard = true;
            this.billToIdFlexGrid.ColumnInfo = resources.GetString("billToIdFlexGrid.ColumnInfo");
            this.billToIdFlexGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.billToIdFlexGrid.ExtendLastCol = true;
            this.billToIdFlexGrid.Location = new System.Drawing.Point(9, 3);
            this.billToIdFlexGrid.Name = "billToIdFlexGrid";
            this.billToIdFlexGrid.Rows.Count = 1;
            this.billToIdFlexGrid.Rows.DefaultSize = 17;
            this.billToIdFlexGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.billToIdFlexGrid.Size = new System.Drawing.Size(578, 442);
            this.billToIdFlexGrid.StyleInfo = resources.GetString("billToIdFlexGrid.StyleInfo");
            this.billToIdFlexGrid.TabIndex = 3;
            // 
            // BillToIDsMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BillToIDsMaintenance";
            this.Text = "BillToIDs Maintenance";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billToIdFlexGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.TextBox BillToIDsTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private C1.Win.C1FlexGrid.C1FlexGrid billToIdFlexGrid;
        private System.Windows.Forms.Label databaseLabel;
        private System.Windows.Forms.Button deleteBtn;
    }
}

