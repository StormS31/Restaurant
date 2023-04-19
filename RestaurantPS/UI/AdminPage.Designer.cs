
using System.Windows.Forms;

namespace RestaurantPS.UI
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.angajatLabel = new System.Windows.Forms.Label();
            this.diverseTable = new System.Windows.Forms.DataGridView();
            this.listAngajati = new System.Windows.Forms.Button();
            this.addAngajat = new System.Windows.Forms.Button();
            this.meniuPreparateLabel = new System.Windows.Forms.Label();
            this.veziPreparate = new System.Windows.Forms.Button();
            this.stergePreparat = new System.Windows.Forms.Button();
            this.adaugaPreparat = new System.Windows.Forms.Button();
            this.roundGradientPanel1 = new StormComponent.RoundGradientPanel();
            this.roundGradientPanel2 = new StormComponent.RoundGradientPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.genereazaRaportBtn = new System.Windows.Forms.Button();
            this.statisticiBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.modificaPreparatBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.diverseTable)).BeginInit();
            this.roundGradientPanel1.SuspendLayout();
            this.roundGradientPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // angajatLabel
            // 
            resources.ApplyResources(this.angajatLabel, "angajatLabel");
            this.angajatLabel.BackColor = System.Drawing.Color.Transparent;
            this.angajatLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.angajatLabel.ForeColor = System.Drawing.Color.White;
            this.angajatLabel.Name = "angajatLabel";
            // 
            // diverseTable
            // 
            this.diverseTable.AllowUserToAddRows = false;
            this.diverseTable.AllowUserToDeleteRows = false;
            this.diverseTable.AllowUserToResizeColumns = false;
            this.diverseTable.AllowUserToResizeRows = false;
            this.diverseTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.diverseTable.BackgroundColor = System.Drawing.Color.White;
            this.diverseTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diverseTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.diverseTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.diverseTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.diverseTable, "diverseTable");
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.diverseTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.diverseTable.EnableHeadersVisualStyles = false;
            this.diverseTable.GridColor = System.Drawing.Color.LightGray;
            this.diverseTable.MultiSelect = false;
            this.diverseTable.Name = "diverseTable";
            this.diverseTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.diverseTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.diverseTable.RowHeadersVisible = false;
            this.diverseTable.RowTemplate.Height = 25;
            this.diverseTable.RowTemplate.ReadOnly = true;
            this.diverseTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // listAngajati
            // 
            this.listAngajati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(116)))), ((int)(((byte)(252)))));
            resources.ApplyResources(this.listAngajati, "listAngajati");
            this.listAngajati.FlatAppearance.BorderSize = 0;
            this.listAngajati.ForeColor = System.Drawing.Color.White;
            this.listAngajati.Name = "listAngajati";
            this.listAngajati.UseVisualStyleBackColor = false;
            this.listAngajati.Click += new System.EventHandler(this.listAngajati_Click);
            // 
            // addAngajat
            // 
            this.addAngajat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(116)))), ((int)(((byte)(252)))));
            resources.ApplyResources(this.addAngajat, "addAngajat");
            this.addAngajat.FlatAppearance.BorderSize = 0;
            this.addAngajat.ForeColor = System.Drawing.Color.White;
            this.addAngajat.Name = "addAngajat";
            this.addAngajat.UseVisualStyleBackColor = false;
            this.addAngajat.Click += new System.EventHandler(this.addAngajat_Click);
            // 
            // meniuPreparateLabel
            // 
            resources.ApplyResources(this.meniuPreparateLabel, "meniuPreparateLabel");
            this.meniuPreparateLabel.BackColor = System.Drawing.Color.Transparent;
            this.meniuPreparateLabel.ForeColor = System.Drawing.Color.White;
            this.meniuPreparateLabel.Name = "meniuPreparateLabel";
            // 
            // veziPreparate
            // 
            this.veziPreparate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(116)))), ((int)(((byte)(252)))));
            resources.ApplyResources(this.veziPreparate, "veziPreparate");
            this.veziPreparate.FlatAppearance.BorderSize = 0;
            this.veziPreparate.ForeColor = System.Drawing.Color.White;
            this.veziPreparate.Name = "veziPreparate";
            this.veziPreparate.UseVisualStyleBackColor = false;
            this.veziPreparate.Click += new System.EventHandler(this.veziPreparate_Click);
            // 
            // stergePreparat
            // 
            this.stergePreparat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(116)))), ((int)(((byte)(252)))));
            resources.ApplyResources(this.stergePreparat, "stergePreparat");
            this.stergePreparat.FlatAppearance.BorderSize = 0;
            this.stergePreparat.ForeColor = System.Drawing.Color.White;
            this.stergePreparat.Name = "stergePreparat";
            this.stergePreparat.UseVisualStyleBackColor = false;
            this.stergePreparat.Click += new System.EventHandler(this.stergePreparat_Click);
            // 
            // adaugaPreparat
            // 
            this.adaugaPreparat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(116)))), ((int)(((byte)(252)))));
            resources.ApplyResources(this.adaugaPreparat, "adaugaPreparat");
            this.adaugaPreparat.FlatAppearance.BorderSize = 0;
            this.adaugaPreparat.ForeColor = System.Drawing.Color.White;
            this.adaugaPreparat.Name = "adaugaPreparat";
            this.adaugaPreparat.UseVisualStyleBackColor = false;
            this.adaugaPreparat.Click += new System.EventHandler(this.adaugaPreparat_Click);
            // 
            // roundGradientPanel1
            // 
            this.roundGradientPanel1.BackColor = System.Drawing.Color.White;
            this.roundGradientPanel1.BorderRadius = 50;
            this.roundGradientPanel1.Controls.Add(this.diverseTable);
            this.roundGradientPanel1.ForeColor = System.Drawing.Color.Black;
            this.roundGradientPanel1.GradientAngle = 90F;
            this.roundGradientPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.roundGradientPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            resources.ApplyResources(this.roundGradientPanel1, "roundGradientPanel1");
            this.roundGradientPanel1.Name = "roundGradientPanel1";
            // 
            // roundGradientPanel2
            // 
            this.roundGradientPanel2.BackColor = System.Drawing.Color.White;
            this.roundGradientPanel2.BorderRadius = 30;
            this.roundGradientPanel2.Controls.Add(this.panel3);
            this.roundGradientPanel2.Controls.Add(this.panel4);
            this.roundGradientPanel2.Controls.Add(this.panel6);
            this.roundGradientPanel2.Controls.Add(this.label1);
            this.roundGradientPanel2.Controls.Add(this.meniuPreparateLabel);
            this.roundGradientPanel2.Controls.Add(this.angajatLabel);
            this.roundGradientPanel2.Controls.Add(this.panel5);
            this.roundGradientPanel2.Controls.Add(this.panel2);
            this.roundGradientPanel2.Controls.Add(this.panel1);
            this.roundGradientPanel2.ForeColor = System.Drawing.Color.Black;
            this.roundGradientPanel2.GradientAngle = 90F;
            this.roundGradientPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.roundGradientPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            resources.ApplyResources(this.roundGradientPanel2, "roundGradientPanel2");
            this.roundGradientPanel2.Name = "roundGradientPanel2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(26)))), ((int)(((byte)(120)))));
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(26)))), ((int)(((byte)(120)))));
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(26)))), ((int)(((byte)(120)))));
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.genereazaRaportBtn);
            this.panel5.Controls.Add(this.statisticiBtn);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // genereazaRaportBtn
            // 
            this.genereazaRaportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(116)))), ((int)(((byte)(252)))));
            resources.ApplyResources(this.genereazaRaportBtn, "genereazaRaportBtn");
            this.genereazaRaportBtn.FlatAppearance.BorderSize = 0;
            this.genereazaRaportBtn.ForeColor = System.Drawing.Color.White;
            this.genereazaRaportBtn.Name = "genereazaRaportBtn";
            this.genereazaRaportBtn.UseVisualStyleBackColor = false;
            this.genereazaRaportBtn.Click += new System.EventHandler(this.genereazaRaportBtn_Click);
            // 
            // statisticiBtn
            // 
            this.statisticiBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(116)))), ((int)(((byte)(252)))));
            resources.ApplyResources(this.statisticiBtn, "statisticiBtn");
            this.statisticiBtn.FlatAppearance.BorderSize = 0;
            this.statisticiBtn.ForeColor = System.Drawing.Color.White;
            this.statisticiBtn.Name = "statisticiBtn";
            this.statisticiBtn.UseVisualStyleBackColor = false;
            this.statisticiBtn.Click += new System.EventHandler(this.statisticiBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.panel2.Controls.Add(this.modificaPreparatBtn);
            this.panel2.Controls.Add(this.stergePreparat);
            this.panel2.Controls.Add(this.adaugaPreparat);
            this.panel2.Controls.Add(this.veziPreparate);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // modificaPreparatBtn
            // 
            this.modificaPreparatBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(116)))), ((int)(((byte)(252)))));
            resources.ApplyResources(this.modificaPreparatBtn, "modificaPreparatBtn");
            this.modificaPreparatBtn.FlatAppearance.BorderSize = 0;
            this.modificaPreparatBtn.ForeColor = System.Drawing.Color.White;
            this.modificaPreparatBtn.Name = "modificaPreparatBtn";
            this.modificaPreparatBtn.UseVisualStyleBackColor = false;
            this.modificaPreparatBtn.Click += new System.EventHandler(this.modificaPreparatBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.panel1.Controls.Add(this.addAngajat);
            this.panel1.Controls.Add(this.listAngajati);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // AdminPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(180)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.roundGradientPanel1);
            this.Controls.Add(this.roundGradientPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "AdminPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPage_Close);
            ((System.ComponentModel.ISupportInitialize)(this.diverseTable)).EndInit();
            this.roundGradientPanel1.ResumeLayout(false);
            this.roundGradientPanel2.ResumeLayout(false);
            this.roundGradientPanel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label angajatLabel;
        private System.Windows.Forms.DataGridView diverseTable;
        private System.Windows.Forms.Button listAngajati;
        private Button addAngajat;
        private Label meniuPreparateLabel;
        private Button veziPreparate;
        private Button stergePreparat;
        private Button adaugaPreparat;
        private StormComponent.RoundGradientPanel roundGradientPanel1;
        private StormComponent.RoundGradientPanel roundGradientPanel2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button modificaPreparatBtn;
        private Panel panel5;
        private Label label1;
        private Panel panel6;
        private Button genereazaRaportBtn;
        private Button statisticiBtn;
    }
}