namespace Little_SalesTaxCalc_Project
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
            this.Lbl_Billy_Bobs = new System.Windows.Forms.Label();
            this.lblVehiclePrice = new System.Windows.Forms.Label();
            this.lblWarranty = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.ListWarranty = new System.Windows.Forms.ListBox();
            this.ListState = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_Billy_Bobs
            // 
            this.Lbl_Billy_Bobs.AutoSize = true;
            this.Lbl_Billy_Bobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Lbl_Billy_Bobs.Location = new System.Drawing.Point(109, 56);
            this.Lbl_Billy_Bobs.Name = "Lbl_Billy_Bobs";
            this.Lbl_Billy_Bobs.Size = new System.Drawing.Size(491, 31);
            this.Lbl_Billy_Bobs.TabIndex = 0;
            this.Lbl_Billy_Bobs.Text = "Billy Bob\'s Vehicle Sales Tax Calculator";
            // 
            // lblVehiclePrice
            // 
            this.lblVehiclePrice.AutoSize = true;
            this.lblVehiclePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblVehiclePrice.Location = new System.Drawing.Point(124, 151);
            this.lblVehiclePrice.Name = "lblVehiclePrice";
            this.lblVehiclePrice.Size = new System.Drawing.Size(182, 25);
            this.lblVehiclePrice.TabIndex = 1;
            this.lblVehiclePrice.Text = "Vehicle Base Price:";
            this.lblVehiclePrice.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblWarranty
            // 
            this.lblWarranty.AutoSize = true;
            this.lblWarranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblWarranty.Location = new System.Drawing.Point(126, 247);
            this.lblWarranty.Name = "lblWarranty";
            this.lblWarranty.Size = new System.Drawing.Size(180, 25);
            this.lblWarranty.TabIndex = 2;
            this.lblWarranty.Text = "Extended warranty:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblState.Location = new System.Drawing.Point(197, 349);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(109, 25);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "State Sold:";
            // 
            // ListWarranty
            // 
            this.ListWarranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ListWarranty.FormattingEnabled = true;
            this.ListWarranty.ItemHeight = 25;
            this.ListWarranty.Items.AddRange(new object[] {
            "No warranty",
            "One Year",
            "Two Year",
            "Three Year"});
            this.ListWarranty.Location = new System.Drawing.Point(323, 247);
            this.ListWarranty.Name = "ListWarranty";
            this.ListWarranty.Size = new System.Drawing.Size(184, 29);
            this.ListWarranty.TabIndex = 4;
            // 
            // ListState
            // 
            this.ListState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ListState.FormattingEnabled = true;
            this.ListState.ItemHeight = 25;
            this.ListState.Items.AddRange(new object[] {
            "WA",
            "OR"});
            this.ListState.Location = new System.Drawing.Point(323, 349);
            this.ListState.Name = "ListState";
            this.ListState.Size = new System.Drawing.Size(74, 29);
            this.ListState.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCalculate.Location = new System.Drawing.Point(478, 341);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(137, 37);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnClear.Location = new System.Drawing.Point(357, 455);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 47);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnExit.Location = new System.Drawing.Point(526, 455);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 46);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtMoney.Location = new System.Drawing.Point(323, 151);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(184, 30);
            this.txtMoney.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(736, 545);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.ListState);
            this.Controls.Add(this.ListWarranty);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblWarranty);
            this.Controls.Add(this.lblVehiclePrice);
            this.Controls.Add(this.Lbl_Billy_Bobs);
            this.Name = "Form1";
            this.Text = "Billy Bob\'s Vehicle Sales Tax Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Billy_Bobs;
        private System.Windows.Forms.Label lblVehiclePrice;
        private System.Windows.Forms.Label lblWarranty;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ListBox ListWarranty;
        private System.Windows.Forms.ListBox ListState;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMoney;
    }
}

