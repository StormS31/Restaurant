
namespace RestaurantPS.UI
{
    partial class AdminRapoarteForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.roundGradientPanel1 = new StormComponent.RoundGradientPanel();
            this.data2 = new System.Windows.Forms.Label();
            this.data1 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.dataFinal = new System.Windows.Forms.DateTimePicker();
            this.dataInceput = new System.Windows.Forms.DateTimePicker();
            this.roundGradientPanel2 = new StormComponent.RoundGradientPanel();
            this.rapoateTable = new System.Windows.Forms.DataGridView();
            this.roundGradientPanel1.SuspendLayout();
            this.roundGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rapoateTable)).BeginInit();
            this.SuspendLayout();
            // 
            // roundGradientPanel1
            // 
            this.roundGradientPanel1.BackColor = System.Drawing.Color.White;
            this.roundGradientPanel1.BorderRadius = 30;
            this.roundGradientPanel1.Controls.Add(this.data2);
            this.roundGradientPanel1.Controls.Add(this.data1);
            this.roundGradientPanel1.Controls.Add(this.cancelBtn);
            this.roundGradientPanel1.Controls.Add(this.okBtn);
            this.roundGradientPanel1.Controls.Add(this.dataFinal);
            this.roundGradientPanel1.Controls.Add(this.dataInceput);
            this.roundGradientPanel1.ForeColor = System.Drawing.Color.Black;
            this.roundGradientPanel1.GradientAngle = 90F;
            this.roundGradientPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.roundGradientPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.roundGradientPanel1.Location = new System.Drawing.Point(12, 73);
            this.roundGradientPanel1.Name = "roundGradientPanel1";
            this.roundGradientPanel1.Size = new System.Drawing.Size(377, 223);
            this.roundGradientPanel1.TabIndex = 0;
            // 
            // data2
            // 
            this.data2.AutoSize = true;
            this.data2.BackColor = System.Drawing.Color.Transparent;
            this.data2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.data2.ForeColor = System.Drawing.Color.White;
            this.data2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.data2.Location = new System.Drawing.Point(42, 100);
            this.data2.Name = "data2";
            this.data2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.data2.Size = new System.Drawing.Size(108, 21);
            this.data2.TabIndex = 15;
            this.data2.Text = "Data de final";
            // 
            // data1
            // 
            this.data1.AutoSize = true;
            this.data1.BackColor = System.Drawing.Color.Transparent;
            this.data1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.data1.ForeColor = System.Drawing.Color.White;
            this.data1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.data1.Location = new System.Drawing.Point(19, 40);
            this.data1.Name = "data1";
            this.data1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.data1.Size = new System.Drawing.Size(131, 21);
            this.data1.TabIndex = 14;
            this.data1.Text = "Data de inceput";
            this.data1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(0, 177);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(185, 45);
            this.cancelBtn.TabIndex = 13;
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
            this.okBtn.Location = new System.Drawing.Point(185, 177);
            this.okBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(192, 45);
            this.okBtn.TabIndex = 12;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // dataFinal
            // 
            this.dataFinal.Location = new System.Drawing.Point(156, 99);
            this.dataFinal.Name = "dataFinal";
            this.dataFinal.Size = new System.Drawing.Size(220, 23);
            this.dataFinal.TabIndex = 1;
            // 
            // dataInceput
            // 
            this.dataInceput.Location = new System.Drawing.Point(156, 39);
            this.dataInceput.Name = "dataInceput";
            this.dataInceput.Size = new System.Drawing.Size(220, 23);
            this.dataInceput.TabIndex = 0;
            // 
            // roundGradientPanel2
            // 
            this.roundGradientPanel2.BackColor = System.Drawing.Color.White;
            this.roundGradientPanel2.BorderRadius = 50;
            this.roundGradientPanel2.Controls.Add(this.rapoateTable);
            this.roundGradientPanel2.ForeColor = System.Drawing.Color.Black;
            this.roundGradientPanel2.GradientAngle = 90F;
            this.roundGradientPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.roundGradientPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.roundGradientPanel2.Location = new System.Drawing.Point(395, 12);
            this.roundGradientPanel2.Name = "roundGradientPanel2";
            this.roundGradientPanel2.Padding = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.roundGradientPanel2.Size = new System.Drawing.Size(842, 336);
            this.roundGradientPanel2.TabIndex = 11;
            // 
            // rapoateTable
            // 
            this.rapoateTable.AllowUserToAddRows = false;
            this.rapoateTable.AllowUserToDeleteRows = false;
            this.rapoateTable.AllowUserToResizeColumns = false;
            this.rapoateTable.AllowUserToResizeRows = false;
            this.rapoateTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rapoateTable.BackgroundColor = System.Drawing.Color.White;
            this.rapoateTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rapoateTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.rapoateTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rapoateTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rapoateTable.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rapoateTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.rapoateTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rapoateTable.EnableHeadersVisualStyles = false;
            this.rapoateTable.GridColor = System.Drawing.Color.LightGray;
            this.rapoateTable.Location = new System.Drawing.Point(4, 15);
            this.rapoateTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rapoateTable.MultiSelect = false;
            this.rapoateTable.Name = "rapoateTable";
            this.rapoateTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rapoateTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.rapoateTable.RowHeadersVisible = false;
            this.rapoateTable.RowHeadersWidth = 25;
            this.rapoateTable.RowTemplate.Height = 25;
            this.rapoateTable.RowTemplate.ReadOnly = true;
            this.rapoateTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rapoateTable.Size = new System.Drawing.Size(834, 306);
            this.rapoateTable.TabIndex = 1;
            // 
            // RapoarteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(180)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1249, 360);
            this.Controls.Add(this.roundGradientPanel2);
            this.Controls.Add(this.roundGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RapoarteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticiForm";
            this.roundGradientPanel1.ResumeLayout(false);
            this.roundGradientPanel1.PerformLayout();
            this.roundGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rapoateTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private StormComponent.RoundGradientPanel roundGradientPanel1;
        private System.Windows.Forms.DateTimePicker dataFinal;
        private System.Windows.Forms.DateTimePicker dataInceput;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label data2;
        private System.Windows.Forms.Label data1;
        private StormComponent.RoundGradientPanel roundGradientPanel2;
        private System.Windows.Forms.DataGridView rapoateTable;
    }
}