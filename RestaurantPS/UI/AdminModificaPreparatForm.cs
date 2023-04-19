using BL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantPS.UI
{
    public partial class AdminModificaPreparatForm : Form
    {
        private MeniuService meniuService;
        public AdminModificaPreparatForm()
        {
            InitializeComponent();
            this.meniuService = new MeniuService();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string denumire = this.denumireTextBox.Text;
                double pret = double.Parse(this.pretTextBox.Text);
                int stoc = int.Parse(this.stocTextBox.Text);
                int id = int.Parse(this.idTextBox.Text);
                DialogResult dialogResult = MessageBox.Show("Operatiune nu este reversibila, sigur doresti sa continui?", "Confirmare update", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    meniuService.UpdatePreparat(new Preparat(denumire, stoc, pret, id));
                }
                MessageBox.Show("Preparat modificat cu succes");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Preparat p = meniuService.GetPreparat(int.Parse(this.idTextBox.Text));
                this.denumireTextBox.Text = p.Nume;
                this.pretTextBox.Text = p.Pret.ToString();
                this.stocTextBox.Text = p.Stoc.ToString();
            }
            catch(Exception exc)
            {
                this.denumireTextBox.Text = "";
                this.pretTextBox.Text = "";
                this.stocTextBox.Text = "";
            }
        }
    }
}
