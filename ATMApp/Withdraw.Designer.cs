
namespace ATMApp
{
    partial class Withdraw
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
            this.label2 = new System.Windows.Forms.Label();
            this.BackTxt = new System.Windows.Forms.Label();
            this.WdBtn = new System.Windows.Forms.Button();
            this.AmountTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitTxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AvailBalanceTxt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(257, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 29);
            this.label2.TabIndex = 47;
            this.label2.Text = "WITHDRAW";
            // 
            // BackTxt
            // 
            this.BackTxt.AutoSize = true;
            this.BackTxt.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackTxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BackTxt.Location = new System.Drawing.Point(331, 380);
            this.BackTxt.Name = "BackTxt";
            this.BackTxt.Size = new System.Drawing.Size(66, 29);
            this.BackTxt.TabIndex = 51;
            this.BackTxt.Text = "Back";
            this.BackTxt.Click += new System.EventHandler(this.BackTxt_Click);
            // 
            // WdBtn
            // 
            this.WdBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.WdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WdBtn.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WdBtn.ForeColor = System.Drawing.Color.White;
            this.WdBtn.Location = new System.Drawing.Point(296, 280);
            this.WdBtn.Name = "WdBtn";
            this.WdBtn.Size = new System.Drawing.Size(188, 42);
            this.WdBtn.TabIndex = 50;
            this.WdBtn.Text = "WITHDRAW";
            this.WdBtn.UseVisualStyleBackColor = false;
            this.WdBtn.Click += new System.EventHandler(this.WdBtn_Click);
            // 
            // AmountTb
            // 
            this.AmountTb.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AmountTb.Location = new System.Drawing.Point(296, 224);
            this.AmountTb.Name = "AmountTb";
            this.AmountTb.Size = new System.Drawing.Size(268, 33);
            this.AmountTb.TabIndex = 49;
            this.AmountTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountTb_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(169, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 26);
            this.label3.TabIndex = 48;
            this.label3.Text = "AMOUNT";
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
            this.panel1.TabIndex = 52;
            // 
            // ExitTxt
            // 
            this.ExitTxt.AutoSize = true;
            this.ExitTxt.Font = new System.Drawing.Font("Montserrat SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitTxt.ForeColor = System.Drawing.Color.White;
            this.ExitTxt.Location = new System.Drawing.Point(633, 4);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 445);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 18);
            this.panel2.TabIndex = 53;
            // 
            // AvailBalanceTxt
            // 
            this.AvailBalanceTxt.AutoSize = true;
            this.AvailBalanceTxt.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AvailBalanceTxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.AvailBalanceTxt.Location = new System.Drawing.Point(209, 161);
            this.AvailBalanceTxt.Name = "AvailBalanceTxt";
            this.AvailBalanceTxt.Size = new System.Drawing.Size(237, 21);
            this.AvailBalanceTxt.TabIndex = 54;
            this.AvailBalanceTxt.Text = "AVAILABLE BALANCE: Rp.xxxx";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 463);
            this.Controls.Add(this.AvailBalanceTxt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackTxt);
            this.Controls.Add(this.WdBtn);
            this.Controls.Add(this.AmountTb);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label BackTxt;
        private System.Windows.Forms.Button WdBtn;
        private System.Windows.Forms.TextBox AmountTb;
        private System.Windows.Forms.Label ExitTxt;
        private System.Windows.Forms.Label AvailBalanceTxt;
    }
}