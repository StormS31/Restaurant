
namespace RestaurantPS.UI
{
    partial class AdminModificaPreparatForm
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
            this.roundGradientPanel1 = new StormComponent.RoundGradientPanel();
            this.idLabel = new System.Windows.Forms.Label();
            this.numeLabel = new System.Windows.Forms.Label();
            this.stocLabel = new System.Windows.Forms.Label();
            this.pretLabel = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.denumireTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.stocTextBox = new System.Windows.Forms.TextBox();
            this.pretTextBox = new System.Windows.Forms.TextBox();
            this.roundGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundGradientPanel1
            // 
            this.roundGradientPanel1.BackColor = System.Drawing.Color.White;
            this.roundGradientPanel1.BorderRadius = 30;
            this.roundGradientPanel1.Controls.Add(this.pretTextBox);
            this.roundGradientPanel1.Controls.Add(this.stocTextBox);
            this.roundGradientPanel1.Controls.Add(this.idTextBox);
            this.roundGradientPanel1.Controls.Add(this.denumireTextBox);
            this.roundGradientPanel1.Controls.Add(this.okBtn);
            this.roundGradientPanel1.Controls.Add(this.cancelBtn);
            this.roundGradientPanel1.Controls.Add(this.pretLabel);
            this.roundGradientPanel1.Controls.Add(this.stocLabel);
            this.roundGradientPanel1.Controls.Add(this.numeLabel);
            this.roundGradientPanel1.Controls.Add(this.idLabel);
            this.roundGradientPanel1.ForeColor = System.Drawing.Color.Black;
            this.roundGradientPanel1.GradientAngle = 225F;
            this.roundGradientPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.roundGradientPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.roundGradientPanel1.Location = new System.Drawing.Point(0, -2);
            this.roundGradientPanel1.Name = "roundGradientPanel1";
            this.roundGradientPanel1.Size = new System.Drawing.Size(390, 255);
            this.roundGradientPanel1.TabIndex = 0;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.BackColor = System.Drawing.Color.Transparent;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.idLabel.ForeColor = System.Drawing.Color.White;
            this.idLabel.Location = new System.Drawing.Point(85, 34);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(32, 25);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            // 
            // numeLabel
            // 
            this.numeLabel.AutoSize = true;
            this.numeLabel.BackColor = System.Drawing.Color.Transparent;
            this.numeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numeLabel.ForeColor = System.Drawing.Color.White;
            this.numeLabel.Location = new System.Drawing.Point(17, 74);
            this.numeLabel.Name = "numeLabel";
            this.numeLabel.Size = new System.Drawing.Size(100, 25);
            this.numeLabel.TabIndex = 0;
            this.numeLabel.Text = "Denumire";
            // 
            // stocLabel
            // 
            this.stocLabel.AutoSize = true;
            this.stocLabel.BackColor = System.Drawing.Color.Transparent;
            this.stocLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stocLabel.ForeColor = System.Drawing.Color.White;
            this.stocLabel.Location = new System.Drawing.Point(66, 114);
            this.stocLabel.Name = "stocLabel";
            this.stocLabel.Size = new System.Drawing.Size(51, 25);
            this.stocLabel.TabIndex = 0;
            this.stocLabel.Text = "Stoc";
            // 
            // pretLabel
            // 
            this.pretLabel.AutoSize = true;
            this.pretLabel.BackColor = System.Drawing.Color.Transparent;
            this.pretLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pretLabel.ForeColor = System.Drawing.Color.White;
            this.pretLabel.Location = new System.Drawing.Point(68, 152);
            this.pretLabel.Name = "pretLabel";
            this.pretLabel.Size = new System.Drawing.Size(49, 25);
            this.pretLabel.TabIndex = 0;
            this.pretLabel.Text = "Pret";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(0, 208);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(195, 45);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "Inchide";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.okBtn.FlatAppearance.BorderSize = 0;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.okBtn.ForeColor = System.Drawing.Color.White;
            this.okBtn.Location = new System.Drawing.Point(196, 208);
            this.okBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(195, 45);
            this.okBtn.TabIndex = 15;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // denumireTextBox
            // 
            this.denumireTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.denumireTextBox.Location = new System.Drawing.Point(123, 75);
            this.denumireTextBox.Name = "denumireTextBox";
            this.denumireTextBox.Size = new System.Drawing.Size(257, 27);
            this.denumireTextBox.TabIndex = 16;
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.idTextBox.Location = new System.Drawing.Point(123, 35);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(257, 27);
            this.idTextBox.TabIndex = 16;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // stocTextBox
            // 
            this.stocTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stocTextBox.Location = new System.Drawing.Point(123, 115);
            this.stocTextBox.Name = "stocTextBox";
            this.stocTextBox.Size = new System.Drawing.Size(257, 27);
            this.stocTextBox.TabIndex = 16;
            // 
            // pretTextBox
            // 
            this.pretTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pretTextBox.Location = new System.Drawing.Point(123, 153);
            this.pretTextBox.Name = "pretTextBox";
            this.pretTextBox.Size = new System.Drawing.Size(257, 27);
            this.pretTextBox.TabIndex = 16;
            // 
            // ModificaPreparatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(180)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(392, 252);
            this.Controls.Add(this.roundGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ModificaPreparatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifica preparat";
            this.roundGradientPanel1.ResumeLayout(false);
            this.roundGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private StormComponent.RoundGradientPanel roundGradientPanel1;
        private System.Windows.Forms.Label pretLabel;
        private System.Windows.Forms.Label stocLabel;
        private System.Windows.Forms.Label numeLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox pretTextBox;
        private System.Windows.Forms.TextBox stocTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox denumireTextBox;
        private System.Windows.Forms.Button okBtn;
    }
}