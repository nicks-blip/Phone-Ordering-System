namespace Phone_Ordering_System
{
    partial class frmPhoneOrdering
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            grpPhoneOrder = new GroupBox();
            picPinkPhone = new PictureBox();
            picBluePhone = new PictureBox();
            nudPinkQuantity = new NumericUpDown();
            lblPinkPhones = new Label();
            nudBlueQuantity = new NumericUpDown();
            lblBluePhones = new Label();
            grpOrderSummary = new GroupBox();
            lblTotalValue = new Label();
            lblTotalText = new Label();
            lblTaxValue = new Label();
            lblTaxText = new Label();
            lblSubtotalValue = new Label();
            lblSubtotalText = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            grpPhoneOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPinkPhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBluePhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPinkQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBlueQuantity).BeginInit();
            grpOrderSummary.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.FromArgb(0, 192, 0);
            lblTitle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(324, 42);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(522, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "PHONE ORDERING SYSTEM.";
            lblTitle.Click += label1_Click;
            // 
            // grpPhoneOrder
            // 
            grpPhoneOrder.BackColor = Color.FromArgb(255, 255, 192);
            grpPhoneOrder.Controls.Add(picPinkPhone);
            grpPhoneOrder.Controls.Add(picBluePhone);
            grpPhoneOrder.Controls.Add(nudPinkQuantity);
            grpPhoneOrder.Controls.Add(lblPinkPhones);
            grpPhoneOrder.Controls.Add(nudBlueQuantity);
            grpPhoneOrder.Controls.Add(lblBluePhones);
            grpPhoneOrder.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpPhoneOrder.ForeColor = Color.Black;
            grpPhoneOrder.Location = new Point(40, 127);
            grpPhoneOrder.Name = "grpPhoneOrder";
            grpPhoneOrder.Size = new Size(512, 393);
            grpPhoneOrder.TabIndex = 1;
            grpPhoneOrder.TabStop = false;
            grpPhoneOrder.Text = "PHONE ORDER";
            // 
            // picPinkPhone
            // 
            picPinkPhone.BorderStyle = BorderStyle.FixedSingle;
            picPinkPhone.Image = Properties.Resources.images__1_;
            picPinkPhone.Location = new Point(46, 234);
            picPinkPhone.Name = "picPinkPhone";
            picPinkPhone.Size = new Size(100, 100);
            picPinkPhone.SizeMode = PictureBoxSizeMode.Zoom;
            picPinkPhone.TabIndex = 5;
            picPinkPhone.TabStop = false;
            // 
            // picBluePhone
            // 
            picBluePhone.BorderStyle = BorderStyle.FixedSingle;
            picBluePhone.Image = Properties.Resources.images;
            picBluePhone.Location = new Point(46, 88);
            picBluePhone.Name = "picBluePhone";
            picBluePhone.Size = new Size(100, 100);
            picBluePhone.SizeMode = PictureBoxSizeMode.Zoom;
            picBluePhone.TabIndex = 4;
            picBluePhone.TabStop = false;
            // 
            // nudPinkQuantity
            // 
            nudPinkQuantity.ForeColor = Color.Fuchsia;
            nudPinkQuantity.Location = new Point(286, 206);
            nudPinkQuantity.Name = "nudPinkQuantity";
            nudPinkQuantity.Size = new Size(180, 35);
            nudPinkQuantity.TabIndex = 3;
            // 
            // lblPinkPhones
            // 
            lblPinkPhones.AutoSize = true;
            lblPinkPhones.ForeColor = Color.Fuchsia;
            lblPinkPhones.Location = new Point(19, 206);
            lblPinkPhones.Name = "lblPinkPhones";
            lblPinkPhones.Size = new Size(261, 27);
            lblPinkPhones.TabIndex = 2;
            lblPinkPhones.Text = "Pink Phone (Ksh 22,000):";
            // 
            // nudBlueQuantity
            // 
            nudBlueQuantity.ForeColor = Color.Blue;
            nudBlueQuantity.Location = new Point(284, 54);
            nudBlueQuantity.Name = "nudBlueQuantity";
            nudBlueQuantity.Size = new Size(180, 35);
            nudBlueQuantity.TabIndex = 1;
            nudBlueQuantity.ValueChanged += nudBlueQuantity_ValueChanged;
            // 
            // lblBluePhones
            // 
            lblBluePhones.AutoSize = true;
            lblBluePhones.ForeColor = Color.Blue;
            lblBluePhones.Location = new Point(25, 55);
            lblBluePhones.Name = "lblBluePhones";
            lblBluePhones.Size = new Size(262, 27);
            lblBluePhones.TabIndex = 0;
            lblBluePhones.Text = "Blue Phone (Ksh 20,000):";
            // 
            // grpOrderSummary
            // 
            grpOrderSummary.BackColor = Color.FromArgb(255, 128, 0);
            grpOrderSummary.Controls.Add(lblTotalValue);
            grpOrderSummary.Controls.Add(lblTotalText);
            grpOrderSummary.Controls.Add(lblTaxValue);
            grpOrderSummary.Controls.Add(lblTaxText);
            grpOrderSummary.Controls.Add(lblSubtotalValue);
            grpOrderSummary.Controls.Add(lblSubtotalText);
            grpOrderSummary.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpOrderSummary.ForeColor = Color.Black;
            grpOrderSummary.Location = new Point(672, 127);
            grpOrderSummary.Name = "grpOrderSummary";
            grpOrderSummary.Size = new Size(345, 188);
            grpOrderSummary.TabIndex = 2;
            grpOrderSummary.TabStop = false;
            grpOrderSummary.Text = "ORDER SUMMARY";
            // 
            // lblTotalValue
            // 
            lblTotalValue.BorderStyle = BorderStyle.FixedSingle;
            lblTotalValue.ForeColor = Color.Black;
            lblTotalValue.Location = new Point(199, 137);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(120, 28);
            lblTotalValue.TabIndex = 5;
            lblTotalValue.Text = "0.00";
            lblTotalValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalText
            // 
            lblTotalText.AutoSize = true;
            lblTotalText.ForeColor = Color.Black;
            lblTotalText.Location = new Point(30, 140);
            lblTotalText.Name = "lblTotalText";
            lblTotalText.Size = new Size(143, 27);
            lblTotalText.TabIndex = 4;
            lblTotalText.Text = "Total Amount";
            // 
            // lblTaxValue
            // 
            lblTaxValue.BorderStyle = BorderStyle.FixedSingle;
            lblTaxValue.ForeColor = Color.FromArgb(0, 64, 0);
            lblTaxValue.Location = new Point(199, 93);
            lblTaxValue.Name = "lblTaxValue";
            lblTaxValue.Size = new Size(120, 28);
            lblTaxValue.TabIndex = 3;
            lblTaxValue.Text = "0.00";
            lblTaxValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTaxText
            // 
            lblTaxText.AutoSize = true;
            lblTaxText.ForeColor = Color.FromArgb(0, 64, 0);
            lblTaxText.Location = new Point(30, 96);
            lblTaxText.Name = "lblTaxText";
            lblTaxText.Size = new Size(174, 27);
            lblTaxText.TabIndex = 2;
            lblTaxText.Text = "Sales Tax (16%):";
            // 
            // lblSubtotalValue
            // 
            lblSubtotalValue.BorderStyle = BorderStyle.FixedSingle;
            lblSubtotalValue.ForeColor = Color.FromArgb(0, 0, 192);
            lblSubtotalValue.Location = new Point(199, 55);
            lblSubtotalValue.Name = "lblSubtotalValue";
            lblSubtotalValue.Size = new Size(120, 28);
            lblSubtotalValue.TabIndex = 1;
            lblSubtotalValue.Text = "0.00";
            lblSubtotalValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSubtotalText
            // 
            lblSubtotalText.AutoSize = true;
            lblSubtotalText.ForeColor = Color.Navy;
            lblSubtotalText.Location = new Point(30, 50);
            lblSubtotalText.Name = "lblSubtotalText";
            lblSubtotalText.Size = new Size(97, 27);
            lblSubtotalText.TabIndex = 0;
            lblSubtotalText.Text = "Subtotal:";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.LightGreen;
            btnCalculate.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(186, 568);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(179, 40);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate Total";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(128, 255, 255);
            btnClear.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(572, 568);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 40);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(871, 568);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 40);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmPhoneOrdering
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 727);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(grpOrderSummary);
            Controls.Add(grpPhoneOrder);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmPhoneOrdering";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phone Ordering System";
            Load += Form1_Load;
            grpPhoneOrder.ResumeLayout(false);
            grpPhoneOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPinkPhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBluePhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPinkQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBlueQuantity).EndInit();
            grpOrderSummary.ResumeLayout(false);
            grpOrderSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grpPhoneOrder;
        private GroupBox grpOrderSummary;
        private Label lblBluePhones;
        private Label lblPinkPhones;
        private NumericUpDown nudBlueQuantity;
        private NumericUpDown nudPinkQuantity;
        private Label lblSubtotalValue;
        private Label lblSubtotalText;
        private Label lblTotalText;
        private Label lblTaxValue;
        private Label lblTaxText;
        private Label lblTotalValue;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private PictureBox picBluePhone;
        private PictureBox picPinkPhone;
    }
}
