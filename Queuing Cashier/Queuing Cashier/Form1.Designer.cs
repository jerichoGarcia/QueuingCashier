namespace Queuing_Cashier
{
    partial class frmQueuingForm
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
            btnCashier = new Button();
            label1 = new Label();
            lblQueue = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.BackColor = SystemColors.ActiveCaption;
            btnCashier.FlatStyle = FlatStyle.Flat;
            btnCashier.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCashier.Location = new Point(60, 53);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(110, 98);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = false;
            btnCashier.Click += btnCashier_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(215, 53);
            label1.Name = "label1";
            label1.Size = new Size(186, 25);
            label1.TabIndex = 1;
            label1.Text = "Position in Queue";
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Cambria", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblQueue.Location = new Point(228, 92);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(172, 41);
            lblQueue.TabIndex = 2;
            lblQueue.Text = "P - 10000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(23, 154);
            label2.Name = "label2";
            label2.Size = new Size(175, 17);
            label2.TabIndex = 3;
            label2.Text = "* Click to get a number";
            // 
            // frmQueuingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 200);
            Controls.Add(label2);
            Controls.Add(lblQueue);
            Controls.Add(label1);
            Controls.Add(btnCashier);
            Name = "frmQueuingForm";
            Text = "Form1";
            Load += frmQueuingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCashier;
        private Label label1;
        private Label lblQueue;
        private Label label2;
    }
}