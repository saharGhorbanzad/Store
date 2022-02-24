namespace SaneiStore
{
    partial class frm_CustomerList
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GCustomerPlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transportation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlotName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheCostOfRepair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FortyPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SixtyPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GCustomerDsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbSearch = new System.Windows.Forms.GroupBox();
            this.txtADate = new System.Windows.Forms.MaskedTextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPlotName = new System.Windows.Forms.ComboBox();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsslInfo1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslInfo2 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.GbSearch.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(4, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.Name,
            this.Phone,
            this.Address,
            this.Date,
            this.GCustomerPlot,
            this.Transportation,
            this.PlotName,
            this.TheCostOfRepair,
            this.FortyPercent,
            this.SixtyPercent,
            this.Total,
            this.GCustomerDsc});
            this.dgvCustomer.Location = new System.Drawing.Point(4, 88);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.Size = new System.Drawing.Size(944, 359);
            this.dgvCustomer.TabIndex = 2;
            this.dgvCustomer.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_RowEnter);
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "کد مشتری";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "نام مشتری";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "تلفن";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "آدرس";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "تاریخ مراجعه";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // GCustomerPlot
            // 
            this.GCustomerPlot.DataPropertyName = "PlotId";
            this.GCustomerPlot.HeaderText = "کد کالای مصرفی";
            this.GCustomerPlot.Name = "GCustomerPlot";
            this.GCustomerPlot.ReadOnly = true;
            this.GCustomerPlot.Visible = false;
            // 
            // Transportation
            // 
            this.Transportation.DataPropertyName = "Transportation";
            this.Transportation.HeaderText = "هزینه حمل و نقل";
            this.Transportation.Name = "Transportation";
            this.Transportation.ReadOnly = true;
            // 
            // PlotName
            // 
            this.PlotName.DataPropertyName = "PlotName";
            this.PlotName.HeaderText = "نام کالای مصرفی";
            this.PlotName.Name = "PlotName";
            this.PlotName.ReadOnly = true;
            // 
            // TheCostOfRepair
            // 
            this.TheCostOfRepair.DataPropertyName = "TheCostOfRepair";
            this.TheCostOfRepair.HeaderText = "هزینه تعمیر";
            this.TheCostOfRepair.Name = "TheCostOfRepair";
            this.TheCostOfRepair.ReadOnly = true;
            // 
            // FortyPercent
            // 
            this.FortyPercent.DataPropertyName = "FortyPercent";
            this.FortyPercent.HeaderText = "40درصد سهم نمایندگی";
            this.FortyPercent.Name = "FortyPercent";
            this.FortyPercent.ReadOnly = true;
            // 
            // SixtyPercent
            // 
            this.SixtyPercent.DataPropertyName = "SixtyPercent";
            this.SixtyPercent.HeaderText = "60 درصد سهم کارشناس";
            this.SixtyPercent.Name = "SixtyPercent";
            this.SixtyPercent.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "جمع کل دریافتی کارشناس با احتساب ایاب و ذهاب و کالای مصرفی";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // GCustomerDsc
            // 
            this.GCustomerDsc.DataPropertyName = "Dsc";
            this.GCustomerDsc.HeaderText = "توضیحات";
            this.GCustomerDsc.Name = "GCustomerDsc";
            this.GCustomerDsc.ReadOnly = true;
            // 
            // GbSearch
            // 
            this.GbSearch.Controls.Add(this.txtADate);
            this.GbSearch.Controls.Add(this.txtAddress);
            this.GbSearch.Controls.Add(this.label4);
            this.GbSearch.Controls.Add(this.txtCustomerName);
            this.GbSearch.Controls.Add(this.label3);
            this.GbSearch.Controls.Add(this.label2);
            this.GbSearch.Controls.Add(this.label1);
            this.GbSearch.Controls.Add(this.cmbPlotName);
            this.GbSearch.Controls.Add(this.btnSearch);
            this.GbSearch.Location = new System.Drawing.Point(4, 3);
            this.GbSearch.Name = "GbSearch";
            this.GbSearch.Size = new System.Drawing.Size(944, 79);
            this.GbSearch.TabIndex = 3;
            this.GbSearch.TabStop = false;
            this.GbSearch.Text = "جستجو";
            // 
            // txtADate
            // 
            this.txtADate.Location = new System.Drawing.Point(81, 18);
            this.txtADate.Mask = "0000/00/00";
            this.txtADate.Name = "txtADate";
            this.txtADate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtADate.Size = new System.Drawing.Size(100, 21);
            this.txtADate.TabIndex = 5;
            this.txtADate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtADate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtADate_KeyDown);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(81, 45);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(794, 21);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddress_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(878, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "آدرس:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(556, 18);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(319, 21);
            this.txtCustomerName.TabIndex = 4;
            this.txtCustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerName_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(878, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "نام مشتری:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "تاریخ مراجعه:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "کالای مصرفی:";
            // 
            // cmbPlotName
            // 
            this.cmbPlotName.FormattingEnabled = true;
            this.cmbPlotName.Location = new System.Drawing.Point(256, 18);
            this.cmbPlotName.Name = "cmbPlotName";
            this.cmbPlotName.Size = new System.Drawing.Size(216, 21);
            this.cmbPlotName.TabIndex = 2;
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslInfo1,
            this.tsslInfo2});
            this.ssMain.Location = new System.Drawing.Point(0, 451);
            this.ssMain.Name = "ssMain";
            this.ssMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ssMain.Size = new System.Drawing.Size(955, 22);
            this.ssMain.TabIndex = 22;
            // 
            // tsslInfo1
            // 
            this.tsslInfo1.AutoSize = false;
            this.tsslInfo1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslInfo1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tsslInfo1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tsslInfo1.ForeColor = System.Drawing.Color.Blue;
            this.tsslInfo1.Name = "tsslInfo1";
            this.tsslInfo1.Size = new System.Drawing.Size(840, 17);
            this.tsslInfo1.Spring = true;
            this.tsslInfo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsslInfo2
            // 
            this.tsslInfo2.AutoSize = false;
            this.tsslInfo2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslInfo2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tsslInfo2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tsslInfo2.ForeColor = System.Drawing.Color.Red;
            this.tsslInfo2.Name = "tsslInfo2";
            this.tsslInfo2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsslInfo2.Size = new System.Drawing.Size(100, 17);
            // 
            // frm_CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 473);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.GbSearch);
            this.Controls.Add(this.dgvCustomer);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "لیست مشتری ها";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.GbSearch.ResumeLayout(false);
            this.GbSearch.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Plot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dsc;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.GroupBox GbSearch;
        private System.Windows.Forms.MaskedTextBox txtADate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPlotName;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslInfo1;
        private System.Windows.Forms.ToolStripStatusLabel tsslInfo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn GCustomerPlot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transportation;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlotName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheCostOfRepair;
        private System.Windows.Forms.DataGridViewTextBoxColumn FortyPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn SixtyPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn GCustomerDsc;
    }
}

