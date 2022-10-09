namespace BlackLotusClientApp.Forms
{
    partial class FormFlower
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFlower = new System.Windows.Forms.DataGridView();
            this.lblFlowerName = new System.Windows.Forms.Label();
            this.lblFlowerDescriptoin = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCategoty = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtFlowerName = new System.Windows.Forms.TextBox();
            this.txtFlowerDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtFlowerID = new System.Windows.Forms.TextBox();
            this.lblFlowerID = new System.Windows.Forms.Label();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnReFress = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlower)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFlower
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlower.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFlower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlower.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFlower.Location = new System.Drawing.Point(279, 87);
            this.dgvFlower.Name = "dgvFlower";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlower.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFlower.Size = new System.Drawing.Size(509, 351);
            this.dgvFlower.TabIndex = 0;
            this.dgvFlower.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFlower_CellContentClick);
            // 
            // lblFlowerName
            // 
            this.lblFlowerName.AutoSize = true;
            this.lblFlowerName.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlowerName.Location = new System.Drawing.Point(13, 63);
            this.lblFlowerName.Name = "lblFlowerName";
            this.lblFlowerName.Size = new System.Drawing.Size(115, 25);
            this.lblFlowerName.TabIndex = 1;
            this.lblFlowerName.Text = "Flower Name :";
            this.lblFlowerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlowerDescriptoin
            // 
            this.lblFlowerDescriptoin.AutoSize = true;
            this.lblFlowerDescriptoin.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlowerDescriptoin.Location = new System.Drawing.Point(12, 122);
            this.lblFlowerDescriptoin.Name = "lblFlowerDescriptoin";
            this.lblFlowerDescriptoin.Size = new System.Drawing.Size(102, 25);
            this.lblFlowerDescriptoin.TabIndex = 2;
            this.lblFlowerDescriptoin.Text = "Description :";
            this.lblFlowerDescriptoin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(13, 297);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(63, 25);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "Stock  :";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategoty
            // 
            this.lblCategoty.AutoSize = true;
            this.lblCategoty.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoty.Location = new System.Drawing.Point(12, 238);
            this.lblCategoty.Name = "lblCategoty";
            this.lblCategoty.Size = new System.Drawing.Size(140, 25);
            this.lblCategoty.TabIndex = 4;
            this.lblCategoty.Text = "Flower Category :";
            this.lblCategoty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(13, 181);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(55, 25);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price :\r\n";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFlowerName
            // 
            this.txtFlowerName.Location = new System.Drawing.Point(25, 91);
            this.txtFlowerName.Multiline = true;
            this.txtFlowerName.Name = "txtFlowerName";
            this.txtFlowerName.Size = new System.Drawing.Size(240, 24);
            this.txtFlowerName.TabIndex = 6;
            // 
            // txtFlowerDescription
            // 
            this.txtFlowerDescription.Location = new System.Drawing.Point(25, 150);
            this.txtFlowerDescription.Multiline = true;
            this.txtFlowerDescription.Name = "txtFlowerDescription";
            this.txtFlowerDescription.Size = new System.Drawing.Size(240, 24);
            this.txtFlowerDescription.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(25, 207);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(240, 24);
            this.txtPrice.TabIndex = 8;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(25, 265);
            this.txtCategory.Multiline = true;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(240, 24);
            this.txtCategory.TabIndex = 9;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(25, 323);
            this.txtStock.Multiline = true;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(240, 24);
            this.txtStock.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(101, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(190, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtFlowerID
            // 
            this.txtFlowerID.Location = new System.Drawing.Point(25, 36);
            this.txtFlowerID.Multiline = true;
            this.txtFlowerID.Name = "txtFlowerID";
            this.txtFlowerID.Size = new System.Drawing.Size(151, 24);
            this.txtFlowerID.TabIndex = 15;
            // 
            // lblFlowerID
            // 
            this.lblFlowerID.AutoSize = true;
            this.lblFlowerID.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlowerID.Location = new System.Drawing.Point(13, 8);
            this.lblFlowerID.Name = "lblFlowerID";
            this.lblFlowerID.Size = new System.Drawing.Size(81, 25);
            this.lblFlowerID.TabIndex = 14;
            this.lblFlowerID.Text = "Flower ID:";
            this.lblFlowerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(190, 37);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 16;
            this.btnGet.Text = "Get By ID";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnReFress
            // 
            this.btnReFress.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReFress.Location = new System.Drawing.Point(665, 37);
            this.btnReFress.Name = "btnReFress";
            this.btnReFress.Size = new System.Drawing.Size(75, 23);
            this.btnReFress.TabIndex = 17;
            this.btnReFress.Text = "ReFresh";
            this.btnReFress.UseVisualStyleBackColor = true;
            this.btnReFress.Click += new System.EventHandler(this.btnReFress_Click);
            // 
            // FormFlower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReFress);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtFlowerID);
            this.Controls.Add(this.lblFlowerID);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtFlowerDescription);
            this.Controls.Add(this.txtFlowerName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCategoty);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblFlowerDescriptoin);
            this.Controls.Add(this.lblFlowerName);
            this.Controls.Add(this.dgvFlower);
            this.Name = "FormFlower";
            this.Text = "FormFlower";
            this.Load += new System.EventHandler(this.FormFlower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFlower;
        private System.Windows.Forms.Label lblFlowerName;
        private System.Windows.Forms.Label lblFlowerDescriptoin;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblCategoty;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtFlowerName;
        private System.Windows.Forms.TextBox txtFlowerDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtFlowerID;
        private System.Windows.Forms.Label lblFlowerID;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnReFress;
    }
}