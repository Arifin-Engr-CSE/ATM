
namespace ATM.UI.MainForm
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_checkBalance = new System.Windows.Forms.Button();
            this.btn_cashDeposit = new System.Windows.Forms.Button();
            this.btn_fundtranfer = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_cashWithdraw = new System.Windows.Forms.Button();
            this.btn_miniStatement = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 47);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(89, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "BD Bank Limited";
            // 
            // btn_checkBalance
            // 
            this.btn_checkBalance.BackColor = System.Drawing.Color.Lime;
            this.btn_checkBalance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_checkBalance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_checkBalance.ForeColor = System.Drawing.Color.Black;
            this.btn_checkBalance.Location = new System.Drawing.Point(36, 125);
            this.btn_checkBalance.Name = "btn_checkBalance";
            this.btn_checkBalance.Size = new System.Drawing.Size(180, 46);
            this.btn_checkBalance.TabIndex = 6;
            this.btn_checkBalance.Text = "Check Balance";
            this.btn_checkBalance.UseVisualStyleBackColor = false;
            this.btn_checkBalance.Click += new System.EventHandler(this.btn_checkBalance_Click);
            // 
            // btn_cashDeposit
            // 
            this.btn_cashDeposit.BackColor = System.Drawing.Color.Lime;
            this.btn_cashDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cashDeposit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cashDeposit.ForeColor = System.Drawing.Color.Black;
            this.btn_cashDeposit.Location = new System.Drawing.Point(36, 179);
            this.btn_cashDeposit.Name = "btn_cashDeposit";
            this.btn_cashDeposit.Size = new System.Drawing.Size(180, 46);
            this.btn_cashDeposit.TabIndex = 6;
            this.btn_cashDeposit.Text = "Cash Deposit";
            this.btn_cashDeposit.UseVisualStyleBackColor = false;
            this.btn_cashDeposit.Click += new System.EventHandler(this.btn_cashDeposit_Click);
            // 
            // btn_fundtranfer
            // 
            this.btn_fundtranfer.BackColor = System.Drawing.Color.Lime;
            this.btn_fundtranfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fundtranfer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_fundtranfer.ForeColor = System.Drawing.Color.Black;
            this.btn_fundtranfer.Location = new System.Drawing.Point(36, 232);
            this.btn_fundtranfer.Name = "btn_fundtranfer";
            this.btn_fundtranfer.Size = new System.Drawing.Size(180, 46);
            this.btn_fundtranfer.TabIndex = 6;
            this.btn_fundtranfer.Text = "Fund Transfer";
            this.btn_fundtranfer.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lime;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(36, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 46);
            this.button4.TabIndex = 6;
            this.button4.Text = "Others Services";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btn_cashWithdraw
            // 
            this.btn_cashWithdraw.BackColor = System.Drawing.Color.Lime;
            this.btn_cashWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cashWithdraw.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cashWithdraw.ForeColor = System.Drawing.Color.Black;
            this.btn_cashWithdraw.Location = new System.Drawing.Point(253, 125);
            this.btn_cashWithdraw.Name = "btn_cashWithdraw";
            this.btn_cashWithdraw.Size = new System.Drawing.Size(180, 46);
            this.btn_cashWithdraw.TabIndex = 6;
            this.btn_cashWithdraw.Text = "Cash Withdrawal";
            this.btn_cashWithdraw.UseVisualStyleBackColor = false;
            // 
            // btn_miniStatement
            // 
            this.btn_miniStatement.BackColor = System.Drawing.Color.Lime;
            this.btn_miniStatement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_miniStatement.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_miniStatement.ForeColor = System.Drawing.Color.Black;
            this.btn_miniStatement.Location = new System.Drawing.Point(253, 179);
            this.btn_miniStatement.Name = "btn_miniStatement";
            this.btn_miniStatement.Size = new System.Drawing.Size(180, 46);
            this.btn_miniStatement.TabIndex = 6;
            this.btn_miniStatement.Text = "Mini Statement";
            this.btn_miniStatement.UseVisualStyleBackColor = false;
            this.btn_miniStatement.Click += new System.EventHandler(this.btn_miniStatement_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Lime;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(253, 232);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(180, 46);
            this.button7.TabIndex = 6;
            this.button7.Text = "PIN Change";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Lime;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(253, 287);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(180, 46);
            this.button8.TabIndex = 6;
            this.button8.Text = "Bill Payment";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(78, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 38);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please Choose a transaction";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Gray;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(147, 349);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(170, 39);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(464, 395);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btn_fundtranfer);
            this.Controls.Add(this.btn_miniStatement);
            this.Controls.Add(this.btn_cashDeposit);
            this.Controls.Add(this.btn_cashWithdraw);
            this.Controls.Add(this.btn_checkBalance);
            this.Controls.Add(this.panel1);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_checkBalance;
        private System.Windows.Forms.Button btn_cashDeposit;
        private System.Windows.Forms.Button btn_fundtranfer;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_cashWithdraw;
        private System.Windows.Forms.Button btn_miniStatement;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Cancel;
    }
}