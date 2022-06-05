
namespace ATMApp
{
    partial class Balance
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitTxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BalanceTxt = new System.Windows.Forms.Label();
            this.AccNumTxt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BackTxt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.ExitTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 100);
            this.panel1.TabIndex = 1;
            // 
            // ExitTxt
            // 
            this.ExitTxt.AutoSize = true;
            this.ExitTxt.Font = new System.Drawing.Font("Montserrat SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitTxt.ForeColor = System.Drawing.Color.White;
            this.ExitTxt.Location = new System.Drawing.Point(633, 0);
            this.ExitTxt.Name = "ExitTxt";
            this.ExitTxt.Size = new System.Drawing.Size(37, 40);
            this.ExitTxt.TabIndex = 10;
            this.ExitTxt.Text = "X";
            this.ExitTxt.Click += new System.EventHandler(this.ExitTxt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(171, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "Account Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(171, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 26);
            this.label2.TabIndex = 23;
            this.label2.Text = "Your Balance:";
            // 
            // BalanceTxt
            // 
            this.BalanceTxt.AutoSize = true;
            this.BalanceTxt.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BalanceTxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BalanceTxt.Location = new System.Drawing.Point(373, 220);
            this.BalanceTxt.Name = "BalanceTxt";
            this.BalanceTxt.Size = new System.Drawing.Size(111, 26);
            this.BalanceTxt.TabIndex = 25;
            this.BalanceTxt.Text = "BalanceRs";
            // 
            // AccNumTxt
            // 
            this.AccNumTxt.AutoSize = true;
            this.AccNumTxt.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccNumTxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.AccNumTxt.Location = new System.Drawing.Point(373, 162);
            this.AccNumTxt.Name = "AccNumTxt";
            this.AccNumTxt.Size = new System.Drawing.Size(107, 26);
            this.AccNumTxt.TabIndex = 24;
            this.AccNumTxt.Text = "ACC NUM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 18);
            this.panel2.TabIndex = 35;
            // 
            // BackTxt
            // 
            this.BackTxt.AutoSize = true;
            this.BackTxt.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackTxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BackTxt.Location = new System.Drawing.Point(294, 335);
            this.BackTxt.Name = "BackTxt";
            this.BackTxt.Size = new System.Drawing.Size(66, 29);
            this.BackTxt.TabIndex = 36;
            this.BackTxt.Text = "Back";
            this.BackTxt.Click += new System.EventHandler(this.BackTxt_Click);
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 407);
            this.Controls.Add(this.BackTxt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BalanceTxt);
            this.Controls.Add(this.AccNumTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Balance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ExitTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BalanceTxt;
        private System.Windows.Forms.Label AccNumTxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label BackTxt;
    }
}