namespace TAH.LibFineCalc.UI
{
    partial class FrmLibFineCalc
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
            lblMain = new Label();
            lblMainSub = new Label();
            lblOverdue = new Label();
            txtOverdueBooks = new TextBox();
            txtDaysOverdue = new TextBox();
            lblDaysOverdue = new Label();
            btnCalcFine = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblTotalFine = new Label();
            SuspendLayout();
            // 
            // lblMain
            // 
            lblMain.AutoSize = true;
            lblMain.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMain.Location = new Point(39, 18);
            lblMain.Name = "lblMain";
            lblMain.Size = new Size(272, 32);
            lblMain.TabIndex = 0;
            lblMain.Text = "Library Fine Calculator";
            // 
            // lblMainSub
            // 
            lblMainSub.AutoSize = true;
            lblMainSub.Location = new Point(28, 50);
            lblMainSub.Name = "lblMainSub";
            lblMainSub.Size = new Size(305, 15);
            lblMainSub.TabIndex = 1;
            lblMainSub.Text = "Overdue materials are assessed at $0.05 per book per day";
            // 
            // lblOverdue
            // 
            lblOverdue.AutoSize = true;
            lblOverdue.Location = new Point(28, 104);
            lblOverdue.Name = "lblOverdue";
            lblOverdue.Size = new Size(146, 15);
            lblOverdue.TabIndex = 2;
            lblOverdue.Text = "Number of overdue books";
            // 
            // txtOverdueBooks
            // 
            txtOverdueBooks.Font = new Font("Segoe UI", 12F);
            txtOverdueBooks.Location = new Point(28, 122);
            txtOverdueBooks.Name = "txtOverdueBooks";
            txtOverdueBooks.Size = new Size(305, 29);
            txtOverdueBooks.TabIndex = 3;
            // 
            // txtDaysOverdue
            // 
            txtDaysOverdue.Font = new Font("Segoe UI", 12F);
            txtDaysOverdue.Location = new Point(28, 197);
            txtDaysOverdue.Name = "txtDaysOverdue";
            txtDaysOverdue.Size = new Size(305, 29);
            txtDaysOverdue.TabIndex = 5;
            // 
            // lblDaysOverdue
            // 
            lblDaysOverdue.AutoSize = true;
            lblDaysOverdue.Location = new Point(28, 179);
            lblDaysOverdue.Name = "lblDaysOverdue";
            lblDaysOverdue.Size = new Size(146, 15);
            lblDaysOverdue.TabIndex = 4;
            lblDaysOverdue.Text = "Number of overdue books";
            // 
            // btnCalcFine
            // 
            btnCalcFine.BackColor = Color.FromArgb(224, 224, 224);
            btnCalcFine.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnCalcFine.Location = new Point(28, 251);
            btnCalcFine.Name = "btnCalcFine";
            btnCalcFine.Size = new Size(305, 57);
            btnCalcFine.TabIndex = 6;
            btnCalcFine.Text = "Calculate Fine";
            btnCalcFine.UseVisualStyleBackColor = false;
            btnCalcFine.Click += btnCalcFine_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 14F);
            btnClear.Location = new Point(28, 314);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(129, 38);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightCoral;
            btnExit.Font = new Font("Segoe UI", 14F);
            btnExit.Location = new Point(204, 314);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(129, 38);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblTotalFine
            // 
            lblTotalFine.BackColor = SystemColors.Control;
            lblTotalFine.BorderStyle = BorderStyle.Fixed3D;
            lblTotalFine.FlatStyle = FlatStyle.Popup;
            lblTotalFine.Font = new Font("Segoe UI", 20F);
            lblTotalFine.Location = new Point(28, 367);
            lblTotalFine.Name = "lblTotalFine";
            lblTotalFine.Size = new Size(305, 57);
            lblTotalFine.TabIndex = 9;
            lblTotalFine.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmLibFineCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 450);
            Controls.Add(lblTotalFine);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalcFine);
            Controls.Add(txtDaysOverdue);
            Controls.Add(lblDaysOverdue);
            Controls.Add(txtOverdueBooks);
            Controls.Add(lblOverdue);
            Controls.Add(lblMainSub);
            Controls.Add(lblMain);
            Name = "FrmLibFineCalc";
            Text = "Library Fine Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMain;
        private Label lblMainSub;
        private Label lblOverdue;
        private TextBox txtOverdueBooks;
        private TextBox txtDaysOverdue;
        private Label lblDaysOverdue;
        private Button btnCalcFine;
        private Button btnClear;
        private Button btnExit;
        private Label lblTotalFine;
    }
}
