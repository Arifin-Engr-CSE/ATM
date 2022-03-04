
namespace ATM.UI.SatatementForm
{
    partial class MiniStatementMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniStatementMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_accSatetment = new System.Windows.Forms.Button();
            this.btn_trStatement = new System.Windows.Forms.Button();
            this.btn_backtoMainmenu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 47);
            this.panel1.TabIndex = 6;
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
            // btn_accSatetment
            // 
            this.btn_accSatetment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_accSatetment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_accSatetment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_accSatetment.Location = new System.Drawing.Point(57, 84);
            this.btn_accSatetment.Name = "btn_accSatetment";
            this.btn_accSatetment.Size = new System.Drawing.Size(201, 30);
            this.btn_accSatetment.TabIndex = 7;
            this.btn_accSatetment.Text = "Account Statetment";
            this.btn_accSatetment.UseVisualStyleBackColor = false;
            // 
            // btn_trStatement
            // 
            this.btn_trStatement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_trStatement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trStatement.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_trStatement.Location = new System.Drawing.Point(57, 120);
            this.btn_trStatement.Name = "btn_trStatement";
            this.btn_trStatement.Size = new System.Drawing.Size(201, 30);
            this.btn_trStatement.TabIndex = 7;
            this.btn_trStatement.Text = "Transaction Statetment";
            this.btn_trStatement.UseVisualStyleBackColor = false;
            // 
            // btn_backtoMainmenu
            // 
            this.btn_backtoMainmenu.BackColor = System.Drawing.Color.Silver;
            this.btn_backtoMainmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backtoMainmenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_backtoMainmenu.Location = new System.Drawing.Point(57, 156);
            this.btn_backtoMainmenu.Name = "btn_backtoMainmenu";
            this.btn_backtoMainmenu.Size = new System.Drawing.Size(201, 30);
            this.btn_backtoMainmenu.TabIndex = 7;
            this.btn_backtoMainmenu.Text = "Back to Main Menu";
            this.btn_backtoMainmenu.UseVisualStyleBackColor = false;
            // 
            // MiniStatementMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(311, 224);
            this.Controls.Add(this.btn_backtoMainmenu);
            this.Controls.Add(this.btn_trStatement);
            this.Controls.Add(this.btn_accSatetment);
            this.Controls.Add(this.panel1);
            this.Name = "MiniStatementMenu";
            this.Text = "MiniStatementMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_accSatetment;
        private System.Windows.Forms.Button btn_trStatement;
        private System.Windows.Forms.Button btn_backtoMainmenu;
    }
}