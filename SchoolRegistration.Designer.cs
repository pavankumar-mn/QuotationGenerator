namespace RegistrationAndLogin
{
    partial class SchoolRegistration
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSchoolname = new System.Windows.Forms.TextBox();
            this.txtSchoolRep = new System.Windows.Forms.TextBox();
            this.txtSchoolAddress = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewSchool = new System.Windows.Forms.DataGridView();
            this.btnSDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.quotationsDataSetSchoolListing = new RegistrationAndLogin.QuotationsDataSetSchoolListing();
            this.schoolsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolsTableAdapter = new RegistrationAndLogin.QuotationsDataSetSchoolListingTableAdapters.SchoolsTableAdapter();
            this.schoolIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolRepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotationsDataSetSchoolListing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "School Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "School Representative";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(684, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // txtSchoolname
            // 
            this.txtSchoolname.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchoolname.Location = new System.Drawing.Point(345, 63);
            this.txtSchoolname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSchoolname.Name = "txtSchoolname";
            this.txtSchoolname.Size = new System.Drawing.Size(250, 41);
            this.txtSchoolname.TabIndex = 1;
            // 
            // txtSchoolRep
            // 
            this.txtSchoolRep.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchoolRep.Location = new System.Drawing.Point(345, 130);
            this.txtSchoolRep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSchoolRep.Name = "txtSchoolRep";
            this.txtSchoolRep.Size = new System.Drawing.Size(250, 41);
            this.txtSchoolRep.TabIndex = 2;
            // 
            // txtSchoolAddress
            // 
            this.txtSchoolAddress.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchoolAddress.Location = new System.Drawing.Point(853, 63);
            this.txtSchoolAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSchoolAddress.Multiline = true;
            this.txtSchoolAddress.Name = "txtSchoolAddress";
            this.txtSchoolAddress.Size = new System.Drawing.Size(250, 115);
            this.txtSchoolAddress.TabIndex = 3;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(911, 217);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(202, 52);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Save";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "School Registrartion";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(911, 474);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewSchool
            // 
            this.dataGridViewSchool.AllowUserToAddRows = false;
            this.dataGridViewSchool.AllowUserToDeleteRows = false;
            this.dataGridViewSchool.AllowUserToOrderColumns = true;
            this.dataGridViewSchool.AutoGenerateColumns = false;
            this.dataGridViewSchool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchool.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.schoolIdDataGridViewTextBoxColumn,
            this.schoolNameDataGridViewTextBoxColumn,
            this.schoolRepDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridViewSchool.DataSource = this.schoolsBindingSource;
            this.dataGridViewSchool.Location = new System.Drawing.Point(55, 217);
            this.dataGridViewSchool.Name = "dataGridViewSchool";
            this.dataGridViewSchool.RowHeadersWidth = 62;
            this.dataGridViewSchool.RowTemplate.Height = 28;
            this.dataGridViewSchool.Size = new System.Drawing.Size(836, 397);
            this.dataGridViewSchool.TabIndex = 8;
            this.dataGridViewSchool.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewSchool_DataError);
            // 
            // btnSDelete
            // 
            this.btnSDelete.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDelete.Location = new System.Drawing.Point(911, 382);
            this.btnSDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSDelete.Name = "btnSDelete";
            this.btnSDelete.Size = new System.Drawing.Size(202, 52);
            this.btnSDelete.TabIndex = 6;
            this.btnSDelete.Text = "Delete";
            this.btnSDelete.UseVisualStyleBackColor = true;
            this.btnSDelete.Click += new System.EventHandler(this.btnSDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(911, 298);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(202, 52);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // quotationsDataSetSchoolListing
            // 
            this.quotationsDataSetSchoolListing.DataSetName = "QuotationsDataSetSchoolListing";
            this.quotationsDataSetSchoolListing.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schoolsBindingSource
            // 
            this.schoolsBindingSource.DataMember = "Schools";
            this.schoolsBindingSource.DataSource = this.quotationsDataSetSchoolListing;
            // 
            // schoolsTableAdapter
            // 
            this.schoolsTableAdapter.ClearBeforeFill = true;
            // 
            // schoolIdDataGridViewTextBoxColumn
            // 
            this.schoolIdDataGridViewTextBoxColumn.DataPropertyName = "SchoolId";
            this.schoolIdDataGridViewTextBoxColumn.HeaderText = "SchoolId";
            this.schoolIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.schoolIdDataGridViewTextBoxColumn.Name = "schoolIdDataGridViewTextBoxColumn";
            this.schoolIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.schoolIdDataGridViewTextBoxColumn.Visible = false;
            this.schoolIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // schoolNameDataGridViewTextBoxColumn
            // 
            this.schoolNameDataGridViewTextBoxColumn.DataPropertyName = "SchoolName";
            this.schoolNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.schoolNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.schoolNameDataGridViewTextBoxColumn.Name = "schoolNameDataGridViewTextBoxColumn";
            this.schoolNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // schoolRepDataGridViewTextBoxColumn
            // 
            this.schoolRepDataGridViewTextBoxColumn.DataPropertyName = "SchoolRep";
            this.schoolRepDataGridViewTextBoxColumn.HeaderText = "Representative";
            this.schoolRepDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.schoolRepDataGridViewTextBoxColumn.Name = "schoolRepDataGridViewTextBoxColumn";
            this.schoolRepDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // SchoolRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 664);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSDelete);
            this.Controls.Add(this.dataGridViewSchool);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtSchoolAddress);
            this.Controls.Add(this.txtSchoolRep);
            this.Controls.Add(this.txtSchoolname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "SchoolRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotationsDataSetSchoolListing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSchoolname;
        private System.Windows.Forms.TextBox txtSchoolRep;
        private System.Windows.Forms.TextBox txtSchoolAddress;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewSchool;
        private System.Windows.Forms.Button btnSDelete;
        private System.Windows.Forms.Button btnUpdate;
        private QuotationsDataSetSchoolListing quotationsDataSetSchoolListing;
        private System.Windows.Forms.BindingSource schoolsBindingSource;
        private QuotationsDataSetSchoolListingTableAdapters.SchoolsTableAdapter schoolsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolRepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}