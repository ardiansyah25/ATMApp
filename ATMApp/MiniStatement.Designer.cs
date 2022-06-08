
namespace ATMApp
{
    partial class MiniStatement
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
            this.label2 = new System.Windows.Forms.Label();
            this.ExitTxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MiniSDgv = new System.Windows.Forms.DataGridView();
            this.BackTxt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MiniSDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ExitTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 100);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(134, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // ExitTxt
            // 
            this.ExitTxt.AutoSize = true;
            this.ExitTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitTxt.ForeColor = System.Drawing.Color.White;
            this.ExitTxt.Location = new System.Drawing.Point(665, 7);
            this.ExitTxt.Name = "ExitTxt";
            this.ExitTxt.Size = new System.Drawing.Size(35, 33);
            this.ExitTxt.TabIndex = 10;
            this.ExitTxt.Text = "X";
            this.ExitTxt.Click += new System.EventHandler(this.ExitTxt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(214, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "MINI STATEMENT";
            // 
            // MiniSDgv
            // 
            this.MiniSDgv.AllowUserToAddRows = false;
            this.MiniSDgv.AllowUserToDeleteRows = false;
            this.MiniSDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MiniSDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MiniSDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MiniSDgv.Location = new System.Drawing.Point(0, 158);
            this.MiniSDgv.Name = "MiniSDgv";
            this.MiniSDgv.ReadOnly = true;
            this.MiniSDgv.RowTemplate.Height = 25;
            this.MiniSDgv.Size = new System.Drawing.Size(709, 286);
            this.MiniSDgv.TabIndex = 5;
            // 
            // BackTxt
            // 
            this.BackTxt.AutoSize = true;
            this.BackTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackTxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BackTxt.Location = new System.Drawing.Point(318, 469);
            this.BackTxt.Name = "BackTxt";
            this.BackTxt.Size = new System.Drawing.Size(60, 25);
            this.BackTxt.TabIndex = 26;
            this.BackTxt.Text = "Back";
            this.BackTxt.Click += new System.EventHandler(this.BackTxt_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 527);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 18);
            this.panel2.TabIndex = 27;
            // 
            // MiniStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BackTxt);
            this.Controls.Add(this.MiniSDgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MiniStatement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniStatement";
            this.Load += new System.EventHandler(this.MiniStatement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MiniSDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ExitTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView MiniSDgv;
        private System.Windows.Forms.Label BackTxt;
        private System.Windows.Forms.Panel panel2;
    }
}