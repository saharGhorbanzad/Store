namespace SaneiStore
{
    partial class frm_StoreList
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
            this.dgvStore = new System.Windows.Forms.DataGridView();
            this.PlotId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlotName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProviderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsslInfo1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslInfo2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPlotName = new System.Windows.Forms.TextBox();
            this.P = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).BeginInit();
            this.ssMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStore
            // 
            this.dgvStore.AllowUserToAddRows = false;
            this.dgvStore.AllowUserToDeleteRows = false;
            this.dgvStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlotId,
            this.PlotName,
            this.Count,
            this.Price,
            this.ProviderName,
            this.PurchaseDate,
            this.Dsc});
            this.dgvStore.Location = new System.Drawing.Point(2, 56);
            this.dgvStore.Name = "dgvStore";
            this.dgvStore.ReadOnly = true;
            this.dgvStore.Size = new System.Drawing.Size(797, 284);
            this.dgvStore.TabIndex = 0;
            this.dgvStore.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStore_RowEnter);
            // 
            // PlotId
            // 
            this.PlotId.DataPropertyName = "PlotId";
            this.PlotId.HeaderText = "کدکالا";
            this.PlotId.Name = "PlotId";
            this.PlotId.ReadOnly = true;
            this.PlotId.Width = 40;
            // 
            // PlotName
            // 
            this.PlotName.DataPropertyName = "PlotName";
            this.PlotName.HeaderText = "نام کالا";
            this.PlotName.Name = "PlotName";
            this.PlotName.ReadOnly = true;
            this.PlotName.Width = 200;
            // 
            // Count
            // 
            this.Count.DataPropertyName = "Count";
            this.Count.HeaderText = "تعداد کالا";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 40;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "قیمت کالا";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // ProviderName
            // 
            this.ProviderName.DataPropertyName = "ProviderName";
            this.ProviderName.HeaderText = "نام تامین کننده";
            this.ProviderName.Name = "ProviderName";
            this.ProviderName.ReadOnly = true;
            this.ProviderName.Width = 120;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.DataPropertyName = "PurchaseDate";
            this.PurchaseDate.HeaderText = "تاریخ خرید";
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.ReadOnly = true;
            this.PurchaseDate.Width = 75;
            // 
            // Dsc
            // 
            this.Dsc.DataPropertyName = "Dsc";
            this.Dsc.HeaderText = "توضیحات";
            this.Dsc.Name = "Dsc";
            this.Dsc.ReadOnly = true;
            this.Dsc.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslInfo1,
            this.tsslInfo2});
            this.ssMain.Location = new System.Drawing.Point(0, 373);
            this.ssMain.Name = "ssMain";
            this.ssMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ssMain.Size = new System.Drawing.Size(800, 22);
            this.ssMain.TabIndex = 23;
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
            this.tsslInfo1.Size = new System.Drawing.Size(685, 17);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtPlotName);
            this.groupBox1.Controls.Add(this.P);
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 49);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(3, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPlotName
            // 
            this.txtPlotName.Location = new System.Drawing.Point(480, 21);
            this.txtPlotName.Name = "txtPlotName";
            this.txtPlotName.Size = new System.Drawing.Size(265, 21);
            this.txtPlotName.TabIndex = 1;
            this.txtPlotName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPlotName_KeyDown);
            // 
            // P
            // 
            this.P.AutoSize = true;
            this.P.Location = new System.Drawing.Point(751, 24);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(42, 13);
            this.P.TabIndex = 0;
            this.P.Text = "نام کالا:";
            // 
            // frm_StoreList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvStore);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "frm_StoreList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "انبار";
            this.Load += new System.EventHandler(this.frm_StoreList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).EndInit();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslInfo1;
        private System.Windows.Forms.ToolStripStatusLabel tsslInfo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlotId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlotName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProviderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dsc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPlotName;
        private System.Windows.Forms.Label P;
    }
}

