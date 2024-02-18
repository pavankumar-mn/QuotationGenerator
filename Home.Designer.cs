namespace RegistrationAndLogin
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnPReg = new System.Windows.Forms.Button();
            this.btnSReg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetQuotation = new System.Windows.Forms.Button();
            this.cbSchool = new System.Windows.Forms.ComboBox();
            this.schoolsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quotationsDataSetSchoolListing = new RegistrationAndLogin.QuotationsDataSetSchoolListing();
            this.labBrand = new System.Windows.Forms.Label();
            this.labSchool = new System.Windows.Forms.Label();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quotationsDataSetProductDrop = new RegistrationAndLogin.QuotationsDataSetProductDrop();
            this.labGetQuotation = new System.Windows.Forms.Label();
            this.schoolsTableAdapter = new RegistrationAndLogin.QuotationsDataSetSchoolListingTableAdapters.SchoolsTableAdapter();
            this.distinctFillToolStrip = new System.Windows.Forms.ToolStrip();
            this.distinctFillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.productsTableAdapter = new RegistrationAndLogin.QuotationsDataSetProductDropTableAdapters.ProductsTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotationsDataSetSchoolListing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotationsDataSetProductDrop)).BeginInit();
            this.distinctFillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(197, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome , This is your dashboard ...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreateUser);
            this.panel1.Controls.Add(this.btnPReg);
            this.panel1.Controls.Add(this.btnSReg);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(30, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 95);
            this.panel1.TabIndex = 1;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(363, 43);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(129, 40);
            this.btnCreateUser.TabIndex = 3;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnPReg
            // 
            this.btnPReg.Location = new System.Drawing.Point(212, 43);
            this.btnPReg.Name = "btnPReg";
            this.btnPReg.Size = new System.Drawing.Size(104, 40);
            this.btnPReg.TabIndex = 2;
            this.btnPReg.Text = "Product";
            this.btnPReg.UseVisualStyleBackColor = true;
            this.btnPReg.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSReg
            // 
            this.btnSReg.Location = new System.Drawing.Point(84, 43);
            this.btnSReg.Name = "btnSReg";
            this.btnSReg.Size = new System.Drawing.Size(93, 40);
            this.btnSReg.TabIndex = 1;
            this.btnSReg.Text = "School";
            this.btnSReg.UseVisualStyleBackColor = true;
            this.btnSReg.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Registration Forms";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.lbLocation);
            this.panel2.Controls.Add(this.txtLocation);
            this.panel2.Controls.Add(this.txtDiscount);
            this.panel2.Controls.Add(this.lbDiscount);
            this.panel2.Controls.Add(this.cbModel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnGetQuotation);
            this.panel2.Controls.Add(this.cbSchool);
            this.panel2.Controls.Add(this.labBrand);
            this.panel2.Controls.Add(this.labSchool);
            this.panel2.Controls.Add(this.cbBrand);
            this.panel2.Controls.Add(this.labGetQuotation);
            this.panel2.Location = new System.Drawing.Point(30, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 373);
            this.panel2.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(848, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(89, 35);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocation.Location = new System.Drawing.Point(302, 156);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(86, 25);
            this.lbLocation.TabIndex = 13;
            this.lbLocation.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(401, 157);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(155, 26);
            this.txtLocation.TabIndex = 9;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(151, 158);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 26);
            this.txtDiscount.TabIndex = 8;
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.Location = new System.Drawing.Point(21, 157);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(111, 25);
            this.lbDiscount.TabIndex = 9;
            this.lbDiscount.Text = "Discount %";
            // 
            // cbModel
            // 
            this.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(762, 76);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(175, 28);
            this.cbModel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(679, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Model";
            // 
            // btnGetQuotation
            // 
            this.btnGetQuotation.Location = new System.Drawing.Point(694, 247);
            this.btnGetQuotation.Name = "btnGetQuotation";
            this.btnGetQuotation.Size = new System.Drawing.Size(141, 60);
            this.btnGetQuotation.TabIndex = 10;
            this.btnGetQuotation.Text = "Get Quotation";
            this.btnGetQuotation.UseVisualStyleBackColor = true;
            this.btnGetQuotation.Click += new System.EventHandler(this.btnGetQuotation_Click);
            // 
            // cbSchool
            // 
            this.cbSchool.DataSource = this.schoolsBindingSource;
            this.cbSchool.DisplayMember = "SchoolName";
            this.cbSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSchool.FormattingEnabled = true;
            this.cbSchool.Location = new System.Drawing.Point(93, 73);
            this.cbSchool.Name = "cbSchool";
            this.cbSchool.Size = new System.Drawing.Size(228, 28);
            this.cbSchool.TabIndex = 5;
            this.cbSchool.ValueMember = "SchoolId";
            // 
            // schoolsBindingSource
            // 
            this.schoolsBindingSource.DataMember = "Schools";
            this.schoolsBindingSource.DataSource = this.quotationsDataSetSchoolListing;
            // 
            // quotationsDataSetSchoolListing
            // 
            this.quotationsDataSetSchoolListing.DataSetName = "QuotationsDataSetSchoolListing";
            this.quotationsDataSetSchoolListing.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labBrand
            // 
            this.labBrand.AutoSize = true;
            this.labBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBrand.Location = new System.Drawing.Point(358, 76);
            this.labBrand.Name = "labBrand";
            this.labBrand.Size = new System.Drawing.Size(64, 25);
            this.labBrand.TabIndex = 4;
            this.labBrand.Text = "Brand";
            // 
            // labSchool
            // 
            this.labSchool.AutoSize = true;
            this.labSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSchool.Location = new System.Drawing.Point(14, 73);
            this.labSchool.Name = "labSchool";
            this.labSchool.Size = new System.Drawing.Size(73, 25);
            this.labSchool.TabIndex = 3;
            this.labSchool.Text = "School";
            // 
            // cbBrand
            // 
            this.cbBrand.DataSource = this.productsBindingSource;
            this.cbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(428, 74);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(200, 28);
            this.cbBrand.TabIndex = 6;
            this.cbBrand.ValueMember = "Brand";
            this.cbBrand.SelectedIndexChanged += new System.EventHandler(this.cbBrand_SelectedIndexChanged);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.quotationsDataSetProductDrop;
            // 
            // quotationsDataSetProductDrop
            // 
            this.quotationsDataSetProductDrop.DataSetName = "QuotationsDataSetProductDrop";
            this.quotationsDataSetProductDrop.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labGetQuotation
            // 
            this.labGetQuotation.AutoSize = true;
            this.labGetQuotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGetQuotation.Location = new System.Drawing.Point(4, 0);
            this.labGetQuotation.Name = "labGetQuotation";
            this.labGetQuotation.Size = new System.Drawing.Size(133, 25);
            this.labGetQuotation.TabIndex = 0;
            this.labGetQuotation.Text = "Get Quotation";
            // 
            // schoolsTableAdapter
            // 
            this.schoolsTableAdapter.ClearBeforeFill = true;
            // 
            // distinctFillToolStrip
            // 
            this.distinctFillToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.distinctFillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.distinctFillToolStripButton});
            this.distinctFillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.distinctFillToolStrip.Name = "distinctFillToolStrip";
            this.distinctFillToolStrip.Size = new System.Drawing.Size(1070, 34);
            this.distinctFillToolStrip.TabIndex = 3;
            this.distinctFillToolStrip.Text = "distinctFillToolStrip";
            // 
            // distinctFillToolStripButton
            // 
            this.distinctFillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.distinctFillToolStripButton.Name = "distinctFillToolStripButton";
            this.distinctFillToolStripButton.Size = new System.Drawing.Size(96, 29);
            this.distinctFillToolStripButton.Text = "DistinctFill";
            this.distinctFillToolStripButton.Click += new System.EventHandler(this.distinctFillToolStripButton_Click);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 666);
            this.Controls.Add(this.distinctFillToolStrip);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotationsDataSetSchoolListing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotationsDataSetProductDrop)).EndInit();
            this.distinctFillToolStrip.ResumeLayout(false);
            this.distinctFillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPReg;
        private System.Windows.Forms.Button btnSReg;
        private System.Windows.Forms.Label labGetQuotation;
        private System.Windows.Forms.Label labSchool;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.Label labBrand;
        private System.Windows.Forms.ComboBox cbSchool;
        private System.Windows.Forms.Button btnGetQuotation;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Button btnCreateUser;
        private QuotationsDataSetSchoolListing quotationsDataSetSchoolListing;
        private System.Windows.Forms.BindingSource schoolsBindingSource;
        private QuotationsDataSetSchoolListingTableAdapters.SchoolsTableAdapter schoolsTableAdapter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStrip distinctFillToolStrip;
        private System.Windows.Forms.ToolStripButton distinctFillToolStripButton;
        private QuotationsDataSetProductDrop quotationsDataSetProductDrop;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private QuotationsDataSetProductDropTableAdapters.ProductsTableAdapter productsTableAdapter;
    }
}