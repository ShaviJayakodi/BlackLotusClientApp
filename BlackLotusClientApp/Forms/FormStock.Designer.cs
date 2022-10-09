namespace BlackLotusClientApp.Forms
{
    partial class FormStock
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
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.lblStockId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStockName = new System.Windows.Forms.Label();
            this.txtStockID = new System.Windows.Forms.TextBox();
            this.txtStockName = new System.Windows.Forms.TextBox();
            this.txtFlowerID = new System.Windows.Forms.TextBox();
            this.txtQuentity = new System.Windows.Forms.TextBox();
            this.btdAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(290, 82);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.Size = new System.Drawing.Size(448, 282);
            this.dgvStock.TabIndex = 0;
            this.dgvStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellContentClick);
            // 
            // lblStockId
            // 
            this.lblStockId.AutoSize = true;
            this.lblStockId.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockId.Location = new System.Drawing.Point(12, 63);
            this.lblStockId.Name = "lblStockId";
            this.lblStockId.Size = new System.Drawing.Size(70, 25);
            this.lblStockId.TabIndex = 1;
            this.lblStockId.Text = "Stock ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Flower ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quentity";
            // 
            // lblStockName
            // 
            this.lblStockName.AutoSize = true;
            this.lblStockName.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockName.Location = new System.Drawing.Point(12, 128);
            this.lblStockName.Name = "lblStockName";
            this.lblStockName.Size = new System.Drawing.Size(101, 25);
            this.lblStockName.TabIndex = 4;
            this.lblStockName.Text = "Stock Name";
            // 
            // txtStockID
            // 
            this.txtStockID.Location = new System.Drawing.Point(32, 91);
            this.txtStockID.Multiline = true;
            this.txtStockID.Name = "txtStockID";
            this.txtStockID.Size = new System.Drawing.Size(232, 25);
            this.txtStockID.TabIndex = 5;
            // 
            // txtStockName
            // 
            this.txtStockName.Location = new System.Drawing.Point(32, 156);
            this.txtStockName.Multiline = true;
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.Size = new System.Drawing.Size(232, 25);
            this.txtStockName.TabIndex = 6;
            // 
            // txtFlowerID
            // 
            this.txtFlowerID.Location = new System.Drawing.Point(32, 286);
            this.txtFlowerID.Multiline = true;
            this.txtFlowerID.Name = "txtFlowerID";
            this.txtFlowerID.Size = new System.Drawing.Size(232, 25);
            this.txtFlowerID.TabIndex = 7;
            // 
            // txtQuentity
            // 
            this.txtQuentity.Location = new System.Drawing.Point(32, 221);
            this.txtQuentity.Multiline = true;
            this.txtQuentity.Name = "txtQuentity";
            this.txtQuentity.Size = new System.Drawing.Size(232, 25);
            this.txtQuentity.TabIndex = 8;
            // 
            // btdAdd
            // 
            this.btdAdd.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdAdd.Location = new System.Drawing.Point(13, 340);
            this.btdAdd.Name = "btdAdd";
            this.btdAdd.Size = new System.Drawing.Size(75, 23);
            this.btdAdd.TabIndex = 9;
            this.btdAdd.Text = "ADD";
            this.btdAdd.UseVisualStyleBackColor = true;
            this.btdAdd.Click += new System.EventHandler(this.btdAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(104, 341);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(203, 341);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(663, 53);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btdAdd);
            this.Controls.Add(this.txtQuentity);
            this.Controls.Add(this.txtFlowerID);
            this.Controls.Add(this.txtStockName);
            this.Controls.Add(this.txtStockID);
            this.Controls.Add(this.lblStockName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStockId);
            this.Controls.Add(this.dgvStock);
            this.Name = "FormStock";
            this.Text = "Stock Management";
            this.Load += new System.EventHandler(this.FormStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Label lblStockId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStockName;
        private System.Windows.Forms.TextBox txtStockID;
        private System.Windows.Forms.TextBox txtStockName;
        private System.Windows.Forms.TextBox txtFlowerID;
        private System.Windows.Forms.TextBox txtQuentity;
        private System.Windows.Forms.Button btdAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
    }
}