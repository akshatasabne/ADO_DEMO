namespace ADO_DEMO
{
    partial class Form1
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
            this.labid = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.labname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.labCatname = new System.Windows.Forms.Label();
            this.comboCompany = new System.Windows.Forms.ComboBox();
            this.butsave = new System.Windows.Forms.Button();
            this.butupdate = new System.Windows.Forms.Button();
            this.butSearch = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butShowAll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labid
            // 
            this.labid.AutoSize = true;
            this.labid.Location = new System.Drawing.Point(75, 47);
            this.labid.Name = "labid";
            this.labid.Size = new System.Drawing.Size(64, 16);
            this.labid.TabIndex = 0;
            this.labid.Text = "ProductId";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(192, 44);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(156, 22);
            this.textId.TabIndex = 1;
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.Location = new System.Drawing.Point(75, 113);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(97, 16);
            this.labname.TabIndex = 2;
            this.labname.Text = "Product_Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product_Price";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(192, 113);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(156, 22);
            this.textName.TabIndex = 4;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(192, 170);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(156, 22);
            this.textPrice.TabIndex = 5;
            // 
            // labCatname
            // 
            this.labCatname.AutoSize = true;
            this.labCatname.Location = new System.Drawing.Point(75, 237);
            this.labCatname.Name = "labCatname";
            this.labCatname.Size = new System.Drawing.Size(106, 16);
            this.labCatname.TabIndex = 6;
            this.labCatname.Text = "Category_Name";
            // 
            // comboCompany
            // 
            this.comboCompany.FormattingEnabled = true;
            this.comboCompany.Location = new System.Drawing.Point(192, 237);
            this.comboCompany.Name = "comboCompany";
            this.comboCompany.Size = new System.Drawing.Size(156, 24);
            this.comboCompany.TabIndex = 7;
            // 
            // butsave
            // 
            this.butsave.Location = new System.Drawing.Point(78, 327);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(75, 47);
            this.butsave.TabIndex = 8;
            this.butsave.Text = "Save";
            this.butsave.UseVisualStyleBackColor = true;
            this.butsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // butupdate
            // 
            this.butupdate.Location = new System.Drawing.Point(273, 327);
            this.butupdate.Name = "butupdate";
            this.butupdate.Size = new System.Drawing.Size(75, 47);
            this.butupdate.TabIndex = 9;
            this.butupdate.Text = "Update";
            this.butupdate.UseVisualStyleBackColor = true;
            this.butupdate.Click += new System.EventHandler(this.butupdate_Click);
            // 
            // butSearch
            // 
            this.butSearch.BackColor = System.Drawing.Color.White;
            this.butSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butSearch.Location = new System.Drawing.Point(466, 40);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(75, 40);
            this.butSearch.TabIndex = 10;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = false;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(642, 40);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 40);
            this.butDelete.TabIndex = 11;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butShowAll
            // 
            this.butShowAll.Location = new System.Drawing.Point(569, 327);
            this.butShowAll.Name = "butShowAll";
            this.butShowAll.Size = new System.Drawing.Size(75, 47);
            this.butShowAll.TabIndex = 12;
            this.butShowAll.Text = "Show All";
            this.butShowAll.UseVisualStyleBackColor = true;
            this.butShowAll.Click += new System.EventHandler(this.butShowAll_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(394, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(369, 187);
            this.dataGridView1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
            this.Text = "ADO Connection";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labid;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label labCatname;
        private System.Windows.Forms.ComboBox comboCompany;
        private System.Windows.Forms.Button butsave;
        private System.Windows.Forms.Button butupdate;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butShowAll;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

