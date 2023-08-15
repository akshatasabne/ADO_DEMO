namespace ADO_DEMO
{
    partial class Form2
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
            this.labeid = new System.Windows.Forms.Label();
            this.labename = new System.Windows.Forms.Label();
            this.labesalary = new System.Windows.Forms.Label();
            this.labDpart = new System.Windows.Forms.Label();
            this.texteid = new System.Windows.Forms.TextBox();
            this.textename = new System.Windows.Forms.TextBox();
            this.textesalary = new System.Windows.Forms.TextBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.ButSave = new System.Windows.Forms.Button();
            this.butUpdate = new System.Windows.Forms.Button();
            this.butSearch = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labeid
            // 
            this.labeid.AutoSize = true;
            this.labeid.Location = new System.Drawing.Point(244, 66);
            this.labeid.Name = "labeid";
            this.labeid.Size = new System.Drawing.Size(85, 16);
            this.labeid.TabIndex = 0;
            this.labeid.Text = "Employee ID";
            // 
            // labename
            // 
            this.labename.AutoSize = true;
            this.labename.Location = new System.Drawing.Point(244, 123);
            this.labename.Name = "labename";
            this.labename.Size = new System.Drawing.Size(109, 16);
            this.labename.TabIndex = 1;
            this.labename.Text = "Employee Name";
            // 
            // labesalary
            // 
            this.labesalary.AutoSize = true;
            this.labesalary.Location = new System.Drawing.Point(244, 197);
            this.labesalary.Name = "labesalary";
            this.labesalary.Size = new System.Drawing.Size(111, 16);
            this.labesalary.TabIndex = 2;
            this.labesalary.Text = "Employee Salary";
            // 
            // labDpart
            // 
            this.labDpart.AutoSize = true;
            this.labDpart.Location = new System.Drawing.Point(244, 251);
            this.labDpart.Name = "labDpart";
            this.labDpart.Size = new System.Drawing.Size(77, 16);
            this.labDpart.TabIndex = 3;
            this.labDpart.Text = "Department";
            // 
            // texteid
            // 
            this.texteid.Location = new System.Drawing.Point(440, 66);
            this.texteid.Name = "texteid";
            this.texteid.Size = new System.Drawing.Size(132, 22);
            this.texteid.TabIndex = 4;
            // 
            // textename
            // 
            this.textename.Location = new System.Drawing.Point(440, 123);
            this.textename.Name = "textename";
            this.textename.Size = new System.Drawing.Size(132, 22);
            this.textename.TabIndex = 5;
            // 
            // textesalary
            // 
            this.textesalary.Location = new System.Drawing.Point(440, 191);
            this.textesalary.Name = "textesalary";
            this.textesalary.Size = new System.Drawing.Size(132, 22);
            this.textesalary.TabIndex = 6;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(440, 251);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(132, 24);
            this.cmbDepartment.TabIndex = 7;
            // 
            // ButSave
            // 
            this.ButSave.Location = new System.Drawing.Point(92, 327);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(75, 48);
            this.ButSave.TabIndex = 8;
            this.ButSave.Text = "Save";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // butUpdate
            // 
            this.butUpdate.Location = new System.Drawing.Point(279, 327);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(75, 48);
            this.butUpdate.TabIndex = 9;
            this.butUpdate.Text = "Update";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(440, 327);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(75, 51);
            this.butSearch.TabIndex = 10;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(633, 324);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(75, 51);
            this.butDel.TabIndex = 11;
            this.butDel.Text = "Delete";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.textesalary);
            this.Controls.Add(this.textename);
            this.Controls.Add(this.texteid);
            this.Controls.Add(this.labDpart);
            this.Controls.Add(this.labesalary);
            this.Controls.Add(this.labename);
            this.Controls.Add(this.labeid);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeid;
        private System.Windows.Forms.Label labename;
        private System.Windows.Forms.Label labesalary;
        private System.Windows.Forms.Label labDpart;
        private System.Windows.Forms.TextBox texteid;
        private System.Windows.Forms.TextBox textename;
        private System.Windows.Forms.TextBox textesalary;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Button ButSave;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button butDel;
    }
}