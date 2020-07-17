namespace pharmacy
{
    partial class CustomerInvoiceForm
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
            this.addbtn = new System.Windows.Forms.Button();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.custInvGridView = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBal = new System.Windows.Forms.TextBox();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.txtTol = new System.Windows.Forms.TextBox();
            this.txtdrugId = new System.Windows.Forms.TextBox();
            this.txtdruNam = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.payLab = new System.Windows.Forms.Label();
            this.BalLab = new System.Windows.Forms.Label();
            this.drugIdLab = new System.Windows.Forms.Label();
            this.DrugnamLab = new System.Windows.Forms.Label();
            this.PriceLab = new System.Windows.Forms.Label();
            this.TotalLab = new System.Windows.Forms.Label();
            this.qtylab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.custInvGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(975, 430);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(147, 55);
            this.addbtn.TabIndex = 2;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(975, 547);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(147, 59);
            this.PrintBtn.TabIndex = 4;
            this.PrintBtn.Text = "Print Invoice";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // custInvGridView
            // 
            this.custInvGridView.AllowUserToAddRows = false;
            this.custInvGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.custInvGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custInvGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.delete});
            this.custInvGridView.Location = new System.Drawing.Point(12, 359);
            this.custInvGridView.Name = "custInvGridView";
            this.custInvGridView.RowHeadersWidth = 51;
            this.custInvGridView.RowTemplate.Height = 24;
            this.custInvGridView.Size = new System.Drawing.Size(803, 272);
            this.custInvGridView.TabIndex = 6;
            this.custInvGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.custInvGridView_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Drug Id";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Drug Name";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Price";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Quantity";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Total";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Text = "Delete";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 67);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "DEEPAL PHARMACY";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txtBal);
            this.groupBox1.Controls.Add(this.txtPay);
            this.groupBox1.Controls.Add(this.txtTol);
            this.groupBox1.Controls.Add(this.txtdrugId);
            this.groupBox1.Controls.Add(this.txtdruNam);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtqty);
            this.groupBox1.Controls.Add(this.payLab);
            this.groupBox1.Controls.Add(this.BalLab);
            this.groupBox1.Controls.Add(this.drugIdLab);
            this.groupBox1.Controls.Add(this.DrugnamLab);
            this.groupBox1.Controls.Add(this.PriceLab);
            this.groupBox1.Controls.Add(this.TotalLab);
            this.groupBox1.Controls.Add(this.qtylab);
            this.groupBox1.Location = new System.Drawing.Point(22, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1010, 215);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items";
            // 
            // txtBal
            // 
            this.txtBal.Location = new System.Drawing.Point(656, 118);
            this.txtBal.Name = "txtBal";
            this.txtBal.Size = new System.Drawing.Size(173, 22);
            this.txtBal.TabIndex = 24;
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(656, 72);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(173, 22);
            this.txtPay.TabIndex = 23;
            // 
            // txtTol
            // 
            this.txtTol.Location = new System.Drawing.Point(656, 29);
            this.txtTol.Name = "txtTol";
            this.txtTol.Size = new System.Drawing.Size(173, 22);
            this.txtTol.TabIndex = 22;
            // 
            // txtdrugId
            // 
            this.txtdrugId.Location = new System.Drawing.Point(180, 29);
            this.txtdrugId.Name = "txtdrugId";
            this.txtdrugId.Size = new System.Drawing.Size(180, 22);
            this.txtdrugId.TabIndex = 21;
            this.txtdrugId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdrugId_KeyPress);
            // 
            // txtdruNam
            // 
            this.txtdruNam.Location = new System.Drawing.Point(180, 72);
            this.txtdruNam.Name = "txtdruNam";
            this.txtdruNam.Size = new System.Drawing.Size(180, 22);
            this.txtdruNam.TabIndex = 20;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(180, 111);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(180, 22);
            this.txtPrice.TabIndex = 19;
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(180, 153);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(180, 22);
            this.txtqty.TabIndex = 18;
            // 
            // payLab
            // 
            this.payLab.AutoSize = true;
            this.payLab.Location = new System.Drawing.Point(508, 72);
            this.payLab.Name = "payLab";
            this.payLab.Size = new System.Drawing.Size(63, 17);
            this.payLab.TabIndex = 17;
            this.payLab.Text = "Payment";
            // 
            // BalLab
            // 
            this.BalLab.AutoSize = true;
            this.BalLab.Location = new System.Drawing.Point(508, 118);
            this.BalLab.Name = "BalLab";
            this.BalLab.Size = new System.Drawing.Size(59, 17);
            this.BalLab.TabIndex = 16;
            this.BalLab.Text = "Balance";
            // 
            // drugIdLab
            // 
            this.drugIdLab.AutoSize = true;
            this.drugIdLab.Location = new System.Drawing.Point(47, 29);
            this.drugIdLab.Name = "drugIdLab";
            this.drugIdLab.Size = new System.Drawing.Size(54, 17);
            this.drugIdLab.TabIndex = 15;
            this.drugIdLab.Text = "Drug Id";
            // 
            // DrugnamLab
            // 
            this.DrugnamLab.AutoSize = true;
            this.DrugnamLab.Location = new System.Drawing.Point(47, 72);
            this.DrugnamLab.Name = "DrugnamLab";
            this.DrugnamLab.Size = new System.Drawing.Size(80, 17);
            this.DrugnamLab.TabIndex = 14;
            this.DrugnamLab.Text = "Drug Name";
            // 
            // PriceLab
            // 
            this.PriceLab.AutoSize = true;
            this.PriceLab.Location = new System.Drawing.Point(47, 116);
            this.PriceLab.Name = "PriceLab";
            this.PriceLab.Size = new System.Drawing.Size(40, 17);
            this.PriceLab.TabIndex = 13;
            this.PriceLab.Text = "Price";
            // 
            // TotalLab
            // 
            this.TotalLab.AutoSize = true;
            this.TotalLab.Location = new System.Drawing.Point(508, 29);
            this.TotalLab.Name = "TotalLab";
            this.TotalLab.Size = new System.Drawing.Size(40, 17);
            this.TotalLab.TabIndex = 12;
            this.TotalLab.Text = "Total";
            // 
            // qtylab
            // 
            this.qtylab.AutoSize = true;
            this.qtylab.Location = new System.Drawing.Point(47, 158);
            this.qtylab.Name = "qtylab";
            this.qtylab.Size = new System.Drawing.Size(61, 17);
            this.qtylab.TabIndex = 11;
            this.qtylab.Text = "Quantity";
            // 
            // CustomerInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1156, 753);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.custInvGridView);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.addbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerInvoiceForm";
            this.Text = "Customer Invoice";
            ((System.ComponentModel.ISupportInitialize)(this.custInvGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.DataGridView custInvGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBal;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.TextBox txtTol;
        private System.Windows.Forms.TextBox txtdrugId;
        private System.Windows.Forms.TextBox txtdruNam;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label payLab;
        private System.Windows.Forms.Label BalLab;
        private System.Windows.Forms.Label drugIdLab;
        private System.Windows.Forms.Label DrugnamLab;
        private System.Windows.Forms.Label PriceLab;
        private System.Windows.Forms.Label TotalLab;
        private System.Windows.Forms.Label qtylab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}