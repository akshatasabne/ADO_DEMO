namespace ADO_DEMO
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butShowAll = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butSearch = new System.Windows.Forms.Button();
            this.butupdate = new System.Windows.Forms.Button();
            this.butsave = new System.Windows.Forms.Button();
            this.comboCompany = new System.Windows.Forms.ComboBox();
            this.labCatname = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labname = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.labid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(375, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(385, 150);
            this.dataGridView1.TabIndex = 27;
            // 
            // butShowAll
            // 
            this.butShowAll.Location = new System.Drawing.Point(550, 345);
            this.butShowAll.Name = "butShowAll";
            this.butShowAll.Size = new System.Drawing.Size(133, 28);
            this.butShowAll.TabIndex = 26;
            this.butShowAll.Text = "Show All";
            this.butShowAll.UseVisualStyleBackColor = true;
            this.butShowAll.Click += new System.EventHandler(this.butShowAll_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(623, 58);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(133, 28);
            this.butDelete.TabIndex = 25;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butSearch
            // 
            this.butSearch.BackColor = System.Drawing.Color.White;
            this.butSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butSearch.Location = new System.Drawing.Point(447, 58);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(133, 28);
            this.butSearch.TabIndex = 24;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = false;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butupdate
            // 
            this.butupdate.Location = new System.Drawing.Point(254, 345);
            this.butupdate.Name = "butupdate";
            this.butupdate.Size = new System.Drawing.Size(133, 28);
            this.butupdate.TabIndex = 23;
            this.butupdate.Text = "Update";
            this.butupdate.UseVisualStyleBackColor = true;
            this.butupdate.Click += new System.EventHandler(this.butupdate_Click);
            // 
            // butsave
            // 
            this.butsave.Location = new System.Drawing.Point(59, 345);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(133, 28);
            this.butsave.TabIndex = 22;
            this.butsave.Text = "Save";
            this.butsave.UseVisualStyleBackColor = true;
            this.butsave.Click += new System.EventHandler(this.butsave_Click);
            // 
            // comboCompany
            // 
            this.comboCompany.FormattingEnabled = true;
            this.comboCompany.Location = new System.Drawing.Point(173, 255);
            this.comboCompany.Name = "comboCompany";
            this.comboCompany.Size = new System.Drawing.Size(172, 24);
            this.comboCompany.TabIndex = 21;
            // 
            // labCatname
            // 
            this.labCatname.AutoSize = true;
            this.labCatname.Location = new System.Drawing.Point(56, 255);
            this.labCatname.Name = "labCatname";
            this.labCatname.Size = new System.Drawing.Size(106, 16);
            this.labCatname.TabIndex = 20;
            this.labCatname.Text = "Category_Name";
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(173, 188);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(172, 22);
            this.textPrice.TabIndex = 19;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(173, 131);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(172, 22);
            this.textName.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Product_Price";
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.Location = new System.Drawing.Point(56, 131);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(97, 16);
            this.labname.TabIndex = 16;
            this.labname.Text = "Product_Name";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(173, 62);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(172, 22);
            this.textId.TabIndex = 15;
            // 
            // labid
            // 
            this.labid.AutoSize = true;
            this.labid.Location = new System.Drawing.Point(56, 65);
            this.labid.Name = "labid";
            this.labid.Size = new System.Drawing.Size(64, 16);
            this.labid.TabIndex = 14;
            this.labid.Text = "ProductId";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 413);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butShowAll);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.butupdate);
            this.Controls.Add(this.butsave);
            this.Controls.Add(this.comboCompany);
            this.Controls.Add(this.labCatname);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labname);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.labid);
            this.Name = "Form3";
            this.Text = "Disconnected Demo";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butShowAll;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button butupdate;
        private System.Windows.Forms.Button butsave;
        private System.Windows.Forms.ComboBox comboCompany;
        private System.Windows.Forms.Label labCatname;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label labid;
    }
}