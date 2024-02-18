namespace RegistrationAndLogin
{
    partial class ProductRegistration
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
            this.btnPClose = new System.Windows.Forms.Button();
            this.labelProduct = new System.Windows.Forms.Label();
            this.btnProductRegister = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.txtMrp = new System.Windows.Forms.TextBox();
            this.labelMRP = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.btnPDelete = new System.Windows.Forms.Button();
            this.btnPUpdate = new System.Windows.Forms.Button();
            this.quotationsDataSetProductListing = new RegistrationAndLogin.QuotationsDataSetProductListing();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new RegistrationAndLogin.QuotationsDataSetProductListingTableAdapters.ProductsTableAdapter();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotationsDataSetProductListing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPClose
            // 
            this.btnPClose.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPClose.Location = new System.Drawing.Point(905, 474);
            this.btnPClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPClose.Name = "btnPClose";
            this.btnPClose.Size = new System.Drawing.Size(146, 52);
            this.btnPClose.TabIndex = 9;
            this.btnPClose.Text = "Close";
            this.btnPClose.UseVisualStyleBackColor = true;
            this.btnPClose.Click += new System.EventHandler(this.btnPClose_Click);
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.Location = new System.Drawing.Point(372, 9);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(281, 32);
            this.labelProduct.TabIndex = 14;
            this.labelProduct.Text = "Product Registrartion";
            // 
            // btnProductRegister
            // 
            this.btnProductRegister.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductRegister.Location = new System.Drawing.Point(905, 219);
            this.btnProductRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProductRegister.Name = "btnProductRegister";
            this.btnProductRegister.Size = new System.Drawing.Size(142, 52);
            this.btnProductRegister.TabIndex = 6;
            this.btnProductRegister.Text = "Save";
            this.btnProductRegister.UseVisualStyleBackColor = true;
            this.btnProductRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(514, 63);
            this.txtColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColor.Multiline = true;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(250, 43);
            this.txtColor.TabIndex = 3;
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(132, 123);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(250, 41);
            this.txtModel.TabIndex = 2;
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.Location = new System.Drawing.Point(132, 63);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(250, 41);
            this.txtBrand.TabIndex = 1;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.Location = new System.Drawing.Point(417, 61);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(73, 33);
            this.labelColor.TabIndex = 11;
            this.labelColor.Text = "Color";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModel.Location = new System.Drawing.Point(36, 123);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(83, 33);
            this.labelModel.TabIndex = 9;
            this.labelModel.Text = "Model";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrand.Location = new System.Drawing.Point(36, 61);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(80, 33);
            this.labelBrand.TabIndex = 7;
            this.labelBrand.Text = "Brand";
            // 
            // txtMrp
            // 
            this.txtMrp.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMrp.Location = new System.Drawing.Point(797, 115);
            this.txtMrp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMrp.Name = "txtMrp";
            this.txtMrp.Size = new System.Drawing.Size(250, 41);
            this.txtMrp.TabIndex = 5;
            this.txtMrp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // labelMRP
            // 
            this.labelMRP.AutoSize = true;
            this.labelMRP.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMRP.Location = new System.Drawing.Point(876, 66);
            this.labelMRP.Name = "labelMRP";
            this.labelMRP.Size = new System.Drawing.Size(64, 33);
            this.labelMRP.TabIndex = 16;
            this.labelMRP.Text = "MRP";
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(514, 123);
            this.txtSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSize.Multiline = true;
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(250, 43);
            this.txtSize.TabIndex = 4;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.Location = new System.Drawing.Point(417, 126);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(65, 33);
            this.labelSize.TabIndex = 18;
            this.labelSize.Text = "Size";
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.AllowUserToDeleteRows = false;
            this.dataGridViewProduct.AutoGenerateColumns = false;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.mRPDataGridViewTextBoxColumn});
            this.dataGridViewProduct.DataSource = this.productsBindingSource;
            this.dataGridViewProduct.Location = new System.Drawing.Point(23, 199);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersWidth = 62;
            this.dataGridViewProduct.RowTemplate.Height = 28;
            this.dataGridViewProduct.Size = new System.Drawing.Size(865, 470);
            this.dataGridViewProduct.TabIndex = 10;
            this.dataGridViewProduct.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewProduct_DataError);
            // 
            // btnPDelete
            // 
            this.btnPDelete.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDelete.Location = new System.Drawing.Point(905, 385);
            this.btnPDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPDelete.Name = "btnPDelete";
            this.btnPDelete.Size = new System.Drawing.Size(142, 52);
            this.btnPDelete.TabIndex = 8;
            this.btnPDelete.Text = "Delete";
            this.btnPDelete.UseVisualStyleBackColor = true;
            this.btnPDelete.Click += new System.EventHandler(this.btnPDelete_Click);
            // 
            // btnPUpdate
            // 
            this.btnPUpdate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPUpdate.Location = new System.Drawing.Point(905, 300);
            this.btnPUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPUpdate.Name = "btnPUpdate";
            this.btnPUpdate.Size = new System.Drawing.Size(142, 52);
            this.btnPUpdate.TabIndex = 7;
            this.btnPUpdate.Text = "Update";
            this.btnPUpdate.UseVisualStyleBackColor = true;
            this.btnPUpdate.Click += new System.EventHandler(this.btnPUpdate_Click);
            // 
            // quotationsDataSetProductListing
            // 
            this.quotationsDataSetProductListing.DataSetName = "QuotationsDataSetProductListing";
            this.quotationsDataSetProductListing.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.quotationsDataSetProductListing;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIdDataGridViewTextBoxColumn.Visible = false;
            this.productIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.Width = 150;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 150;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.Width = 150;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.Width = 150;
            // 
            // mRPDataGridViewTextBoxColumn
            // 
            this.mRPDataGridViewTextBoxColumn.DataPropertyName = "MRP";
            this.mRPDataGridViewTextBoxColumn.HeaderText = "MRP";
            this.mRPDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mRPDataGridViewTextBoxColumn.Name = "mRPDataGridViewTextBoxColumn";
            this.mRPDataGridViewTextBoxColumn.Width = 150;
            // 
            // ProductRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 681);
            this.Controls.Add(this.btnPUpdate);
            this.Controls.Add(this.btnPDelete);
            this.Controls.Add(this.dataGridViewProduct);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.txtMrp);
            this.Controls.Add(this.labelMRP);
            this.Controls.Add(this.btnPClose);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.btnProductRegister);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelBrand);
            this.Name = "ProductRegistration";
            this.Text = "ProductRegistration";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotationsDataSetProductListing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPClose;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Button btnProductRegister;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.TextBox txtMrp;
        private System.Windows.Forms.Label labelMRP;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Button btnPDelete;
        private System.Windows.Forms.Button btnPUpdate;
        private QuotationsDataSetProductListing quotationsDataSetProductListing;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private QuotationsDataSetProductListingTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRPDataGridViewTextBoxColumn;
    }
}