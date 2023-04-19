
namespace RestaurantPS.UI
{
    partial class LogInForm
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
            this.LogInBtn = new System.Windows.Forms.Button();
            this.userBox = new System.Windows.Forms.TextBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.roundGradientPanel3 = new StormComponent.RoundGradientPanel();
            this.roundGradientPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogInBtn
            // 
            this.LogInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(40)))), ((int)(((byte)(104)))));
            this.LogInBtn.FlatAppearance.BorderSize = 0;
            this.LogInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogInBtn.ForeColor = System.Drawing.Color.Transparent;
            this.LogInBtn.Location = new System.Drawing.Point(230, 199);
            this.LogInBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(118, 33);
            this.LogInBtn.TabIndex = 12;
            this.LogInBtn.TabStop = false;
            this.LogInBtn.Text = "Log In";
            this.LogInBtn.UseVisualStyleBackColor = false;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(129, 84);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(219, 23);
            this.userBox.TabIndex = 3;
            // 
            // UserLabel
            // 
            this.UserLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserLabel.ForeColor = System.Drawing.Color.White;
            this.UserLabel.Location = new System.Drawing.Point(13, 79);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(103, 23);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.Text = "Username";
            // 
            // PassLabel
            // 
            this.PassLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PassLabel.BackColor = System.Drawing.Color.Transparent;
            this.PassLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PassLabel.ForeColor = System.Drawing.Color.White;
            this.PassLabel.Location = new System.Drawing.Point(43, 144);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(80, 23);
            this.PassLabel.TabIndex = 1;
            this.PassLabel.Text = "Parola";
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(129, 149);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(219, 23);
            this.PassBox.TabIndex = 1;
            // 
            // roundGradientPanel3
            // 
            this.roundGradientPanel3.BackColor = System.Drawing.Color.White;
            this.roundGradientPanel3.BorderRadius = 0;
            this.roundGradientPanel3.Controls.Add(this.LogInBtn);
            this.roundGradientPanel3.Controls.Add(this.userBox);
            this.roundGradientPanel3.Controls.Add(this.PassBox);
            this.roundGradientPanel3.Controls.Add(this.PassLabel);
            this.roundGradientPanel3.Controls.Add(this.UserLabel);
            this.roundGradientPanel3.ForeColor = System.Drawing.Color.Black;
            this.roundGradientPanel3.GradientAngle = 315F;
            this.roundGradientPanel3.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.roundGradientPanel3.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.roundGradientPanel3.Location = new System.Drawing.Point(-1, -3);
            this.roundGradientPanel3.Name = "roundGradientPanel3";
            this.roundGradientPanel3.Padding = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.roundGradientPanel3.Size = new System.Drawing.Size(355, 247);
            this.roundGradientPanel3.TabIndex = 14;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(180)))), ((int)(((byte)(235)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(353, 242);
            this.Controls.Add(this.roundGradientPanel3);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.roundGradientPanel3.ResumeLayout(false);
            this.roundGradientPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox PassBox;
        private StormComponent.RoundGradientPanel roundGradientPanel3;
    }
}